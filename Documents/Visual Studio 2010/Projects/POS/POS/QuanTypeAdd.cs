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
    public partial class QuanTypeAdd : Form
    {
        private cUsers loggedUser;
        public QuanTypeAdd(cUsers user)
        {
            InitializeComponent();
            dtpDtAdd.Format = DateTimePickerFormat.Custom;
            dtpDtAdd.CustomFormat = "ddd dd MMM yyyy";
            CenterToParent();

            loggedUser = new cUsers();
            loggedUser = user;
            llblLog.Text = loggedUser.UserName;
        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtQtyType.Text.Trim() == "")
            {
                MessageBox.Show("Quantity Type Required");
                return;
            }

            cQuanTypes qtyType = new cQuanTypes(0, txtQtyType.Text, dtpDtAdd.Value.ToString());

            if (qtyType.checkQuanType())
            {
                MessageBox.Show("This quantity type already exits!");
                return;
            }

            if (qtyType.SaveRecord())
            {
                txtQtyType.Clear();
                MessageBox.Show("Saved");
            }
        }

        private void dtpDtAdd_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
