using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace POS
{
    class cPrint
    {
        private uint mMealID;
        private string mName;
        private decimal mPrice;
        private string mDateSold;
        private uint mPortions;
        private decimal mSubTotal;
        private decimal mTotal;
		//private uint mCategoryID;
		//private uint mQuanTypeID;
        
        private string mSalesPerson;

        private SqlCommand cmd;
        private SqlParameter param;
        private SqlConnection con;

        private string constr = "Data Source=AKOSUAPC;Initial Catalog=Akorno;Integrated Security=True";

        public cPrint()
        {

        }
        public cPrint(uint MealID, string Name, decimal Price, uint Portions, decimal SubTotal, uint QuantID, string DateSold, decimal Total, string SalesPerson)
        {
            mMealID = MealID;
            mName = Name;
            mPrice = Price;
            mPortions = Portions;
            mSubTotal = SubTotal;
            mTotal = Total;
            mSalesPerson = SalesPerson;
            mDateSold = DateSold;
        }

        public uint MealID
        {
            get { return mMealID; }
            set { mMealID = value; }
        }

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        public decimal Price
        {
            get { return mPrice; }
            set { mPrice = value; }
        }

        public uint Portions
        {
            get { return mPortions; }
            set { mPortions = value; }
        }

        public decimal SubTotal
        {
            get { return mSubTotal; }
            set { mSubTotal = value; }
        }

        public decimal Total
        {
            get { return mTotal; }
            set { mTotal = value; }
        }

        //public uint CategoryID
        //{
        //    get { return mCategoryID; }
        //    set { mCategoryID = value; }
        //}

        //public uint QuanTypeID
        //{
        //    get { return mQuanTypeID; }
        //    set { mQuanTypeID = value; }
        //}

        public string DateSold
        {
            get { return mDateSold; }
            set { mDateSold = value; }
        }

        public string SalesPerson
        {
            get { return mSalesPerson; }
            set { mSalesPerson = value; }
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
        private void query(string parameterName, uint parameterValue)
        {
            param = new SqlParameter();
            param.ParameterName = parameterName;
            param.SqlDbType = SqlDbType.Int;
            param.Direction = ParameterDirection.Input;
            param.Value = parameterValue;
            cmd.Parameters.Add(param);
        }
        //add decimals
        private void query(string parameterName, decimal parameterValue)
        {
            param = new SqlParameter();
            param.ParameterName = parameterName;
            param.SqlDbType = SqlDbType.Decimal;
            param.Direction = ParameterDirection.Input;
            param.Value = parameterValue;
            cmd.Parameters.Add(param);
        }

        // mMealID;
        //private string mName;
        //private decimal mPrice;
        //private string mDateSold;
        //private int mPortions;
        //private decimal mSubTotal;
        //private decimal mTotal;
        
        //private string mSalesPerson;

        public bool saveRecord()
        {
            openConnection();
            cmd.CommandText = "prc_SaleSave";

            query("@MealID", MealID);
            query("@Name", Name);
            query("@Price", Price);
            query("@Portions", Portions);
            query("@mSubTotal", SubTotal);
            query("@DateSold", DateSold);
            
            query("@Total", Total);
            query("@SalesPerson", SalesPerson);

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

        public bool mealDelete()
        {
            openConnection();
            cmd.CommandText = "prc_MealDelete";

            query("@MealName", Name);
   //         query("@QuanTypeID", QuanType);

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

        public bool checkMeal()
        {
            openConnection();
            cmd.CommandText = "prc_MealCheck";

            query("@Name", Name);
//            query("@QuanTypeID", QuanTypeID);

            SqlDataReader dr = cmd.ExecuteReader();
            try
            {
                while (dr.Read())
                {
                    if (dr.GetSqlValue(0).ToString() == "1")
                        return true;
                }
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
            return false;
        }

        public DataSet MealsGet()
        {
            openConnection();
            cmd.CommandText = "prc_MealsGet";

            query("MealID", MealID);

            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds, "Meals");
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
