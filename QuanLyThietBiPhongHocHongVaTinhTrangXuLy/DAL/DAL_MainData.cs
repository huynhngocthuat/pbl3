using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTL;
namespace DAL
{
    public class DAL_MainData
    {
        private MVH_10Entities db;
        private static DAL_MainData _Instance;
        public static DAL_MainData Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_MainData();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        private DAL_MainData()
        {
            db = new MVH_10Entities();
        }
        #region data
        public List<REPORT> DAL_getReport()
        {
            var result = from c in db.REPORTs select c;
            return result.ToList<REPORT>();
        }
        public List<RESPONSE> DAL_getResponse()
        {
            var result = from c in db.RESPONSEs select c;
            return result.ToList<RESPONSE>();
        }
        public List<EQUIPMENT> DAL_getEquipment()
        {
            var result = from c in db.EQUIPMENTs select c;
            return result.ToList<EQUIPMENT>();
        }
        public List<ROOM> DAL_getRoom()
        {
            var result = from c in db.ROOMs select c;
            return result.ToList<ROOM>();
        }
        public List<ZONE> DAL_getZone()
        {
            var result = from c in db.ZONEs select c;
            return result.ToList<ZONE>();
        }
        public List<STATUS> DAL_getStatus()
        {
            var result = from c in db.STATUS select c;
            return result.ToList<STATUS>();
        }
        public List<ACCOUNT> DAL_getAccount()
        {
            var result = from c in db.ACCOUNTs select c;
            return result.ToList<ACCOUNT>();
        }
        #endregion
        #region Flogin
        public void DAL_SETACCOUNT(ACCOUNT ac)
        {
            db.ACCOUNTs.Add(ac);
            db.SaveChanges();
        }
        public List<AccountShow> DAL_GetAccountShow()
        {           
            var la = (from c in db.ACCOUNTs select 
                      new AccountShow{
                                       AccountId = c.accountId,
                                       username = c.username, 
                                       Role = c.role.ToString(), 
                                       fullName = c.fullName, 
                                       faculty = c.faculty, 
                                       @class = c. @class 
                      }).ToList();
            return la.ToList<AccountShow>();
        }
        public ACCOUNT DAL_CheckAccount(string user, string password)
        {
            //var result = from c in db.ACCOUNTs where c.username == user && c.password == password select c;

            //Phan biet chu hoa và thường (COLLATE SQL_Latin1_General_CP1_CS_AS)
            var result = new ACCOUNT();
            var query = "Select * from ACCOUNT where username COLLATE SQL_Latin1_General_CP1_CS_AS like @user AND password COLLATE SQL_Latin1_General_CP1_CS_AS like @password ";
            var query1 = "Select * from ACCOUNT where username COLLATE SQL_Latin1_General_CP1_CS_AS like @user";
            if (password == "")
            {
                 return result = db.ACCOUNTs.SqlQuery(query1, new SqlParameter("@user", user), new SqlParameter("@password", password)).SingleOrDefault();
            }
            else
            {  
                return result = db.ACCOUNTs.SqlQuery(query, new SqlParameter("@user", user), new SqlParameter("@password", password)).SingleOrDefault(); 
            }            
        }
        public void DAL_UPDATEACC(ACCOUNT a2)
        {
            var sup = db.ACCOUNTs.Where(p => p.accountId == a2.accountId).FirstOrDefault();
            sup.fullName = a2.fullName;
            sup.faculty = a2.faculty;
            sup.@class = a2.@class;
            sup.password = a2.password;
            sup.role = a2.role;
            db.SaveChanges();
        }


        //public void DAL_DeleteAccount(List<String> lusername)
        //{
        //    foreach(string i in lusername)
        //    {
        //        var sup = db.ACCOUNTs.Where(p => p.username == i).FirstOrDefault();
        //        db.ACCOUNTs.Remove(sup);
        //        db.SaveChanges();
        //    }    
            
        //}
        #endregion

        #region FMain
        //SELECT REPORT.reportId, REPORT.roomId, MAX(RESPONSE.responseType) as 'responseType', responsedDate, MIN(CAST(message AS NVARCHAR(100))) as message, equipmentName, equipmentStatus, CAST(note AS NVARCHAR(100))[note], reportedDate
        //FROM REPORT
        //LEFT JOIN RESPONSE ON RESPONSE.reportId = REPORT.reportId
        //INNER JOIN EQUIPMENT ON EQUIPMENT.equipmentId = REPORT.equipmentId
        //INNER JOIN STATUS ON STATUS.statusId = REPORT.statusId
        //GROUP BY REPORT.reportId, REPORT.roomId, responsedDate, equipmentName, equipmentStatus, CAST(note AS NVARCHAR(100)) , reportedDate
        public List<ReportShow> DAL_ReportShow()
        {
            List<ReportShow> listReportShow = new List<ReportShow>();
            // Lay tat ca cac report
            var l1 = (from report in db.REPORTs
                          join equipment in db.EQUIPMENTs on report.equipmentId equals equipment.equipmentId
                          join status in db.STATUS on report.statusId equals status.statusId
                          join response in db.RESPONSEs on report.reportId equals response.reportId into p
                          from p2 in p.DefaultIfEmpty()
                          select new
                          {
                              reportId = report.reportId,
                              accontId = report.accountId,
                              roomId = report.roomId,
                              responseDate = (p2 == null) ? null : p2.responsedDate,
                              Type = (p2 == null) ? 0 : p2.responseType,
                              message = (p2 == null) ? null : p2.message,
                              equipmentName = equipment.equipmentName,
                              equipmentStatus = status.equipmentStatus,
                              note = report.note,
                              reportDate = report.reportedDate,
                              isEdit = report.isEdit
                          });
            // loc bo cac report bi trung
            var l2 = (from response in db.RESPONSEs
                          group response by response.reportId into g
                          select new
                          {
                              reportID = g.Key,
                              responseID = (from t2 in g select t2.responseType).Max(),
                          });
            var L_END = (from kq in l1
                           join list in l2 on kq.reportId equals list.reportID into p
                           from ps in p.DefaultIfEmpty()
                           where (kq.Type == ps.responseID) || (kq.Type == 0)
                           select new
                           {
                               reportId = kq.reportId,
                               accountId = kq.accontId,
                               roomId = kq.roomId,
                               responseDate = kq.responseDate,
                               responseMassage = kq.message,
                               equipmentName = kq.equipmentName,
                               equipmentStatus = kq.equipmentStatus,
                               reportMessage = kq.note,
                               reportDate = kq.reportDate,
                               isEdit = kq.isEdit
                           }).ToList();
            // Them tung report vao listReportShow
            foreach (var item in L_END)
            {
                ReportShow newReport = new ReportShow();
                newReport.STT = item.reportId;
                newReport.setAccountId(item.accountId);
                newReport.roomID = item.roomId;
                newReport.responsedDate = Convert.ToDateTime(item.responseDate);
                newReport.responseMessage = item.responseMassage;
                newReport.equipmentName = item.equipmentName;
                newReport.equipmentStatus = item.equipmentStatus;
                newReport.reportMessage = item.reportMessage;
                newReport.reportedDate = Convert.ToDateTime(item.reportDate);
                newReport.setIsEdit(Convert.ToBoolean(item.isEdit));
                listReportShow.Add(newReport);
            }
            return listReportShow;
        }
        public List<int> listReportIDByZone(string zoneId)
        {
            List<REPORT> list = new List<REPORT>();
            List<ROOM> z = db.ROOMs.Where(p => p.zoneId == zoneId).ToList();
            foreach (ROOM item in z)
            {
                list.AddRange(item.REPORTs.ToList());
            }
            List<int> listID = new List<int>();
            foreach (REPORT item in list)
            {
                listID.Add(item.reportId);
            }
            return listID;
        }
        #endregion
        #region FReport
        public void DAL_AddReport(int newAccountId, string newRoomId, string newEquimentId, string newStatusId, string newNote)
        {
            //lay maxId
            int maxId = db.REPORTs.Select(p => p.reportId).Max();
            // tao bao cao
            REPORT report = new REPORT()
            {
                reportId = maxId + 1,
                accountId = newAccountId,
                roomId = newRoomId,
                equipmentId = newEquimentId,
                statusId = newStatusId,
                note = newNote,
                reportStatus = 0,
                reportedDate = DateTime.Now,
                isEdit = true
            };
            db.REPORTs.Add(report);
            db.SaveChanges();
        }
        public void DAL_EditReport(int reportId, string newRoomId, string newEquipmentId, string newStatusId, string newNote)
        {
            REPORT report = db.REPORTs.Find(reportId);
            report.roomId = newRoomId;
            report.equipmentId = newEquipmentId;
            report.statusId = newStatusId;
            report.note = newNote;
            report.reportedDate = DateTime.Now;
            db.SaveChanges();
        }
        #endregion

    }
}
