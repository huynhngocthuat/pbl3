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
            DAL_ZoneData.Instance.DAL_SETZONE(zn);
        }
        public void BUS_DELETEZONE(string zoneid)
        {
            DAL_ZoneData.Instance.DAL_DELETEZONE(zoneid);
        }
        public void BUS_UPDATEZONE(ZONE zn2, string zoneid)
        {
            DAL_ZoneData.Instance.DAL_UPDATEZONE(zn2, zoneid);
        }
        public List<ZoneShow> BUS_SortZoneById()
        {
            return DAL_ZoneData.Instance.DAL_SortZoneById();
        }
        public List<ZONE> BUS_SortZoneByName()
        {
            return DAL_ZoneData.Instance.DAL_SortZoneByName();
        }
        public int BUS_CHECKZONE(ZONE zn)
        {
            return DAL_ZoneData.Instance.DAL_CHECKZONE(zn);
        }
        public ZONE BUS_getZoneByIDZone(string zoneid)
        {
            return DAL_ZoneData.Instance.DAL_getZoneByIZone(zoneid);
        }
    }
}
