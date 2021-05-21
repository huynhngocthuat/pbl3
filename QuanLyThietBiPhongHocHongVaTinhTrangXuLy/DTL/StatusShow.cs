using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTL
{
    public class StatusShow
    {
        [System.ComponentModel.DisplayName("Mã tình trạng")]
        public string statusID { get; set; }
        [System.ComponentModel.DisplayName("Mã thiết bị")]
        public string equipmentID { get; set; }
        [System.ComponentModel.DisplayName("Tình trạng")]
        public string equipmentStatus { get; set; }
    }
}
