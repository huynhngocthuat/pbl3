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
            string user = txbUsername.Text;
            string password = txbPassWord.Text;
            if (user == "") { lbwarm.Text = "Vui lòng nhập tên tài khoản"; }
            else if (password == "") { lbwarm.Text = "Vui lòng nhập mật khẩu"; }

            else
            {
                password = BUS_MainData.Instance.BUS_Encrypt(txbPassWord.Text);
                if (BUS_MainData.Instance.BUS_Checkaccount(user, password) == 1)
                {
                    FAdmin f = new FAdmin();
                    this.Dispose();
                    f.SetACFormADMIN(BUS_MainData.Instance.BUS_GETACCOUNT());
                    f.ShowDialog();
                }
                else if (BUS_MainData.Instance.BUS_Checkaccount(user, password) == 0)
                {
                    FUser f = new FUser(user);
                    this.Dispose();
                    f.SetACFormUSER(BUS_MainData.Instance.BUS_GETACCOUNT());
                    f.ShowDialog();

                }
                else { lbwarm.Text = "Sai tên đăng nhập hoặc mật khẩu!"; }
            }
        }

        private void txbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.ToString() == " ")
            {              
                MessageBox.Show("Không được nhập kí tự trống");
                e.Handled = true;
            }    
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

