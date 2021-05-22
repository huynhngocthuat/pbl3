using DAL;
using DTL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_AdminData
    {
        ACCOUNT ac = new ACCOUNT();

        private static BUS_AdminData _Instance;

        public static BUS_AdminData Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BUS_AdminData();
                return _Instance;
            }
            private set { _Instance = value; }
        }

        #region GetData
        public List<ZONE> BUS_GetAllZones()
        {
            return DAL_AdminData.Instance.DAL_GetALlZones();
        }

        public List<REPORT> BUS_GetAllReports()
        {
            return DAL_AdminData.Instance.DAL_GetALlReports();
        }
        public string BUS_GetZoneIdByZoneName(string zoneName)
        {
            return DAL_AdminData.Instance.DAL_GetZoneIdByZoneName(zoneName);
        }
        #endregion

        public void BUS_SetResponse(RESPONSE response)
        {
            DAL_AdminData.Instance.DAL_SetResponse(response);
        }

        public List<ReportShow> BUS_ShowAllReports()
        {
            return DAL_AdminData.Instance.DAL_ShowAllReports();
        }
        public List<ReportShow> BUS_ShowReportList(string zoneId, int check, int date)
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
                list1 = BUS_ShowAllReports();
            }
            else
            {
                listReportId = DAL_AdminData.Instance.GetReportIdListByZoneId(zoneId);
                foreach (ReportShow item in BUS_ShowAllReports())
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
            if (check == 3)
            {
                foreach (ReportShow item in list1)
                {
                    if (item.getResponseType() == 0 || item.getResponseType() == 1)
                    {
                        list2.Add(item);
                    }
                }
            }
            else if (check == 2)
            {
                foreach (ReportShow item in list1)
                {
                    if (item.getResponseType() == 2 || item.getResponseType() == 3)
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
                        if ((DateTime.Now - item.reportedDate).TotalDays < 15)
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
            // Thiet lap lai stt
            for (int i = 0; i < list3.Count(); i++)
            {
                list3[i].STT = i + 1;
            }
            return list3;
        }
        public bool BUS_CheckReportStatus(int reportID, int responseType)
        {
            return DAL_AdminData.Instance.DAL_CheckReportStatus(reportID, responseType);
        }
        public bool BUS_CheckIfResolvedReport(int reportID)
        {
            return DAL_AdminData.Instance.DAL_CheckIfResolvedReport(reportID);
        }
        public int BUS_GetReportStatusByReportId(int reportId)
        {
            return DAL_AdminData.Instance.DAL_GetReportStatusByReportId(reportId);
        }
        public List<int> BUS_GetReportIdList()
        {
            List<int> reportIdList = new List<int>();
            foreach (REPORT item in DAL_AdminData.Instance.DAL_GetALlReports())
            {
                reportIdList.Add(item.reportId);
            }
            return reportIdList;
        }
    }
}
