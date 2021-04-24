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
        public string roomID { get; set; }
        public DateTime responsedDate { get; set; }
        public string responseMessage { get; set; }
        public string equipmentName  { get; set; }
        public string equipmentStatus { get; set; }
        public string reportMessage { get; set; }
        public DateTime reportedDate { get; set; }
    }
}
