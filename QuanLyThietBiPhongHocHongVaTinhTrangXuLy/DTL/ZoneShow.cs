using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTL
{
    public class ZoneShow
    {
        [System.ComponentModel.DisplayName("Mã khu")]
        public string zoneID { get; set; }
        [System.ComponentModel.DisplayName("Tên khu")]
        public string zoneName { get; set; }
    }
}
