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
    public partial class FStatusEdit : Form
    {
        public delegate void refreshData();
        public refreshData refresh;
        private string statusid;
        private string option;
        private string equipmentid;
        public FStatusEdit(string equipmentid, string statusid, string option)
        {
            this.option = option;
            this.statusid = statusid;
            this.equipmentid = equipmentid;
            InitializeComponent();
            if(option == "Edit")
            {
                setSTATUS();
                txtMaTinhTrang.Enabled = false;
                txb_MathietBi.Enabled = false;
            }
            txb_MathietBi.Text = equipmentid;
            txb_MathietBi.Enabled = false;
        }

        private void setSTATUS()
        {
            STATUS s = new STATUS();
            s = BUS_StatusData.Instance.BUS_getStatusByIDStatus(statusid);
            txtMaTinhTrang.Text = s.statusId;
            txtTinhTrang.Text = s.equipmentStatus;
            txb_MathietBi.Text = s.equipmentId;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (option == "Add")
            {
                STATUS rm = new STATUS();
                rm.statusId = txtMaTinhTrang.Text;
                rm.equipmentId = txb_MathietBi.Text;
                rm.equipmentStatus = txtTinhTrang.Text;
                if (BUS_StatusData.Instance.BUS_CHECKSTATUS(rm) == 0)
                {
                    MessageBox.Show("ID trạng thái đã bị trùng! Vui lòng thay đổi");
                }
                else
                {
                    BUS_StatusData.Instance.BUS_SETSTATUS(rm);
                    MessageBox.Show("Thêm thành công!");
                }
            }
            else
            {
                txtMaTinhTrang.Text = statusid;
                STATUS rm2 = new STATUS();
                rm2.equipmentId = txb_MathietBi.Text;
                rm2.equipmentStatus = txtTinhTrang.Text;
                rm2.statusId = txtMaTinhTrang.Text;
                BUS_StatusData.Instance.BUS_UPDATESTATUS(rm2);
                MessageBox.Show("Cập nhập thành công!");
            }
            refresh();
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
