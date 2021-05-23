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
using BUS;

namespace QuanLyThietBiPhongHocHongVaTinhTrangXuLy
{
    public partial class FAccount : Form
    {
        private ACCOUNT a = new ACCOUNT();
        public FAccount(ACCOUNT ac)
        {
            a = ac;
            InitializeComponent();
        }
        public void GUI(ACCOUNT ac)
        {
            txbFullname.Text = ac.fullName;
            txtkhoa.Text = ac.faculty;
            txtlop.Text = ac.@class;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txbFullname.Text != "" && txtkhoa.Text != ""
                && txtlop.Text != "" && txtmkcu.Text != ""
                && txtmkmoi1.Text != "" && txtmkm2.Text != "")
            {
                string pass = BUS_MainData.Instance.BUS_Encrypt(txtmkcu.Text);
                //a = BUS_MainData.Instance.BUS_GETACCOUNT();
                if (string.Compare(pass, a.password) == 0)
                {
                    if (txtmkmoi1.Text.Count() >= 8)
                    {
                        if (String.Compare(txtmkmoi1.Text, txtmkm2.Text, false) == 0)
                        {
                            ACCOUNT a2 = new ACCOUNT();
                            a2.accountId = a.accountId;
                            a2.fullName = txbFullname.Text;
                            a2.faculty = txtkhoa.Text;
                            a2.@class = txtlop.Text;
                            a2.password = BUS_MainData.Instance.BUS_Encrypt(txtmkm2.Text);
                            BUS_MainData.Instance.BUS_UPDATEACC(a2);
                            MessageBox.Show("Cập nhật thành công!");
                            this.Close();
                        }
                        else { MessageBox.Show("Xác nhận sai mật khẩu"); }                       
                    }
                    else { MessageBox.Show("Mật khẩu phải trên 8 kí tự"); }                  
                }
                else { MessageBox.Show("Nhập sai mật khẩu cũ"); }                
            }
            else { MessageBox.Show("Nhập thiếu thông tin"); }
        }

        private void txtmkcu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == " ")
            {
                MessageBox.Show("Không được nhập kí tự trống");
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
