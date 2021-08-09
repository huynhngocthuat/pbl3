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
        #region data
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
        public List<ACCOUNT> BUS_ACCOUNT()
        {
            return DAL_MainData.Instance.DAL_getAccount();
        }
        public List<EQUIPMENT> BUS_EQUIPMENT()
        {
            return DAL_MainData.Instance.DAL_getEquipment();
        }
        public List<STATUS> BUS_STATUS()
        {
            return DAL_MainData.Instance.DAL_getStatus();
        }
        public List<REPORT> BUS_REPORT()
        {
            return DAL_MainData.Instance.DAL_getReport();
        }
        #endregion
        #region FLogin Lê Quốc Huy
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
            for (int i = 0; i < hash.Length; i++)
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

        public List<AccountShow> BUS_AccountShow()
        {
            #region cach1
            /* List<AccountShow> accs = new List<AccountShow>();

            List<ACCOUNT> ac = BUS_ACCOUNT();
            foreach (var item in ac)
            {
                AccountShow a = new AccountShow();
                //a.setaccountID(item.accountId);
                a.fullName = item.fullName;
                a.@class = item.@class;
                a.faculty = item.faculty;
                //a.setpass(item.password);
                a.username = item.username;
                //if (item.role == 1)
                //{ a.role = "Admin"; }
                //else { a.role = "User"; }
                accs.Add(a);
            }
            return accs.ToList();
            */
            #endregion 

            return DAL_MainData.Instance.DAL_GetAccountShow();
        }
        #region deleteAccountBUS
        /*public void BUS_DeleteAccount(List<String> lusername)
        {
            DAL_MainData.Instance.DAL_DeleteAccount(lusername);
        }*/
        #endregion
        public List<AccountShow> BUS_Search(string fullname)
        {
            List<AccountShow> l = new List<AccountShow>();
          
            foreach(var item in BUS_AccountShow())
            {
                if(item.fullName.ToLower().Contains(fullname.ToLower()) == true)
                {
                    l.Add(item);
                }    
            }    
            return l;
        }
        public List<AccountShow> BUS_Sort(string cbbitem)
        {
            string item = cbbitem;
            switch (item)
            {
                case "Họ và tên":
                    {
                        return BUS_AccountShow().OrderBy(o => o.fullName).ToList();                       
                    }
                case "Khoa":
                    {
                        return BUS_AccountShow().OrderBy(o => o.faculty).ToList();                       
                    }
                case "Lớp":
                    {
                        return BUS_AccountShow().OrderBy(o => o.@class).ToList();                       
                    }
                case "Username":
                    {
                        return BUS_AccountShow().OrderBy(o => o.username).ToList();                      
                    }
                case "Role":
                    {
                        return BUS_AccountShow().OrderBy(o => o.Role).ToList();                        
                    }
                default:
                    {
                        return BUS_AccountShow();
                    }
            }
        }
        #endregion

        #region FMain Huỳnh Ngọc Thuật
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

        // lay danh sach report theo Khu, Da Xu Ly?, Ngay
        //BUS_MainData.Instance.BUS_ReportShow("",1,5)
        public List<ReportShow> BUS_ReportShow(string zoneId, int check, DateTime timeStart, DateTime timeEnd)
        {
            // zoneId -> "A",......
            // check -> 1: All, 2: Chua, 3: Roi  
            
            
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
            foreach(ReportShow item in list2)
            {
                if(item.reportedDate <= timeEnd.AddDays(1) && item.reportedDate > timeStart)
                {
                    list3.Add(item);
                }
            }
            //Thiet lap lai stt
            for (int i = 0; i < list3.Count(); i++)
            {
                list3[i].STT = i + 1;
            }
            return list3;
        }
        #endregion

        #region FUser Huynh Ngoc Thuat
        // lay danh sach bao cao cua mot user
        public List<ReportShow> BUS_ReportShowByAccount(string userName, int indexDate)
        {
            // date -> 0: Bao cach day 15 ngay,.....
            List<ReportShow> list1 = new List<ReportShow>();
            List<ReportShow> list2 = new List<ReportShow>();
            int accountId = 0;
            // lay accountId bang username
            foreach (var item in BUS_ACCOUNT())
            {
                if (item.username == userName)
                {
                    accountId = item.accountId;
                }
            }
            // loc danh sach theo accountId
            foreach (ReportShow item in BUS_ReportShow())
            {
                if (item.getAccountId() == accountId)
                {
                    list1.Add(item);
                }
            }
            //loc danh sach theo ngay
            switch (indexDate)
            {
                case 0:
                    foreach (ReportShow item in list1)
                    {
                        if ((DateTime.Now - item.reportedDate).TotalDays < 15)
                        {
                            list2.Add(item);
                        }
                    }
                    break;
                case 1:
                    foreach (ReportShow item in list1)
                    {
                        if ((DateTime.Now - item.reportedDate).TotalDays < 30)
                        {
                            list2.Add(item);
                        }
                    }
                    break;
                case 2:
                    foreach (ReportShow item in list1)
                    {
                        if ((DateTime.Now - item.reportedDate).TotalDays < 60)
                        {
                            list2.Add(item);
                        }
                    }
                    break;
                case 3:
                    foreach (ReportShow item in list1)
                    {
                        if ((DateTime.Now - item.reportedDate).TotalDays < 365)
                        {
                            list2.Add(item);
                        }
                    }
                    break;
                default:
                    list2 = list1;
                    break;
            }
            return list2;
        }
        public REPORT getReportBySTT(int STT, string userName, int indexDate)
        {
            int reportId = BUS_MainData.Instance.getListReportId(userName, indexDate)[STT - 1];
            foreach (REPORT item in BUS_REPORT())
            {
                if (item.reportId == reportId)
                {
                    return item;
                }
            }
            return null;
        }
        #endregion
        #region FReport Huỳnh Ngọc Thuật
        public List<int> getListReportId(string userName, int indexDate)
        {
            List<int> list = new List<int>();
            foreach (var item in BUS_ReportShowByAccount(userName, indexDate))
            {
                list.Add(item.STT);
            }
            return list;
        }

        // lay list phong theo ten khu
        public List<ROOM> getRoomByZoneName(string zoneName)
        {
            foreach (ZONE item in BUS_ZONE())
            {
                if (item.zoneName == zoneName)
                {
                    return item.ROOMs.OrderBy(o => o.roomId).ToList<ROOM>();
                }
            }
            return null;
        }

        // lay list thiet bi theo phong
        public List<EQUIPMENT> getQuipmentByRoomId(string roomId)
        {
            foreach (ROOM item in BUS_ROOM())
            {
                if (item.roomId == roomId)
                {
                    return item.EQUIPMENTs.OrderBy(o => o.equipmentName).ToList<EQUIPMENT>();
                }
            }
            return null;
        }

        // lay list tinh trang theo thiet bi
        public List<STATUS> getStatusByEquipmentName(string equipmentName)
        {
            foreach (EQUIPMENT item in BUS_EQUIPMENT())
            {
                if (item.equipmentName == equipmentName)
                {
                    return item.STATUS.OrderBy(o => o.equipmentStatus).ToList<STATUS>();
                }
            }
            return null;
        }

        // tao mot report moi
        public void BUS_AddReport(string userName, string newRoomId, string equipmentName, string equipmentStatus, string newNote)
        {
            //int newAccountId, string newRoomId, string newEquimentId, string newStatusId, string newNote
            int newAccountId = 0;
            string newEquipmentId = null;
            string newStatusId = null;
            foreach (ACCOUNT item in BUS_ACCOUNT())
            {
                if (item.username == userName)
                {
                    newAccountId = item.accountId;
                }
            }
            // search equipmentId, equipmentStatus
            foreach (ROOM item in BUS_ROOM())
            {
                if (item.roomId == newRoomId)
                {
                    foreach (EQUIPMENT item1 in item.EQUIPMENTs.ToList<EQUIPMENT>())
                    {
                        if (item1.equipmentName == equipmentName)
                        {
                            newEquipmentId = item1.equipmentId;
                            foreach (STATUS item2 in item1.STATUS.ToList<STATUS>())
                            {
                                if (item2.equipmentStatus == equipmentStatus)
                                {
                                    newStatusId = item2.statusId;
                                    break;
                                }
                            }
                            break;
                        }
                    }
                    break;
                }
            }
            DAL_MainData.Instance.DAL_AddReport(newAccountId, newRoomId, newEquipmentId, newStatusId, newNote);
        }
        public void BUS_EditReport(int reportId, string newRoomId, string equipmentName, string equipmentStatus, string newNote)
        {
            string newEquipmentId = null;
            string newStatusId = null;
            // search equipmentId, equipmentStatus
            foreach (ROOM item in BUS_ROOM())
            {
                if (item.roomId == newRoomId)
                {
                    foreach (EQUIPMENT item1 in item.EQUIPMENTs.ToList<EQUIPMENT>())
                    {
                        if (item1.equipmentName == equipmentName)
                        {
                            newEquipmentId = item1.equipmentId;
                            foreach (STATUS item2 in item1.STATUS.ToList<STATUS>())
                            {
                                if (item2.equipmentStatus == equipmentStatus)
                                {
                                    newStatusId = item2.statusId;
                                    break;
                                }
                            }
                            break;
                        }
                    }
                    break;
                }
            }
            DAL_MainData.Instance.DAL_EditReport(reportId, newRoomId, newEquipmentId, newStatusId, newNote);
        }
        #endregion

    }
}
