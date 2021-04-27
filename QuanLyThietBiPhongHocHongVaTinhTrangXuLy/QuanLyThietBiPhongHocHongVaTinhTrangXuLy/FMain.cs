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
using DTL;

namespace QuanLyThietBiPhongHocHongVaTinhTrangXuLy
{
    public partial class FMain : Form
    {
        public FMain()
        {
            
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            FLogin f = new FLogin();
            //this.Hide();
            f.ShowDialog();           
        }

        private void btnDulieu_Click(object sender, EventArgs e)
        {
            dataGridView_showReport.DataSource = BUS_MainData.Instance.BUS_ReportShow();
        }
    }
}
