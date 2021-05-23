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
    public partial class FAdmin : Form
    {
        private ACCOUNT ac = new ACCOUNT();
        public Form CurrentForm;
        public FAdmin()
        {
            InitializeComponent();
            setCbbZone();
            setCbbTime();
        }
        public void SetACFormADMIN(ACCOUNT a)
        {
            ac = a;
            setLbFullName();
        }

        public void setCbbZone()
        {
            cbbZone.Items.Add("Tất cả");
            cbbZone.SelectedIndex = 0;
            foreach (var item in BUS_AdminData.Instance.BUS_GetAllZones())
            {
                cbbZone.Items.Add(item.zoneName.ToString());
            }
        }

        public void setCbbTime()
        {
            cbbReportTime.Text = "Chọn ngày báo cáo";
            cbbReportTime.Items.AddRange(new string[]
            {
                "Báo cách đây 15 ngày",
                "Báo cách đây 30 ngày",
                "Báo cách đây 60 ngày",
                "Báo cách đây 1 năm"
            });
        }

        public void setLbFullName()
        {
            lbFullName.Text = ac.fullName;
        }

        private void btnCreateResponse_Click(object sender, EventArgs e)
        {
            if (dgvReport.SelectedRows.Count == 1)
            {
                DataGridViewRow dataGridViewRow = dgvReport.CurrentRow;
                List<int> reportIdList = BUS_AdminData.Instance.BUS_GetReportIdList();
                int reportId = reportIdList[Convert.ToInt32(dataGridViewRow.Cells["STT"].Value) - 1];
                string roomId = dataGridViewRow.Cells["roomId"].Value.ToString();
                string equipmentName = dataGridViewRow.Cells["equipmentName"].Value.ToString();
                string equipmentStatus = dataGridViewRow.Cells["equipmentStatus"].Value.ToString();
                string note = dataGridViewRow.Cells["reportMessage"].Value.ToString();
                string reportDate = dataGridViewRow.Cells["reportedDate"].Value.ToString();

                int reportStatus = DAL_AdminData.Instance.DAL_GetReportStatusByReportId(reportId);
                bool isDenied = BUS_AdminData.Instance.BUS_CheckIfResolvedReport(reportId);

                if (!isDenied)
                {                   
                    OpenChildForm(new FResponse(ac, reportId, roomId, equipmentName, equipmentStatus, note, reportDate));
                }
                else
                {
                    if (reportStatus == 3) MessageBox.Show("Báo cáo đã được phản hồi là sai!");
                    else if (reportStatus == 2) MessageBox.Show("Báo cáo đã được xử lý!");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn một báo cáo để phản hồi!");
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            //FMain fMain = new FMain();
            //fMain.ShowDialog();
        }

        private void btnManageZone_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FZone());
        }

        private void btnManageRoom_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FRoom(""));
        }

        private void btnManageEquipment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FEquipment());
        }
        private void btn_Account_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FAccountManagement());
        }
        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            FAccount fAccount = new FAccount(ac);
            fAccount.GUI(ac);
            fAccount.ShowDialog();
        }
        private void btnShowData_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = BUS_AdminData.Instance.BUS_ShowAllReports();
            int check = 1;
            int indexDate = 0;
            string zoneId = BUS_AdminData.Instance.BUS_GetZoneIdByZoneName(cbbZone.Text);
            if (ckbNotResolvedYet.Checked == true && ckbResolved.Checked == false)
            {
                check = 3;
            }
            else if (ckbNotResolvedYet.Checked == false && ckbResolved.Checked == true)
            {
                check = 2;
            }
            indexDate = cbbReportTime.SelectedIndex;
            dgvReport.DataSource = BUS_AdminData.Instance.BUS_ShowReportList(zoneId, check, indexDate);
        }

        private void OpenChildForm(Form ChildForm)
        {
            if(CurrentForm != null)
            {
                CurrentForm.Close();
            }
            CurrentForm = ChildForm;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.TopLevel = false;
            ChildForm.Dock = DockStyle.Fill;
            pnDesktop.Controls.Add(ChildForm);
            pnDesktop.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void bttHome_Click(object sender, EventArgs e)
        {
            if(CurrentForm != null)
            CurrentForm.Dispose();           
        }
    }
}