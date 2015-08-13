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
    public partial class InventoryAdd : Form
    {
        private cUsers loggedUser;

        public InventoryAdd(cUsers user)
        {
            InitializeComponent();
            CenterToParent();
            LoadItems();

            dtpDtAdd.Format = DateTimePickerFormat.Custom;
            dtpDtAdd.CustomFormat = "ddd dd MMM yyyy";

            loggedUser = user;

            llblLog.Text = loggedUser.UserName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbItems.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an item");
                return;
            }
            cInventory inv = new cInventory(0, Convert.ToUInt32(cmbItems.SelectedValue),  Convert.ToUInt32(numQty.Value), dtpDtAdd.Value.ToString(), loggedUser.UserID);

            if (inv.checkInventory())
            {
                DialogResult dialogResult = MessageBox.Show("This this item was already added today. Continue with update?", "Add", MessageBoxButtons.YesNo);
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

        private void btnExt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadItems()
        {
            DataSet ds = new DataSet();
            cInventory inv = new cInventory();

            ds = inv.InventoryGet();

            ds.Tables[0].DefaultView.Sort = "Name asc";

            cmbItems.DataSource = ds.Tables[0].DefaultView;
            cmbItems.ValueMember = "MealID";
            cmbItems.DisplayMember = "Name";

            //cmbItems.Sorted = true;
            cmbItems.SelectedIndex = -1;
        }
    }
}
