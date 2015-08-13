using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace POS
{
    public partial class UserAdd : Form
    {
        private cUsers loggedUser;
        public UserAdd(cUsers user)
        {
            InitializeComponent();

            loggedUser = new cUsers();
            loggedUser = user;

            dtpDtAdd.Format = DateTimePickerFormat.Custom;
            dtpDtAdd.CustomFormat = "ddd dd MMM yyyy";
            CenterToParent();

            loadUserTypes();
        }

        private void loadUserTypes()
        {
            DataSet ds = new DataSet();
            cUserRoles user = new cUserRoles();

            ds = user.UserRolesGet();

            cmbType.DataSource = ds.Tables[0];
            cmbType.ValueMember = "UserRolesID";
            cmbType.DisplayMember = "Roles";

           

            cmbType.SelectedIndex = -1;
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tBxFirstName.Text.Trim() == "")
            {
                MessageBox.Show("First Name Required");
                return;
            }
            if (tBxLastName.Text.Trim() == "")
            {
                MessageBox.Show("Last Name Required");
                return;
            }

            if (cmbType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a user type.");
                return;
            }

            if (txtBxPassword.Text == "")
            {

                MessageBox.Show("Please enter a password.");
                return;
            }

            cUsers use = new cUsers(tBxFirstName.Text, tBxLastName.Text, cUsers.CalculateSHA1(txtBxPassword.Text, Encoding.UTF8), txtBxCompany.Text, Convert.ToInt16(cmbType.SelectedValue.ToString()), false, dtpDtAdd.Value.ToString(), dtpDtAdd.Value.ToString(), dtpDtAdd.Value.ToString());

            if (use.checkUserName())
            {
                MessageBox.Show("A user with this name already exits!");
                return;
            }

            if (use.saveRecord())
            {
                MessageBox.Show("Saved");
                txtBxPassword.Clear();
                tBxFirstName.Clear();
                tBxLastName.Clear();
                cmbType.SelectedIndex = -1;
                tBxFirstName.Focus();
            }
        }


        
    }
}
