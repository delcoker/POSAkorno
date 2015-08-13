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
    class cInventory
    {

        private uint mInventoryID;
        private uint mMealID;
        private uint mAmountAdded;
        private int mUserID;
       
        private string mDateAdded;
        private string mLastModified;

        private SqlCommand cmd;
        private SqlParameter param;
        private SqlConnection con;

        private string constr = new cConstr().Constr;

        public cInventory()
        {
            //constr = "Data Source=AKOSUAPC;Initial Catalog=Ako;Integrated Security=True";

        }
        public cInventory(uint InventoryID, uint MealID, uint AmountAdded, string DateAdded, int UserID)
        {
            mInventoryID = InventoryID;
            mMealID = MealID;
            mAmountAdded = AmountAdded;
            mDateAdded = DateAdded;
            mUserID = UserID;
            //      constr = ConfigurationManager.AppSettings["Connectionstring"];
            //      constr = "Data Source=AKOSUAPC;Initial Catalog=Test;Integrated Security=True";
        }

        public cInventory(uint InventoryID, uint MealID, uint AmountAdded, string DateAdded, int UserID, string LastModified)
        {
            mInventoryID = InventoryID;
            mMealID = MealID;
            mAmountAdded = AmountAdded;
            mDateAdded = DateAdded;
            mUserID = UserID;
            //      constr = ConfigurationManager.AppSettings["Connectionstring"];
            //      constr = "Data Source=AKOSUAPC;Initial Catalog=Test;Integrated Security=True";
        }

        public uint InventoryID
        {
            get { return mInventoryID; }
            set { mInventoryID = value; }
        }

        public string LastModified
        {
            get { return mLastModified; }
            set { mLastModified = value; }
        }

        public int UserID
        {
            get { return mUserID; }
            set { mUserID = value; }
        }
        
        public uint MealID
        {
            get { return mMealID; }
            set { mMealID = value; }
        }

        public uint AmountAdded
        {
            get { return mAmountAdded; }
            set { mAmountAdded = value; }
        }

        public string DateAdded
        {
            get { return mDateAdded; }
            set { mDateAdded = value; }
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

        public bool saveRecord()
        {
            openConnection();
            cmd.CommandText = "prc_InventorySave";

            query("@InventoryID", InventoryID);
            query("@MealID", MealID);
            query("@CreditQuantity", AmountAdded);
            query("@DateCredited", DateAdded);
            query("@UserID", UserID);
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

        public bool InventoryDelete()
        {
            openConnection();
            cmd.CommandText = "prc_InventoryDelete";

            //query("@MealName", Name);
            //query("@QuanTypeID", QuanTypeID);

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

        public bool checkInventory()
        {
            openConnection();
            cmd.CommandText = "prc_InventoryCheck";

            query("@MealID", MealID);
            //query("@QuanTypeID", QuanTypeID);

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

        public DataSet InventoryGet()
        {
            openConnection();
            cmd.CommandText = "prc_InventoryGet";

            query("@InventoryID", InventoryID);

            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds, "Inventory");
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

        public DataSet InventoryMealsGet()
        {
            openConnection();
            cmd.CommandText = "prc_InventoryMealsGet";

            query("@MealID", MealID);

            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds, "Inventory");
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

    }
}
