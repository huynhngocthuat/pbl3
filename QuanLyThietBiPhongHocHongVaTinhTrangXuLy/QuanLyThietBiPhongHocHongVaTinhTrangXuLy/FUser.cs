using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;
using DTL;

namespace QuanLyThietBiPhongHocHongVaTinhTrangXuLy
{
    public partial class FUser : Form
    {
        private ACCOUNT ac = new ACCOUNT();
        private string userName { get; set; }
        public FUser(string username)
        {
            this.userName = username;
            InitializeComponent();
            setCbbTime();
            setCbbZone();
            setNameGroupBox();
        }
        #region mapping data 
        public void setCbbZone()
        {
            cbb_Zone.Items.Add("Tất cả");
            cbb_Zone.Text = "Tất cả";
            foreach (var item in BUS_MainData.Instance.BUS_ZONE())
            {
                cbb_Zone.Items.Add(item.zoneName.ToString());
            }
        }
        public void setCbbTime()
        {
            cbb_Time.Text = "Báo cách đây 15 ngày";
            cbb_Time.Items.AddRange(new string[]
            {
                "Báo cách đây 15 ngày",
                "Báo cách đây 30 ngày",
                "Báo cách đây 60 ngày",
                "Báo cách đây 1 năm"
            });
        }
        // lay thong tin sinh vien dang dang nhap
        public void setNameGroupBox()
        {
            foreach (var item in BUS_MainData.Instance.BUS_ACCOUNT())
            {
                if (item.username == userName)
                {
                    groupbox_main.Text = item.fullName + " - " + item.@class;
                }
            }
        }
        public void SetACFormUSER(ACCOUNT a)
        {
            ac = a;
        }
        #endregion
        #region events
        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            FAccount f = new FAccount(ac);
            f.GUI(ac);
            f.ShowDialog();
        }
        public void Show(string zoneId, int check, int indexDate)
        {
            dataGridView_AllData.DataSource = BUS_MainData.Instance.BUS_ReportShow(zoneId, check, indexDate);
            // thiet lap lai so thu tu
            List<ReportShow> list = BUS_MainData.Instance.BUS_ReportShowByAccount(userName);
            for (int i = 0; i < list.Count(); i++)
            {
                list[i].STT = i + 1;
            }
            dataGridView_UserData.DataSource = list;
        }
        private void btnDulieu_Click(object sender, EventArgs e)
        {
            int check = 1;
            int indexDate = 0;
            string zoneId = BUS_MainData.Instance.getZoneIdByName(cbb_Zone.Text);
            if (ckb_ChuaXuLy.Checked == true && ckb_DaXuLy.Checked == false)
            {
                check = 2;
            }
            else if (ckb_ChuaXuLy.Checked == false && ckb_DaXuLy.Checked == true)
            {
                check = 3;
            }
            indexDate = cbb_Time.SelectedIndex;
            Show(zoneId, check, indexDate);
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnTaobaocao_Click(object sender, EventArgs e)
        {
            FReport f = new FReport(userName, -1, "Add");
            f.d += new FReport.Mydel(Show);
            f.ShowDialog();
        }
        #endregion

        private void btn_EditReport_Click(object sender, EventArgs e)
        {
            if(dataGridView_UserData.SelectedRows.Count == 1)
            {
                int STT = Convert.ToInt32(dataGridView_UserData.CurrentRow.Cells["STT"].Value);
                bool isEdit = Convert.ToBoolean(BUS_MainData.Instance.getReportBySTT(STT, userName).isEdit);
                if (isEdit==false)
                {
                    MessageBox.Show("Không được chỉnh sửa :>");
                }
                else
                {
                    FReport f = new FReport(userName, STT, "Edit");
                    f.d += new FReport.Mydel(Show);
                    f.ShowDialog();
                }
            }
            else if(dataGridView_UserData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn một báo cáo để chỉnh sửa :>");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng :>");
            }

        }
    }
}
