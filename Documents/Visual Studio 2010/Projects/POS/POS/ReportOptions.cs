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
    public partial class ReportOptions : Form
    {
        private cUsers loggedUser;

        public ReportOptions(cUsers user)
        {
            loggedUser = new cUsers();
            loggedUser = user;

            InitializeComponent();

            dtPickerStartDate.Format = DateTimePickerFormat.Custom;
            dtPickerStartDate.CustomFormat = "ddd dd MMM yyyy";

            dtPickerEndDate.Format = DateTimePickerFormat.Custom;
            dtPickerEndDate.CustomFormat = "ddd dd MMM yyyy";

            loadData();
            clearControls();

            CenterToParent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearControls();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            cReports rpt = new cReports();
            //string Date = dtPickerStartDate.Value.Date.ToShortDateString();
            rpt.StartDate = (dtPickerStartDate.Value.Date+ tpStart.Value.TimeOfDay).ToString();
            rpt.EndDate = (dtPickerEndDate.Value.Date + tpEnd.Value.TimeOfDay).ToString();

            rpt.ReportOnCashier = "Everything";

            // consider use checkboxes
            if (chkEmployee.Checked)
            {
                rpt.UserID = Convert.ToInt32(cmbEmployees.SelectedValue);
                rpt.ReportOnCashier = cmbEmployees.Text;
            }

            rpt.TimedReport();

            ReportView rptVw = new ReportView(rpt, loggedUser);
            rptVw.Show();

            Cursor.Current = Cursors.Default;

        }

        private void loadData()
        {
            loadCategories();
            LoadMeals();
            LoadQties();
            LoadEmp();
        }

        private void LoadEmp()
        {

            DataSet ds = new DataSet();
            cUsers emps = new cUsers();

            ds = emps.EmpGetTypes();

            cmbEmployees.DataSource = ds.Tables[0];
            cmbEmployees.ValueMember = "UserID";
            cmbEmployees.DisplayMember = "Username";

            cmbEmployees.SelectedIndex = cmbEmployees.FindStringExact(loggedUser.UserName); 
        }

        private void loadCategories()
        {
            DataSet ds = new DataSet();
            cCategory cat = new cCategory();

            ds = cat.CategoryGet();

            cmbCategory.DataSource = ds.Tables[0];
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.DisplayMember = "Category";

            cmbCategory.SelectedIndex = -1;
        }

        private void LoadMeals()
        {
            DataSet ds = new DataSet();
            cMeals meal = new cMeals();

            ds = meal.mealsGet();

            cmbMeal.DataSource = ds.Tables[0];
            cmbMeal.ValueMember = "MealID";
            cmbMeal.DisplayMember = "Name";

            cmbMeal.SelectedIndex = -1;
        }

        private void LoadQties()
        {
            DataSet ds = new DataSet();
            cQuanTypes qty = new cQuanTypes();

            ds = qty.QuanTypeGet();

            cmbQuantity.DataSource = ds.Tables[0];
            cmbQuantity.ValueMember = "QuanTypeID";
            cmbQuantity.DisplayMember = "QuanType";

            cmbQuantity.SelectedIndex = -1;
        }

        private void clearControls()
        {

            if (loggedUser.permission(3))
            {
                chkEmployee.Checked = false;
                //return;
            }



            dtPickerStartDate.Format = DateTimePickerFormat.Custom;
            dtPickerStartDate.CustomFormat = "ddd dd MMM yyyy";

            dtPickerEndDate.Format = DateTimePickerFormat.Custom;
            dtPickerEndDate.CustomFormat = "ddd dd MMM yyyy";

            DateTime today = DateTime.Now;

            dtPickerStartDate.Value = DateTime.Now; // DateTime.Now.AddDays(-7); 
            dtPickerEndDate.Value = DateTime.Now;

            //numYear.Value = DateTime.Today.Year;

            lblDesc.Text = "Select report criteria option(s) Or Print All Records";

            txtEmployeeNo.Text = "";

            //cmbMeal.Enabled = false;
            //chkMeal.Checked = false;
            //chkMeal.Enabled = false;

            //cmbEmployees.Enabled = false;
            //chkEmployee.Checked = false;
            //chkEmployee.Enabled = false;

            //txtEmployeeNo.Enabled = false;

            //cmbCategory.Enabled = false;
            //chkCategory.Checked = false;
            //chkCategory.Enabled = false;

            //cmbQuantity.Enabled = false;
            //chkQuantity.Checked = false;
            //chkQuantity.Enabled = false;

            ////chkDeActivatedEmployees.Enabled = false;
            ////chkDates.Enabled = false;

            ////cmbApplicant.Enabled = false;
            ////chkApplicant.Enabled = false;

            //lblType.Visible = false;
            //cmbType.Visible = false;

            ////cmbProgram.Enabled = false;
            ////chkProgram.Enabled = false;

            //cmbQuantity.Enabled = false;
            //chkQuantity.Enabled = false;

            ////cmbVacancyStatus.Enabled = false;
            ////cmbVacancyRef.Enabled = false;

            ////chkVacancyRef.Enabled = false;
            ////chkVacancyStatus.Enabled = false;

            ////cmbCourse.Enabled = false;
            ////chkCourse.Enabled = false;

            //cmbSaleDetail.Enabled = false;
            //chkSaleDetail.Enabled = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkEmployee_Click(object sender, EventArgs e)
        {
            //if (!loggedIn())
            //{
            //    return;
            //}
            if (!loggedUser.access(Convert.ToInt16(chkEmployee.Tag)))
            {
                chkEmployee.Checked = true;
                //return;
            }
        }

        private void cmbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!loggedUser.access(Convert.ToInt16(cmbEmployees.Tag)))
            {
                return;
            }
        }

        private void cmbEmployees_Click(object sender, EventArgs e)
        {

            if (!loggedUser.access(Convert.ToInt16(cmbEmployees.Tag)))
            {
                return;
            }
        }

    }
}
