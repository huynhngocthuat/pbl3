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
            dateEnd.Value = DateTime.Now;
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

        public void setLbFullName()
        {
            lbFullName.Text = ac.fullName;
        }

        private void btnCreateResponse_Click(object sender, EventArgs e)
        {
            if (dgvReport.SelectedRows.Count == 1)
            {
                DataGridViewRow dataGridViewRow = dgvReport.CurrentRow;

                int check = 1;
                string zoneId = BUS_AdminData.Instance.BUS_GetZoneIdByZoneName(cbbZone.Text);
                if (ckbNotResolvedYet.Checked == true && ckbResolved.Checked == false)
                {
                    check = 3;
                }
                else if (ckbNotResolvedYet.Checked == false && ckbResolved.Checked == true)
                {
                    check = 2;
                }
                List<int> reportIdList = BUS_AdminData.Instance.BUS_GetReportIdList(zoneId, check, dateStart.Value, dateEnd.Value);
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
                    FResponse form = new FResponse(ac, reportId, roomId, equipmentName, equipmentStatus,
                        note, reportDate, zoneId, check, dateStart.Value, dateEnd.Value);
                    form.del = new FResponse.MyDel(show);
                    OpenChildForm(form);
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
            OpenChildForm(new FAccountManagement(ac));
        }
        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            FAccount fAccount = new FAccount(ac);
            fAccount.GUI(ac);
            fAccount.updateData += new FAccount.UpdateData(setLbFullName);
            fAccount.ShowDialog();
        }
        public void show(string zoneId, int check, DateTime dateStart, DateTime dateEnd)
        {
            dgvReport.DataSource = BUS_AdminData.Instance.BUS_ShowReportList(zoneId, check, dateStart, dateEnd);
        }
        private void btnShowData_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = BUS_AdminData.Instance.BUS_ShowAllReports();
            int check = 1;
            string zoneId = BUS_AdminData.Instance.BUS_GetZoneIdByZoneName(cbbZone.Text);
            if (ckbNotResolvedYet.Checked == true && ckbResolved.Checked == false)
            {
                check = 3;
            }
            else if (ckbNotResolvedYet.Checked == false && ckbResolved.Checked == true)
            {
                check = 2;
            }
            show(zoneId, check, dateStart.Value, dateEnd.Value);
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