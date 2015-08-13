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
    public partial class UserView : Form
    {
        private cUsers loggedUser;
        private string company = "Akorno";

        public UserView(cUsers user)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitializeComponent();

            loggedUser = new cUsers();
            loggedUser = user;

            dtpDtAdd.Format = DateTimePickerFormat.Custom;
            dtpDtAdd.CustomFormat = "ddd dd MMM yyyy";
            CenterToParent();

            LoadUserTypes();
            LoadUsers();

            Cursor.Current = Cursors.WaitCursor;
        }

        private void LoadUsers()
        {
            DataSet ds = new DataSet();
            try
            {
                cUsers user = new cUsers();
                user.UserID = 0;
                ds = user.UsersGet();

                dgvUsr.DataSource = ds.Tables[0];

                dgvUsr.Columns[0].HeaderText = "User ID";
                dgvUsr.Columns[1].HeaderText = "Name";
                dgvUsr.Columns[2].HeaderText = "Company";
                dgvUsr.Columns[3].HeaderText = "Permission";
                dgvUsr.Columns[4].HeaderText = "Date Added";
                dgvUsr.Columns[5].HeaderText = "Last Attepted Login";
                dgvUsr.Columns[6].HeaderText = "Last Login";

                dgvUsr.Columns[0].Visible = false;
                dgvUsr.Columns[2].Visible = false;
                dgvUsr.Columns[3].Visible = false;
                //dgvUsr.Columns[0].Visible = false;
                //dgvUsr.Columns[0].Visible = false;

                dgvUsr.Columns[1].Width = 200;
                dgvUsr.Columns[2].Width = 200;
                dgvUsr.Columns[3].Width = 200;
                dgvUsr.Columns[4].Width = 200;
                dgvUsr.Columns[5].Width = 200;
                dgvUsr.Columns[6].Width = 200;

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ds.Dispose();
            }

            disableTools();
            
        }

        private void disableTools()
        {
            tBxFirstName.Enabled = false;
            txtBxPassword.Enabled = false;
            cmbType.Enabled = false;
            tBxFirstName.Focus();
            txtBxPassword.Clear();
        }

        private void LoadUserTypes()
        {
            DataSet ds = new DataSet();
            cUserRoles user = new cUserRoles();

            ds = user.UserRolesGet();

            cmbType.DataSource = ds.Tables[0];
            cmbType.ValueMember = "UserRolesID";
            cmbType.DisplayMember = "Roles";

            cmbType.SelectedIndex = -1;

            if (loggedUser.UserName == "Del")
            {
                cmbType.Items.Remove("Superuser");
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tBxFirstName.Text.Trim() == "")
            {
                MessageBox.Show("Name Required");
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

            string[] names = tBxFirstName.Text.Split();

            int usertype = 0;
            cUsers use = new cUsers();

            //if (tBxFirstName.Text == "Del")
            //    use = new cUsers("Del", "", cUsers.CalculateSHA1(txtBxPassword.Text, Encoding.UTF8), "de~la", 3, false, dtpDtAdd.Value.ToString(), dtpDtAdd.Value.ToString(), dtpDtAdd.Value.ToString());
            //else
            ////Convert.ToInt16(cmbType.SelectedValue.ToString());
            //{

            if (tBxFirstName.Text == "Del")
            {
                names = new string[]{"Del",""};
            }
             
                use = new cUsers(names[0], names[1], cUsers.CalculateSHA1(txtBxPassword.Text, Encoding.UTF8), company, Convert.ToUInt16(cmbType.SelectedValue), false, dtpDtAdd.Value.ToString(), dtpDtAdd.Value.ToString(), dtpDtAdd.Value.ToString());
            //}
            use.UserID = Convert.ToUInt16(dgvUsr["UserID", dgvUsr.CurrentCell.RowIndex].Value);
            
            //if (tBxFirstName.Text == "Del")
            //{
                
            //    use.UserName = "Del";
            //    use.Password = cUsers.CalculateSHA1(txtBxPassword.Text, Encoding.UTF8);
            //    //use.PermLevel = 3;
            //}
            //else
            //{

            //}

            if (use.saveRecord())
            {
                MessageBox.Show("Saved");
                //txtBxPassword.Clear();
                //tBxFirstName.Clear();
                ////tBxLastName.Clear();
                //cmbType.SelectedIndex = -1;
                //tBxFirstName.Focus();

                LoadUsers();
            }

            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dgvUsr_Click(dgvUsr, e);

            tBxFirstName.Enabled = true;
            txtBxPassword.Enabled = true;
            cmbType.Enabled = true;
            tBxFirstName.Focus();

            if (tBxFirstName.Text == "Del")
            {
                disableTools();
                txtBxPassword.Enabled = true;
            }
        }

        private void dgvUsr_Click(object sender, EventArgs e)
        {
            disableTools();
            tBxFirstName.Text = dgvUsr["Username", dgvUsr.CurrentCell.RowIndex].Value.ToString();
            cmbType.SelectedValue = Convert.ToInt16(dgvUsr["PermLevel", dgvUsr.CurrentCell.RowIndex].Value);
            dtpDtAdd.Value = Convert.ToDateTime(dgvUsr["DateAdded", dgvUsr.CurrentCell.RowIndex].Value);

            
       
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
