using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThietBiPhongHocHongVaTinhTrangXuLy
{
    public partial class FResponse : Form
    {
        private ACCOUNT a = new ACCOUNT();
        private int reportId;
        private string roomId;
        private string equipmentName;
        private string equipmentStatus;
        private string note;
        private string reportDate;

        public FResponse(ACCOUNT ac)
        {
            a = ac;
            InitializeComponent();
            setCbbResponseType();
        }
        public FResponse(ACCOUNT ac, int reportId, string roomId, string equipmentName, string equipmentStatus, string note, string reportDate)
        {
            a = ac;
            InitializeComponent();
            setCbbResponseType();
            this.reportId = reportId;
            this.roomId = roomId.ToString();
            this.equipmentName = equipmentName;
            this.equipmentStatus = equipmentStatus;
            this.note = note;
            this.reportDate = reportDate;
            LoadResponseForm();

        }
        public void LoadResponseForm()
        {
            txbReportId.Text = reportId.ToString();
            txbRoomId.Text = roomId.ToString();
            txbEquipmentName.Text = equipmentName;
            txbEquipmentStatus.Text = equipmentStatus;
            rtbNote.Text = note;
            dtpReportedDate.Value = Convert.ToDateTime(reportDate);
        }
        public void setCbbResponseType()
        {
            cbbResponseType.Text = "Chọn loại phản hồi";
            cbbResponseType.Items.AddRange(new string[]
            {
                "Đã nhận tin",
                "Đã xử lý",
                "Báo cáo sai"
            });
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cbbResponseType.SelectedIndex == -1 || rtbResponseMessage == null)
            {
                MessageBox.Show("Vui lòng chọn loại phản hồi và điền vào lời nhắn phản hồi!");
            }
            else
            {
                RESPONSE response = new RESPONSE();
                response.accountId = a.accountId;
                response.reportId = reportId;
                response.message = rtbResponseMessage.Text;
                response.responseType = cbbResponseType.SelectedIndex + 1;
                response.responsedDate = DateTime.Now;
                BUS_AdminData.Instance.BUS_SetResponse(response);
                MessageBox.Show("Tạo phản hồi thành công!");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbResponseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int responseType = cbbResponseType.SelectedIndex + 1;
            bool isAccepted = BUS_AdminData.Instance.BUS_CheckReportStatus(reportId, responseType);
            int reportStatus = BUS_AdminData.Instance.BUS_GetReportStatusByReportId(reportId);
            if (!isAccepted)
            {
                if (reportStatus == 0)
                {
                    cbbResponseType.SelectedIndex = 0;
                    MessageBox.Show("Tin chưa được nhận, vui lòng nhận tin trước!");
                }
                else if (reportStatus == 1)
                {
                    cbbResponseType.SelectedIndex = 1;
                    MessageBox.Show("Báo cáo đã được nhận!");
                }
                else
                {
                    MessageBox.Show("Lỗi!");
                }
            }
        }
    }
}
