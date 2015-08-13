using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POS
{
    class CommonFunc
    {
        private string company;

        public CommonFunc()
        {
            company = "Akorno Catering Ltd.";
        }

        public string Company
        {
            set { company = value; }
            get { return company; }
        }
    }
}
