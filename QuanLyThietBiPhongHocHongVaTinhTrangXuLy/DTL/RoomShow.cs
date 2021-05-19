using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTL
{
    public class RoomShow
    {
        [System.ComponentModel.DisplayName("Tên Phòng")]
        public string roomID { get; set; }
        [System.ComponentModel.DisplayName("Tên Khu")]
        public string zoneID { get; set; }
        [System.ComponentModel.DisplayName("Chức Năng")]
        public string roomFunciton { get; set; }
    }
}
