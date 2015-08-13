using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using POS.Properties;


namespace POS
{
    public partial class Sale : Form
    {
        private cUsers loggedUser;
        private int changer = 0;

        public static bool transactionComplete = false;


        private string multiplier = "0";

        //object senderDoubleClcik;
        //EventArgs eDoubleClick = new EventArgs();
        public Sale(cUsers user)
        {
            loggedUser = new cUsers();
            loggedUser = user;




            InitializeComponent();
            CenterToParent();
            LoadDifCtgy();

            //numTot.Tex;

            llblLog.Text = loggedUser.UserName;

            int a = SystemInformation.VerticalScrollBarWidth;

            //lstVwBrkfst.

            //tabCont.Sc

            //lstVwBrkfst.

            // make scrollbar width bigger
            //lstVwBrkfst.get
            //for (int i = 0; i < lstVwBrkfst.Controls.Count; i++)
            //{
            //   Control c = tabCont.Controls[i];
            //}

            //cScrollBar sc = new cScrollBar();
            //ListView ss = sc;
            //sc.OnScroll();



            // Handle the TextChanged to get the text for our search.
           // txtSearch.TextChanged += new EventHandler(txtSearch_TextChanged);

            txtSearch.GotFocus += new EventHandler(RemoveText);
            txtSearch.LostFocus += new EventHandler(AddText);
        }




        private void LoadAll()
        {
            LoadDifferentMealsIntoListView("", lstVwAll, 99);

            //for (int i = 0; i < this.lstVwAll.Controls.Count; i++)
            //{
            //    if (this.lstVwAll.Controls[0].Controls[i].GetType() == typeof(TextBox))
            //    {
            //        TextBox box = this.lstVwAll.Controls[0].Controls[i] as TextBox;
            //        box.Text = "clear";
            //    }


            //}



            //for (int i = 0; i < this.lstVwAll.Controls[0].Controls.Count; i++)
            //{
            //    if (this.lstVwAll.Controls[0].Controls[i].GetType() == typeof(VScrollBar))
            //    {

            //    }


            //}

        }

        private void LoadStaffDiscount()
        {
            LoadStaffDiscountView(listViewStaffDiscount);
        }

        private void LoadSnacks()
        {
            LoadDifferentMealsIntoListView("Snack", lstVwSnck, 99);
        }

        //   uses category type
        private void LoadSingles()
        {
            LoadDifferentMealsIntoListView("Singles", lstVwSngl, 99);
        }

        private void LoadDeluxe()
        {
            LoadDifferentMealsIntoListView(1, lstVwDeluxe);
        }

        private void LoadClassic()
        {
            LoadDifferentMealsIntoListView(2, lstVwClassic);
        }

        private void LoadAmericana()
        {
            LoadDifferentMealsIntoListView(3, lstVwAmericana);
        }

        private void LoadDifferentMealsIntoListView(uint QuantityTypeID, ListView LstVw)
        {
            DataSet ds = new DataSet();
            cMeals meals = new cMeals();

            try
            {
                meals.QuanTypeID = QuantityTypeID;
                ds = meals.specificMealGetByQuantity(QuantityTypeID);

                LstVw.Columns.Add("Name", 250, HorizontalAlignment.Left);
                LstVw.Columns.Add("Price", 100, HorizontalAlignment.Left);
                LstVw.Columns.Add("Quantity Type", 150, HorizontalAlignment.Left);

                // Get the table from the data set
                DataTable dtable = ds.Tables[0];
                // or DataTable dtable = ds.Tables["Meals"];

                // Clear the ListView control
                LstVw.Items.Clear();

                // Location of Large Icon images
                //lstVwBrkfst.LargeImageList = imgLst;

                // Display items in the ListView control
                for (int i = 0; i < dtable.Rows.Count; i++)
                {
                    DataRow drow = dtable.Rows[i];

                    // Only row that have not been deleted
                    if (drow.RowState != DataRowState.Deleted)
                    {
                        // Define the list items
                        ListViewItem lvi = new ListViewItem(drow["Name"].ToString().ToUpper());
                        lvi.SubItems.Add(drow["Price"].ToString());
                        lvi.SubItems.Add(drow["QuanType"].ToString());

                        // Hold the id ---------------
                        lvi.SubItems.Add(drow["MealID"].ToString());
                        lvi.Name = drow["MealID"].ToString();

                        // del add the hasstock here
                        lvi.SubItems.Add(drow["HasStock"].ToString());


                        lvi.ToolTipText = "Select this to choose " + drow["Name"].ToString();

                        //imgLst = new ImageList();
                        //Image j = new Image();
                        //Bitmap image = new Bitmap(drow["Name"].ToString().Trim());
                        //imgLst.Images.Add(Resources.ReferenceEquals());
                        //-----------------------------------------------------



                        // Text representing image
                        lvi.ImageKey = drow["Name"].ToString().Trim() + ".jpg";


                        //if the ImageList does not contain the key set it to the default
                        if (!imgLst.Images.ContainsKey(lvi.ImageKey))
                        {
                            lvi.ImageIndex = 0;

                        }



                        // Add the list items to the ListView
                        LstVw.Items.Add(lvi);

                        //       this.Controls.Add(lstVwBrkfst);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ds.Dispose();
            }

        }

        private void LoadDifferentMealsIntoListView(string Category, ListView LstVw, uint CategoryID)
        {
            DataSet ds = new DataSet();
            cMeals meals = new cMeals();

            try
            {
                meals.CategoryID = CategoryID;
                ds = meals.specificMealGet(Category);

                LstVw.Columns.Add("Name", 250, HorizontalAlignment.Left);
                LstVw.Columns.Add("Price", 100, HorizontalAlignment.Left);
                LstVw.Columns.Add("Quantity Type", 150, HorizontalAlignment.Left);

                // Get the table from the data set
                DataTable dtable = ds.Tables[0];
                // or DataTable dtable = ds.Tables["Meals"];

                // Clear the ListView control
                LstVw.Items.Clear();

                // Location of Large Icon images
                //lstVwBrkfst.LargeImageList = imgLst;

                // Display items in the ListView control
                for (int i = 0; i < dtable.Rows.Count; i++)
                {
                    DataRow drow = dtable.Rows[i];

                    // Only row that have not been deleted
                    if (drow.RowState != DataRowState.Deleted)
                    {

                        // Define the list items
                        ListViewItem lvi = new ListViewItem(drow["Name"].ToString().ToUpper());
                        lvi.SubItems.Add(drow["Price"].ToString());
                        lvi.SubItems.Add(drow["QuanType"].ToString());

                        // Hold the id ---------------
                        lvi.SubItems.Add(drow["MealID"].ToString());
                        lvi.Name = drow["MealID"].ToString();

                        // del add the hasstock here
                        lvi.SubItems.Add(drow["HasStock"].ToString());


                        lvi.ToolTipText = "Select this to choose " + drow["Name"].ToString();

                        //imgLst = new ImageList();
                        //Image j = new Image();
                        //Bitmap image = new Bitmap(drow["Name"].ToString().Trim());
                        //imgLst.Images.Add(Resources.ReferenceEquals());
                        //-----------------------------------------------------



                        // Text representing image
                        lvi.ImageKey = drow["Name"].ToString().Trim() + ".jpg";


                        //if the ImageList does not contain the key set it to the default
                        if (!imgLst.Images.ContainsKey(lvi.ImageKey))
                        {
                            lvi.ImageIndex = 0;

                        }



                        // Add the list items to the ListView
                        LstVw.Items.Add(lvi);

                        //       this.Controls.Add(lstVwBrkfst);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ds.Dispose();
            }

        }

        private void LoadStaffDiscountView(ListView LstVw)
        {
            DataSet ds = new DataSet();
            cMeals meals = new cMeals();

            try
            {
                ds = meals.staffDiscountGet();

                LstVw.Columns.Add("Name", 250, HorizontalAlignment.Left);
                LstVw.Columns.Add("Price", 100, HorizontalAlignment.Left);
                LstVw.Columns.Add("Quantity Type", 150, HorizontalAlignment.Left);

                // Get the table from the data set
                DataTable dtable = ds.Tables[0];
                // or DataTable dtable = ds.Tables["Meals"];

                // Clear the ListView control
                LstVw.Items.Clear();

                // Location of Large Icon images
                //lstVwBrkfst.LargeImageList = imgLst;

                // Display items in the ListView control
                for (int i = 0; i < dtable.Rows.Count; i++)
                {
                    DataRow drow = dtable.Rows[i];

                    // Only row that have not been deleted
                    if (drow.RowState != DataRowState.Deleted)
                    {
                        // Define the list items
                        ListViewItem lvi = new ListViewItem(drow["Name"].ToString().ToUpper());
                        lvi.SubItems.Add(drow["Price"].ToString());
                        lvi.SubItems.Add(drow["QuanType"].ToString());

                        // Hold the id ---------------
                        lvi.SubItems.Add(drow["MealID"].ToString());
                        lvi.Name = drow["MealID"].ToString();

                        // del add the hasstock here
                        lvi.SubItems.Add(drow["HasStock"].ToString());


                        lvi.ToolTipText = "Select this to choose " + drow["Name"].ToString();

                        //imgLst = new ImageList();
                        //Image j = new Image();
                        //Bitmap image = new Bitmap(drow["Name"].ToString().Trim());
                        //imgLst.Images.Add(Resources.ReferenceEquals());
                        //-----------------------------------------------------



                        // Text representing image
                        lvi.ImageKey = drow["Name"].ToString().Trim() + ".jpg";


                        //if the ImageList does not contain the key set it to the default
                        if (!imgLst.Images.ContainsKey(lvi.ImageKey))
                        {
                            lvi.ImageIndex = 0;

                        }



                        // Add the list items to the ListView
                        LstVw.Items.Add(lvi);

                        //       this.Controls.Add(lstVwBrkfst);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ds.Dispose();
            }

        }
        //string[] resourceNames;

        //// Function
        //Boolean ResourceExists(string resourceName)
        //{
        //    if (resourceNames == null)
        //    {
        //        resourceNames =
        //            System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceNames();
        //    }

        //    return resourceNames.Contains(resourceName);
        //}

        private void ringItemsFromListViews(ListView lstVw)
        {
            // Acquire SelectedItems reference.
            var selectedItems = lstVw.SelectedItems;
            if (selectedItems.Count > 0)
            {

                //NumPortions a = new NumPortions();
                //a.ShowDialog();
                //String qty = a.por().ToString();
                //if (a.por() > 0)

                {

                    ListViewItem lvi = new ListViewItem(selectedItems[0].SubItems[0].Text);
                    lvi.SubItems.Add(selectedItems[0].SubItems[1].Text);    // Price

                    int qty = 1;
                    /////////////////get the multiplier////////////////////////
                    if(multiplier.Contains("x") && Convert.ToInt16(multiplier.Substring(0,multiplier.IndexOf("x"))) > 0 ){
                        qty = Convert.ToInt16(multiplier.Substring(0,multiplier.IndexOf("x")));


                        /////// stock check considering multiplier
                        if (!(stockCheck(selectedItems, lstVw, qty)))
                        {
                            return;
                        }
                        /////////////////////////////////////////////////////

                    }





                    /////////////////multiplier///////////////////////////////
                    lvi.SubItems.Add(qty.ToString());    // Portions
                    
                    
                    lvi.SubItems.Add(selectedItems[0].SubItems[2].Text);    // qtytype
                    lvi.SubItems.Add((Convert.ToInt16(lvi.SubItems[2].Text) * Convert.ToDecimal(lvi.SubItems[1].Text)).ToString());    // subtotal 

                    // meal id
                    lvi.SubItems.Add(selectedItems[0].SubItems[3].Text);
                    lvi.Name = selectedItems[0].SubItems[3].Text;

                    // is it part of stock table
                    lvi.SubItems.Add(selectedItems[0].SubItems[4].Text);

                    //if (!selectedItems.Contains(lvi))
                    //{
                    //    lstVwItms.Items.Add(lvi);
                    //}

                    //// ----------------------------// why this doesnt work
                    if (!(lstVwItms.Items.ContainsKey(lvi.SubItems[5].Text)))
                    {
                        lstVwItms.Items.Add(lvi);
                    }
                    //else
                    //{
                    //    lstVwItms_DoubleClick(senderDoubleClcik, eDoubleClick);
                    //}
                    //lstVwItms.Items[0].SubItems[2].Text;
                    //lvi.SubItems[2].Text;
                }
            }
            totalUpdate();
        }

        private void LoadBreakFast()
        {
            LoadDifferentMealsIntoListView("Breakfast", lstVwBrkfst, 99);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadDifCtgy()
        {
            LoadBreakFast();
            LoadClassic();
            LoadAmericana();
            LoadDeluxe();
            LoadSingles();
            LoadSnacks();


            LoadAll();
            LoadStaffDiscount();
        }

        private void btnLstVwChng_Click(object sender, EventArgs e)
        {
            if (changer == 0)
            {
                lstVwBrkfst.View = View.List;
                lstVwDeluxe.View = View.List;
                lstVwClassic.View = View.List;
                lstVwSnck.View = View.List;
                lstVwSngl.View = View.List;
                lstVwAmericana.View = View.List;

                //foreach (Control childControl in tabPane.Controls)
                //{
                //    if (childControl is ListView)
                //    {
                //        ((ListView)childControl).View = View.List;
                //    }
                //}

                btnLstVwChng.Text = "List";
                changer++;
            }
            else if (changer == 1)
            {
                lstVwBrkfst.View = View.LargeIcon;
                lstVwDeluxe.View = View.LargeIcon;
                lstVwClassic.View = View.LargeIcon;
                lstVwSnck.View = View.LargeIcon;
                lstVwSngl.View = View.LargeIcon;
                //lstVwAll.View = View.LargeIcon;
                lstVwAmericana.View = View.LargeIcon;
                //foreach (Control childControl in tabPane.Controls)
                //{
                //    if (childControl is ListView)
                //    {
                //        ((ListView)childControl).View = View.LargeIcon;
                //    }
                //}

                btnLstVwChng.Text = "Large Icon";
                changer++;
            }
            else if (changer == 2)
            {
                lstVwBrkfst.View = View.Details;
                lstVwDeluxe.View = View.Details;
                lstVwClassic.View = View.Details;
                lstVwSnck.View = View.Details;
                lstVwSngl.View = View.Details;
                //lstVwAll.View = View.Details;
                lstVwAmericana.View = View.Details;
                btnLstVwChng.Text = "Details";
                changer++;
            }
            else if (changer == 3)
            {
                lstVwBrkfst.View = View.SmallIcon;
                lstVwDeluxe.View = View.SmallIcon;
                lstVwClassic.View = View.SmallIcon;
                lstVwSnck.View = View.SmallIcon;
                lstVwSngl.View = View.SmallIcon;
                //lstVwAll.View = View.SmallIcon;
                lstVwAmericana.View = View.SmallIcon;
                btnLstVwChng.Text = "Small Icon";
                changer++;
            }
            else if (changer == 4)
            {
                lstVwBrkfst.View = View.Tile;
                lstVwDeluxe.View = View.Tile;
                lstVwClassic.View = View.Tile;
                lstVwSnck.View = View.Tile;
                lstVwSngl.View = View.Tile;
                //lstVwAll.View = View.Tile;
                lstVwAmericana.View = View.Tile;
                btnLstVwChng.Text = "Tile";
                changer = 0;
            }
            //else
            //{
            //    lstVwBrkfst.View = View.;
            //    lstVwDnr.View = View.Tile;
            //    lstVwLnch.View = View.Tile;
            //    lstVwSnck.View = View.Tile;
            //    lstVwSngl.View = View.Tile;
            //    changer++;
            //}
            //     lstVwItms.View = View.Details;

        }

        private void highLightCash()
        {
            numCash.Focus();
            numCash.Select(0, numCash.Text.Length);
        }


        private void totalUpdate()
        {
            // highLightCash();
            decimal total = 0;
            foreach (ListViewItem itm in lstVwItms.Items)
            {
                itm.SubItems[4].Text = (Convert.ToInt16(itm.SubItems[2].Text) * Convert.ToDecimal(itm.SubItems[1].Text)).ToString();
                total += Convert.ToDecimal(itm.SubItems[4].Text);
            }
            try
            {
                // Display text of first item selected.
                numTot.Value = total;

                numCash.Text = total.ToString();
            }
            catch (ArgumentOutOfRangeException exArg)
            {
                //DialogResult decision = MessageBox.Show("Are you sure you want to sell this quantity?", "Confirmation", MessageBoxButtons.YesNo);
                //if (decision == DialogResult.Yes)
                //{
                //    numTot.Maximum = 9999;
                //}
                //else
                //{
                //}

            }

            // calculate change
            calculateChange();
        }

        private void lstVwItms_DoubleClick(object sender, EventArgs e)
        {

            // Acquire SelectedItems 
            var selectedItems = lstVwItms.SelectedItems;
            if (selectedItems.Count > 0)
            {
                NumPortions a = new NumPortions();
                a.ShowDialog();
                String qty = a.por().ToString();
                if (a.por() > 0)
                {
                    ListViewItem lvi = new ListViewItem(selectedItems[0].SubItems[0].Text);
                    lvi.SubItems.Add(selectedItems[0].SubItems[1].Text);    // Price
                    lvi.SubItems.Add(qty);    // Portions
                    lvi.SubItems.Add(selectedItems[0].SubItems[3].Text);    // qtytype
                    lvi.SubItems.Add((Convert.ToInt16(lvi.SubItems[2].Text) * Convert.ToDecimal(lvi.SubItems[1].Text)).ToString());    // subtotal 

                    // Hold the id ---------------
                    lvi.SubItems.Add(selectedItems[0].SubItems[5].Text);
                    lvi.Name = selectedItems[0].SubItems[5].Text;

                    //if (selectedItems[0].SubItems[0].Text == "Staff Discount")
                    //{
                    //    lvi.Name = "Staff Discount";
                    //}

                    // is it part of stock table
                    lvi.SubItems.Add(selectedItems[0].SubItems[6].Text);

                    lstVwItms.Items.Add(lvi);
                    lstVwItms.Items.Remove(selectedItems[0]);

                }
            }

            //totalUpdate();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var selectedItems = lstVwItms.SelectedItems;
            for (; selectedItems.Count > 0; )
            //   if ( selectedItems.Count > 0 )
            {
                lstVwItms.Items.Remove(selectedItems[0]);

            }
            totalUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lstVwItms = lstVwBrkfst;

            MessageBox.Show(this.tabCont.Controls[1].GetType().ToString());

            string path = "";
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
            }



            String picName = Microsoft.VisualBasic.Interaction.InputBox("Enter image name", "Image name");

            try
            {
                if (!imgLst.Images.ContainsKey(path))
                {
                    //string filePath = "";
                    Image img = (Image.FromFile(path));
                    imgLst.Images.Add(picName, img);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btnPrnt_Click(object sender, EventArgs e)
        {

            Sale.transactionComplete = false;

           

            calculateChange();
            if ((txtBChange.Text == "" || Convert.ToDecimal(txtBChange.Text) < 0 || lstVwItms.Items.Count <= 0 || Convert.ToDecimal(numCash.Text) < numTot.Value))
            {
                MessageBox.Show("The change might be <= zero (0)");
                numCash.Focus();
                //numCash.Show();
                numCash.Select(0, numCash.Text.Length);

                return;
            }


            //txtBChange.Text = (Convert.ToDecimal(numCash.Text) - Convert.ToDecimal(numTot.Text)).ToString();

            Print prnt = new Print(lstVwItms, loggedUser, Convert.ToDecimal(numCash.Text), Convert.ToDecimal(txtBChange.Text));
            prnt.ShowDialog();
        }

        private ListView list()
        {
            return lstVwItms;
        }


        private void numCash_ValueChanged(object sender, EventArgs e)
        {
            if (numTot.Text != "")
                calculateChange();

        }

        private void numCash_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void numCash_Enter(object sender, EventArgs e)
        {
            btnPrnt.Focus();
        }

        private void numCash_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnPrnt.Focus();
            }
        }

        private void numCash_Click(object sender, EventArgs e)
        {
            numCash.Focus();
            //numCash.Show();
            numCash.Select(0, numCash.Text.Length);

            //totalUpdate();
        }

        private void itemClickedAgain(ListView lst)
        {
            // Acquire SelectedItems 
            var selectedItems = lst.SelectedItems;
            if (selectedItems.Count > 0 && (lstVwItms.Items.ContainsKey(selectedItems[0].Name)))
            {
                int selectedIntoListViewIndex = lstVwItms.Items.IndexOfKey(selectedItems[0].Name);





                //int a = Convert.ToInt16(lst.Items[selectedIntoListViewIndex].SubItems[0].Text.Trim());

                int qty = (Convert.ToInt16(lstVwItms.Items[selectedIntoListViewIndex].SubItems[2].Text) + 1);






                // using multiplier for number of portions of dish
                if (multiplier.Contains("x") && Convert.ToInt16(multiplier.Substring(0, multiplier.IndexOf("x"))) > 0)
                {
                    qty = Convert.ToInt16(multiplier.Substring(0, multiplier.IndexOf("x")));



                    /////// stock check considering multiplier
                    if (!(stockCheck(selectedItems,lst, qty)))
                    {
                        return;
                    }
                     /////////////////////////////////////////////////////

                }

               

                lstVwItms.Items[selectedIntoListViewIndex].SubItems[2].Text = qty.ToString();


                //lstVwItms.HideSelection = false;
                lstVwItms.Select();
                lstVwItms.Items[selectedIntoListViewIndex].Selected = true;

            }
            //totalUpdate();
            // reset multiplier

        }

        // checks stock of individual listviews and if it's possible to purhase more based on what is in the selected listview
        private bool stockCheck(ListView.SelectedListViewItemCollection selectedItems, ListView lst)
        {
            if (selectedItems.Count == 0)
            {
                return false;
            }
            bool status = true;
            ///////////////////////////////////
            /////inventory////stock////////////

            int mealID = Convert.ToInt32(selectedItems[0].Name);

            bool hasStock = Convert.ToBoolean(selectedItems[0].SubItems[4].Text);

            int qtyLeft = 0;

            DataSet ds = new DataSet();
            cInventory inv = new cInventory();

            inv.MealID = Convert.ToUInt32(mealID);

            ///////////////////////////////// find item in listview and get amount//////////////////////////////////////////////////////
            int qtyInSelectedList = 0;
            // Acquire SelectedItems 
            //var sel = selectedItems.
            var selectedItem = lst.SelectedItems;
            if (selectedItem.Count > 0 && (lstVwItms.Items.ContainsKey(selectedItem[0].Name)))
            {
                int selectedIntoListViewIndex = lstVwItms.Items.IndexOfKey(selectedItem[0].Name);

                //int a = Convert.ToInt16(lst.Items[selectedIntoListViewIndex].SubItems[0].Text.Trim());

                qtyInSelectedList = (Convert.ToInt16(lstVwItms.Items[selectedIntoListViewIndex].SubItems[2].Text));
                //// multiplier
                if (multiplier.Contains("x") && Convert.ToInt16(multiplier.Substring(0, multiplier.IndexOf("x"))) > 0)
                {
                    int qty = Convert.ToInt16(multiplier.Substring(0, multiplier.IndexOf("x")));
                    if (qty < qtyInSelectedList)
                    {
                        (lstVwItms.Items[selectedIntoListViewIndex].SubItems[2].Text) = Convert.ToString(qty);
                        qtyInSelectedList = qty;
                    }

                   // multiplier = "0";
                }
                
                lstVwItms.Items[selectedIntoListViewIndex].Selected = true;

            }

            //lstVwItms.

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // if it's part of the inverntory table
            if (hasStock)
            {

                //try
                //{
                ds = inv.InventoryMealsGet();
                qtyLeft = Convert.ToInt32(ds.Tables[0].Rows[0]["SLeft"].ToString());
                //}
                //catch (Exception ex)
                //{

                //}


                if (!(qtyLeft > 0))
                {
                    MessageBox.Show("This item has " + qtyLeft + " stock in the inventory.\nPelase top up");
                    status = false;
                }
                //else if (qtyLeft == 2)
                //{
                //    MessageBox.Show("You have two more of this item left");
                //    status = true;
                //}
                //else if (qtyLeft == 1)
                //{
                //    MessageBox.Show("You have one more of this item left. Top up soon");
                //    //don't allow more
                //    status = true;
                //}
                else
                {
                    status = true;
                }
                if (qtyLeft - qtyInSelectedList <= 0)
                {
                    MessageBox.Show("You can not purchase more of this product.\nTop up inventory.\n" + qtyLeft+ " left");
                    status = false;
                }
            }
            return status;
        }


        // considers use of numpad ... multiple 
        private bool stockCheck(ListView.SelectedListViewItemCollection selectedItems, ListView lst, int qtyToBuy)
        {
            bool status = true;
            ///////////////////////////////////
            /////inventory////stock////////////

            int mealID = Convert.ToInt32(selectedItems[0].Name);

            bool hasStock = Convert.ToBoolean(selectedItems[0].SubItems[4].Text);

            int qtyLeft = 0;

            DataSet ds = new DataSet();
            cInventory inv = new cInventory();

            inv.MealID = Convert.ToUInt32(mealID);

            ///////////////////////////////// find item in listview and get amount//////////////////////////////////////////////////////
            //int qtyInSelectedList = 0;
            //// Acquire SelectedItems 
            ////var sel = selectedItems.
            //var selectedItem = lst.SelectedItems;
            //if (selectedItem.Count > 0 && (lstVwItms.Items.ContainsKey(selectedItem[0].Name)))
            //{
            //    int selectedIntoListViewIndex = lstVwItms.Items.IndexOfKey(selectedItem[0].Name);

            //    //int a = Convert.ToInt16(lst.Items[selectedIntoListViewIndex].SubItems[0].Text.Trim());

            //    qtyInSelectedList = (Convert.ToInt16(lstVwItms.Items[selectedIntoListViewIndex].SubItems[2].Text));
            //    //// multiplier
            //    //if (multiplier.Contains("x") && Convert.ToInt16(multiplier.Substring(0, multiplier.IndexOf("x"))) > 0)
            //    //{
            //    //    qty = Convert.ToInt16(multiplier.Substring(0, multiplier.IndexOf("x")));
            //    //}

            //    //lstVwItms.Items[selectedIntoListViewIndex].SubItems[2].Text = qty.ToString();


            //    //lstVwItms.HideSelection = false;
            //    lstVwItms.Select();
            //    lstVwItms.Items[selectedIntoListViewIndex].Selected = true;

            //}

            //lstVwItms.

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // if it's part of the inverntory table
            if (hasStock)
            {

                //try
                //{
                ds = inv.InventoryMealsGet();
                qtyLeft = Convert.ToInt32(ds.Tables[0].Rows[0]["SLeft"].ToString());
                //}
                //catch (Exception ex)
                //{

                //}


                if (!(qtyLeft > 0))
                {
                    MessageBox.Show("This item has no stock in the inventory. Pelase top up");
                    status = false;
                }
                //else if (qtyLeft == 2)
                //{
                //    MessageBox.Show("You have two more of this item left");
                //    status = true;
                //}
                //else if (qtyLeft == 1)
                //{
                //    MessageBox.Show("You have one more of this item left. Top up soon");
                //    //don't allow more
                //    status = true;
                //}
                else
                {
                    status = true;
                }
                if (qtyLeft - qtyToBuy < 0)
                {
                    MessageBox.Show("You can not purchase more of this product.\nTop up inventory\n"+ qtyLeft + " left.");
                    status = false;
                }
            }
            return status;
        }

        private void lstVwBrkfst_Click(object sender, EventArgs e)
        {
            var selectedItems = lstVwBrkfst.SelectedItems;

            if (!stockCheck(selectedItems, lstVwBrkfst))
            {
                return;
            }

            if (!(selectedItems.Count > 0 && (lstVwItms.Items.ContainsKey(selectedItems[0].Name))))
            {
                ringItemsFromListViews(lstVwBrkfst);
            }
            else

                itemClickedAgain(lstVwBrkfst);

            afterEveryClickSelection();
            
        }

        private void lstVwLnch_Click(object sender, EventArgs e)
        {
            var selectedItems = lstVwClassic.SelectedItems;
            if (!stockCheck(selectedItems, lstVwClassic))
            {
                return;
            }
            if (!(selectedItems.Count > 0 && (lstVwItms.Items.ContainsKey(selectedItems[0].Name))))
            {
                ringItemsFromListViews(lstVwClassic);
            }
            else

                itemClickedAgain(lstVwClassic);


            afterEveryClickSelection();
        }

        private void listViewStaffDiscount_Click(object sender, EventArgs e)
        {
            var selectedItems = listViewStaffDiscount.SelectedItems;
            if (!stockCheck(selectedItems, listViewStaffDiscount))
            {
                return;
            }
            if (!(selectedItems.Count > 0 && (lstVwItms.Items.ContainsKey(selectedItems[0].Name))))
            {
                ringItemsFromListViews(listViewStaffDiscount);
            }
            else
                itemClickedAgain(listViewStaffDiscount);

            afterEveryClickSelection();
        }

        private void lstVwDnr_Click(object sender, EventArgs e)
        {
            var selectedItems = lstVwDeluxe.SelectedItems;
            if (!stockCheck(selectedItems,lstVwDeluxe))
            {
                return;
            }
            if (!(selectedItems.Count > 0 && (lstVwItms.Items.ContainsKey(selectedItems[0].Name))))
            {
                ringItemsFromListViews(lstVwDeluxe);
            }
            else
                itemClickedAgain(lstVwDeluxe);

            afterEveryClickSelection();
        }

        private void lstVwSngl_Click(object sender, EventArgs e)
        {
            var selectedItems = lstVwSngl.SelectedItems;
            if (!stockCheck(selectedItems,lstVwSngl))
            {
                return;
            }
            if (!(selectedItems.Count > 0 && (lstVwItms.Items.ContainsKey(selectedItems[0].Name))))
            {
                ringItemsFromListViews(lstVwSngl);
            }
            else
                itemClickedAgain(lstVwSngl);

            afterEveryClickSelection();
        }

        private void lstVwSnck_Click(object sender, EventArgs e)
        {
            var selectedItems = lstVwSnck.SelectedItems;


            //if (multiplier.Contains("x") && Convert.ToInt16(multiplier.Substring(0, multiplier.IndexOf("x"))) > 0)
            //{
            //    int qty = Convert.ToInt16(multiplier.Substring(0, multiplier.IndexOf("x")));


            //    /////// stock check considering multiplier
            //    if (!(stockCheck(selectedItems, lstVwSnck, qty)))
            //    {
            //        qty = 0;
            //        return;
            //    }
            //    /////////////////////////////////////////////////////

            //}

            //else 
                if (!stockCheck(selectedItems, lstVwSnck))
            {
                return;
            }
            if (!(selectedItems.Count > 0 && (lstVwItms.Items.ContainsKey(selectedItems[0].Name))))
            {
                ringItemsFromListViews(lstVwSnck);
            }
            else
                itemClickedAgain(lstVwSnck);

            afterEveryClickSelection();
        }

        private void lstVwAll_Click(object sender, EventArgs e)
        {
            var selectedItems = lstVwAll.SelectedItems;
            if (!stockCheck(selectedItems, lstVwAll))
            {
                return;
            }
            if (!(selectedItems.Count > 0 && (lstVwItms.Items.ContainsKey(selectedItems[0].Name))))
            {
                ringItemsFromListViews(lstVwAll);
            }
            else
                itemClickedAgain(lstVwAll);

            afterEveryClickSelection();
        }

        private void lstVwAmericana_Click(object sender, EventArgs e)
        {
            var selectedItems = lstVwAmericana.SelectedItems;
            if (!stockCheck(selectedItems, lstVwAmericana))
            {
                return;
            }
            if (!(selectedItems.Count > 0 && (lstVwItms.Items.ContainsKey(selectedItems[0].Name))))
            {
                ringItemsFromListViews(lstVwAmericana);
            }
            else
                itemClickedAgain(lstVwAmericana);


            afterEveryClickSelection();
        }

        private void calculateChange()
        {
            txtBChange.Text = "0";
            try
            {
                txtBChange.Text = (Convert.ToDecimal(numCash.Text) - Convert.ToDecimal(numTot.Text)).ToString();
            }
            catch (FormatException exF)
            {
                numCash.Text = "0.";
            }
            if (Convert.ToDecimal(numTot.Text) < 0 && Convert.ToDecimal(txtBChange.Text) >= 0)
            {
                numCash.Text = "0.00";
                txtBChange.Text = numCash.Text.ToString();
            }

            highLightCash();
        }

        private void numTot_ValueChanged(object sender, EventArgs e)
        {
            numCash.Enabled = true;
        }





        private void Sale_Activated(object sender, EventArgs e)
        {
            if (transactionComplete)
            {
                lstVwItms.Items.Clear();
                numCash.Text = "0";
            }

            else
                transactionComplete = false;

           // totalUpdate();

            calculateChange();

            if (numTot.Value > 0)
            {
                numCash.Enabled = true;
            }

            //MessageBox.Show(this.tabPgAll.Controls[1].GetType().ToString());

            //MessageBox.Show(this.lstVwAll.Controls.Clear);
        }



       

        private void removeStartingZero()
        {
            if (numCash.Text.StartsWith("0"))
            {
                numCash.Text = numCash.Text.Remove(0, 1);
            }
            //numCash.Text = (Convert.ToDecimal(numCash.Text)).ToString("D2");

            //numCash.Text = String.Format("{0:00}", numCash.Text);

        }


        private void btn1_Click(object sender, EventArgs e)
        {
            multiplier += "1";


            //if (numCash.Focused)
            //{
            //numCash.Text = numCash.Text.Substring(1);
            numCash.Text += 1;

            //if (Convert.ToDecimal(numCash.Text.Substring(numCash.Text.IndexOf("."))) > 1)
            //{
            //    numCash.Text = (Convert.ToDecimal(numCash.Text) * 10).ToString();
            //}



            //calculatorLike();


            ////////////////////////stock check ////////////////////////////////////////////

            //var selectedItems = lstVwBrkfst.SelectedItems;

            //if (!stockCheck(selectedItems))
            //{
            //    return;
            //}

            ///////////////////////////////////////////////////////////////////////////////


            //string a = string.Format("{0:f2}", numCash.Text);

            removeStartingZero();
            calculateChange();
            //}
        }

        private void calculatorLike()
        {
            if (numCash.Text.Contains("."))
            {
                string afterDecimal = numCash.Text.Substring(numCash.Text.IndexOf("."));

                int afterDecimalLength = (numCash.Text.Substring(numCash.Text.IndexOf("."))).Length - 1;

                if (numCash.Text.Substring(numCash.Text.IndexOf(".")).Length > 2)
                {
                    numCash.Text = (Convert.ToDecimal(numCash.Text) * 10).ToString();
                    //numCash.Text = numCash.Text.Substring(0, numCash.Text.Length - 1);
                }
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            // number of items selected
            multiplier += "2";

            //// stock
            //var selectedItems = lstVwBrkfst.SelectedItems;

            //if (!stockCheck(selectedItems))
            //{
            //    return;
            //}

            numCash.Text += 2;
            removeStartingZero();
            calculateChange();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            // number of items selected
            multiplier += "3";

            // cash entry

            numCash.Text += 3;
            removeStartingZero();
            calculateChange();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            // number of items selected
            multiplier += "4";

            // cash entry
            numCash.Text += 4;
            removeStartingZero();
            calculateChange();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            // number of items selected
            multiplier += "5";

            // cash entry
            numCash.Text += 5;
            removeStartingZero();
            calculateChange();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            // number of items selected
            multiplier += "6";

            // cash entry
            numCash.Text += 6;
            removeStartingZero();
            calculateChange();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            // number of items selected
            multiplier += "7";

            // cash entry
            numCash.Text += 7;
            removeStartingZero();
            calculateChange();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            // number of items selected
            multiplier += "8";

            // cash entry
            numCash.Text += 8;
            removeStartingZero();
            calculateChange();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            // number of items selected
            multiplier += "9";

            // cash entry
            numCash.Text += 9;
            removeStartingZero();
            calculateChange();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            // number of items selected
            multiplier += "0";

            // cash entry
            numCash.Text += 0;
            removeStartingZero();
            calculateChange();
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            if (!numCash.Text.Contains("."))
                numCash.Text += ".";
            removeStartingZero();
            calculateChange();
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            numCash.Text = "0";
            calculateChange();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Call FindItemWithText with the contents of the textbox.
            //for (int i = 0; tabCont.SelectedIndex > 0; i++)
            //{
            //tabCont.SelectedTab = tabPgAll;
            //string i = tabCont.SelectedTab.Controls[0].Controls.GetType().ToString();

            //if (tabCont.SelectedTab.Name == tabPgBrkfst.Name)
            //{

            //}

            tabCont.SelectedTab = tabPgAll;

            ListViewItem foundItem = lstVwAll.FindItemWithText(txtSearch.Text, false, 0, true);
            if (foundItem != null)
            {
                lstVwAll.TopItem = foundItem;
            }
        }


        //http://stackoverflow.com/questions/11873378/adding-placeholder-text-to-textbox
        private void RemoveText(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void AddText(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
                txtSearch.Text = "Search...";
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (!(multiplier.Contains("x")))
                multiplier += "x";
        }

        //}



        private void afterEveryClickSelection()
        {
            // reset multiplier
            multiplier = "0";


            lstVwItms.SelectedItems.Clear();
            numCash.Focus();

            totalUpdate();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            var selectedItems = lstVwItms.SelectedItems;
            foreach( ListViewItem itm in selectedItems)
            //if (selectedItems.Count > 0)
            {
                int qty = Convert.ToInt16(itm.SubItems[2].Text);
                qty -= 1;
                itm.SubItems[2].Text = qty.ToString();
                if (qty == 0)
                {
                    lstVwItms.Items.Remove(itm);
                }
            }
            totalUpdate();
        }
    }
}
