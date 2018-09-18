using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_2_Les_3_Northwind_klantenservice
{
    class Customer
    {
        public string _CustomerID { get; set; }
        public string _CompanyName { get; set; }
        public string _ContactName { get; set; }
        public string _City { get; set; }
        public string _Country { get; set; }
        public string _Phone { get; set; }
    }
    class Search
    {
        public string _CustomerID { get; set; }
    }
}
