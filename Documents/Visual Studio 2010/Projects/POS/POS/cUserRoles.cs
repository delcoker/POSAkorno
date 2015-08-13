using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace POS
{
    class cUserRoles
    {
        private int mUserRoleID;
        private string mUserRole;
        private string mDateAdded;

        private SqlCommand cmd;
        private SqlParameter param;
        private SqlConnection con;

        private string constr = new cConstr().Constr;

        public cUserRoles()
        {
        //    constr = "Data Source=AKOSUAPC;Initial Catalog=Akorno;Integrated Security=True";
        //    constr = ConfigurationManager.AppSettings["Connectionstring"];
        }

        public cUserRoles(int UserRoleID, string UserRole, string DateAdded)
        {
         //   constr = "Data Source=AKOSUAPC;Initial Catalog=Akorno;Integrated Security=True";
            mUserRoleID = UserRoleID;
            mUserRole = UserRole;
            mDateAdded = DateAdded;
        }

        public int UserRoleID
        {
            get { return mUserRoleID; }
            set { mUserRoleID = value; }
        }

        public string UserRole
        {
            get { return mUserRole; }
            set { mUserRole = value; }
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

        public bool SaveRecord()
        {
            openConnection();
            cmd.CommandText = "prc_CategorySave";

            query("@UserRolesID", UserRoleID);
            query("@Roles", UserRole);
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

        public bool UserRoleDelete()
        {
            openConnection();
            cmd.CommandText = "prc_UserRoleDelete";

            query("@UserRoleID", UserRoleID);

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

        public bool checkUserRole()
        {
            openConnection();
            cmd.CommandText = "prc_checkUserRole";

            query("@UserRole", UserRole);

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

        public DataSet UserRolesGet()
        {
            openConnection();
            cmd.CommandText = "prc_UserRolesGet";

            query("@UserRoleID", UserRoleID);

            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds, "UserRole");
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
