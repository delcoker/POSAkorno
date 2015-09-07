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
    public partial class CompanyDetails : Form
    {
        public CompanyDetails()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             cCompanyDetails cc = new cCompanyDetails();
            cc.Address = txtAddress.Text;
            cc.CompanyName = txtName.Text;
            cc.Email = txtEmail.Text;
            cc.Telephone = txtTel.Text;
            cc.Telephone_two = txtTel2.Text;
            cc.Website = txtWebsite.Text;
            cc.InfoID = 0;
            cc.DateAdded = DateTime.Now.ToString();


            if (cc.saveRecord())
            {
                MessageBox.Show("Saved");
            }
            else
                MessageBox.Show("Not Saved");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
