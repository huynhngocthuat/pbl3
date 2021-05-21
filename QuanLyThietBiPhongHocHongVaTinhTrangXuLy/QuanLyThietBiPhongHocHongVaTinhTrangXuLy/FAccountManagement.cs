using BUS;
using DAL;
using DTL;
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
    public partial class FAccountManagement : Form
    {
        public FAccountManagement()
        {
            InitializeComponent();
            SetDgv();
            SetCbbRole();
            SetcbbSort();
            txtmk1.Enabled = false;
            txtmk2.Enabled = false;
            txtusername.Enabled = false;
        }
        private void SetDgv()
        {
            dataGridView1.DataSource = BUS_MainData.Instance.BUS_AccountShow();
        }
        private void SetCbbRole()
        {
            cbbrole.Items.AddRange(new string[]
            {
                "User",
                "Admin",
            });
        }
        private void SetcbbSort()
        {
            cbbSort.Items.AddRange(new string[] {
            "Họ và tên",
            "Khoa",
            "Lớp",
            "Username",
            "Role",
            });
            cbbSort.SelectedIndex = 0;
        }

        #region deleteaccount
        /*private void button1_Click(object sender, EventArgs e)
        {
            List<String> lusername = new List<string>();
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if(r.Count >0)
            {
                foreach(DataGridViewRow i in r)
                {
                    lusername.Add(i.Cells["username"].Value.ToString());
                }
                BUS_MainData.Instance.BUS_DeleteAccount(lusername);
                SetDgv();
            }    
        }*/
        #endregion

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int vt = dataGridView1.CurrentCell.RowIndex;
            txtusername.Text = dataGridView1.Rows[vt].Cells[0].Value.ToString();
            cbbrole.Text = dataGridView1.Rows[vt].Cells[1].Value?.ToString();
            txtfullname.Text = dataGridView1.Rows[vt].Cells[2].Value.ToString();     
            txtKhoa.Text = dataGridView1.Rows[vt].Cells[3].Value.ToString();
            txtLop.Text = dataGridView1.Rows[vt].Cells[4].Value.ToString();
           
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                txtmk1.Enabled = true;
                txtmk2.Enabled = true;
            }
            else
            {
                txtmk1.Enabled = false;
                txtmk2.Enabled = false;
                txtmk1.Text = "";
                txtmk2.Text = "";
            }    
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            ACCOUNT newac = new ACCOUNT();
            foreach (ACCOUNT a in BUS_MainData.Instance.BUS_ACCOUNT())
            {
                if (txtusername.Text == a.username)
                {
                    newac.password = a.password;
                    newac.accountId = a.accountId;
                    newac.username = a.username;
                    if (txtfullname.Text != "" && txtKhoa.Text != "" && txtLop.Text != "")
                    {
                        newac.fullName = txtfullname.Text;
                        newac.faculty = txtKhoa.Text;
                        newac.@class = txtLop.Text;
                        newac.role = cbbrole.SelectedIndex;
                        if (checkBox1.Checked)
                        {
                            if (txtmk1.Text.Count() >= 8 && txtmk1.Text != "")
                            {
                                if (String.Compare(txtmk1.Text, txtmk2.Text, false) == 0)
                                {
                                    newac.password = BUS_MainData.Instance.BUS_Encrypt(txtmk2.Text);
                                    BUS_MainData.Instance.BUS_UPDATEACC(newac);
                                    MessageBox.Show("Cập nhật thành công!");
                                    SetDgv();
                                    checkBox1.Checked = false;
                                }
                                else { MessageBox.Show("Xác nhận sai mật khẩu!"); }
                            }
                            else { MessageBox.Show("Mật khẩu phải từ 8 kí tự trở lên!"); }
                        }
                        else
                        {
                            if (newac.accountId == a.accountId && newac.username == a.username
                                && newac.fullName == a.fullName && newac.faculty == newac.faculty
                                && newac.password == a.password && a.@class == newac.@class
                                && newac.role == a.role)
                            {
                                MessageBox.Show("Bạn chưa sửa thông tin gì!");
                            }
                            else
                            {
                                BUS_MainData.Instance.BUS_UPDATEACC(newac);
                                MessageBox.Show("Cập nhật thành công!");
                                SetDgv();
                                checkBox1.Checked = false;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập thiếu thông tin");
                    }
                    break;       
                }     
            }              
         }

        private void txtmk1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == " ")
            {
                MessageBox.Show("Không được nhập kí tự trống");
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtsearch.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tìm kiếm");
            } 
            else
            {
                dataGridView1.DataSource = BUS_MainData.Instance.BUS_Search(txtsearch.Text);
            }       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BUS_MainData.Instance.BUS_Sort(cbbSort.SelectedItem.ToString());
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            SetDgv();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetDgv();
        }
    }
}
