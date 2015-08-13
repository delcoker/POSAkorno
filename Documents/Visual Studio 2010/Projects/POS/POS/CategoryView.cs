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
    public partial class CategoryView : Form
    {
        private cUsers loggedUser;
        public CategoryView(cUsers user)
        {
            InitializeComponent();
            LoadCategories();
            dtpDtAdd.Format = DateTimePickerFormat.Custom;
            dtpDtAdd.CustomFormat = "ddd dd MMM yyyy";
            CenterToParent();

            loggedUser = new cUsers();
            loggedUser = user;

            llblLog.Text = loggedUser.UserName;
        }

        private void LoadCategories()
        {
            DataSet ds = new DataSet();
            try
            {
                cCategory cat = new cCategory();
                cat.CategoryID = 0;
                ds = cat.CategoryGet();

                dgvCat.DataSource = ds.Tables[0];

                dgvCat.Columns[0].HeaderText = "Category ID";
                dgvCat.Columns[1].HeaderText = "Category";
                dgvCat.Columns[2].HeaderText = "Date Added";

                dgvCat.Columns[0].Visible = false;
                dgvCat.Columns[1].Width = 200;
                dgvCat.Columns[2].Width = 200;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ds.Dispose();
            }
            txtCat.Enabled = false;
            txtCat.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dgvCat_Click(dgvCat, e);
            txtCat.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnClose_Click(sender, e);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtCat.Text.Trim() == "")
            {
                MessageBox.Show("Select a category");
                return;
            }

            cCategory cat = new cCategory();
            cat.Category = txtCat.Text;

            if (cat.CategoryDelete())
            {
                MessageBox.Show("Deleted");
                txtCat.Clear();
            }
            else
                MessageBox.Show("Not Deleted");

            LoadCategories();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCat.Text.Trim() == "")
            {
                MessageBox.Show("Select a category");
                return;
            }

            cCategory cat = new cCategory();

            cat.CategoryID = Convert.ToUInt32(dgvCat["CategoryID", dgvCat.CurrentCell.RowIndex].Value);
            cat.Category = txtCat.Text;
            cat.DateAdded = dtpDtAdd.Value.ToString();

            if (cat.checkCategory())
            {
                MessageBox.Show("This category already exists!");
                return;
            }

            if (cat.SaveRecord())
            {
                MessageBox.Show("Saved");
                txtCat.Clear();
            }
            LoadCategories();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CategoryAdd catA = new CategoryAdd(loggedUser );
            catA.ShowDialog();
            LoadCategories();
        }

        private void dgvCat_Click(object sender, EventArgs e)
        {
            txtCat.Enabled = false;
            txtCat.Text = dgvCat["Category", dgvCat.CurrentCell.RowIndex].Value.ToString();
            dtpDtAdd.Value = Convert.ToDateTime(dgvCat["DateAdded", dgvCat.CurrentCell.RowIndex].Value);
        }

    

    }

}

