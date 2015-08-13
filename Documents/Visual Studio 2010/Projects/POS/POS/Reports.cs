using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace POS
{
    class Reports
    {
        private string mStartDate;
        private string mEndDate;

        private int mEmployeeID;
        private string mEmployeeNo;

        private int mCategoryID;
        private int mMealID;
        private int mQuantityTypeID;
        private int mSaleDetail;

        private string mMonth;

        private string mDateCreated;

        private SqlCommand cmd;
        private SqlParameter param;
        private SqlConnection con;

        private DataSet mDS = new DataSet();
        private string constr = new cConstr().Constr;

        public int CategoryID
        {
            get { return mCategoryID; }
            set { mCategoryID = value; }
        }

        public int MealID
        {
            get { return mMealID; }
            set { mMealID = value; }
        }

        public int QuantityTypeID
        {
            get { return mQuantityTypeID; }
            set { mQuantityTypeID = value; }
        }

        public int SaleDetail
        {
            get { return mSaleDetail; }
            set { mSaleDetail = value; }
        }

        public int EmployeeID
        {
            get { return mEmployeeID; }
            set { mEmployeeID = value; }
        }

        public string EmployeeNo
        {
            get { return mEmployeeNo; }
            set { mEmployeeNo = value; }
        }

        public string StartDate
        {
            get { return mStartDate; }
            set { mStartDate = value; }
        }

        public string DateCreated
        {
            get { return mDateCreated; }
            set { mDateCreated = value; }
        }

        public string EndDate
        {
            get { return mEndDate; }
            set { mEndDate = value; }
        }

        public string Month
        {
            get { return mMonth; }
            set { mMonth = value; }
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
        // add double
        private void query(string parameterName, double parameterValue)
        {
            param = new SqlParameter();
            param.ParameterName = parameterName;
            param.SqlDbType = SqlDbType.Decimal;
            param.Direction = ParameterDirection.Input;
            param.Value = parameterValue;
            cmd.Parameters.Add(param);
        }

        public bool saveReportRecord()
        {
            openConnection();
            cmd.CommandText = "prc_SaleDetailSave";

            //query("@SaleDetailID", SaleDetailID);
            //query("@MealID", MealID);
            //query("@SaleID", SaleID);
            //query("@Quantity", Quantity);
            //query("@Subtotal", Subtotal);
            //query("@Total", Total);
            query("@DateCreated", DateCreated);

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw ex;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
        }
    }
}
