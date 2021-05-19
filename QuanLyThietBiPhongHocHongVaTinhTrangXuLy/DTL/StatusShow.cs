using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTL
{
    public class StatusShow
    {
        [System.ComponentModel.DisplayName("ID Trạng Thái")]
        public string statusID { get; set; }
        [System.ComponentModel.DisplayName("ID Thiết Bị")]
        public string equipmentID { get; set; }
        [System.ComponentModel.DisplayName("Tên Trạng Thái")]
        public string equipmentStatus { get; set; }
    }
}
