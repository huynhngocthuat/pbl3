using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;
using DTL;

namespace QuanLyThietBiPhongHocHongVaTinhTrangXuLy
{
    public partial class FStatus : Form
    {
        private string equipmentid;
        public FStatus(string equipmentid)
        {
            this.equipmentid = equipmentid;
            InitializeComponent();
            ShowStatus();
        }
        public void ShowStatus()
        {
            dataGridView_StatusShow.DataSource = BUS_StatusData.Instance.BUS_StatusShowForIDEquipment(equipmentid);
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            dataGridView_StatusShow.DataSource = BUS_StatusData.Instance.BUS_StatusShow();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FStatusEdit f = new FStatusEdit(equipmentid, "", "Add");
            f.refresh += new FStatusEdit.refreshData(ShowStatus);
            f.ShowDialog();

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string statusid = dataGridView_StatusShow.CurrentRow.Cells["statusID"].Value.ToString();
            FStatusEdit f = new FStatusEdit(equipmentid, statusid, "Edit");
            f.refresh += new FStatusEdit.refreshData(ShowStatus);
            f.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string statusid = dataGridView_StatusShow.CurrentRow.Cells["statusID"].Value.ToString();
            BUS_StatusData.Instance.BUS_DELETESTATUS(statusid);
            MessageBox.Show("Xóa thành công!");
            ShowStatus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
