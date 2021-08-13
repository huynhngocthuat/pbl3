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
    public partial class FZone : Form
    {
        public FZone()
        {
            InitializeComponent();
            ShowZone();
        }
        public void ShowZone()
        {
            dataGridView_ShowZone.DataSource = BUS_ZoneData.Instance.BUS_ZoneShow();
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            ShowZone();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FZoneEdit f = new FZoneEdit("", "Add");
            f.refresh += new FZoneEdit.refreshData(ShowZone);
            f.Show();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView_ShowZone.SelectedRows.Count == 1)
            {
                string zoneid = dataGridView_ShowZone.CurrentRow.Cells["zoneID"].Value.ToString();
                BUS_ZoneData.Instance.BUS_DELETEZONE(zoneid);
                MessageBox.Show("Xóa thành công!");
                ShowZone();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khu vực :>");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dataGridView_ShowZone.SelectedRows.Count == 1)
            {
                string zoneid = dataGridView_ShowZone.CurrentRow.Cells["zoneID"].Value.ToString();
                FZoneEdit f = new FZoneEdit(zoneid, "Edit");
                f.refresh += new FZoneEdit.refreshData(ShowZone);
                f.Show();
            }
            else
            {
                MessageBox.Show("Vui long chọn khu vực :>");
            }
        }

        private void btnXemphong_Click(object sender, EventArgs e)
        {
            if(dataGridView_ShowZone.SelectedRows.Count == 1)
            {
                string zoneId = dataGridView_ShowZone.CurrentRow.Cells["zoneID"].Value.ToString();
                FRoom f = new FRoom(zoneId);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khu vực!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
