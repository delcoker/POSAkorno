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
    class cInventoryDebit
    {
        private uint mInventoryDebitID;
        private uint mMealID;
        private uint mDebitQuantity;
        private string mDateDebited;
        private int mUserID;

        private SqlCommand cmd;
        private SqlParameter param;
        private SqlConnection con;

        private string constr = new cConstr().Constr;

        public uint InventoryDebitID
        {
            get { return mInventoryDebitID; }
            set { mInventoryDebitID = value; }
        }
        
        public uint MealID
        {
            get { return mMealID; }
            set { mMealID = value; }
        }

        public uint DebitQuantity
        {
            get { return mDebitQuantity; }
            set { mDebitQuantity = value; }
        }

        public string DateDebited
        {
            get { return mDateDebited; }
            set { mDateDebited = value; }
        }

        public int UserID
        {
            get { return mUserID; }
            set { mUserID = value; }
        }

        public cInventoryDebit(uint InventoryDebitID, uint MealID, uint DebitQuantity, string DateDebited, int UserID)
        {
            mInventoryDebitID = InventoryDebitID;
            mMealID = MealID;
            mDebitQuantity = DebitQuantity;
            mDateDebited = DateDebited;
            mUserID = UserID;
            //      constr = ConfigurationManager.AppSettings["Connectionstring"];
            //      constr = "Data Source=AKOSUAPC;Initial Catalog=Test;Integrated Security=True";
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
            cmd.CommandText = "prc_InventoryDebitSave";

            query("@InventoryDebitID", InventoryDebitID);
            query("@MealID", MealID);
            query("@DebitQuantity", DebitQuantity);
            query("@DateDebited", DateDebited);
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

        public bool InventoryDebitDelete()
        {
            openConnection();
            cmd.CommandText = "prc_InventoryDebitDelete";

            query("@InventoryDebitID", InventoryDebitID);
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

        public bool checkInventoryDebit()
        {
            openConnection();
            cmd.CommandText = "prc_InventoryDebitCheck";

            query("@MDebitID", InventoryDebitID);
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

        public DataSet InventoryDebitGet()
        {
            openConnection();
            cmd.CommandText = "prc_InventoryDebitGet";

            query("@DebitID", MealID);

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

    }
}
