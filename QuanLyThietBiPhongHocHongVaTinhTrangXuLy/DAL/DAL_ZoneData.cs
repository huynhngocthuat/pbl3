using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTL;

namespace DAL
{
    public class DAL_ZoneData
    {
        private MVH_10Entities db;
        private static DAL_ZoneData _Instance;
        public static DAL_ZoneData Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_ZoneData();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        private DAL_ZoneData()
        {
            db = new MVH_10Entities();
        }
        public List<ZoneShow> DAL_ZoneShow()
        {
            List<ZoneShow> listZoneShow = new List<ZoneShow>();
            var l1 = (from zone in db.ZONEs

                      select new
                      {
                          zoneId = zone.zoneId,
                          zoneName = zone.zoneName,
                      });
            foreach (var item in l1)
            {
                listZoneShow.Add(new ZoneShow
                {
                    zoneID = item.zoneId,
                    zoneName = item.zoneName

                });
            }
            return listZoneShow;
        }
        public void DAL_SETZONE(ZONE zn)
        {
            db.ZONEs.Add(zn);
            db.SaveChanges();
        }
        public int DAL_CHECKZONE(ZONE zn)
        {
            int a = 1;
            foreach (var i in db.ZONEs)
            {
                if (i.zoneId == zn.zoneId)
                {
                    a = 0;
                    break;
                }
            }
            return a;
        }
        public void DAL_DELETEZONE(string zoneid)
        {
            ZONE zn = db.ZONEs.Where(p => p.zoneId == zoneid).SingleOrDefault();
            db.ZONEs.Remove(zn);
            db.SaveChanges();
        }
        public void DAL_UPDATEZONE(ZONE zn2, string zoneid)
        {
            var sup = db.ZONEs.Where(p => p.zoneId == zoneid).SingleOrDefault();
            sup.zoneId = zn2.zoneId;
            sup.zoneName = zn2.zoneName;
            db.SaveChanges();
        }
        public List<ZoneShow> DAL_SortZoneById()
        {
            List<ZoneShow> oldZoneList = DAL_ZoneData.Instance.DAL_ZoneShow();
            List<ZoneShow> newZoneList = new List<ZoneShow>();
            newZoneList = oldZoneList.OrderBy(z => z.zoneID).ToList();
            return newZoneList;
        }
        public List<ZONE> DAL_SortZoneByName()
        {
            List<ZONE> oldZoneList = DAL_MainData.Instance.DAL_getZone();
            List<ZONE> newZoneList = new List<ZONE>();
            newZoneList = oldZoneList.OrderBy(z => z.zoneName).ToList();
            return newZoneList;
        }
        public ZONE DAL_getZoneByIZone(string zoneid)
        {
            ZONE sup = db.ZONEs.Where(p => p.zoneId == zoneid).SingleOrDefault();
            return sup;
        }
    }
}
