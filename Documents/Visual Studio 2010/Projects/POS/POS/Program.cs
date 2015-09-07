using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // switch to this
            Application.Run(new Mainform(new cUsers()));

            ////////////////////////////////////////////










            //////// for debugging
            cUsers del = new cUsers();
            del.UserID = 1;
            del.UserName = "Del";



            //Application.Run(new MealView(del));

            //Application.Run(new Sale(del));

            //Application.Run(new ReportOptions(del));

            //Application.Run(new ItemTracker(del));
        }
    }
}
