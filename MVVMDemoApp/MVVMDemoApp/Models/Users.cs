using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemoApp.Models
{
    public class Users
    {

        #region Properties
        public int UserId { get; set; }
        private string fName;

        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }
        private string lName;

        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }
        private string country;

        public string Country
        {
            get { return  country; }
            set {  country = value; }
        }


        #endregion
    }
}
