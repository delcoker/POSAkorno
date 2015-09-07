using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS
{
    public partial class InventoryView : Form
    {
        private cUsers loggedUser;
        private int productID;
        public InventoryView(cUsers user)
        {
            InitializeComponent();
            CenterToParent();

            LoadItems();
            LoadMeals();
            dtpDtAdd.Format = DateTimePickerFormat.Custom;
            dtpDtAdd.CustomFormat = "ddd dd MMM yyyy";

            dtpDateAdded.Format = DateTimePickerFormat.Custom;
            dtpDateAdded.CustomFormat = "ddd dd MMM yyyy";
            
            //cmbItems.Enabled = false;
            pEdt.Enabled = false;


            loggedUser = new cUsers();
            loggedUser = user;

            llblLog.Text = loggedUser.UserName;
            productID = 0;

            updateFont();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!loggedUser.access(Convert.ToInt16(btnEdit.Tag)))
            {
                return;
            }
            if (cmbItems.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an item");
                return;
            }
            
            pEdt.Enabled = true;
            //dgvInv.Enabled = false;

            //productID

            //cmbItems.Enabled = false;
        }


        private void LoadItems()
        {
            DataSet ds = new DataSet();
            cInventory inv = new cInventory();

            //ds = inv.InventoryGet();

            //cmbItems.DataSource = ds.Tables[0];
            //cmbItems.ValueMember = "MealID";
            //cmbItems.DisplayMember = "Name";

            //cmbItems.SelectedIndex = -1;

            try
            {
                ds = inv.InventoryMealsGet();

                dgvInv.DataSource = ds.Tables[0];

                dgvInv.Columns[0].HeaderText = "Meal ID";
                dgvInv.Columns[1].HeaderText = "Meal ID";
                dgvInv.Columns[2].HeaderText = "Name";
                dgvInv.Columns[3].HeaderText = "Credit";
                dgvInv.Columns[4].HeaderText = "Debit";
                dgvInv.Columns[5].HeaderText = "Stock Left";
                dgvInv.Columns[6].HeaderText = "Last Deduction";
                dgvInv.Columns[7].HeaderText = "Last Credit";
                //dgvInv.Columns[8].HeaderText = "MealID";
                //dgvInv.Columns[9].HeaderText = "Stock Left";
                //dgvInv.Columns[10].HeaderText = "Last Modified";

                dgvInv.Columns[0].Visible = false;
                dgvInv.Columns[1].Width = 50;
                dgvInv.Columns[1].Visible = false;
                dgvInv.Columns[2].Width = 200;
                //dgvInv.Columns[2].Visible = false;
                dgvInv.Columns[3].Width = 100;
                //dgvInv.Columns[3].Visible = false;
                dgvInv.Columns[4].Width = 100;
                //dgvInv.Columns[4].Visible = false;
                dgvInv.Columns[5].Width = 100;
                //dgvInv.Columns[].Visible = false;
                dgvInv.Columns[6].Width = 150;
                dgvInv.Columns[7].Width = 100;
                //dgvInv.Columns[7].Visible = false;
                //dgvInv.Columns[8].Width = 80;
                //dgvInv.Columns[9].Width = 120;
                dgvInv.Columns[8].Visible = false;
                dgvInv.Columns[9].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ds.Dispose();
            }

            //pEdt.Enabled = false;
            //dgvInv.Sort(dgvInv.Columns["Name"], ListSortDirection.Ascending);
        }

        private void updateFont()
        {
            foreach (DataGridViewColumn c in dgvInv.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 16F, GraphicsUnit.Pixel);
            }
        }


        private void LoadMeals()
        {
            DataSet ds = new DataSet();
            cInventory inv = new cInventory();

            ds = inv.InventoryGet();

            ds.Tables[0].DefaultView.Sort = "Name asc";

            cmbItems.DataSource = ds.Tables[0].DefaultView;
            cmbItems.DisplayMember = "Name";
            cmbItems.ValueMember = "MealID";
            
            cmbItems.SelectedIndex = -1;

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvInv_Click(object sender, EventArgs e)
        {
            pEdt.Enabled = false;
            //dgvInv.Enabled = true;
            try
            {
                numQty.Value = Convert.ToDecimal(dgvInv["SLeft", dgvInv.CurrentCell.RowIndex].Value);
                cmbItems.SelectedValue = Convert.ToInt16(dgvInv["TDeductedMealID", dgvInv.CurrentCell.RowIndex].Value);
                dtpDateAdded.Value = Convert.ToDateTime(dgvInv["LastCreditDate", dgvInv.CurrentCell.RowIndex].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please add stock to start the inventory count.\n"  + ex.Message);
                if (!loggedUser.access(Convert.ToInt16(btnAdd.Tag)))
                {
                    return;
                }
                InventoryAdd inv = new InventoryAdd(loggedUser);
                inv.ShowDialog();
                LoadItems();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (!loggedUser.access(Convert.ToInt16(btnDel.Tag)))
            {
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!loggedUser.access(Convert.ToInt16(btnSave.Tag)))
            {
                return;
            }

            cInventory inv = new cInventory(0, Convert.ToUInt32(cmbItems.SelectedValue), Convert.ToUInt32(numQty.Value), dtpDtAdd.Value.ToString(), loggedUser.UserID);

            if (inv.checkInventory())
            {
                DialogResult dialogResult = MessageBox.Show("This item was already added to or deducted from today. Continue with update?", "Add", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    // preventing adding twice to the same item because
                    //MessageBox.Show("Item not added");
                    //return;
                }
                else
                {
                    MessageBox.Show("Item not added");
                    return;
                }
            }

            if (rdbAddition.Checked)
            {

                if (inv.saveRecord())
                {
                    MessageBox.Show("Added");
                }
                else
                {
                    MessageBox.Show("Sorry could not be added");
                    return;
                }
            }
            else if (rdbDeduct.Checked)
            {
                if (!(Convert.ToInt32(dgvInv["SLeft", dgvInv.CurrentCell.RowIndex].Value) - Convert.ToUInt32(numQty.Value) >= 0))
                {
                    MessageBox.Show("Not enough stock on this item");
                    return;
                }

                cInventoryDebit invD = new cInventoryDebit(0, Convert.ToUInt32(cmbItems.SelectedValue), Convert.ToUInt32(numQty.Value), dtpDtAdd.Value.ToString(), loggedUser.UserID);

                try
                {
                    if (!invD.saveRecord())
                    {
                        MessageBox.Show("Could not save to inventory\n");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw ex;
                }

                MessageBox.Show("Deducted");
            }
            else
            {
                MessageBox.Show("Please select addition or deduction option");
                return;
            }
            LoadItems();
            pEdt.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!loggedUser.access(Convert.ToInt16(btnAdd.Tag)))
            {
                return;
            }
            InventoryAdd inv = new InventoryAdd(loggedUser);
            inv.ShowDialog();
            LoadItems();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!loggedUser.access(Convert.ToInt16(btnAdd.Tag)))
            {
                return;
            }
            this.Close();
            this.Dispose();
            MealView inv = new MealView(loggedUser);
            inv.ShowDialog();
            //LoadItems();
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            if (!loggedUser.access(Convert.ToInt16(btnTrack.Tag)))
            {
                return;
            }
            //this.Close();
            //this.Dispose();
            ItemTracker it = new ItemTracker(loggedUser);
            it.ShowDialog();
            LoadItems();
        }
    }
}
