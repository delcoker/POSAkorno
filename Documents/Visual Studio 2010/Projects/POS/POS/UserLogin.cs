using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace POS
{
    public partial class UserLogin : Form
    {

       
        private int LoginCount;
        private string Solution;

        public cUsers mUser = new cUsers();

        private int mAccessLevel;
        private string mUserName;
        private int mUserID;
        private bool mExpiredPassword = false;
        private int mDaysLeft;
        private string mPassword;

      //  dataOneGen.CommonFunc newFunc = new dataOneGen.CommonFunc();
        CommonFunc newFunc = new CommonFunc();
        /// <summary>
        /// ////////////////////////////////////////0////////////////////////
        /// </summary>

   //     private int UserAccessLevel;
   //     public string LoginUserName;
   //     public string mClient = "";

        String[,] arrUserProcess;
   //     int UserProcessCount = 0;
   //     private string Solution;
    //    private int mUserID;

   //     dataOneGen.Users myUser = new dataOneGen.Users();
   //     dataOneGen.Users sUser = new dataOneGen.Users();


        //public cUsers User
        //{
        //    get { return User; }
        //    set { User = value; }
        //}

        private Process keyboard = null;

        public UserLogin()
        {

            Cursor.Current = Cursors.WaitCursor;

            InitializeComponent();
            CenterToScreen();

            txtCopyRight.Text = "Copyright (c), 2013 de~la Coker" + Environment.NewLine + "All Rights Reserved";

     //       Solution = ConfigurationManager.AppSettings["Solution"];

            //if (Solution.Trim().Length == 0)
            //{
            //    MessageBox.Show("Solution Key Not defined in config file. Please Contact Administrator to ensure Solution Code is defined.");
            //}

            LoadUsers();

            Cursor.Current = Cursors.Default;
            //txtPassword.GotFocus += new EventHandler(startKeyBoard);
            //this.LostFocus += new EventHandler(endKeyBoard);
        }

        private void startKeyBoard(object sender, EventArgs e)
        {
            keyboard = Process.Start("osk.exe");
        }
        private void endKeyBoard(object sender, EventArgs e)
        {
            keyboard.Kill();
        }

        private void LoadUsers()
        {
            DataSet ds = new DataSet();
            cUsers user = new cUsers();

            ds = user.UsersGet();

            cmbUsers.DataSource = ds.Tables[0];
            cmbUsers.ValueMember = "UserID";
            cmbUsers.DisplayMember = "UserName";

            cmbUsers.SelectedIndex = cmbUsers.FindStringExact("Del"); 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (keyboard != null && !keyboard.HasExited)
            {
                keyboard.Kill();
                keyboard.Dispose();
                keyboard = null;
            }

            if (Convert.ToInt16(cmbUsers.SelectedValue) == -1 || txtPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("A valid UserName and Password is required");
                txtPassword.Focus();
                //numCash.Show();
                txtPassword.Select(0, txtPassword.Text.Length);
            }
            else
            {
                //mUserName = cmbUsers.Text;
                mUser.UserName = cmbUsers.Text;
                LoginCount += 1;
                if (LoginCount > 3)
                {
                    EndApp();
                }
                int attempts = mUser.getAttempts();
                if (attempts > 3)
                {
                    EndApp();
                }
                try
                {

                    Cursor.Current = Cursors.WaitCursor;

                    //mUser.UserName = txtUserName.Text.ToString();

                    //if (!mUser.checkUserName())
                    //{
                    //    Cursor.Current = Cursors.Default;
                    //    MessageBox.Show("User name or password invalid.");
                    //    return;
                    //    //EndApp();
                    //}


                    mUser.Password = cUsers.CalculateSHA1( txtPassword.Text.ToString(), Encoding.UTF8);

                    if (!mUser.checkUserPassword())
                    {
                        Cursor.Current = Cursors.Default;
                        MessageBox.Show("User name or password invalid.");
                        txtPassword.Focus();
                        //numCash.Show();
                        txtPassword.Select(0, txtPassword.Text.Length);
                        return;
                        //EndApp();
                    }




                    //mUser.Solution = Solution;
                    //AccessLevel = mUser.GetLoginAccessLevel(txtUserName.Text.ToString(), txtPassword.Text.ToString());
                    //mAccessLevel = AccessLevel;
                    //mUserName = txtUserName.Text.ToString();
                    //mDaysLeft = mUser.DaysToExpire;
                    //mExpiredPassword = mUser.ExpiredPassword;

                    //if (mExpiredPassword == true)
                    //{
                    //    Cursor.Current = Cursors.Default;
                    //    MessageBox.Show("The User's Password provided has expired, please contact System Administrator.");
                    //    EndApp();
                    //}

                    //if (mAccessLevel <= 0)
                    //{
                    //    Cursor.Current = Cursors.Default;
                    //    MessageBox.Show("Invalid User Name and Password, please re-enter login details");
                    //    if (LoginCount == 3)
                    //    {
                    //        EndApp();
                    //    }

                    //}
                    //else
                    //{

                    //    if (mDaysLeft > 0 && mDaysLeft <= 7)
                    //    {
                    //        Cursor.Current = Cursors.Default;
                    //        MessageBox.Show("Password will expire in " + mDaysLeft.ToString() + " days, please ensure you change password before it expires.");

                    //    }

                    //    //mUserID = mUser.UserID;

                    //    //newFunc.UserName = mUserName;
                    //    //newFunc.UserID = mUserID;
                    //    //newFunc.SaveXmlGlobalValues();


                    //    //--------------------------------------
                    //    // Log User Activity
                    //    //--------------------------------------
                    //    //mUser.UserID = mUserID;
                    //    //mUser.Solution = Solution;
                    //    //mUser.ActivityType = 1;
                    //    //mUser.ActivityDesc = "Log unto system";
                    //    //mUser.MachineName = Environment.MachineName.ToString();

                    //    try
                    //    {

                    //        string strHostName = "";
                    //        strHostName = System.Net.Dns.GetHostName();
                    //        IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);
                    //        IPAddress[] addr = ipEntry.AddressList;
                    //        string mhostIP = addr[addr.Length - 1].ToString();

                    //        foreach (IPAddress ip in ipEntry.AddressList)
                    //        {
                    //            Console.WriteLine("    {0}", ip);
                    //        }

                    // //       mUser.IPAddress = newFunc.GetHostIPAddress();
                    //    }
                    //    catch
                    //    {
                    //  //      mUser.IPAddress = "";
                    //    }
                    //    // ---------------------- not uncommented
                    //    //sUser.IPAddress = "";
                    ////    mUser.SaveUserActivity();

                    //    //MessageBox.Show("User Domain Name " + Environment.UserDomainName + " System Username " + System.Net.Dns...GetHostName());

                    Cursor.Current = Cursors.Default;
                    CloseForm();
                    //}

                }
                catch (Exception ex)
                {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show(ex.Message);

                }
            }
        }

        

        private void CloseForm()
        {
            //this.Close();
            this.Cursor = Cursors.Default;
            this.Hide();

        }

        private void EndApp()
        {
            this.Close();
            this.Dispose();
            Application.Exit();

        }


        public int User_AccessLevel
        {
            get { return mAccessLevel; }

        }

        public string UserName
        {
            get { return mUserName; }

        }

        public int UserID
        {
            get { return mUserID; }
        }


        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13 && cmbUsers.Text.Length > 0 && txtPassword.Text.Length > 0)
            {
                btnLogin.PerformClick();
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13 && cmbUsers.Text.Length > 0)
            {
                txtPassword.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mUserName = null;
            mUser.UserName = null;
            this.Close();
            //this.DialogResult = DialogResult.OK;
            //EndApp();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            keyboard = Process.Start("osk.exe");
            txtPassword.Focus();
        }

       
    }
}
