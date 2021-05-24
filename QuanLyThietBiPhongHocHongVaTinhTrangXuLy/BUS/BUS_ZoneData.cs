using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTL;
namespace BUS
{
    public class BUS_ZoneData
    {
        private static BUS_ZoneData _Instance;
        public static BUS_ZoneData Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BUS_ZoneData();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        public List<ZoneShow> BUS_ZoneShow()
        {
            return DAL_ZoneData.Instance.DAL_ZoneShow();
        }
        public void BUS_SETZONE(ZONE zn)
        {
            DAL_ZoneData.Instance.DAL_SetZone(zn);
        }
        public void BUS_DELETEZONE(string zoneid)
        {
            DAL_ZoneData.Instance.DAL_DeleleZone(zoneid);
        }
        public void BUS_UPDATEZONE(ZONE zn2, string zoneid)
        {
            DAL_ZoneData.Instance.DAL_UpdateZone(zn2, zoneid);
        }
        public int BUS_CHECKZONE(ZONE zn)
        {
            return DAL_ZoneData.Instance.DAL_CheckZone(zn);
        }
        public ZONE BUS_getZoneByIDZone(string zoneid)
        {
            foreach (ZONE item in BUS_MainData.Instance.BUS_ZONE())
            {
                if (item.zoneId == zoneid)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
