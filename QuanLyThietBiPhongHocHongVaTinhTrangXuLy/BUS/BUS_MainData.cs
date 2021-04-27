using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTL;

namespace BUS
{
    public class BUS_MainData
    {
        ACCOUNT ac = new ACCOUNT();
        private static BUS_MainData _Instance;
        public static BUS_MainData Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BUS_MainData();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        public List<ReportShow> BUS_ReportShow()
        {
            return DAL_MainData.Instance.DAL_ReportShow();
        }
        public List<ZONE> BUS_ZONE()
        {
            return DAL_MainData.Instance.DAL_getZone();
        }
        public List<ROOM> BUS_ROOM()
        {
            return DAL_MainData.Instance.DAL_getRoom();
        }
        public int BUS_Checkaccount(string user, string passwword)
        {           
            ac = DAL_MainData.Instance.DAL_CheckAccount(user, passwword);
            if (ac != null)
            {
                if (ac.role == 1)
                {
                    return 1;
                }
                else if (ac.role == 0) return 0;
            }
            return -1;
        }

        public ACCOUNT BUS_GETACCOUNT()
        {         
            return ac;
        }
        public List<ACCOUNT> BUS_ACCOUNT()
        {
            return DAL_MainData.Instance.DAL_getAccount();
        }

        public void BUS_SETACCOUNT(ACCOUNT ac)
        {
            DAL_MainData.Instance.DAL_SETACCOUNT(ac);
        }    
        public string BUS_Encrypt(string password)
        {
            string MaHoa = "";
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hash = new MD5CryptoServiceProvider().ComputeHash(temp);

            // tạo một stringbuilder thực thi nhanh hơn và ít tốn bộ nhớ hơn cộng chuỗi String
           StringBuilder sb = new StringBuilder();
           for(int i =0; i<hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x"));
            }
            MaHoa = sb.ToString();
            return MaHoa; 
        }
        public void BUS_UPDATEACC(ACCOUNT a2)
        {
            DAL_MainData.Instance.DAL_UPDATEACC(a2);
        }
    }
}
