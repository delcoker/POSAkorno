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
    public partial class MealView : Form
    {
        private cUsers loggedUser;

        private static int minNumericBox = -50;
        public MealView(cUsers user)
        {
           
            InitializeComponent();
            CenterToParent();
            LoadMeals();
            LoadCategories();
            LoadQtyTypes();

            dtpDtAdd.Format = DateTimePickerFormat.Custom;
            dtpDtAdd.CustomFormat = "ddd dd MMM yyyy";

            //   dgvCat_Click(dgvCat, new DataGridViewCellEventArgs(0, 0));
            // datagridviewRowClickedEventHandler(new object(), new eventargs());

            cmbQtyType.Enabled = false;

            loggedUser = new cUsers();
            loggedUser = user;

            llblLog.Text = loggedUser.UserName;

            updateFont();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int buttonPerm = Convert.ToInt16(btnEdit.Tag);

            if (!loggedUser.access(buttonPerm))
            {
                return;
            }

            if(txtName.Text == "" || txtName.Text == null)
            {
                MessageBox.Show("Please select what you would like to edit first");
                return;
            }

           // dgvCat_Click(dgvCat, e);
            pEdt.Enabled = true;

            highMealName();
        }

        private void highMealName()
        {
            txtName.Focus();
            txtName.Select(0, txtName.Text.Length);
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!loggedUser.access(Convert.ToInt16(btnAdd.Tag)))
            {
                return;
            }
            MealAdd add = new MealAdd(loggedUser);
            add.ShowDialog();
            LoadMeals();
        }

        private void LoadMeals()
        {
            DataSet ds = new DataSet();
            cMeals meals = new cMeals();
           
            try
            {
                meals.MealID = 0;
                ds = meals.mealsGet();

                dgvCat.DataSource = ds.Tables[0];

                dgvCat.Columns[0].HeaderText = "Meal ID";
                dgvCat.Columns[1].HeaderText = "Name";
                dgvCat.Columns[2].HeaderText = "Price";
                dgvCat.Columns[3].HeaderText = "Category ID";
                dgvCat.Columns[4].HeaderText = "Category";
                dgvCat.Columns[5].HeaderText = "Quantity Type ID";
                dgvCat.Columns[6].HeaderText = "Quantity Type";
                dgvCat.Columns[7].HeaderText = "Date Added";
                dgvCat.Columns[8].HeaderText = "Track Stock";

                dgvCat.Columns[0].Visible = false;
                dgvCat.Columns[1].Width = 200;
                dgvCat.Columns[2].Width = 100;
                dgvCat.Columns[3].Visible = false;
                dgvCat.Columns[4].Width = 150;
                dgvCat.Columns[5].Visible = false;
                dgvCat.Columns[6].Width = 150;
                dgvCat.Columns[7].Width = 120;
                dgvCat.Columns[8].Width = 100;
                dgvCat.Columns[10].Visible = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ds.Dispose();
            }

            pEdt.Enabled = false;

            numPrice.Minimum = 0;


            //dgvCat.Sort(dgvCat.Columns["Name"], ListSortDirection.Ascending);
            // enabld(false);
        }

        public void enabld(bool status)
        {
            txtName.Enabled = status;
            cmbCtgy.Enabled = status;
            cmbQtyType.Enabled = status;
            numPrice.Enabled = status;
        }

        public void clear()
        {
            txtName.Clear();
            cmbCtgy.SelectedIndex = -1;
            cmbQtyType.SelectedIndex = -1;
            numPrice.Value = 0;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            
            if (!loggedUser.access(Convert.ToInt16(btnDel.Tag)))
            {
                return;
            }

            
            

            cMeals meal = new cMeals();
            meal.MealID = Convert.ToUInt32(dgvCat["MealID", dgvCat.CurrentCell.RowIndex].Value);
            //meal.Name = txtName.Text;
            //meal.QuanTypeID = Convert.ToUInt32(cmbQtyType.SelectedValue);

            //MessageBox.Show(meal.Name);
            //MessageBox.Show(meal.QuanTypeID.ToString());

            if (meal.mealDelete())
            {
                MessageBox.Show("Deleted.\nWill not display in Sale Items.");
                clear();
            }
            else
                MessageBox.Show("Not Deleted");

            LoadMeals();
        }

        private void LoadCategories()
        {
            DataSet ds = new DataSet();
            cCategory cat = new cCategory();

            ds = cat.CategoryGet();

            ds.Tables[0].DefaultView.Sort = "Category asc";

            cmbCtgy.DataSource = ds.Tables[0].DefaultView;
            cmbCtgy.ValueMember = "CategoryID";
            cmbCtgy.DisplayMember = "Category";

            cmbCtgy.SelectedIndex = -1;
        }

        private void LoadQtyTypes()
        {
            DataSet ds = new DataSet();
            cQuanTypes qty = new cQuanTypes();

            ds = qty.QuanTypeGet();

            cmbQtyType.DataSource = ds.Tables[0];
            cmbQtyType.ValueMember = "QuanTypeID";
            cmbQtyType.DisplayMember = "QuanType";

            cmbQtyType.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!loggedUser.access(Convert.ToInt16(btnSave.Tag)))
            {
                return;
            }
            if (!pEdt.Enabled)
            {
                MessageBox.Show("Select an item and edit before saving");
                return;
            }
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Name of the meal required");
                return;
            }
            if (cmbCtgy.SelectedIndex < 0)
            {
                MessageBox.Show("Select a category");
                return;
            }
            if (cmbQtyType.SelectedIndex < 0)
            {
                MessageBox.Show("Select a quantity type");
                return;
            }
            if (numPrice.Value == 0)
            {
                MessageBox.Show("Input a price amount");
                return;
            }

            cMeals meal = new cMeals();

            meal.MealID = Convert.ToUInt32(dgvCat["MealID", dgvCat.CurrentCell.RowIndex].Value);
            meal.Deleted = rdbDeleted.Checked;
            meal.Name = txtName.Text;
            meal.Price = Convert.ToDecimal(numPrice.Value);
            meal.CategoryID = Convert.ToUInt32(cmbCtgy.SelectedValue);
            meal.QuanTypeID = Convert.ToUInt32(cmbQtyType.SelectedValue);
            meal.DateAdded = dtpDtAdd.Value.ToString();
            meal.HasStock = rdbHaveStock.Checked;
            
            

            //if (meal.checkMeal())
            //{
            //    MessageBox.Show("This meal already exists!");
            //    return;
            //}

            if (meal.saveRecord())
            {
                MessageBox.Show("Saved");
                clear();
            }
            else
                MessageBox.Show("Not Saved");

            LoadMeals();
        }

        private void dgvCat_Click(object sender, EventArgs e)
        {
        //    enabld(false);
            pEdt.Enabled = false;
            txtName.Text = dgvCat["Name", dgvCat.CurrentCell.RowIndex].Value.ToString();
            if (txtName.Text == "Staff Discount")
            {
                numPrice.Minimum = minNumericBox;
            }
            else
                numPrice.Minimum = 0;
            numPrice.Value = Convert.ToDecimal(dgvCat["Price", dgvCat.CurrentCell.RowIndex].Value);
            cmbCtgy.SelectedValue = Convert.ToInt16(dgvCat["CategoryID", dgvCat.CurrentCell.RowIndex].Value);
            cmbQtyType.SelectedValue = Convert.ToInt16(dgvCat["QuanTypeID", dgvCat.CurrentCell.RowIndex].Value);
            dtpDtAdd.Value = Convert.ToDateTime(dgvCat["DateAdded", dgvCat.CurrentCell.RowIndex].Value);
            rdbHaveStock.Checked = Convert.ToBoolean(dgvCat["HasStock", dgvCat.CurrentCell.RowIndex].Value);
            rdbDeleted.Checked = Convert.ToBoolean(dgvCat["Deleted", dgvCat.CurrentCell.RowIndex].Value);
        }

        private void pMealEdit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdbHaveStock_Click(object sender, EventArgs e)
        {
            if (!rdbHaveStock.Checked)
            {
                rdbHaveStock.Checked = true;
            }
            else
            {
                rdbHaveStock.Checked = false;
            }
        }

        private void rdbDeleted_Click(object sender, EventArgs e)
        {
            if (!rdbDeleted.Checked)
            {
                rdbDeleted.Checked = true;
            }
            else
            {
                rdbDeleted.Checked = false;
            }
        }

        private void updateFont()
        {
            foreach (DataGridViewColumn c in dgvCat.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 16F, GraphicsUnit.Pixel);
            }
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            if (!loggedUser.access(Convert.ToInt16(btnAdd.Tag)))
            {
                return;
            }
            this.Close();
            this.Dispose();
            InventoryView inv = new InventoryView(loggedUser);
            inv.ShowDialog();
            
        }


    }
}
