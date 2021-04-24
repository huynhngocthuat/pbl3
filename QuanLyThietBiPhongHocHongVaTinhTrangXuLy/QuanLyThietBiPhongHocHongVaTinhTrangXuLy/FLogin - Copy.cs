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
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            FRegister f = new FRegister();
            f.ShowDialog();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txbUsername.Text == "1")
            {
                FAdmin f = new FAdmin();
                f.ShowDialog();
            }
            else if (txbUsername.Text == "2")
            {
                FUser f = new FUser();
                f.ShowDialog();
            }
            else MessageBox.Show("Error");
        }
    }
}
