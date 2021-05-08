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
        public string roomID { get; set; }
        public DateTime responsedDate { get; set; }
        private int responseType { get; set; }
        public string responseMessage { get; set; }
        public string equipmentName  { get; set; }
        public string equipmentStatus { get; set; }
        public string reportMessage { get; set; }
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
