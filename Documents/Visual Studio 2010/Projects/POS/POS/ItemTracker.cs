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
    public partial class ItemTracker : Form
    {
        private cUsers loggedUser;

        public ItemTracker(cUsers user)
        {
            InitializeComponent();

            LoadItems();


            loggedUser = new cUsers();
            loggedUser = user;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadItems()
        {
            DataSet ds = new DataSet();
            cMeals cat = new cMeals();

            ds = cat.mealsGetActive();

            //ds.Tables[0].DefaultView.Sort = "Category asc";

            cmbItems.DataSource = ds.Tables[0].DefaultView;
            cmbItems.ValueMember = "MealID";
            cmbItems.DisplayMember = "Name";

            cmbCategory.DataSource = cmbItems.DataSource;
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.DisplayMember = "Category";

            cmbQty.DataSource = cmbItems.DataSource;
            cmbQty.ValueMember = "QuanTypeID";
            cmbQty.DisplayMember = "QuanType";

            cmbPrice.DataSource = cmbItems.DataSource;
            cmbPrice.ValueMember = "Price";
            cmbPrice.DisplayMember = "Price";
            //cmbItems.SelectedIndex = -1;
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            cMeals meal = new cMeals();
            meal.MealID = Convert.ToUInt32(cmbItems.SelectedValue);
            meal.Deleted = false;
            meal.Name = Convert.ToString(cmbItems.Text);
            meal.Price = Convert.ToDecimal(cmbPrice.SelectedValue);
            meal.CategoryID = Convert.ToUInt32(cmbCategory.SelectedValue);
            meal.QuanTypeID = Convert.ToUInt32(cmbQty.SelectedValue);
            meal.DateAdded = DateTime.Now.ToString();
            meal.HasStock = true;


            if (meal.saveRecord())
            {
                MessageBox.Show("Tracking " + meal.Name + ".\nYou may add stock.");

            }
            else
                MessageBox.Show("Not Tracking");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cMeals meal = new cMeals();
            meal.MealID = Convert.ToUInt32(cmbItems.SelectedValue);
            meal.Deleted = false;
            meal.Name = Convert.ToString(cmbItems.Text);
            meal.Price = Convert.ToDecimal(cmbPrice.SelectedValue);
            meal.CategoryID = Convert.ToUInt32(cmbCategory.SelectedValue);
            meal.QuanTypeID = Convert.ToUInt32(cmbQty.SelectedValue);
            meal.DateAdded = DateTime.Now.ToString();
            meal.HasStock = false;


            if (meal.saveRecord())
            {
                MessageBox.Show("Not Tracking " + meal.Name + ".\nYou may add stock.");

            }
            else
                MessageBox.Show("Tracking");
        }

        
    }
}
