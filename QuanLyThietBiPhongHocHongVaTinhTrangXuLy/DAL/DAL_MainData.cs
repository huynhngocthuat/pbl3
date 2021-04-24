﻿using System;
using System.Collections.Generic;
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
                              roomId = report.roomId,
                              responseDate = (p2 == null) ? null : p2.responsedDate,
                              Type = (p2 == null) ? 0 : p2.responseType,
                              message = (p2 == null) ? null : p2.message,
                              equipmentName = equipment.equipmentName,
                              equipmentStatus = status.equipmentStatus,
                              note = report.note,
                              reportDate = report.reportedDate,
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
                               roomId = kq.roomId,
                               responseDate = kq.responseDate,
                               responseMassage = kq.message,
                               equipmentName = kq.equipmentName,
                               equipmentStatus = kq.equipmentStatus,
                               reportMessage = kq.note,
                               reportDate = kq.reportDate
                           }).ToList();
            // Them tung report vao listReportShow
            foreach (var item in L_END)
            {
                listReportShow.Add(new ReportShow
                {
                    STT = item.reportId,
                    roomID = item.roomId,
                    responsedDate = Convert.ToDateTime(item.responseDate),
                    responseMessage = item.responseMassage,
                    equipmentName = item.equipmentName,
                    equipmentStatus = item.equipmentStatus,
                    reportMessage = item.reportMessage,
                    reportedDate = Convert.ToDateTime(item.reportDate)
                });
            }
            return listReportShow;
        }
        
    }
}