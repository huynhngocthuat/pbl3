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
        [System.ComponentModel.DisplayName("Mã tài khoản")]
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
        [System.ComponentModel.DisplayName("Họ và tên")]
        public string fullName { get; set; }

        [System.ComponentModel.DisplayName("Khoa")]
        public string faculty { get; set; }

        [System.ComponentModel.DisplayName("Lớp")]
        public string @class { get; set; }

        [System.ComponentModel.DisplayName("Tên đăng nhập")]
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

        public int getaccountID()
        {
            return accountId;
        }
        public void setaccountID(int i)
        {
            accountId = i;
        }
        //public void setpass(string a)
        //{
        //    password = a;
        //}
    }
}
