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

namespace QuanLyThietBiPhongHocHongVaTinhTrangXuLy
{
    public partial class FReport : Form
    {
        public delegate void Mydel(string zoneId, int check, int indexDate);
        public Mydel d { get; set; }
        private string userName;
        private int STT;
        private string option;
        private int reportId;
        public FReport(string userName, int STT, string option)
        {
            this.userName = userName;
            this.STT = STT;
            this.option = option;
            InitializeComponent();
            setCbbZone();
            setNameGroupBox();
            if(option == "Edit")
            {
                btn_HuyBaoCao.Text = "Thoát";
                btn_XacNhan.Text = "Lưu chỉnh sửa";
                label6.Text = "CHỈNH SỬA BÁO CÁO";
                setDataEdit();
            }
        }

        public void setCbbZone()
        {
            foreach (var item in BUS_MainData.Instance.BUS_ZONE())
            {
                cbbKhu.Items.Add(item.zoneName.ToString());
            }
        }
        public void setNameGroupBox()
        {
            foreach (var item in BUS_MainData.Instance.BUS_ACCOUNT())
            {
                if (item.username == userName)
                {
                    label7.Text = item.fullName + " - " + item.@class;
                }
            }
        }

        public void setDataEdit()
        {
            List<int> listReportId = BUS_MainData.Instance.getListReportId(userName);
            reportId = listReportId[STT - 1];
            foreach (var report in BUS_MainData.Instance.BUS_REPORT())
            {
                if (report.reportId == reportId)
                {
                    cbbKhu.Text = report.ROOM.ZONE.zoneName;
                    cbbPhonghoc.Text = report.roomId;
                    txbGhichu.Text = report.note;
                    foreach (var equipment in report.ROOM.EQUIPMENTs.ToList())
                    {
                        if (report.equipmentId == equipment.equipmentId)
                        {
                            cbbThietbi.Text = equipment.equipmentName;
                            foreach (var status in equipment.STATUS.ToList())
                            {
                                if (report.statusId == status.statusId)
                                {
                                    cbbTinhtrang.Text = status.equipmentStatus;
                                    break;
                                }
                            }
                            break;
                        }
                    }
                    break;
                }
                
            }

        }
        private void btn_HuyBaoCao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbKhu_SelectedIndexChanged(object sender, EventArgs e)
        {
            // clear cac cbb khi chon khu vuc khac
            cbbPhonghoc.Items.Clear();
            cbbPhonghoc.Text = "";
            cbbThietbi.Text = "";
            cbbTinhtrang.Text = "";
            foreach (var room in BUS_MainData.Instance.getRoomByZoneName(cbbKhu.Text))
            {
                cbbPhonghoc.Items.Add(room.roomId);
            }
        }

        private void cbbPhonghoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            // clear cac cbb khi chon phong khac
            cbbThietbi.Items.Clear();
            cbbThietbi.Text = "";
            cbbTinhtrang.Text = "";
            foreach (var equipment in BUS_MainData.Instance.getQuipmentByRoomId(cbbPhonghoc.Text))
            {
                cbbThietbi.Items.Add(equipment.equipmentName);
            }
        }

        private void cbbThietbi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbTinhtrang.Items.Clear();
            cbbTinhtrang.Text = "";
            foreach (var status in BUS_MainData.Instance.getStatusByEquipmentName(cbbThietbi.Text))
            {
                cbbTinhtrang.Items.Add(status.equipmentStatus);
            }
        }
        public int addReport()
        {
            // kiem tra xem report do da ton tai hay chua
            int checkReport = -1;
            foreach (var item in BUS_AdminData.Instance.BUS_ShowReportList("", 3, 5)) // xem trong nhung report chua duoc response
            {
                if (item.equipmentName == cbbThietbi.Text && item.roomID == cbbPhonghoc.Text)
                {
                    checkReport = 1;
                }
            }
            if (cbbPhonghoc.Text == "" || cbbThietbi.Text == "" || cbbTinhtrang.Text == "" || cbbKhu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !!!");
                return 0;
            }
            else if (checkReport == 1)
            {
                MessageBox.Show("Thiết bị bạn chọn đã được báo cáo");
                return 0;
            }
            else
            {
                BUS_MainData.Instance.BUS_AddReport(userName, cbbPhonghoc.Text, cbbThietbi.Text, cbbTinhtrang.Text, txbGhichu.Text);
                return 1;
            }
        }
        public void editReport()
        {
            BUS_MainData.Instance.BUS_EditReport(reportId, cbbPhonghoc.Text, cbbThietbi.Text, cbbTinhtrang.Text, txbGhichu.Text);
        }
        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            int check = 0;
            if(option == "Edit")
            {
                editReport();
                check = 1;
            }
            else
            {
                check = addReport();
            }
            if (check == 1)
            {
                d("", 1, 5);
                this.Dispose();
            }
            //this.Close();
        }
    }
}
