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
namespace QuanLyThietBiPhongHocHongVaTinhTrangXuLy
{
    public partial class FZoneEdit : Form
    {
        public delegate void refreshData();
        public refreshData refresh;
        private string zoneid;
        private string option;
        public FZoneEdit(string zoneId, string option)
        {
            this.zoneid = zoneId;
            this.option = option;
            InitializeComponent();
            setZONE();
        }
        private void setZONE()
        {
            if(option == "Edit")
            {
                ZONE s = new ZONE();
                s = BUS_ZoneData.Instance.BUS_getZoneByIDZone(zoneid);
                txtMakhu.Text = s.zoneId;
                txtTenkhu.Text = s.zoneName;
                txtMakhu.Enabled = false;
                this.Text = "Chỉnh sửa khu vực";
            }        
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (option == "Add")
            {
                ZONE rm = new ZONE();
                rm.zoneName = txtTenkhu.Text;
                rm.zoneId = txtMakhu.Text;
                if (BUS_ZoneData.Instance.BUS_CHECKZONE(rm) == 0)
                {
                    MessageBox.Show("ID khu đã bị trùng! Vui lòng thay đổi");
                }
                else
                {
                    BUS_ZoneData.Instance.BUS_SETZONE(rm);
                    MessageBox.Show("Thêm thành công!");
                }
            }
            else
            {
                txtMakhu.Text = zoneid;
                ZONE rm2 = new ZONE();
                rm2.zoneId = txtMakhu.Text;
                rm2.zoneName = txtTenkhu.Text;
                BUS_ZoneData.Instance.BUS_UPDATEZONE(rm2, zoneid);
                MessageBox.Show("Cập nhập thành công!");
            }
            refresh();
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
