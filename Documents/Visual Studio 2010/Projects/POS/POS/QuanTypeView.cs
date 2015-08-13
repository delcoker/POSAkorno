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
    public partial class QuanTypeView : Form
    {
        private cUsers loggedUser;

        public QuanTypeView(cUsers  user)
        {
            InitializeComponent();
            LoadQuanTypes();
            CenterToParent();

            loggedUser = new cUsers();
            loggedUser = user;
            llblLog.Text = loggedUser.UserName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadQuanTypes()
        {
            DataSet ds = new DataSet();
            try
            {
                cQuanTypes qtyT = new cQuanTypes();
                qtyT.QuanTypeID = 0;
                ds = qtyT.QuanTypeGet();

                dgvQtyT.DataSource = ds.Tables[0];

                dgvQtyT.Columns[0].HeaderText = "Quantity Type ID";
                dgvQtyT.Columns[1].HeaderText = "Quantity Type";
                dgvQtyT.Columns[2].HeaderText = "Date Added";

                dgvQtyT.Columns[0].Visible = false;
                dgvQtyT.Columns[1].Width = 200;
                dgvQtyT.Columns[2].Width = 200;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ds.Dispose();
            }
            txtQtyType.Enabled = false;
            txtQtyType.Focus();
        }

        private void dgvQtyT_Click(object sender, EventArgs e)
        {
            txtQtyType.Enabled = false;
            txtQtyType.Text = dgvQtyT["QuanType", dgvQtyT.CurrentCell.RowIndex].Value.ToString();
            dtpDtAdd.Value = Convert.ToDateTime(dgvQtyT["DateAdded", dgvQtyT.CurrentCell.RowIndex].Value);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dgvQtyT_Click(dgvQtyT, e);
            txtQtyType.Enabled = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtQtyType.Text.Trim() == "")
            {
                MessageBox.Show("Select a quantitiy type");
                return;
            }
            //txtQtyType.Text = dgvQtyT["QuanType", dgvQtyT.CurrentCell.RowIndex].Value.ToString();
            cQuanTypes qtyT = new cQuanTypes();
            qtyT.QuanType = txtQtyType.Text;

            if (qtyT.QuanTypeDelete())
            {
                txtQtyType.Clear();
                MessageBox.Show("Deleted");
            }
            else
                MessageBox.Show("Not Deleted");

            LoadQuanTypes();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtQtyType.Text.Trim() == "")
            {
                MessageBox.Show("Quantitiy type required");
                return;
            }

            cQuanTypes qtyT = new cQuanTypes();

            qtyT.QuanTypeID = Convert.ToUInt32(dgvQtyT["QuanTypeID", dgvQtyT.CurrentCell.RowIndex].Value);
            qtyT.QuanType = txtQtyType.Text;
            qtyT.DateAdded = dtpDtAdd.Value.ToString();

            if (qtyT.checkQuanType())
            {
                MessageBox.Show("This quantity type already exits!");
                return;
            }

            if (qtyT.SaveRecord())
            {
                MessageBox.Show("Saved");
                txtQtyType.Clear();
            }
            LoadQuanTypes();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            QuanTypeAdd qtyA = new QuanTypeAdd(loggedUser);
            qtyA.ShowDialog();
            LoadQuanTypes();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dtpDtAdd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblQuanType_Click(object sender, EventArgs e)
        {

        }

        private void txtQtyType_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvQtyT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void llblLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }


    }
}
