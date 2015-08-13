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
    public partial class MealAdd : Form
        
    {
        private cUsers loggedUser;
        public MealAdd(cUsers user)
        {
            InitializeComponent();
            CenterToParent();
            LoadCategories();
            LoadQtyTypes();

            dtpDtAdd.Format = DateTimePickerFormat.Custom;
            dtpDtAdd.CustomFormat = "ddd dd MMM yyyy";

            loggedUser = new cUsers();
            loggedUser = user;


            // advantages of superuser
            if (loggedUser.PermLevel == 3)
            {
                numPrice.Minimum = -50;
            }

            llblLog.Text = loggedUser.UserName;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
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

            //bool hasStock = 

            cMeals meal = new cMeals(0, txtName.Text, numPrice.Value, Convert.ToUInt32(cmbCtgy.SelectedValue), Convert.ToUInt32(cmbQtyType.SelectedValue), dtpDtAdd.Value.ToString(), rdbHaveStock.Checked);

            if (meal.checkMeal())
            {
                MessageBox.Show("This meal already exists");
                return;
            }

            if (meal.saveRecord())
            {
                MessageBox.Show("Added");
            }
            else
            {
                MessageBox.Show("Sorry could not be added");
                return;
            }
            clear();
        }

        private void clear()
        {
        //    txtName.Clear();
            numPrice.Value = 0;
        //    numPrice.Focus();
        //    numPrice.Select();
        //    cmbCtgy.SelectedIndex = -1;
        //    cmbCtgy.SelectedIndex = -1;
        }

        private void LoadCategories()
        {
            DataSet ds = new DataSet();
            cCategory cat = new cCategory();

            ds = cat.CategoryGet();

            cmbCtgy.DataSource = ds.Tables[0];
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
    }
}
