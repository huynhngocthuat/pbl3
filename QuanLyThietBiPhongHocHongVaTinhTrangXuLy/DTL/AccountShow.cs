using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTL
{
    public class AccountShow
    {
        private int accountId;
        public int AccountId
        {
            private get
            {
                return accountId;
            }
            set
            {
                accountId = value;
            }
        }
        public string username { get; set; }
        //private string password { get; set; }
        private string role;
        public string Role { 
            get
            { return role; }

            set {
                if(value == 1.ToString())
                role = "Admin";
                else
                {
                    role = "User";
                }    
            } 
        }
        public string fullName { get; set; }       
        public string faculty { get; set; }
        public string @class { get; set; }
       
        //public int getaccountID()
        //{
        //    return accountId;
        //}
        //public void setaccountID(int i)
        //{
        //    accountId = i;
        //}
        //public void setpass(string a)
        //{
        //    password = a;
        //}
    }
}
