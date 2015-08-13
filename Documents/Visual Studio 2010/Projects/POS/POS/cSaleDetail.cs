using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace POS
{
    class cSaleDetail
    {
        private int mSaleDetailID;
        private int mSaleID;
        //       private string mFullName;
        private int mMealID;
        private int mQuantity;
        private decimal mSubtotal;
        private decimal mTotal;
        private string mDateCreated;

        private SqlCommand cmd;
        private SqlParameter param;
        private SqlConnection con;

        private string constr = new cConstr().Constr;

        public cSaleDetail(int SaleDetailID, int SaleID, int MealID, int Quantity, decimal Subtotal, decimal Total, string DateCreated)
        {
            mSaleDetailID = SaleDetailID;
            mSaleID = SaleID;
            mMealID = MealID;
            mQuantity = Quantity;
            mSubtotal = Subtotal;
            mTotal = Total;
            mDateCreated = DateCreated;
        }

        public int SaleDetailID
        {
            get { return mSaleDetailID; }
            set { mSaleDetailID = value; }
        }

        public int SaleID
        {
            get { return mSaleID; }
            set { mSaleID = value; }
        }

        public int MealID
        {
            get { return mMealID; }
            set { mMealID = value; }
        }
        public int Quantity
        {
            get { return mQuantity; }
            set { mQuantity = value; }
        }

        public decimal Subtotal
        {
            get { return mSubtotal; }
            set { mSubtotal = value; }
        }

        public decimal Total
        {
            get { return mTotal; }
            set { mTotal = value; }
        }

        public string DateCreated
        {
            get { return mDateCreated; }
            set { mDateCreated = value; }
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

        private void query(string parameterName, double parameterValue)
        {
            param = new SqlParameter();
            param.ParameterName = parameterName;
            param.SqlDbType = SqlDbType.Decimal;
            param.Direction = ParameterDirection.Input;
            param.Value = parameterValue;
            cmd.Parameters.Add(param);
        }

        private void query(string parameterName, decimal parameterValue)
        {
            param = new SqlParameter();
            param.ParameterName = parameterName;
            param.SqlDbType = SqlDbType.Decimal;
            param.Direction = ParameterDirection.Input;
            param.Value = parameterValue;
            cmd.Parameters.Add(param);
        }

        public bool saveSaleDetailRecord()
        {
            openConnection();
            cmd.CommandText = "prc_SaleDetailSave";

            query("@SaleDetailID", SaleDetailID);
            query("@MealID", MealID);
            query("@SaleID", SaleID);
            query("@Quantity", Quantity);
            query("@Subtotal", Subtotal);
            query("@Total", Total);
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