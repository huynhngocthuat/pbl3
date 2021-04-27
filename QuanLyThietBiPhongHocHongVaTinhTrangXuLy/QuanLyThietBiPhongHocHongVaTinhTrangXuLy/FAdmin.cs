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
        public FAdmin()
        {
            InitializeComponent();
        }
        public void SetACFormADMIN(ACCOUNT a)
        {
            ac = a;
        }
        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            FAccount f = new FAccount(ac);
            f.GUI(ac);
            f.ShowDialog();
        }

        private void btnPhanHoi_Click(object sender, EventArgs e)
        {
            FResponse f = new FResponse();
            f.ShowDialog();
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {           
            this.Close();
        }
    }
}
