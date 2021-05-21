using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTL
{
    public class EquipmentShow
    {
        [System.ComponentModel.DisplayName("Mã thiết bị")]
        public string equipmentID { get; set; }
        [System.ComponentModel.DisplayName("Tên phòng")]
        public string roomID { get; set; }
        [System.ComponentModel.DisplayName("Tên thiết bị")]
        public string equipmentName { get; set; }
        [System.ComponentModel.DisplayName("Ngày lắp đặt")]
        public DateTime dateOfInstallation { get; set; }
        [System.ComponentModel.DisplayName("Hãng sản xuất")]
        public string company { get; set; }
    }
}
