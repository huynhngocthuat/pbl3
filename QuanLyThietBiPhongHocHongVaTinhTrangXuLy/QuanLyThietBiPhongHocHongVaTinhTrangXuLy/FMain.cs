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
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            FLogin f = new FLogin();
            //this.Hide();
            f.ShowDialog();           
        }

        private void btnDulieu_Click(object sender, EventArgs e)
        {
            int check = 1;
            string zoneId = BUS_MainData.Instance.getZoneIdByName(cbb_Zone.Text);
            if(ckb_ChuaXuLy.Checked == true && ckb_DaXuLy.Checked == false)
            {
                check = 2;
            }
            else if(ckb_ChuaXuLy.Checked == false && ckb_DaXuLy.Checked == true)
            {
                check = 3;
            }
            dataGridView_showReport.DataSource = BUS_MainData.Instance.BUS_ReportShow(zoneId, check, dateStart.Value, dateEnd.Value);
        }

    }
}
