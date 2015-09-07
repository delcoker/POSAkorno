using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace POS
{
    public partial class Print : Form
    {
        private cUsers loggedUser;
        ListView list = new ListView();

        private string error = "Take a picture with your phone and send this to Del";

        private decimal total = 0;
        private decimal change = 0;
        private int mealID = 0;
        private bool hasStock = false;


        private decimal staffDiscountID = 65;

        public Print(ListView lst, cUsers user, decimal cash, decimal change)
        {
            InitializeComponent();

            CenterToScreen();

            loggedUser = new cUsers();
            loggedUser = user;
            llblLog.Text = loggedUser.UserName;

            dtpDtAdd.Format = DateTimePickerFormat.Custom;
            dtpDtAdd.CustomFormat = "ddd dd MMM yyyy";

            list = lst;

            this.change = change;

            foreach (ListViewItem itm in lst.Items)
            {
                ListViewItem lvi = new ListViewItem(itm.SubItems[0].Text);
                lvi.SubItems.Add(itm.SubItems[1].Text);    // Price
              //  lvi.SubItems.Add(qty);    // Portions
                lvi.SubItems.Add(itm.SubItems[4].Text);    // from previous form it's portions or qty
                lvi.SubItems.Add(itm.SubItems[3].Text);         // add the Type -- deluxe half portion


                lvi.SubItems.Add(itm.SubItems[6].Text);     // is it part of the stock table
                // ----------------------

                //ListViewItem item = new ListViewItem(item);
                lstVwItms.Items.Add(lvi);

                total += Convert.ToDecimal(itm.SubItems[4].Text);
            }

            if (lst.Items.ContainsKey(staffDiscountID.ToString()))
            
                numTotal.Minimum = -20;
            
            else
                numTotal.Minimum = 0;

            numTotal.Value = Convert.ToDecimal(total);
            //total_tbox.Text = String.Format("{0:c}", total);

            numCash.Value = cash;
        }


        private void printReceipt()
        {
            PrintDialog printDialog = new PrintDialog();

            PrintDocument printDocument = new PrintDocument();

            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            
            printDocument.Print();

        }


        private void printReceipt(bool withDialog)
        {
            PrintDialog printDialog = new PrintDialog();

            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument;

            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }


        }

        void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            string fontFamily = "Harrington";

            Font font = new Font("fontFamily", 10);

            Font fontBold = new Font("fontFamily", 10, FontStyle.Bold);

            //int rightPadding = 30;

            int priceAlignment = 20;

            float fontHeight = font.GetHeight();


            Font small = new Font("fontFamily", 8, FontStyle.Bold);

            Font small2 = new Font("fontFamily", 7, FontStyle.Bold);

            int startX = 10;
            int startY = 10;
            int offset = 40;

            int addressSpacing = 3;


            int centreHeading = 30;

            graphic.DrawString("Akorno Services Ltd.", new Font(fontFamily, 15, FontStyle.Bold), new SolidBrush(Color.Black), startX + centreHeading, startY);
            graphic.DrawString("P.O. Box CT9329", fontBold, new SolidBrush(Color.Black), startX + centreHeading + centreHeading, startY * 3 + addressSpacing * 1);
            graphic.DrawString("Cantonments, Accra", fontBold, new SolidBrush(Color.Black), startX + centreHeading + centreHeading / 2, startY * 4 + addressSpacing * 2);
            graphic.DrawString("Phone #: 050 248 0435", fontBold, new SolidBrush(Color.Black), startX + centreHeading + centreHeading / 3, startY = startY * 5 + addressSpacing * 3);

            decimal total = 0;
            //foreach item in the list
            foreach (ListViewItem itm in list.Items)
            {
                string productDescription = itm.SubItems[0].Text;
                string subTotal = itm.SubItems[4].Text;
                string qtyType = itm.SubItems[3].Text.Substring(0,1);

                if (qtyType.StartsWith("n"))
                {
                    qtyType = "";
                }


                string amount = itm.SubItems[2].Text;
                //string productLine = productDescription + subTotal; // + qtyType.Substring(0,3);

                total += Convert.ToDecimal(subTotal);


                graphic.DrawString(amount, font, new SolidBrush(Color.Black), startX, startY + offset);

                graphic.DrawString(qtyType, fontBold, new SolidBrush(Color.Black), startX * 3, startY + offset);

                graphic.DrawString(productDescription, font, new SolidBrush(Color.Black), startX * 5, startY + offset);
                graphic.DrawString(subTotal, font, new SolidBrush(Color.Black), startX * priceAlignment, startY + offset);
                offset += (int)fontHeight + 5;

            }

            graphic.DrawString("_______________________________", font, new SolidBrush(Color.Black), startX, startY + offset);

            offset += 20;
            graphic.DrawString("Total:", fontBold, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(/**String.Format("",**/ total.ToString(), fontBold, new SolidBrush(Color.Black), startX * priceAlignment, startY + offset);

            graphic.DrawString("Cash:", font, new SolidBrush(Color.Black), startX, startY + offset+20);
            graphic.DrawString(/**String.Format("",**/ numCash.Text, font, new SolidBrush(Color.Black), startX * priceAlignment, startY + offset + 20);

            graphic.DrawString("Change:", fontBold, new SolidBrush(Color.Black), startX, startY + offset + 40);
            graphic.DrawString(/**String.Format("",**/ numChange.Text, fontBold, new SolidBrush(Color.Black), startX * priceAlignment, startY + offset + 40);


            graphic.DrawString("_______________________________", font, new SolidBrush(Color.Black), startX, startY + offset + 45);

            graphic.DrawString("Served by:" + loggedUser.UserName, font, new SolidBrush(Color.Black), startX, startY + offset + 60);

            graphic.DrawString(DateTime.Now + "", small, new SolidBrush(Color.Black), startX, startY + offset + 75);

            graphic.DrawString("_______________________________", font, new SolidBrush(Color.Black), startX, startY + offset + 75);
            graphic.DrawString("Receipt design: 0268665232 / delcoker@gmail.com", small2, new SolidBrush(Color.Black), startX, startY + offset + 89);
        }


    
        private void btnPrnt_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            //if (txtBChange.Text == "" || Convert.ToDecimal(txtBChange.Text) < 0)
            //{
            //    MessageBox.Show("The change is below zero (0)");
            //    return;
            //}

            //take out true to print without dialog
            printReceipt();

            

            // after it prints save to database

            // also update the inventory
            //try
            //{
                cSale sale = new cSale(0, loggedUser.UserID, dtpDtAdd.Value.ToString());
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("You have not logged in " + ex.Message);
                
            //    //throw ex;
            //    return;
            //}

            int saleIDLastInseted = 0;
            try
            {
                saleIDLastInseted = Convert.ToInt16(sale.saveSaleRecord());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " could not get last insertedID for sale");

                throw ex;
            }

            




            //last inserted sale id

            foreach (ListViewItem lst in list.Items)
            {
                mealID = Convert.ToInt32(lst.SubItems[5].Text);
                int qty = Convert.ToInt32(lst.SubItems[2].Text);
                
                decimal subtotal = Convert.ToDecimal(lst.SubItems[1].Text) * Convert.ToInt32(lst.SubItems[2].Text);

                cSaleDetail saleDetail = new cSaleDetail(0, saleIDLastInseted, mealID, qty, subtotal, total, dtpDtAdd.Value.ToString());

                //////////////////////////////////////////////////////////////
                // because of staff discount, if total < 0, save 0
                //////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////
                // staff discount logic
                // if total < 0
                // if this is a staff discount, the amount that should be deducted to store a 0 is -4.50 - total devided by number of staff discounts
                //////////////////////////////////////////////////////////////
                if (total < 0)
                {
                    if (saleDetail.MealID == staffDiscountID)
                    {
                        saleDetail.Subtotal = subtotal - total;
                    }
                    saleDetail.Total = 0;
                }

    

                /////////////////////////////////////////////////////////////

                try
                {
                    if (!saleDetail.saveSaleDetailRecord())
                    {
                        MessageBox.Show("Could not save sale detail." + error);
                    }
               
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw ex;
                }


                hasStock = Convert.ToBoolean(lst.SubItems[6].Text);

                if(hasStock)
                {
                    cInventoryDebit inv = new cInventoryDebit(0, Convert.ToUInt32(mealID), Convert.ToUInt32(qty), dtpDtAdd.Value.ToString(), loggedUser.UserID);
                   
                    try
                    {
                        if (!inv.saveRecord())
                        {
                            MessageBox.Show("Could not save to inventory\n" + error);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        throw ex;
                    }
                }
                
            }
            Sale.transactionComplete = true;
            this.Close();

            Cursor.Current = Cursors.Default;

        }

      

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numCash_ValueChanged(object sender, EventArgs e)
        {
            //txtBChange.Text = (Convert.ToDecimal(numCash.Value) - Convert.ToDecimal(total_tbox.Text)).ToString();
            numChange.Value = change;
        }

        private void numCash_KeyDown(object sender, KeyEventArgs e)
        {
            numCash_ValueChanged(sender, e);
        }

        private void numCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            numCash_ValueChanged(sender, e);
        }

    }
}
