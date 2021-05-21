using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTL;
namespace DAL
{
    public class DAL_AdminData
    {
        private MVH_10Entities db;
        private static DAL_AdminData _Instance;
        public static DAL_AdminData Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_AdminData();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        private DAL_AdminData()
        {
            db = new MVH_10Entities();
        }
        
        #region GetData
        public List<ZONE> DAL_GetALlZones()
        {
            var zones = from c in db.ZONEs select c;
            return zones.ToList<ZONE>();
        }
        public List<REPORT> DAL_GetALlReports()
        {
            var reports = from c in db.REPORTs select c;
            return reports.ToList<REPORT>();
        }
        public int DAL_GetReportStatusByReportId(int reportId)
        {
            foreach (REPORT report in DAL_GetALlReports())
            {
                if (report.reportId == reportId)
                {
                    return (int)report.reportStatus;
                }
            }
            return -1;
        }
        public List<ReportShow> DAL_ShowAllReports()
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
                             responseType = kq.Type,
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
                newReport.setResponseType(item.responseType);
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

        public List<int> GetReportIdListByZoneId(string zoneId)
        {
            List<REPORT> reportList = new List<REPORT>();
            List<ROOM> z = db.ROOMs.Where(p => p.zoneId == zoneId).ToList();
            foreach (ROOM item in z)
            {
                reportList.AddRange(item.REPORTs.ToList());
            }
            List<int> reportIdList = new List<int>();
            foreach (REPORT item in reportList)
            {
                reportIdList.Add(item.reportId);
            }
            return reportIdList;
        }
        public string DAL_GetZoneIdByZoneName(string zoneName)
        {
            foreach (ZONE item in DAL_GetALlZones())
            {
                if (item.zoneName == zoneName)
                {
                    return item.zoneId;
                }
            }
            return "";
        }
        #endregion

        #region SetData
        public void DAL_SetResponse(RESPONSE response)
        {
            db.RESPONSEs.Add(response);
            db.SaveChanges();
        }
        #endregion

        #region CheckData
        public bool DAL_CheckReportStatus(int reportId, int responseType)
        {
            //reportStatus default = 0: chưa được nhận tin, 1: chưa xử lý, 2: đã xử lý, 3: thông tin sai
            //responseType = 1: đã nhận tin, 2: đã xử lý, 3: thông tin báo cáo sai
            REPORT report = db.REPORTs.Where(p => p.reportId == reportId).Single();

            //nếu report chưa được nhận
            if(report.reportStatus == 0)
            {
                if (responseType == 1) return true; //được phản hồi nhận tin
                else if (responseType == 2) return false; //không được phản hồi đã xử lý khi chưa nhận tin
                else if (responseType == 3) return false; //không được phản hồi báo cáo sai
            }

            //nếu báo cáo đã được nhận, chưa được xử lý
            else if(report.reportStatus == 1)
            {
                if (responseType == 1) return false; //không được phản hồi nhận tin
                else if (responseType == 2) return true; //được phản hồi đã xử lý
                else if (responseType == 3) return true; //được phản hồi rằng báo cáo sai
            }
            return false;
        }

        public bool DAL_CheckIfResolvedReport(int reportId)
        {
            //reportStatus defalt = 0: chưa được nhận tin, 1: chưa xử lý, 2: đã xử lý, 3: thông tin sai
            //responseType = 1: đã nhận tin, 2: đã xử lý, 3: thông tin báo cáo sai
            REPORT report = db.REPORTs.Where(p => p.reportId == reportId).Single();

            //nếu report chưa được nhận
            if (report.reportStatus == 0) return false;

            //nếu báo cáo đã được nhận, chưa được xử lý
            else if (report.reportStatus == 1) return false;

            //nếu báo cáo đã được xử lý
            else if (report.reportStatus == 2) return true;

            //nếu báo cáo đã được phản hồi là sai thông tin
            else if (report.reportStatus == 3) return true;
            return false;
        }
        #endregion
    }
}
