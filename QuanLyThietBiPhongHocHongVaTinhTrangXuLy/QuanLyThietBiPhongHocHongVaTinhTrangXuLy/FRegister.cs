using BUS;
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
    public partial class FRegister : Form
    {
        public FRegister()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtTK.Text != "" && txtMK2.Text != ""
                && txthoten.Text != "" && txtlop.Text != ""
                && txtkhoa.Text != "")
            {
                if (txtMK1.Text.Count() >= 8)
                {
                    if (String.Compare(txtMK1.Text, txtMK2.Text, false) == 0)
                    {
                        if (BUS_MainData.Instance.BUS_Checkaccount(txtTK.Text, "") == -1)
                        {
                            ACCOUNT ac = new ACCOUNT();
                            ac.username = txtTK.Text;
                            ac.password = BUS_MainData.Instance.BUS_Encrypt(txtMK2.Text);
                            ac.role = 0;
                            ac.fullName = txthoten.Text;
                            ac.@class = txtlop.Text;
                            ac.faculty = txtkhoa.Text;
                            BUS_MainData.Instance.BUS_SETACCOUNT(ac);
                            MessageBox.Show("Đăng ký thành công!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Tên tài khoản đã tồn tại");
                        }
                    }
                    else { MessageBox.Show("Xác nhận sai mật khẩu"); }
                }
                else { MessageBox.Show("Mật khẩu phải trên 8 kí tự"); }                     
            }
            else { MessageBox.Show("Nhập thiếu thông tin"); }
        }

        private void txtTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == " ")
            {

                MessageBox.Show("Không được nhập kí tự trống");
                e.Handled = true;
            }
        }
    }
}
