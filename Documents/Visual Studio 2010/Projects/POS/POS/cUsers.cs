using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace POS
{
    public class cUsers
    {
        //public class Users
        //{
        private int mUserID;
        //       private string mFullName;
        private string mUserName;
        private string mPassword;
        private string mCompany;

        private int mPermLevel;
        private bool mDeActivate;

        private string mDateAdded;
        private string mLastLogin;
        private string mLastAttemptedLogin;

        private Boolean mAddAction;
        private Boolean mEditAction;
        private Boolean mViewAction;
        private Boolean mExecuteAction;

        private SqlCommand cmd;
        private SqlParameter param;
        private SqlConnection con;

        private string constr = new cConstr().Constr;

        public cUsers()
        {
        }

        public cUsers(string FirstName, string LastName, string Password, string Company, int PermLevel, bool Deactivate, string DateAdded, string LastLogin, string LastAttemptedLogin)
        {
            mUserName = FirstName + " " + LastName;
            mPassword = Password;
            mPermLevel = PermLevel;
            mDeActivate = Deactivate;
            mCompany = Company;
            mDateAdded = DateAdded;
            mLastAttemptedLogin = LastAttemptedLogin;
            mLastLogin = LastLogin;
        }

        

        //       private IDbConnection cn;
        //       private IDbCommand cmd;

        public int UserID
        {
            get { return mUserID; }
            set { mUserID = value; }
        }

        public string Company
        {
            get { return mCompany; }
            set { mCompany = value; }
        }

        public string UserName
        {
            get { return mUserName; }
            set { mUserName = value; }
        }

        public string Password
        {
            get { return mPassword; }
            set { mPassword = value; }
        }


        public int PermLevel
        {
            get { return mPermLevel; }
            set { mPermLevel = value; }
        }

        public bool DeActivate
        {
            get { return mDeActivate; }
            set { mDeActivate = value; }
        }


        //public int LocationID
        //{
        //    get { return mLocationID; }
        //    set { mLocationID = value; }
        //}

        //public int CompanyID
        //{
        //    get { return mCompanyID; }
        //    set { mCompanyID = value; }

        //}

        //public Boolean AccessAllCompanies
        //{
        //    get { return mAllCompanies; }
        //    set { mAllCompanies = value; }

        //}

        //public string Solution
        //{
        //    get { return mSolution; }
        //    set { mSolution = value; }

        //}

        //public int ProcessID
        //{
        //    get { return mProcessID; }
        //    set { mProcessID = value; }

        //}

        public string DateAdded
        {
            get { return mDateAdded; }
            set { mDateAdded = value; }
        }
        public string LastLogin
        {
            get { return mLastLogin; }
            set { mLastLogin = value; }
        }

        public string LastAttemptedLogin
        {
            get { return mLastAttemptedLogin; }
            set { mLastAttemptedLogin = value; }
        }

        public Boolean AddAction
        {
            get { return mAddAction; }
            set { mAddAction = value; }
        }

        public Boolean ViewAction
        {
            get { return mViewAction; }
            set { mViewAction = value; }
        }

        public Boolean EditAction
        {
            get { return mEditAction; }
            set { mEditAction = value; }
        }

        public Boolean ExecuteAction
        {
            get { return mExecuteAction; }
            set { mExecuteAction = value; }
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

        public bool checkUserPassword()
        {
            openConnection();
            cmd.CommandText = "prc_UserPasswordCheck";

            query("@Name", UserName);
            query("@Password", Password);

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

        public DataSet EmpGetTypes()
        {
            openConnection();
            cmd.CommandText = "prc_EmpGetTypes";

            query("EmpType", PermLevel);
            //    query("DateAdded", DateAdded);

            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds, "Users");
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

        public DataSet UsersGet()
        {
            openConnection();
            cmd.CommandText = "prc_UsersGet";

            query("UserID", UserID);
            //    query("DateAdded", DateAdded);

            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds, "Users");
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

        public DataSet UsersGetActive()
        {
            openConnection();
            cmd.CommandText = "prc_UsersGetActive";

            query("UserID", UserID);
            //    query("DateAdded", DateAdded);

            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds, "Users");
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

        public DataSet UsersGetAll()
        {
            openConnection();
            cmd.CommandText = "prc_UsersGetAll";

            query("UserID", UserID);
            //    query("DateAdded", DateAdded);

            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds, "Users");
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


        public bool access( int ItemPermLevel)
        {
            if (PermLevel <= ItemPermLevel)
            {
                return true;
            }
            MessageBox.Show("You do not have enough rights to access this function");
            return false;
        }

        public bool permission(int ItemPermLevel)
        {
            if (PermLevel <= ItemPermLevel)
            {
                return true;
            }
            return false;
        }

        public bool checkUserName()
        {
            openConnection();
            cmd.CommandText = "prc_checkUserName";

            query("@Name", UserName);
            //query("@Password", Password);

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

        public DataSet userDetailsGet()
        {
            openConnection();
            cmd.CommandText = "prc_UserDetailsGet";

            query("@UserName", UserName);
            query("@Password", Password);

            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds, "UserDetails");
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

        public bool saveRecord()
        {
            openConnection();
            cmd.CommandText = "prc_UserSave";

            query("@UserID", UserID);
            query("@UserName", UserName.Trim());
            query("@Company", Company);
            query("@PermLevel", PermLevel);
            query("@Deactivate", DeActivate);
            query("@Password", Password);
            query("@DateAdded", DateAdded);
            query("@LastLogin", LastLogin);
            query("@LastAttemptedLogin", LastAttemptedLogin);

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

        public bool saveRecordNoPassword()
        {
            openConnection();
            cmd.CommandText = "prc_UserSaveNoPassword";

            query("@UserID", UserID);
            query("@UserName", UserName.Trim());
            query("@Company", Company);
            query("@PermLevel", PermLevel);
            query("@Deactivate", DeActivate);
            query("@Password", Password);
            query("@DateAdded", DateAdded);
            query("@LastLogin", LastLogin);
            query("@LastAttemptedLogin", LastAttemptedLogin);

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


        public bool deactivateUser()
        {
            openConnection();
            cmd.CommandText = "prc_UserDelete";

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

        public bool reactivateUser()
        {
            openConnection();
            cmd.CommandText = "prc_UserReAdd";

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



        //public IDataReader GetUserList()
        //{

        //    SqlCommand cmd = new SqlCommand();
        // //   AppSetting BillSet = new AppSetting();
        ////    cn = BillSet.GetConnection();
        //    //cmd = BillSet.GetCommand();

        //    cmd.CommandText = "dbo.prc_UserList";
        //    cmd.CommandType = CommandType.StoredProcedure;
        ////    cmd.Connection = (SqlConnection)cn; ;

        //    IDbDataParameter param = cmd.CreateParameter();

        //    // Input param.
        //    //param = cmd.CreateParameter();
        //    param.ParameterName = "@Solution";
        //    param.DbType = DbType.String;
        //    param.Value = mSolution;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);


        //    try
        //    {
        //        return cmd.ExecuteReader();
        //    }
        //    catch
        //    {
        //        throw;
        //    }

        //}

        //public DataSet GetUserDataSet()
        //{

        //SqlCommand cmd = new SqlCommand();
        //AppSetting BillSet = new AppSetting();

        //cn = BillSet.GetConnection();
        ////cmd = BillSet.GetCommand();

        //cmd.CommandText = "dbo.prc_UserList";
        //cmd.CommandType = CommandType.StoredProcedure;
        //cmd.Connection = (SqlConnection)cn;

        //IDbDataParameter param = cmd.CreateParameter();

        //// Input param.
        ////param = cmd.CreateParameter();
        //param.ParameterName = "@Solution";
        //param.DbType = DbType.String;
        //param.Value = mSolution;
        //param.Direction = ParameterDirection.Input;
        //cmd.Parameters.Add(param);



        //try
        //{

        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataSet dats = new DataSet();
        //    da.Fill(dats, "Users");
        //    return dats;
        //}
        //catch
        //{
        //    throw;
        //}

        //    }

        //public bool IsUserNameUnique(string sUserName)
        //{

        ////IDbConnection cn;
        //// IDbCommand cmd;

        //AppSetting BillSet = new AppSetting();
        //cn = BillSet.GetConnection();
        //cmd = BillSet.GetCommand();

        //cmd.CommandText = "dbo.prc_User_Search";
        //cmd.CommandType = CommandType.StoredProcedure;
        //cmd.Connection = cn;

        //IDbDataParameter param = cmd.CreateParameter();

        //// Input param -> pass Null value           
        //param.ParameterName = "@UserID";
        //param.DbType = DbType.Int32;
        //param.Value = null;
        //param.Direction = ParameterDirection.Input;
        //cmd.Parameters.Add(param);

        //// Input param.
        //param = cmd.CreateParameter();
        //param.ParameterName = "@UserName";
        //param.DbType = DbType.String;
        //param.Value = sUserName;
        //param.Direction = ParameterDirection.Input;
        //cmd.Parameters.Add(param);


        //// Input param.
        //param = cmd.CreateParameter();
        //param.ParameterName = "@Solution";
        //param.DbType = DbType.String;
        //param.Value = mSolution;
        //param.Direction = ParameterDirection.Input;
        //cmd.Parameters.Add(param);

        //try
        //{
        //    IDataReader datR = cmd.ExecuteReader();
        //    string sUser = null;

        //    while (datR.Read())
        //    {
        //        sUser = datR.GetValue(2).ToString();
        //    }
        //    datR.Close();

        //    if (sUser == null)
        //        return true;
        //    else
        //        return false;

        //}
        //catch
        //{
        //    throw;
        //}

        //    }

        //public int GetDefaultCompany(string sUserName)
        //{

        //    //IDbConnection cn;
        //    // IDbCommand cmd;

        //    AppSetting BillSet = new AppSetting();
        //    cn = BillSet.GetConnection();
        //    cmd = BillSet.GetCommand();

        //    cmd.CommandText = "dbo.prc_UserCompany";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Connection = cn;

        //    IDbDataParameter param = cmd.CreateParameter();

        //    // Input param -> pass Null value           
        //    param.ParameterName = "@UserID";
        //    param.DbType = DbType.Int32;
        //    param.Value = null;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);

        //    // Input param.
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@UserName";
        //    param.DbType = DbType.String;
        //    param.Value = sUserName;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);

        //    // Input param.
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@Solution";
        //    param.DbType = DbType.String;
        //    param.Value = mSolution;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);

        //    try
        //    {
        //        SqlDataReader datR = (SqlDataReader)cmd.ExecuteReader();

        //        int compId = 0;

        //        while (datR.Read())
        //        {
        //            compId = Convert.ToInt16(datR.GetSqlValue(datR.GetOrdinal("CompanyID")).ToString());
        //        }
        //        datR.Close();

        //        return compId;

        //    }
        //    catch
        //    {
        //        throw;
        //    }

        //}


        //public int GetLoginAccessLevel(string sUserName, string sPwd)
        //{

        //    //IDbConnection cn;
        //    //IDbCommand cmd;

        //    AppSetting BillSet = new AppSetting();
        //    cn = BillSet.GetConnection();
        //    cmd = BillSet.GetCommand();

        //    cmd.CommandText = "dbo.prc_UserLogin_Search";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Connection = cn;

        //    IDbDataParameter param = cmd.CreateParameter();


        //    // Input param.
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@UserName";
        //    param.DbType = DbType.String;
        //    param.Value = sUserName;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);


        //    // Input param.
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@Passwd";
        //    param.DbType = DbType.String;
        //    param.Value = sPwd;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);


        //    // Input param.
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@Solution";
        //    param.DbType = DbType.String;
        //    param.Value = mSolution;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);


        //    try
        //    {
        //        IDataReader datR = cmd.ExecuteReader();
        //        int nLevel = -1;

        //        while (datR.Read())
        //        {
        //            nLevel = Convert.ToInt16(datR.GetValue(0).ToString());
        //            UserID = Convert.ToInt32(datR.GetValue(1).ToString());
        //            //nLevel = Convert.ToInt16(datR.GetValue(datR.GetOrdinal("Level")).ToString());
        //        }
        //        datR.Close();

        //        return nLevel;

        //    }
        //    catch
        //    {
        //        throw;
        //    }

        //}



        //public void SaveUserRecord()
        //{
        //    AppSetting BillSet = new AppSetting();
        //    cn = BillSet.GetConnection();
        //    cmd = BillSet.GetCommand();

        //    // Establish name of stored proc.
        //    cmd.CommandText = "dbo.prc_Users_Update";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Connection = cn;


        //    IDbDataParameter param = cmd.CreateParameter();

        //    // Input param.            
        //    param.ParameterName = "@UserID";
        //    param.DbType = DbType.Int16;
        //    param.Value = UserID;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);


        //    // Input param.
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@UserName";
        //    param.DbType = DbType.String;
        //    param.Value = this.UserName;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);

        //    // Input param.
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@FullName";
        //    param.DbType = DbType.String;
        //    param.Value = FullName;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);

        //    // Input param.
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@Passwd";
        //    param.DbType = DbType.String;
        //    param.Value = this.Password;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);


        //    CommonFunc newFunc = new CommonFunc();
        //    mWho = newFunc.GetXmlUserID();

        //    // Input param.
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@Who";
        //    param.DbType = DbType.Int16;
        //    param.Value = mWho;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);


        //    // Input param.
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@DeActivate";
        //    param.DbType = DbType.Boolean;
        //    param.Value = this.DeActivate;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);


        //    // Input param.
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@Level";
        //    param.DbType = DbType.Int16;
        //    param.Value = this.Level;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);


        //    // Input param.
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@CompanyID";
        //    param.DbType = DbType.Int16;
        //    param.Value = mCompanyID;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);



        //    // Input param.
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@AllCompanies";
        //    param.DbType = DbType.Boolean;
        //    param.Value = mAllCompanies;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);


        //    // Input param.
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@Solution";
        //    param.DbType = DbType.String;
        //    param.Value = mSolution;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);


        //    //Execute proc
        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch
        //    {
        //        throw;
        //    }


        //}


        //public void ChangeUserPassword()
        //{
        //    AppSetting BillSet = new AppSetting();
        //    cn = BillSet.GetConnection();
        //    cmd = BillSet.GetCommand();

        //    // Establish name of stored proc.
        //    cmd.CommandText = "dbo.prc_Users_UpdatePswd";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Connection = cn;


        //    IDbDataParameter param = cmd.CreateParameter();


        //    // Input param.
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@UserName";
        //    param.DbType = DbType.String;
        //    param.Value = this.UserName;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);


        //    // Input param.
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@Passwd";
        //    param.DbType = DbType.String;
        //    param.Value = this.Password;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);


        //    // Input param.
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@Solution";
        //    param.DbType = DbType.String;
        //    param.Value = mSolution;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);

        //    //Execute proc
        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch
        //    {
        //        throw;
        //    }


        //}

        //public IDataReader GetUserRecord(int UserID)
        //{

        //    AppSetting BillSet = new AppSetting();
        //    cn = BillSet.GetConnection();
        //    cmd = BillSet.GetCommand();

        //    cmd.CommandText = "dbo.prc_User_Search";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Connection = cn;

        //    IDbDataParameter param = cmd.CreateParameter();

        //    // Input param -> pass Null value           
        //    param.ParameterName = "@UserID";
        //    param.DbType = DbType.Int32;
        //    param.Value = UserID;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);


        //    // Input param.
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@UserName";
        //    param.DbType = DbType.String;
        //    param.Value = null;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);


        //    // Input param.
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@Solution";
        //    param.DbType = DbType.String;
        //    param.Value = mSolution;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);

        //    try
        //    {
        //        return cmd.ExecuteReader();
        //    }
        //    catch
        //    {
        //        throw;
        //    }


        //}


        //public string GetUserFullName(string sUserName)
        //{

        //    AppSetting BillSet = new AppSetting();
        //    cn = BillSet.GetConnection();
        //    cmd = BillSet.GetCommand();

        //    cmd.CommandText = "dbo.prc_User_Search";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Connection = cn;

        //    IDbDataParameter param = cmd.CreateParameter();

        //    // Input param -> pass Null value           
        //    param.ParameterName = "@UserID";
        //    param.DbType = DbType.Int32;
        //    param.Value = null;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);


        //    // Input param.
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@UserName";
        //    param.DbType = DbType.String;
        //    param.Value = sUserName;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);


        //    // Input param.
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@Solution";
        //    param.DbType = DbType.String;
        //    param.Value = mSolution;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);


        //    try
        //    {
        //        IDataReader datR = cmd.ExecuteReader();
        //        string Fname = null;

        //        while (datR.Read())
        //        {
        //            Fname = datR.GetValue(2).ToString();
        //        }
        //        datR.Close();

        //        return Fname;

        //    }
        //    catch
        //    {
        //        throw;
        //    }


        //}

        //public int GetUserDefaultCompany(string sUserName, int nUserId)
        //{

        //    AppSetting BillSet = new AppSetting();
        //    cn = BillSet.GetConnection();
        //    cmd = BillSet.GetCommand();

        //    cmd.CommandText = "dbo.prc_User_Search";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Connection = cn;

        //    IDbDataParameter param = cmd.CreateParameter();

        //    // Input param -> pass Null value           
        //    param.ParameterName = "@UserID";
        //    param.DbType = DbType.Int32;
        //    param.Value = nUserId;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);


        //    // Input param.
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@UserName";
        //    param.DbType = DbType.String;
        //    param.Value = sUserName;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);


        //    // Input param.
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@Solution";
        //    param.DbType = DbType.String;
        //    param.Value = mSolution;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);


        //    try
        //    {
        //        //IDataReader datR = cmd.ExecuteReader();
        //        SqlDataReader datR = (SqlDataReader)cmd.ExecuteReader(); //(SqlDataReader)oTC.GetTimeCardListReader();
        //        int compId = 0;

        //        while (datR.Read())
        //        {
        //            compId = Convert.ToInt16(datR.GetSqlValue(datR.GetOrdinal("CompanyID")).ToString());
        //        }
        //        datR.Close();

        //        return compId;

        //    }
        //    catch
        //    {
        //        throw;
        //    }


        //}

        //public IDataReader GetDataByUserName(string sUserName)
        //{

        //    AppSetting BillSet = new AppSetting();
        //    cn = BillSet.GetConnection();
        //    cmd = BillSet.GetCommand();

        //    cmd.CommandText = "dbo.prc_User_Search";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Connection = cn;

        //    IDbDataParameter param = cmd.CreateParameter();

        //    // Input param -> pass Null value           
        //    param.ParameterName = "@UserID";
        //    param.DbType = DbType.Int32;
        //    param.Value = null;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);


        //    // Input param.
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@UserName";
        //    param.DbType = DbType.String;
        //    param.Value = sUserName;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);

        //    // Input param.
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@Solution";
        //    param.DbType = DbType.String;
        //    param.Value = mSolution;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);

        //    try
        //    {
        //        return cmd.ExecuteReader();
        //    }
        //    catch
        //    {
        //        throw;
        //    }


        //}


        //public DataSet GetProcessList()
        //{

        //    SqlCommand cmd = new SqlCommand();
        //    AppSetting BillSet = new AppSetting();

        //    cn = BillSet.GetConnection();
        //    //cmd = BillSet.GetCommand();

        //    cmd.CommandText = "dbo.prc_ProcessList";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Connection = (SqlConnection)cn;

        //    IDbDataParameter param = cmd.CreateParameter();

        //    // Input param.            
        //    param.ParameterName = "@Solution";
        //    param.DbType = DbType.String;
        //    param.Value = mSolution;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);

        //    try
        //    {

        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataSet dats = new DataSet();
        //        da.Fill(dats, "ProcessList");
        //        return dats;
        //    }
        //    catch
        //    {
        //        throw;
        //    }

        //}

        //public DataSet GetUserProcessList()
        //{

        //    SqlCommand cmd = new SqlCommand();
        //    AppSetting BillSet = new AppSetting();

        //    cn = BillSet.GetConnection();
        //    //cmd = BillSet.GetCommand();

        //    cmd.CommandText = "dbo.prc_UserProcessList";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Connection = (SqlConnection)cn;

        //    IDbDataParameter param = cmd.CreateParameter();

        //    // Input param.            
        //    param.ParameterName = "@Solution";
        //    param.DbType = DbType.String;
        //    param.Value = mSolution;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);


        //    // Input param 
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@ProcID";
        //    param.DbType = DbType.Int32;
        //    param.Value = mProcessID;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);


        //    // Input param 
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@UserID";
        //    param.DbType = DbType.Int32;
        //    param.Value = mUserID;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);



        //    try
        //    {

        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataSet dats = new DataSet();
        //        da.Fill(dats, "UserProcessList");
        //        return dats;
        //    }
        //    catch
        //    {
        //        throw;
        //    }

        //}


        //public IDataReader GetUserProcessListReader()
        //{

        //    SqlCommand cmd = new SqlCommand();
        //    AppSetting BillSet = new AppSetting();

        //    cn = BillSet.GetConnection();
        //    //cmd = BillSet.GetCommand();

        //    cmd.CommandText = "dbo.prc_UserProcessList";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Connection = (SqlConnection)cn;

        //    IDbDataParameter param = cmd.CreateParameter();

        //    // Input param.            
        //    param.ParameterName = "@Solution";
        //    param.DbType = DbType.String;
        //    param.Value = mSolution;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);


        //    // Input param 
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@ProcID";
        //    param.DbType = DbType.Int32;
        //    param.Value = mProcessID;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);


        //    // Input param 
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@UserID";
        //    param.DbType = DbType.Int32;
        //    param.Value = mUserID;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);

        //    // Input param 
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@UserName";
        //    param.DbType = DbType.String;
        //    param.Value = mUserName;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);


        //    try
        //    {
        //        return cmd.ExecuteReader();
        //    }
        //    catch
        //    {
        //        throw;
        //    }


        //    // Input param.            
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@ProcID";
        //    param.DbType = DbType.Int16;
        //    param.Value = mProcessID;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);


        //    // Input param.            
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@ViewAction";
        //    param.DbType = DbType.Boolean;
        //    param.Value = mViewAction;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);


        //    // Input param.            
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@EntryAction";
        //    param.DbType = DbType.Boolean;
        //    param.Value = mAddAction;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);


        //    // Input param.            
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@EditAction";
        //    param.DbType = DbType.Boolean;
        //    param.Value = mEditAction;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);


        //    // Input param.            
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@ExecuteAction";
        //    param.DbType = DbType.Boolean;
        //    param.Value = mExecuteAction;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);


        //    CommonFunc newFunc = new CommonFunc();
        //    mWho = newFunc.GetXmlUserID();

        //    // Input param.
        //    param = cmd.CreateParameter();
        //    param.ParameterName = "@Who";
        //    param.DbType = DbType.Int16;
        //    param.Value = mWho;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);



        //    //Execute proc
        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch
        //    {
        //        throw;
        //    }


        //}


        //public void DeleteUserProcess()
        //{
        //    AppSetting BillSet = new AppSetting();
        //    cn = BillSet.GetConnection();
        //    cmd = BillSet.GetCommand();

        //    // Establish name of stored proc.
        //    cmd.CommandText = "dbo.prc_UserProcess_Delete";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Connection = cn;


        //    IDbDataParameter param = cmd.CreateParameter();

        //    // Input param.            
        //    param.ParameterName = "@ID";
        //    param.DbType = DbType.Int16;
        //    param.Value = mUserProcessID;
        //    param.Direction = ParameterDirection.Input;
        //    cmd.Parameters.Add(param);


        //    //Execute proc
        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch
        //    {
        //        throw;
        //    }

        //}

        //}

        public int getAttempts()
        {
            openConnection();
            cmd.CommandText = "prc_GetAttempts";

            query("@Name", UserName);

            SqlDataReader dr = cmd.ExecuteReader();
            try
            {
                while (dr.Read())
                {
                   Int32 attempts = Convert.ToInt32(dr.GetSqlValue(0).ToString());
                    return attempts;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
                throw ex;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return 4;
        }


        //http://stackoverflow.com/questions/1756188/how-to-use-sha1-or-md5-in-cwhich-one-is-better-in-performance-and-security-fo

        public static string CalculateSHA1(string text, Encoding enc)
        {
            byte[] buffer = enc.GetBytes(text);
            SHA1CryptoServiceProvider cryptoTransformSHA1 = new SHA1CryptoServiceProvider();
            return BitConverter.ToString(cryptoTransformSHA1.ComputeHash(buffer)).Replace("-", "");
        }

    }
}
