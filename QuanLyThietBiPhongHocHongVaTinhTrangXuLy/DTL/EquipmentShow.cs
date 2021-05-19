using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTL
{
    public class EquipmentShow
    {
        [System.ComponentModel.DisplayName("ID Thiết Bị")]
        public string equipmentID { get; set; }
        [System.ComponentModel.DisplayName("Tên Phòng")]
        public string roomID { get; set; }
        [System.ComponentModel.DisplayName("Tên Thiết Bị")]
        public string equipmentName { get; set; }
        [System.ComponentModel.DisplayName("Ngày Sản Xuất")]
        public DateTime dateOfInstallation { get; set; }
        [System.ComponentModel.DisplayName("Hãng Sản Xuất")]
        public string company { get; set; }
    }
}
