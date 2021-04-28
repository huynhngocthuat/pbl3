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
    public partial class FUser : Form
    {
        private ACCOUNT ac = new ACCOUNT();
        public FUser()
        {
            InitializeComponent();
            setCbbKhu();
            setCbbPhongHoc();
        }

        public void setCbbKhu()
        {
            foreach (ZONE item in BUS_MainData.Instance.BUS_ZONE())
            {
                cbbKhu.Items.Add(item.zoneName);
            }
        }
        public void setCbbPhongHoc()
        {
            foreach (ROOM item in BUS_MainData.Instance.BUS_ROOM())
            {
                cbbPhonghoc.Items.Add(item.roomId);
            }
        }
        public void SetACFormUSER(ACCOUNT a)
        {
            ac = a;
        }
        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            FAccount f = new FAccount(ac);
            f.GUI(ac);
            f.ShowDialog();
        }

        private void btnDulieu_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = BUS_MainData.Instance.BUS_ReportShow();
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckb_ChuaXuLy_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
