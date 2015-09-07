using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace POS
{
    class cConstr
        {
        private string mConstr;
        private string mServerName;

        public cConstr()
        {
            //To load up console
            //AllocConsole();


            //mConstr = "Data Source=ABRA;Initial Catalog=Akorno;Integrated Security=True";
            //ABRA PC
            //   mConstr = System.IO.File.ReadAllText(@"..\..\conStr.txt");


            string path = "del.del";

            if (!File.Exists(path))
            {
                AllocConsole();

                
                //File.Create(path);
                TextWriter tw = new StreamWriter(path);
                Console.WriteLine("Please key in server name carefully;\n");
                tw.WriteLine(Console.ReadLine());
                tw.Close();

                
            }

            //    HOUSE-PC11111
            mServerName = System.IO.File.ReadAllText(@"del.del");
            mConstr = "Server=" + mServerName + "Database = Akorno; User Id =house-pc; Password =62131121;";

            //mConstr = "Server=" + serverName + "Database = Akorno; User Id =house-pc; Password =62131121;";
            // mConstr = Console.ReadLine();
            //updateConfigFile(mConstr);
            //System.Console.WriteLine("Contents of WriteText.txt = {0}", mConstr);

        }

        public string Constr
        {
            get { return mConstr; }
            set { value = mConstr; }
        }

        public string ServerName
        {
            get { return mServerName; }
            set { value = mServerName; }
        }


        //https://msdn.microsoft.com/en-us/library/ezwyzy7b.aspx
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();



        //http://www.c-sharpcorner.com/UploadFile/1a81c5/configuring-connection-string-in-app-config-file-during-runt/
        public void updateConfigFile(string con)
        {
            //updating config file
            XmlDocument XmlDoc = new XmlDocument();
            //Loading the Config file
            XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement xElement in XmlDoc.DocumentElement)
            {
                if (xElement.Name == "connectionStrings")
                {
                    //setting the coonection string
                    xElement.FirstChild.Attributes[2].Value = con;
                }
            }
            //writing the connection string in config file
            XmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        }
    }
}
