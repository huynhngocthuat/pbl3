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
            setCbbZone();
            setCbbTime();
        }
        public void setCbbZone()
        {
            cbb_Zone.Items.Add("Tất cả");
            cbb_Zone.Text = "Tất cả";
            foreach (var item in BUS_MainData.Instance.BUS_ZONE())
            {
                cbb_Zone.Items.Add(item.zoneName.ToString());
            }
        }
        public void setCbbTime()
        {
            cbb_Time.Text = "Báo cách đây 15 ngày";
            cbb_Time.Items.AddRange(new string[]
            {
                "Báo cách đây 15 ngày",
                "Báo cách đây 30 ngày",
                "Báo cách đây 60 ngày",
                "Báo cách đây 1 năm"
            });
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            FLogin f = new FLogin();
            //this.Hide();
            f.ShowDialog();           
        }

        private void btnDulieu_Click(object sender, EventArgs e)
        {
            int check = 1;
            int indexDate = 0;
            string zoneId = BUS_MainData.Instance.getZoneIdByName(cbb_Zone.Text);
            if(ckb_ChuaXuLy.Checked == true && ckb_DaXuLy.Checked == false)
            {
                check = 2;
            }
            else if(ckb_ChuaXuLy.Checked == false && ckb_DaXuLy.Checked == true)
            {
                check = 3;
            }
            indexDate = cbb_Time.SelectedIndex;
            dataGridView_showReport.DataSource = BUS_MainData.Instance.BUS_ReportShow(zoneId, check, indexDate);
        }
    }
}
