using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace POS
{
    class cMeals
    {
        private uint mMealID;
        private string mName;
        private decimal mPrice;
		private uint mCategoryID;
		private uint mQuanTypeID;
        private string mDateAdded;
        private bool mHasStock;

        private SqlCommand cmd;
        private SqlParameter param;
        private SqlConnection con;

        private string constr = new cConstr().Constr;

        public cMeals()
        {
            //constr = "Data Source=AKOSUAPC;Initial Catalog=Ako;Integrated Security=True";

        }
        public cMeals(uint MealID, string Name, decimal Price, uint CatID, uint QuantID, string DateAdded)
        {
            mMealID = MealID;
            mName = Name;
            mPrice = Price;
            mCategoryID = CatID;
            mQuanTypeID = QuantID;
            mDateAdded = DateAdded;
            //      constr = ConfigurationManager.AppSettings["Connectionstring"];
            //      constr = "Data Source=AKOSUAPC;Initial Catalog=Test;Integrated Security=True";
        }

        public cMeals(uint MealID, string Name, decimal Price, uint CatID, uint QuantID, string DateAdded, bool HasStock)
        {
            mMealID = MealID;
            mName = Name;
            mPrice = Price;
            mCategoryID = CatID;
            mQuanTypeID = QuantID;
            mDateAdded = DateAdded;
            mHasStock = HasStock;
            //      constr = ConfigurationManager.AppSettings["Connectionstring"];
            //      constr = "Data Source=AKOSUAPC;Initial Catalog=Test;Integrated Security=True";
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
            //    if (value.Count(s => Char.IsDigit(s)) > 0)
            //    {
            //        throw new Exception("Only letters allowed");
            //    }
            //    Name = value;
            //}

        }

        public decimal Price
        {
            get { return mPrice; }
            set { mPrice = value; }
        }

        public uint CategoryID
        {
            get { return mCategoryID; }
            set { mCategoryID = value; }
        }

        public uint QuanTypeID
        {
            get { return mQuanTypeID; }
            set { mQuanTypeID = value; }
        }

        public string DateAdded
        {
            get { return mDateAdded; }
            set { mDateAdded = value; }
        }

        public bool HasStock
        {
            get { return mHasStock; }
            set { mHasStock = value; }
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
        private void query(string parameterName, decimal parameterValue)
        {
            param = new SqlParameter();
            param.ParameterName = parameterName;
            param.SqlDbType = SqlDbType.Decimal;
            param.Direction = ParameterDirection.Input;
            param.Value = parameterValue;
            cmd.Parameters.Add(param);
        }

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

        public bool saveRecord()
        {
            openConnection();
            cmd.CommandText = "prc_MealsSave";

            query("@MealID", MealID);
            query("@Name", Name);
            query("@Price", Price);
            query("@CategoryID", CategoryID);
            query("@QuanTypeID", QuanTypeID);
            query("@DateAdded", DateAdded);
            query("@HasStock", HasStock);

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
            query("@QuanTypeID", QuanTypeID);

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
            query("@QuanTypeID", QuanTypeID);

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

        public DataSet mealsGet()
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

        public DataSet specificMealGet(string Category)
        {
            openConnection();
            cmd.CommandText = "prc_SpecificMealGet";

            query("@Category", Category);

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

        public DataSet specificMealGetByQuantity(uint QuantityTypeID)
        {
            openConnection();
            cmd.CommandText = "prc_SpecificMealGetByQunatity";

            query("@QuantypeID", QuantityTypeID);

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

        

        public DataSet specQtyTypeGet(string QtyType)
        {
            openConnection();
            cmd.CommandText = "prc_SpecQtyTypeGet";

            query("@QuanType", QtyType);

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

        public DataSet staffDiscountGet()
        {
            openConnection();
            cmd.CommandText = "prc_staffDiscountGet";

            //query("@QuanType", QtyType);

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
