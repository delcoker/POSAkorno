using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace POS
{
    class cCompanyDetails
    {
        private int mInfoID;
        //       private string mFullName;
        private string mCompanyName;
        private string mAddress;
        private string mTelephone;

        private string mTelephone_two;
        private string mEmail;


        private string mWebsite;
        private string mDateAdded;


        private SqlCommand cmd;
        private SqlParameter param;
        private SqlConnection con;

        private string constr = new cConstr().Constr;


        //        --	InfoID int identity(1,1),
        //--	CompanyName varchar(10),
        //--	Address text,
        //--	Telephone varchar (15),
        //--	Telephone2 varchar (15),
        //--	Email varchar (50),
        //--  Website varchar (30),
        //--	DateAdded datetime

        public cCompanyDetails()
        {
        }

        public cCompanyDetails(string CompanyName, string Address, string Telephone, string Telephone_two, string Email, string DateAdded, string Website)
        {
            mCompanyName = CompanyName;
            mAddress = Address;
            mTelephone_two = Telephone_two;
            mEmail = Email;
            mTelephone = Telephone;
            mDateAdded = DateAdded;
            mWebsite = Website;
        }


        public int InfoID
        {
            get { return mInfoID; }
            set { mInfoID = value; }
        }

        public string Address
        {
            get { return mAddress; }
            set { mAddress = value; }
        }


        public string CompanyName
        {
            get { return mCompanyName; }
            set { mCompanyName = value; }
        }

        public string Telephone_two
        {
            get { return mTelephone_two; }
            set { mTelephone_two = value; }
        }


        public string Telephone
        {
            get { return mTelephone; }
            set { mTelephone = value; }
        }

        public string Email
        {
            get { return mEmail; }
            set { mEmail = value; }
        }

        public string DateAdded
        {
            get { return mDateAdded; }
            set { mDateAdded = value; }
        }

        public string Website
        {
            get { return mWebsite; }
            set { mWebsite = value; }
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
            cmd.CommandText = "prc_InfoSave";

            query("@InfoID", InfoID);
            query("@CompanyName", CompanyName);
            query("@Address", Address);
            query("@Telephone", Telephone);
            query("@Telephone2", Telephone_two);
            query("@Email", Email);
            query("@DateAdded", DateAdded);
            query("@Website", Website);

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

        public DataSet InfoGet()
        {
            openConnection();
            cmd.CommandText = "prc_InfoGet";

            query("@InfoID", InfoID);
            //    query("DateAdded", DateAdded);

            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds, "Info");
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

//        InfoID int identity(1,1),
//--	CompanyName varchar(10),
//--	Address text,
//--	Telephone varchar (15),
//--	Telephone2 varchar (15),
//--	Email varchar (50),
//--  Website varchar (30),
//--	DateAdded datetime

        public bool InfoDelete()
        {
            openConnection();
            cmd.CommandText = "prc_InfoDelete";

            query("@CompanyName", CompanyName);

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

        //public DataSet UsersGetActive()
        //{
        //    openConnection();
        //    cmd.CommandText = "prc_UsersGetActive";

        //    query("UserID", UserID);
        //    //    query("DateAdded", DateAdded);

        //    DataSet ds = new DataSet();
        //    try
        //    {
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);

        //        da.Fill(ds, "Users");
        //        return ds;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        ds.Dispose();
        //        con.Dispose();
        //        con.Close();
        //    }
        //}


        //public DataSet userDetailsGet()
        //{
        //    openConnection();
        //    cmd.CommandText = "prc_UserDetailsGet";

        //    query("@UserName", UserName);
        //    query("@Password", Password);

        //    DataSet ds = new DataSet();
        //    try
        //    {
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);

        //        da.Fill(ds, "UserDetails");
        //        return ds;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        throw ex;
        //    }
        //    finally
        //    {
        //        ds.Dispose();
        //        con.Dispose();
        //        con.Close();
        //    }
        //}
    }
}

