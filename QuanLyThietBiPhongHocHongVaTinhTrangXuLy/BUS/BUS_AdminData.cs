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
            return DAL_AdminData.Instance.DAL_ShowReportList(zoneId, check, date);
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
        public List<int> BUS_GetReportIdList(string zoneId, int check, int indexDate)
        {
            return DAL_AdminData.Instance.DAL_GetReportIdList(zoneId, check, indexDate);
        }
    }
}
