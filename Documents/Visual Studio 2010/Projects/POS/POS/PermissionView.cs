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
    public partial class PermissionView : Form
    {
        public PermissionView()
        {
            InitializeComponent();
            CenterToParent();
            loadPermissions();

            dtpDtAdd.Format = DateTimePickerFormat.Custom;
            dtpDtAdd.CustomFormat = "ddd dd MMM yyyy";

            //llblLog.Text = loggedUser.UserName;
        }

        public void loadPermissions()
        {
            DataSet ds = new DataSet();
            try
            {
                cPermissions level = new cPermissions();
                level.PermissionLevelID = 0;
                ds = level.prmissionLvlGet();

                dgvPrmssnT.DataSource = ds.Tables[0];

                dgvPrmssnT.Columns[0].HeaderText = "Permission Level ID";
                dgvPrmssnT.Columns[1].HeaderText = "Permission Level";
                dgvPrmssnT.Columns[2].HeaderText = "Info";
                dgvPrmssnT.Columns[3].HeaderText = "Date Added";

                dgvPrmssnT.Columns[0].Visible = false;
                dgvPrmssnT.Columns[1].Width = 100;
                dgvPrmssnT.Columns[2].Width = 200;
                dgvPrmssnT.Columns[2].Width = 200;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ds.Dispose();
            }
        //    pPerEdit.Enabled = false;
            numP.Enabled = false;
            txtQtyType.Enabled = false;
            txtQtyType.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
       //     pPerEdit.Enabled = true;
            numP.Enabled = true;
            txtQtyType.Enabled = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtQtyType.Text.Trim() == "")
            {
                MessageBox.Show("Info required");
                return;
            }

            cPermissions qtyT = new cPermissions();
            qtyT.Info = txtQtyType.Text;
            qtyT.PermissionLevel = Convert.ToUInt16(numP.Value);

            if (qtyT.prmssionLvlDelete())
            {
                txtQtyType.Clear();
                MessageBox.Show("Deleted");
            }
            else
                MessageBox.Show("Not Deleted");

            loadPermissions();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtQtyType.Text.Trim() == "")
            {
                MessageBox.Show("Info required");
                return;
            }

            cPermissions qtyT = new cPermissions();

            qtyT.PermissionLevelID = Convert.ToUInt32(dgvPrmssnT["PermissionLevelID", dgvPrmssnT.CurrentCell.RowIndex].Value);
            qtyT.PermissionLevel = Convert.ToUInt16(numP.Value);
            qtyT.Info = txtQtyType.Text;
            qtyT.DateAdded = dtpDtAdd.Value.ToString();

            if (qtyT.prmssionLvlCheck())
            {
                MessageBox.Show("This permission level already exits!");
                return;
            }

            if (qtyT.saveRecord())
            {
                MessageBox.Show("Saved");
                txtQtyType.Clear();
            }
            loadPermissions();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPrmssnT_Click(object sender, EventArgs e)
        {
            txtQtyType.Enabled = false;
            txtQtyType.Text = dgvPrmssnT["Info", dgvPrmssnT.CurrentCell.RowIndex].Value.ToString();
            try
            {
                numP.Value = Convert.ToUInt16(dgvPrmssnT["PermissionLevel", dgvPrmssnT.CurrentCell.RowIndex].Value);
            }
            catch(Exception uu){
                MessageBox.Show(uu.Message);
            }
            dtpDtAdd.Value = Convert.ToDateTime(dgvPrmssnT["DateAdded", dgvPrmssnT.CurrentCell.RowIndex].Value);
        }
    }
}
