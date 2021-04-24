using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTL;

namespace BUS
{
    public class BUS_MainData
    {
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
    }
}
