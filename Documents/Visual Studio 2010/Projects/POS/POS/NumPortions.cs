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
    public partial class NumPortions : Form
    {
        private int y;
        public NumPortions()
        {
            InitializeComponent();
            CenterToParent();
           
        }

        public int por()
        {
            return y;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            y = Convert.ToInt16(numPrtns.Value);
            this.Close();
        }

        private void btnCncl_Click(object sender, EventArgs e)
        {
            y = 0;
            this.Close();
        }
    }
}
