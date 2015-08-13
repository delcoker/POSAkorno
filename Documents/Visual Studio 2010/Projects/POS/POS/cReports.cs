using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace POS
{
    public class cReports
    {
        private SqlCommand cmd;
        private SqlParameter param;
        private SqlConnection con;

        private string constr = new cConstr().Constr;

        private string mStartDate;
        private string mEndDate;
        private int mUserID;
        private string mUserName;
        private string mReportOnCashier;

        public cReports()
        {
            
        }

        public string StartDate
        {
            get { return mStartDate; }
            set { mStartDate = value; }
        }

        public string ReportOnCashier
        {
            get { return mReportOnCashier; }
            set { mReportOnCashier = value; }
        }

        public string EndDate
        {
            get { return mEndDate; }
            set { mEndDate = value; }
        }

        public string Username
        {
            get { return mUserName; }
            set { mUserName = value; }
        }

        public int UserID
        {
            get { return mUserID; }
            set { mUserID = value; }
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

        public DataSet TimedReport()
        {
            openConnection();
            cmd.CommandText = "prc_SaleReportGet";

            query("@StartDate", StartDate);
            query("@EndDate", EndDate);
            query("@UserID", UserID);

            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds, "Report");
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                ds.Dispose();
                con.Dispose();
                con.Close();
            }
        }
    }
}
