using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace POS
{
    class cSale
    {
        //{
        private int mSaleID;
        //       private string mFullName;
        private int mUserID;
        private string mDateCreated;

        private SqlCommand cmd;
        private SqlParameter param;
        private SqlConnection con;

        private string constr = new cConstr().Constr;

        public cSale(int SaleID, int UserID, string DateCreated)
        {
            mSaleID = SaleID;
            mUserID = UserID;
            mDateCreated = DateCreated;
        }

        public int SaleID
        {
            get { return mSaleID; }
            set { mSaleID = value; }
        }

        public int UserID {
            get { return mUserID; }
            set { mUserID = value; }
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

        public string saveSaleRecord()
        {
            openConnection();
            cmd.CommandText = "prc_SaleSave";

            query("@SaleID", SaleID);
            query("@UserID", UserID);
            query("@DateCreated", DateCreated);

            SqlDataReader dr = cmd.ExecuteReader();

            try
            {
                 
                //cmd.ExecuteNonQuery();

                while (dr.Read())
                {
                    string treatment = dr[0].ToString();
                    return treatment;
                }

                //return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "error";
                throw ex;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }

           
            return "error";
        }


        public bool getLastSaleID()
        {
            openConnection();
            cmd.CommandText = "prc_SaleSave";

            query("@MealID", SaleID);
            query("@UserID", UserID);
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
