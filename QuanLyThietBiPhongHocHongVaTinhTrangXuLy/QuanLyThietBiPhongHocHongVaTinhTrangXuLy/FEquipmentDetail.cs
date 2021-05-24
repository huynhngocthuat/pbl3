using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;
using DTL;
namespace QuanLyThietBiPhongHocHongVaTinhTrangXuLy
{
    public partial class FEquipmentDetail : Form
    {
        public delegate void refreshData(string text);
        public refreshData refresh;
        private string equipmentid;
        private string option;
        private string Text1;
        public FEquipmentDetail(string Text, string equipmentid, string option)
        {
            this.equipmentid = equipmentid;
            this.option = option;
            this.Text1 = Text;
            InitializeComponent();
            if(option == "Edit")
            {
                setEQUIPMENT();
                txtMaThietBi.Enabled = false;
                this.Text = "Chỉnh sửa thiết bị";
            }
            setCbbRoom();
        }
        public void setCbbRoom()
        {
            foreach (var item in BUS_RoomData.Instance.BUS_RoomShow())
            {
                cbbPhongHoc.Items.Add(item.roomID);
            }
        }
        private void setEQUIPMENT()
        {
            EquipmentShow s = new EquipmentShow();
            s = BUS_EquipmentData.Instance.BUS_getEquipmentByIDEquipment(equipmentid);
            txtMaThietBi.Text = s.equipmentID;
            txtTenThietBi.Text = s.equipmentName;
            cbbPhongHoc.Text = s.roomID;
            txtCongTy.Text = s.company;
            dateTimePicker_Ngaydat.Value = s.dateOfInstallation;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (option == "Add")
            {
                EQUIPMENT rm = new EQUIPMENT();
                rm.roomId = cbbPhongHoc.Text;
                rm.company = txtCongTy.Text;
                rm.equipmentId = txtMaThietBi.Text;
                rm.equipmentName = txtTenThietBi.Text;
                rm.dateOfInstallation = dateTimePicker_Ngaydat.Value;
                if (BUS_EquipmentData.Instance.BUS_CHECKEQUIPMENT(rm) == 0)
                {
                    MessageBox.Show("Mã thiết bị đã bị trùng! Vui lòng thay đổi");
                }
                else
                {
                    BUS_EquipmentData.Instance.BUS_SETEQUIPMENT(rm);
                    MessageBox.Show("Thêm thành công!");
                }
            }
            else
            {
                txtMaThietBi.Text = equipmentid;
                EQUIPMENT rm2 = new EQUIPMENT();
                rm2.roomId = cbbPhongHoc.Text;
                rm2.company = txtCongTy.Text;
                rm2.dateOfInstallation = dateTimePicker_Ngaydat.Value;
                rm2.equipmentId = txtMaThietBi.Text;
                rm2.equipmentName = txtTenThietBi.Text;
                BUS_EquipmentData.Instance.BUS_UPDATEEQUIPMENT(rm2, equipmentid);
                MessageBox.Show("Cập nhập thành công!");
            }
            this.Dispose();
            refresh(Text1);
        }

    }
}
