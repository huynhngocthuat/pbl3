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
    public partial class FRoomEdit : Form
    {

        public delegate void refreshData(string zoneId);
        public refreshData refresh;
        private string roomid;
        private string option;
        private string zoneid;
        public FRoomEdit(string roomId, string option)
        {
            this.roomid = roomId;
            this.option = option;
            InitializeComponent();
            setROOM();
        }
        private void setROOM()
        {
            if(option == "Edit")
            {
                ROOM s = new ROOM();
                s = BUS_RoomData.Instance.BUS_getRoomByIDRoom(roomid);
                txbTenphong.Text = s.roomFunction;
                txbMaphong.Text = s.roomId;
                cbbKhuphong.Text = s.zoneId;
                this.zoneid = s.zoneId;
                txbMaphong.Enabled = false;
                this.Text = "Chỉnh sửa phòng";
            }
            
        }

        public void setCbbZone()
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (option == "Add")
            {
                ROOM rm = new ROOM();
                rm.roomId = txbMaphong.Text;
                rm.zoneId = cbbKhuphong.Text;
                rm.roomFunction = txbTenphong.Text;
                if (BUS_RoomData.Instance.BUS_CHECKROOM(rm) == 0)
                {
                    MessageBox.Show("ID phòng đã bị trùng! Vui lòng thay đổi");
                }
                else
                {
                    BUS_RoomData.Instance.BUS_SETROOM(rm);
                    MessageBox.Show("Thêm thành công!");
                }
            }
            else
            {
                txbMaphong.Text = roomid;
                ROOM rm2 = new ROOM();
                rm2.roomId = txbMaphong.Text;
                rm2.roomFunction = txbTenphong.Text;
                rm2.zoneId = cbbKhuphong.Text;
                BUS_RoomData.Instance.BUS_UPDATEROOM(rm2, roomid);
                MessageBox.Show("Cập nhập thành công!");
            }
            refresh(zoneid);
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
