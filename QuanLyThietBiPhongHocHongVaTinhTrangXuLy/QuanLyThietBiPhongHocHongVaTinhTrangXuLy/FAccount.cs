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
        public delegate void UpdateData();
        public UpdateData updateData;

        private ACCOUNT a = new ACCOUNT();
        public FAccount(ACCOUNT ac)
        {
            a = ac;
            InitializeComponent();
            txtmkcu.Enabled = false;
            txtmkmoi1.Enabled = false;
            txtmkm2.Enabled = false;
        }
        public void GUI(ACCOUNT ac)
        {
            txbFullname.Text = ac.fullName;
            txtkhoa.Text = ac.faculty;
            txtlop.Text = ac.@class;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ACCOUNT newac = new ACCOUNT();
            newac.accountId = a.accountId;
            newac.username = a.username;
            newac.password = a.password;
            newac.role = a.role;
            if (txbFullname.Text != "" && txtkhoa.Text != ""
                && txtlop.Text != "")
            {
                newac.fullName = txbFullname.Text;
                newac.faculty = txtkhoa.Text;
                newac.@class = txtlop.Text;
                if (check_change_pass.Checked)
                {
                    string pass = BUS_MainData.Instance.BUS_Encrypt(txtmkcu.Text);
                    //a = BUS_MainData.Instance.BUS_GETACCOUNT();
                    if (string.Compare(pass, a.password) == 0)
                    {
                        if (txtmkmoi1.Text.Count() >= 8)
                        {
                            if (String.Compare(txtmkmoi1.Text, txtmkm2.Text, false) == 0)
                            {
                                if (String.Compare(BUS_MainData.Instance.BUS_Encrypt(txtmkm2.Text), a.password) != 0)
                                {
                                    newac.password = BUS_MainData.Instance.BUS_Encrypt(txtmkm2.Text);
                                    BUS_MainData.Instance.BUS_UPDATEACC(newac);
                                    MessageBox.Show("Cập nhật thành công!");
                                    updateData();
                                    this.Close();
                                }
                                else { MessageBox.Show("Bạn đang nhập mật khẩu cũ"); }
                            }
                            else { MessageBox.Show("Xác nhận sai mật khẩu"); }
                        }
                        else { MessageBox.Show("Mật khẩu phải trên 8 kí tự"); }
                    }
                    else { MessageBox.Show("Nhập sai mật khẩu cũ"); }
                }
                else
                {
                    if (newac.fullName == a.fullName && newac.faculty == a.faculty && newac.@class == a.@class)
                    {
                        MessageBox.Show("Bạn chưa sửa thông tin gì");
                    }
                    else
                    {
                        BUS_MainData.Instance.BUS_UPDATEACC(newac);
                        MessageBox.Show("Cập nhật thành công!");
                        updateData();
                        this.Close();
                    }
                }
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

        private void check_change_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (check_change_pass.Checked)
            {
                txtmkcu.Enabled = true;
                txtmkmoi1.Enabled = true;
                txtmkm2.Enabled = true;
            }
            else
            {
                txtmkcu.Enabled = false;
                txtmkmoi1.Enabled = false;
                txtmkm2.Enabled = false;
                txtmkcu.Text = "";
                txtmkmoi1.Text = "";
                txtmkm2.Text = "";
            }
        }
    }
}
