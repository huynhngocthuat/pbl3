using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTL
{
    public class ReportShow
    {
        public int STT { get; set; }
        private int accountId { get; set; }
        [System.ComponentModel.DisplayName("Tên Phòng")]
        public string roomID { get; set; }
        [System.ComponentModel.DisplayName("Ngày Phản Hồi")]
        public DateTime responsedDate { get; set; }
        private int responseType { get; set; }
        [System.ComponentModel.DisplayName("Phản Hồi")]
        public string responseMessage { get; set; }
        [System.ComponentModel.DisplayName("Tên Thiết Bị")]
        public string equipmentName  { get; set; }
        [System.ComponentModel.DisplayName("Trạng Thái")]
        public string equipmentStatus { get; set; }
        [System.ComponentModel.DisplayName("Ghi Chú")]
        public string reportMessage { get; set; }
        [System.ComponentModel.DisplayName("Ngày Báo Cáo")]
        public DateTime reportedDate { get; set; }
        private bool isEdit { get; set; }


        public int getAccountId()
        {
            return accountId;
        }
        public void setAccountId(int accountId)
        {
            this.accountId = accountId;
        }
        public bool getIsEdit()
        {
            return isEdit;
        }
        public void setIsEdit(bool isEdit)
        {
            this.isEdit = isEdit;
        }
        public int getResponseType()
        {
            return responseType;
        }
        public void setResponseType(int resType)
        {
            this.responseType = resType;
        }
    }
}
