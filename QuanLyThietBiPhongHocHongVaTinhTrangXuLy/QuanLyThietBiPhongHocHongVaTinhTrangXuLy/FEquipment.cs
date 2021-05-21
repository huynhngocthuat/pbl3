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
    public partial class FEquipment : Form
    {
        public FEquipment()
        {
            InitializeComponent();
            setCBBSort();
        }
        public FEquipment(string roomId)
        {
            InitializeComponent();
            setCBBSort();
            if (roomId != "")
            {
                dataGridView_Equipment.DataSource = BUS_EquipmentData.Instance.BUS_ShowEquipmentByRoomId(roomId);
            }
            else
            {
                dataGridView_Equipment.DataSource = BUS_EquipmentData.Instance.BUS_EquipmentShow();
            }
        }
        private void setCBBSort()
        {
            cbbSort.Items.AddRange(new string[]
                {
                    "equipmentId",
                    "equimentName",
                    "roomId",
                    "dateOfInstallation",
                    "company"
                });
        }
        public void Show(string text)
        {
            dataGridView_Equipment.DataSource = BUS_EquipmentData.Instance.BUS_EquipmentShow(text);
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            Show(txb_Search.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FEquipmentDetail f = new FEquipmentDetail(txb_Search.Text, "", "Add");
            f.refresh += new FEquipmentDetail.refreshData(Show);
            f.Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string equipmentid = dataGridView_Equipment.CurrentRow.Cells["equipmentID"].Value.ToString();
            BUS_EquipmentData.Instance.BUS_DELETEEQUIPMENT(equipmentid);
            MessageBox.Show("Xóa thành công!");
            Show(txb_Search.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string equipmentid = dataGridView_Equipment.CurrentRow.Cells["equipmentID"].Value.ToString();
            FEquipmentDetail f = new FEquipmentDetail(txb_Search.Text,equipmentid, "Edit");
            f.refresh += new FEquipmentDetail.refreshData(Show);
            f.Show();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            List<EQUIPMENT> equipmentList = new List<EQUIPMENT>();
            switch (cbbSort.SelectedItem.ToString())
            {
                case "equipmetId":
                    dataGridView_Equipment.DataSource = BUS_EquipmentData.Instance.BUS_SortEquipmentByIdEquipment();
                    break;
                case "equipmentName":
                    dataGridView_Equipment.DataSource = BUS_EquipmentData.Instance.BUS_SortEquipmentByName();
                    break;
                case "roomId":
                    dataGridView_Equipment.DataSource = BUS_EquipmentData.Instance.BUS_SortEquipmentByIdRoom();
                    break;
                case "dateOfInstallation":
                    dataGridView_Equipment.DataSource = BUS_EquipmentData.Instance.BUS_SortEquipmentByDate();
                    break;
                case "company":
                    dataGridView_Equipment.DataSource = BUS_EquipmentData.Instance.BUS_SortEquipmentByCompany();
                    break;
                default:
                    dataGridView_Equipment.DataSource = BUS_EquipmentData.Instance.BUS_SortEquipmentByIdEquipment();
                    break;
            }
        }

        private void btnXemtinhtrang_Click(object sender, EventArgs e)
        {
            if (dataGridView_Equipment.SelectedRows.Count == 1)
            {
                string equipmentid = dataGridView_Equipment.CurrentRow.Cells["equipmentID"].Value.ToString();
                FStatus f = new FStatus(equipmentid);
                f.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một thiết bị!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
