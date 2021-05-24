using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTL;
using DAL;
namespace BUS
{
    public class BUS_StatusData
    {
        private static BUS_StatusData _Instance;
        public static BUS_StatusData Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BUS_StatusData();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        public List<StatusShow> BUS_StatusShow()
        {
            return DAL_StatusData.Instance.DAL_StatusShow();
        }
        public void BUS_SETSTATUS(STATUS rm)
        {
            DAL_StatusData.Instance.DAL_SetStatus(rm);
        }
        public void BUS_DELETESTATUS(string statusid)
        {
            DAL_StatusData.Instance.DAL_DeleteStatus(statusid);
        }
        public void BUS_UPDATESTATUS(STATUS rm2, string statusid)
        {
            DAL_StatusData.Instance.DAL_UpdateStatus(rm2, statusid);
        }
        public STATUS BUS_getStatusByIDStatus(string statusid)
        {
            foreach (STATUS item in BUS_MainData.Instance.BUS_STATUS())
            {
                if (item.statusId == statusid)
                {
                    return item;
                }
            }
            return null;
        }
        public int BUS_CHECKSTATUS(STATUS st)
        {
            return DAL_StatusData.Instance.DAL_CheckStatus(st);
        }
        public List<StatusShow> BUS_StatusShowForIDEquipment(string equipmentId)
        {
            List<StatusShow> l = new List<StatusShow>();

            foreach (var item in BUS_StatusShow())
            {
                if (item.equipmentID.ToLower().Contains(equipmentId.ToLower()) == true)
                {
                    l.Add(item);
                }
            }
            return l;
        }
    }
}
