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
    public partial class CategoryAdd : Form
    {
        private cUsers loggedUser;
        public CategoryAdd(cUsers user)
        {
            InitializeComponent();
            dtpDtAdd.Format = DateTimePickerFormat.Custom;
            dtpDtAdd.CustomFormat = "ddd dd MMM yyyy";
            CenterToParent();

            loggedUser = new cUsers();
            loggedUser = user;
            llblLog.Text = loggedUser.UserName;
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCls_Click(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCat.Text.Trim() == "")
            {
                MessageBox.Show("Category required");
                return;
            }

            cCategory cat = new cCategory(0, txtCat.Text, dtpDtAdd.Value.ToString());

            if (cat.checkCategory())
            {
                MessageBox.Show("This category already exits!");
                return;
            }

            if (cat.SaveRecord())
            {
                MessageBox.Show("Saved");
                txtCat.Clear();
                txtCat.Focus();
            }

        }

    }
}
