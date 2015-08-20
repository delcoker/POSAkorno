using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS
{
    public partial class Mainform : Form
    {
        private cUsers loggedUser;
        public Mainform(cUsers user)
        {
            Cursor.Current = Cursors.WaitCursor;
            CommonFunc cmm = new CommonFunc();

           

            InitializeComponent();

            toolStripStatusLabelCompany.Text = cmm.Company;
     //       toolStripStatusLabelUser.Text = new UserLogin(;
            toolStripStatusLabelDate.Text = /*DateTime.Today.DayOfWeek.ToString() + ", " + */ DateTime.Today.ToLongDateString()  + "  " + DateTime.Now.ToShortTimeString();

            //UserAccessLevel = 3;

            //this.WindowState = FormWindowState.Maximized;

            tooltips();

            try
            {
                //Solution = ConfigurationManager.AppSettings["Solution"];
                //mClient = ConfigurationManager.AppSettings["ClientInfo"];
                //toolStripStatusLabelClientData.Text = mClient;

                //if (Solution.Trim().Length == 0)
                //{
                //    MessageBox.Show("Solution Key Not defined in config file. Please Contact Administrator to ensure Solution Code is defined.");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading Solution/ClientInfo data from config file." + Environment.NewLine + ex.Message);
            }

            Cursor.Current = Cursors.Default;

            bool status = loginSuccess();
            if (!status)
            {
                loggedUser = null;
                return;
            }
            loadUserDetails(status);
            
            CenterToScreen();
            
           

            this.Refresh();
        }

        private void tooltips()
        {
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            //toolTip1.AutoPopDelay = 1000;
            //toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.btnSale, "Sell on of our delicious dishes");
            toolTip1.SetToolTip(this.btnRprt, "Get a report on activities regarding this POS");
            toolTip1.SetToolTip(this.btnMeals, "Add / Edit / View dishes");
            toolTip1.SetToolTip(this.btnInv, "Credit or Debit items in stock");
            toolTip1.SetToolTip(this.btnLg, "Login or Logout");
            toolTip1.SetToolTip(this.btnExt, "Exit");
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {  if (!loggedIn())
            {
                return;
            }
            if (!loggedUser.access(Convert.ToInt16(addToolStripMenuItem.Tag)))
            {
                return;
            }
            CategoryAdd catA = new CategoryAdd(loggedUser);
          
            catA.ShowDialog();
        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {if (!loggedIn())
            {
                return;
            }
            if (!loggedUser.access(Convert.ToInt16(addToolStripMenuItem1.Tag)))
            {
                return;
            }
            QuanTypeAdd qtyA = new QuanTypeAdd(loggedUser);
            
            qtyA.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnExt_Click(sender, e);
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {if (!loggedIn())
            {
                //qtyV.Dispose();
                return;
            }
            if (!loggedUser.access(Convert.ToInt16(viewToolStripMenuItem.Tag)))
            {
                return;
            }
            QuanTypeView qtyV = new QuanTypeView(loggedUser);
            
            qtyV.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {if (!loggedIn())
            {
                return;
            }
            if (!loggedUser.access(Convert.ToInt16(deleteToolStripMenuItem.Tag)))
            {
                return;
            }
            
            CategoryView catV = new CategoryView(loggedUser);
            
            catV.ShowDialog();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (!loggedIn())
            {
                return;
            }
            if (!loggedUser.access(Convert.ToInt16(addToolStripMenuItem2.Tag)))
            {
                return;
            }


            MealAdd add = new MealAdd(loggedUser);
            
            add.ShowDialog();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {if (!loggedIn())
            {
                return;
            }
            if (!loggedUser.access(Convert.ToInt16(viewToolStripMenuItem1.Tag)))
            {
                return;
            }
            MealView viewMeal = new MealView(loggedUser);
            
            viewMeal.ShowDialog();
        }   

        private void viewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (!loggedIn())
            {
                return;
            }
            if (!loggedUser.access(Convert.ToInt16(viewToolStripMenuItem2.Tag)))
            {
                return;
            }
            PermissionView p = new PermissionView();
            
            p.ShowDialog();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            if (!loggedIn())
            {

                return;
            }
            if (!loggedUser.access(Convert.ToInt16(btnSale.Tag)))
            {
                return;
            }
            Sale sell = new Sale(loggedUser);
           
            
            sell.ShowDialog();
        }

        private bool loggedIn()
        {
            bool status = false;
            if (loggedUser == null)
            {
                MessageBox.Show("Please log in first");
                if (loginSuccess())
                {
                    status = true;
                }
                
            }
            else if (!(loggedUser == null))
            {
                status = true; 
            }

            // could not load user details on details username and password provided
            if (!loadUserDetails(status))
            {
                status = false;
                if (!status)
                {
                    MessageBox.Show("Please log in again");
                    if (loginSuccess())
                    {
                        status = true;
                    }
                }
                
            }
            return status;
        }

        private bool loginSuccess()
        {
            bool result = false;

            UserLogin userDetail = new UserLogin();
            
            userDetail.ShowDialog();

            //if (userDetail.UserName != null && userDetail.UserName != "" && userDetail.mUser.checkUserName())
            //{
            //    loggedUser = new cUsers();
            //    loggedUser.UserName = userDetail.UserName;
            //    loggedUser.Password = userDetail.mUser.Password;

            //    result = true;

            //}

            if (userDetail.mUser.UserName != null && userDetail.mUser.UserName != "" && userDetail.mUser.checkUserName())
            {
                loggedUser = new cUsers();
                loggedUser.UserName = userDetail.mUser.UserName;
                loggedUser.Password = userDetail.mUser.Password;

                result = true;

            }

            loadUserDetails(result);

            return result;
        }

        private bool loadUserDetails(bool loadOrNa)
        {
            if (loadOrNa)
            {
                DataSet ds = new DataSet();

                ds = loggedUser.userDetailsGet();
                try
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {

                        loggedUser.UserID = Convert.ToInt16(ds.Tables[0].Rows[0]["UserID"].ToString());
                        loggedUser.PermLevel = Convert.ToInt16(ds.Tables[0].Rows[0]["PermLevel"].ToString());
                        loggedUser.Company = (ds.Tables[0].Rows[0]["Company"].ToString());

                        loggedUser.DeActivate = false;
                        if ((ds.Tables[0].Rows[0]["DeActivate"].ToString()) == "1")
                        {
                            loggedUser.DeActivate = true;
                        }
                        lblLog.Text = loggedUser.UserName;
                        toolStripStatusLabelUser.Text = loggedUser.UserName;
                        return true;
                    }
                    else
                        return false;
                }
                catch (IndexOutOfRangeException outRange)
                {
                    MessageBox.Show("Not Logged In\n" + outRange.ToString() + "\nEntered username and cancelled or db parameter lengths");
                    loggedUser = null;
                    return false;
                    //EndApp();
                }

                

            }
            else
            {
                lblLog.Text = "Not Logged In";
                toolStripStatusLabelUser.Text = "Not Logged In";
                return false;
            }
            
            
        }

        private void EndApp()
        {
            this.Close();
            this.Dispose();
            Application.Exit();
        }

        // view meals
        private void btnMeals_Click(object sender, EventArgs e)
        {
            //int perm = 99;
            
            if (!loggedIn())
            {
                return;
            }
            MealView viewMeal = new MealView(loggedUser);
            //loggedUser.PermLevel;
            viewMeal.ShowDialog();
        }

        private void btnRprt_Click(object sender, EventArgs e)
        {
            if (!loggedIn())
            {
                return;
            }

            //if (!loggedUser.access(Convert.ToInt16(btnRprt.Tag)))
            //{
            //    return;
            //}
            ReportOptions rep = new ReportOptions(loggedUser);
            
            rep.ShowDialog();
        }

        private void btnInv_Click(object sender, EventArgs e)
        {
            if (!loggedIn())
            {
                return;
            }

            //if (!loggedUser.access(Convert.ToInt16(btnInv.Tag)))
            //{
            //    return;
            //}
            InventoryView inv = new InventoryView(loggedUser);
            
            inv.ShowDialog();
        }

        private void addToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (!loggedIn())
            {
                return;
            }
            if (!loggedUser.access(Convert.ToInt16(addToolStripMenuItem4.Tag)))
            {
                return;
            }
            InventoryAdd inv = new InventoryAdd(loggedUser);
            
            inv.ShowDialog();
        }

        private void btnLg_Click(object sender, EventArgs e)
        {
            bool status = loginSuccess();
            if (!status)
            {
                loggedUser = null;
                return;
            }
            loadUserDetails(status);
        }

        private void addToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (!loggedIn())
            {
                return;
            }
            if (!loggedUser.access(Convert.ToInt16(addToolStripMenuItem5.Tag)))
            {
                return;
            }

            UserAdd user = new UserAdd(loggedUser);

            user.ShowDialog();
        }

        private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void viewToolStripMenuItem4_Click(object sender, EventArgs e)
        { 
            if (!loggedIn())
            {
                return;
            }
            if (!loggedUser.access(Convert.ToInt16(viewToolStripMenuItem4.Tag)))
            {
                return;
            }
            
            UserView userVw = new UserView(loggedUser);
           
            userVw.ShowDialog();
        }

        private void addToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (!loggedIn())
            {
                return;
            }
            if (!loggedUser.access(Convert.ToInt16(addToolStripMenuItem3.Tag)))
            {
                return;
            }
        }

        private void viewToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (!loggedIn())
            {
                return;
            }
            if (!loggedUser.access(Convert.ToInt16(viewToolStripMenuItem3.Tag)))
            {
                return;
            }

            InventoryView inv = new InventoryView(loggedUser);
            
            inv.ShowDialog();
        }
    }
}
