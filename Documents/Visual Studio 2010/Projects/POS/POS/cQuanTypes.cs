using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace POS
{
    class cQuanTypes
    {
        private uint mQuanTypeID;
        private string mQuanType;
        private string mDateAdded;

        private SqlCommand cmd;
        private SqlParameter param;
        private SqlConnection con;

        private string constr = new cConstr().Constr;

        public cQuanTypes()
        {
        //    constr = "Data Source=AKOSUAPC;Initial Catalog=Akorno;Integrated Security=True";
        //    constr = ConfigurationManager.AppSettings["Connectionstring"];
        }

        public cQuanTypes(uint QuantID, string QuanType, string DateAdded)
        {
        //    constr = "Data Source=AKOSUAPC;Initial Catalog=Akorno;Integrated Security=True";
            mQuanTypeID = QuantID;
            mQuanType = QuanType;
            mDateAdded = DateAdded;
        }

        public uint QuanTypeID {
            get { return mQuanTypeID;}
            set { mQuanTypeID = value; }
        }

        public string QuanType
        {
            get { return mQuanType; }
            set { mQuanType = value; }
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
            cmd.CommandText = "prc_QuanTypeSave";

            query("@QuanTypeID", QuanTypeID);
            query("@QuanType", QuanType);
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

        public bool QuanTypeDelete()
        {
            openConnection();
            cmd.CommandText = "prc_QuanTypeDelete";

            query("QuanTypeName", QuanType);

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

        public bool checkQuanType()
        {
            openConnection();
            cmd.CommandText = "prc_QuanTypeCheck";

            query("@QuanType", QuanType);

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

        public DataSet QuanTypeGet()
        {
            openConnection();
            cmd.CommandText = "prc_QuanTypeGet";

            query("QuanTypeID", QuanTypeID);
        //    query("DateAdded", DateAdded);

            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds, "QuanType");
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
