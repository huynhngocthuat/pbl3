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
        public List<ReportShow> BUS_ReportShow(string zoneId, int check, int date)
        {
            // zoneId -> "A",......
            // check -> 1: All, 2: Chua, 3: Roi  
            // date -> 0: Bao cach day 15 ngay,.....
            
            List<ReportShow> list1 = new List<ReportShow>();
            List<ReportShow> list2 = new List<ReportShow>();
            List<ReportShow> list3 = new List<ReportShow>();
            List<int> listReportId = new List<int>();
            // loc theo cbbZone
            if (zoneId == "")
            {
                list1 = BUS_ReportShow();
            }
            else
            {
                listReportId = DAL_MainData.Instance.listReportIDByZone(zoneId);
                foreach (ReportShow item in BUS_ReportShow())
                {
                    for (int i = 0; i < listReportId.Count(); i++)
                    {
                        if (listReportId[i] == item.STT)
                        {
                            list1.Add(item);
                        }
                    }
                }
            }
            // loc theo checkbox
            if(check == 3)
            {
                foreach (ReportShow item in list1)
                {
                    if (item.responseMessage != null)
                    {
                        list2.Add(item);
                    }
                }
            }
            else if(check == 2)
            {
                foreach (ReportShow item in list1)
                {
                    if (item.responseMessage == null)
                    {
                        list2.Add(item);
                    }
                }
            }
            else
            {
                list2 = list1;
            }
            // loc theo ngay
            switch (date)
            {
                case 0:
                    foreach (ReportShow item in list2)
                    {
                        if((DateTime.Now - item.reportedDate).TotalDays < 15)
                        {
                            list3.Add(item);
                        }
                    }
                    break;
                case 1:
                    foreach (ReportShow item in list2)
                    {
                        if ((DateTime.Now - item.reportedDate).TotalDays < 30)
                        {
                            list3.Add(item);
                        }
                    }
                    break;
                case 2:
                    foreach (ReportShow item in list2)
                    {
                        if ((DateTime.Now - item.reportedDate).TotalDays < 60)
                        {
                            list3.Add(item);
                        }
                    }
                    break;
                case 3:
                    foreach (ReportShow item in list2)
                    {
                        if ((DateTime.Now - item.reportedDate).TotalDays < 365)
                        {
                            list3.Add(item);
                        }
                    }
                    break;
                default:
                    list3 = list2;
                    break;
            }
            return list3;
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
        public string getZoneIdByName(string zoneName)
        {
            foreach (ZONE item in BUS_ZONE())
            {
                if (zoneName == item.zoneName)
                {
                    return item.zoneId;
                }
            }
            return "";
        }
    }
}
