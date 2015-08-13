using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace POS
{
    public partial class ReportView : Form
    {
        private cReports rep;
        //private DataSet ds;

        private SqlCommand cmd;
        private SqlParameter param;
        private SqlConnection con;

        private string constr = new cConstr().Constr;

        //private string constr = "Data Source=House;Initial Catalog=Akorno;Integrated Security=True";

        
        private cUsers loggedUser;

        public ReportView(cReports report, cUsers user)
        {

            rep = new cReports();
            rep = report;

            InitializeComponent();

            loggedUser = new cUsers();
            loggedUser = user;

            //nibbies();
            //openConnection();
        }

        public void openConnection()
        {
            cmd = new SqlCommand();
            con = new SqlConnection();
            con.ConnectionString = constr;
            cmd.Connection = con;
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
        }

        //add values to a column - strings (varchar)
        private void query(string parameterName, string parameterValue)
        {
            param = new SqlParameter();
            param.ParameterName = parameterName;
            param.SqlDbType = SqlDbType.VarChar;
            param.Direction = ParameterDirection.Input;
            param.Value = parameterValue;
            cmd.Parameters.Add(param);
        }
        //add integers
        private void query(string parameterName, int parameterValue)
        {
            param = new SqlParameter();
            param.ParameterName = parameterName;
            param.SqlDbType = SqlDbType.Int;
            param.Direction = ParameterDirection.Input;
            param.Value = parameterValue;
            cmd.Parameters.Add(param);
        }
        //add decimals
        //private void query(string parameterName, decimal parameterValue);
        //add bools
        private void query(string parameterName, bool parameterValue)
        {
            param = new SqlParameter();
            param.ParameterName = parameterName;
            param.SqlDbType = SqlDbType.Bit;
            param.Direction = ParameterDirection.Input;
            param.Value = parameterValue;
            cmd.Parameters.Add(param);
        }

        //add bools
        private void query(string parameterName, DateTime parameterValue)
        {
            param = new SqlParameter();
            param.ParameterName = parameterName;
            param.SqlDbType = SqlDbType.DateTime;
            param.Direction = ParameterDirection.Input;
            param.Value = parameterValue;
            cmd.Parameters.Add(param);
        }

        //public DataSet TimedReport()
        //{
        //    openConnection();
        //    cmd.CommandText = "prc_SaleReportGet";

        //    query("@StartDate", StartDate);
        //    query("@EndDate", EndDate);
        //    query("@UserID", UserID);

        //    DataSet ds = new DataSet();
        //    try
        //    {
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);

        //        da.Fill(ds, "Report");
        //        return ds;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        throw ex;
        //    }
        //    finally
        //    {
        //        ds.Dispose();
        //        con.Dispose();
        //        con.Close();
        //    }
        //}

        private void ReportView_Load(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable("Report");
            


            ////cmd.CommandText 
            ////    prc_SaleReportGet
            //SqlDataAdapter adapter = new SqlDataAdapter("prc_SaleReportGet", con);
            
            ////this.AkornoDataSet.Report


            ////adapter.Fill(this.AkornoDataSet.Report, rep.UserID, Convert.ToDateTime(rep.StartDate), Convert.ToDateTime(rep.EndDate));

            //this.adapter.Fill(this.AkornoDataSet.Report, rep.UserID, Convert.ToDateTime(rep.StartDate), Convert.ToDateTime(rep.EndDate));

            // had to add this causes a problem with datetime Convert.ToDateTime important!!!!!!!!!!!!!!
            // TODO: This line of code loads data into the 'AkornoDataSet.Report' table. You can move, or remove it, as needed.


            this.ReportTableAdapter.Connection.ConnectionString = constr;
            this.ReportTableAdapter.Fill(this.AkornoDataSet.Report,rep.UserID, Convert.ToDateTime(rep.StartDate), Convert.ToDateTime(rep.EndDate));


            //this.ReportTableAdapter.Fill(this.AkornoDataSet.Report, "1/1/2015",  "12/12/2015");


            // stackoverflow.com/  ------------ cant type everything out: set-page-layout-report-viewer-in-visual-studio-2010
            System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();
            pg.Margins.Top = 0;
            pg.Margins.Bottom = 0;
            pg.Margins.Left = 5;
            pg.Margins.Right = 0;
            //PaperSize size = new PaperSize();
            //size.RawKind = (int)PaperKind.A4;
            //pg.PaperSize = size;
            reportViewer1.SetPageSettings(pg);


            // add parameters to report and add this to actually add/link parameter
            //reportViewer1.LocalReport.ReportPath = "Report2.rdlc";
            try
            {
                ReportParameter username = new ReportParameter("UserName", loggedUser.UserName);
                reportViewer1.LocalReport.SetParameters(username);

                ReportParameter startDate = new ReportParameter("StartDate", rep.StartDate);
                reportViewer1.LocalReport.SetParameters(startDate);

                ReportParameter endDate = new ReportParameter("EndDate", rep.EndDate);
                reportViewer1.LocalReport.SetParameters(endDate);

                ReportParameter ReportOnCashier = new ReportParameter("ReportOnCashier", rep.ReportOnCashier);
                reportViewer1.LocalReport.SetParameters(ReportOnCashier);
            }
            catch (Exception w)
            {
            }

            this.reportViewer1.RefreshReport();
        }
    }
}
