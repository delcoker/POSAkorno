using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace POS
{
    class cCategory
    {
        private uint mCategoryID;
        private string mCategory;
        private string mDateAdded;

        private SqlCommand cmd;
        private SqlParameter param;
        private SqlConnection con;

        private string constr = new cConstr().Constr;

        public cCategory()
        {
        //    constr = "Data Source=AKOSUAPC;Initial Catalog=Akorno;Integrated Security=True";
        //    constr = ConfigurationManager.AppSettings["Connectionstring"];
        }

        public cCategory(uint CatID, string Category, string DateAdded)
        {
         //   constr = "Data Source=AKOSUAPC;Initial Catalog=Akorno;Integrated Security=True";
            mCategoryID = CatID;
            mCategory = Category;
            mDateAdded = DateAdded;
        }

        public uint CategoryID
        {
            get { return mCategoryID; }
            set { mCategoryID = value; }
        }

        public string Category
        {
            get { return mCategory; }
            set { mCategory = value; }
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
        private void query(string parameterName, uint parameterValue)
        {
            param = new SqlParameter();
            param.ParameterName = parameterName;
            param.SqlDbType = SqlDbType.Int;
            param.Direction = ParameterDirection.Input;
            param.Value = parameterValue;
            cmd.Parameters.Add(param);
        }

        public bool SaveRecord()
        {
            openConnection();
            cmd.CommandText = "prc_CategorySave";

            query("@CategoryID", CategoryID);
            query("@Category", Category);
            query("@Date", DateAdded);

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

        public bool CategoryDelete()
        {
            openConnection();
            cmd.CommandText = "prc_CategoryDelete";

            query("@CategoryName", Category);

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

        public bool checkCategory()
        {
            openConnection();
            cmd.CommandText = "prc_CategoryCheck";

            query("@Category", Category);

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

        public DataSet CategoryGet()
        {
            openConnection();
            cmd.CommandText = "prc_CategoryGet";

            query("CategoryID", CategoryID);

            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds, "Category");
                return ds;
            }
            catch (Exception ex)
            {
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
