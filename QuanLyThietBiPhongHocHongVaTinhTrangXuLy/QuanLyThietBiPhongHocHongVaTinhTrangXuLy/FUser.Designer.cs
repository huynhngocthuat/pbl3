
namespace QuanLyThietBiPhongHocHongVaTinhTrangXuLy
{
    partial class FUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupbox_alldata = new System.Windows.Forms.GroupBox();
            this.dataGridView_AllData = new System.Windows.Forms.DataGridView();
            this.btnTaobaocao = new System.Windows.Forms.Button();
            this.btnDulieu = new System.Windows.Forms.Button();
            this.btnDangxuat = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.ckb_ChuaXuLy = new System.Windows.Forms.CheckBox();
            this.ckb_DaXuLy = new System.Windows.Forms.CheckBox();
            this.cbb_Zone = new System.Windows.Forms.ComboBox();
            this.lb_GiangDuong = new System.Windows.Forms.Label();
            this.cbb_Time = new System.Windows.Forms.ComboBox();
            this.groupbox_UserData = new System.Windows.Forms.GroupBox();
            this.dataGridView_UserData = new System.Windows.Forms.DataGridView();
            this.groupbox_main = new System.Windows.Forms.GroupBox();
            this.btn_EditReport = new System.Windows.Forms.Button();
            this.groupbox_alldata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllData)).BeginInit();
            this.groupbox_UserData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UserData)).BeginInit();
            this.groupbox_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox_alldata
            // 
            this.groupbox_alldata.Controls.Add(this.dataGridView_AllData);
            this.groupbox_alldata.Location = new System.Drawing.Point(12, 294);
            this.groupbox_alldata.Name = "groupbox_alldata";
            this.groupbox_alldata.Size = new System.Drawing.Size(1343, 253);
            this.groupbox_alldata.TabIndex = 1;
            this.groupbox_alldata.TabStop = false;
            this.groupbox_alldata.Text = "Tất cả các báo cáo";
            // 
            // dataGridView_AllData
            // 
            this.dataGridView_AllData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AllData.Location = new System.Drawing.Point(7, 21);
            this.dataGridView_AllData.Name = "dataGridView_AllData";
            this.dataGridView_AllData.ReadOnly = true;
            this.dataGridView_AllData.RowHeadersWidth = 51;
            this.dataGridView_AllData.RowTemplate.Height = 24;
            this.dataGridView_AllData.Size = new System.Drawing.Size(1326, 224);
            this.dataGridView_AllData.TabIndex = 0;
            // 
            // btnTaobaocao
            // 
            this.btnTaobaocao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTaobaocao.Location = new System.Drawing.Point(1110, 48);
            this.btnTaobaocao.Name = "btnTaobaocao";
            this.btnTaobaocao.Size = new System.Drawing.Size(201, 28);
            this.btnTaobaocao.TabIndex = 3;
            this.btnTaobaocao.Text = "Tạo báo cáo mới";
            this.btnTaobaocao.UseVisualStyleBackColor = false;
            this.btnTaobaocao.Click += new System.EventHandler(this.btnTaobaocao_Click);
            // 
            // btnDulieu
            // 
            this.btnDulieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDulieu.Location = new System.Drawing.Point(975, 48);
            this.btnDulieu.Name = "btnDulieu";
            this.btnDulieu.Size = new System.Drawing.Size(89, 28);
            this.btnDulieu.TabIndex = 4;
            this.btnDulieu.Text = "Dữ liệu";
            this.btnDulieu.UseVisualStyleBackColor = false;
            this.btnDulieu.Click += new System.EventHandler(this.btnDulieu_Click);
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDangxuat.Location = new System.Drawing.Point(1221, 85);
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.Size = new System.Drawing.Size(90, 28);
            this.btnDangxuat.TabIndex = 8;
            this.btnDangxuat.Text = "Đăng xuất";
            this.btnDangxuat.UseVisualStyleBackColor = false;
            this.btnDangxuat.Click += new System.EventHandler(this.btnDangxuat_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTaiKhoan.Location = new System.Drawing.Point(1110, 85);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(86, 27);
            this.btnTaiKhoan.TabIndex = 15;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.UseVisualStyleBackColor = false;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // ckb_ChuaXuLy
            // 
            this.ckb_ChuaXuLy.AutoSize = true;
            this.ckb_ChuaXuLy.Location = new System.Drawing.Point(460, 55);
            this.ckb_ChuaXuLy.Name = "ckb_ChuaXuLy";
            this.ckb_ChuaXuLy.Size = new System.Drawing.Size(117, 21);
            this.ckb_ChuaXuLy.TabIndex = 16;
            this.ckb_ChuaXuLy.Text = "Tin chưa xử lý";
            this.ckb_ChuaXuLy.UseVisualStyleBackColor = true;
            // 
            // ckb_DaXuLy
            // 
            this.ckb_DaXuLy.AutoSize = true;
            this.ckb_DaXuLy.Location = new System.Drawing.Point(608, 55);
            this.ckb_DaXuLy.Name = "ckb_DaXuLy";
            this.ckb_DaXuLy.Size = new System.Drawing.Size(102, 21);
            this.ckb_DaXuLy.TabIndex = 17;
            this.ckb_DaXuLy.Text = "Tin đã xử lý";
            this.ckb_DaXuLy.UseVisualStyleBackColor = true;
            // 
            // cbb_Zone
            // 
            this.cbb_Zone.FormattingEnabled = true;
            this.cbb_Zone.IntegralHeight = false;
            this.cbb_Zone.ItemHeight = 16;
            this.cbb_Zone.Location = new System.Drawing.Point(170, 53);
            this.cbb_Zone.Name = "cbb_Zone";
            this.cbb_Zone.Size = new System.Drawing.Size(227, 24);
            this.cbb_Zone.TabIndex = 18;
            // 
            // lb_GiangDuong
            // 
            this.lb_GiangDuong.AutoSize = true;
            this.lb_GiangDuong.Location = new System.Drawing.Point(43, 59);
            this.lb_GiangDuong.Name = "lb_GiangDuong";
            this.lb_GiangDuong.Size = new System.Drawing.Size(94, 17);
            this.lb_GiangDuong.TabIndex = 19;
            this.lb_GiangDuong.Text = "Giảng đường:";
            // 
            // cbb_Time
            // 
            this.cbb_Time.FormattingEnabled = true;
            this.cbb_Time.Location = new System.Drawing.Point(762, 52);
            this.cbb_Time.Name = "cbb_Time";
            this.cbb_Time.Size = new System.Drawing.Size(188, 24);
            this.cbb_Time.TabIndex = 20;
            // 
            // groupbox_UserData
            // 
            this.groupbox_UserData.Controls.Add(this.dataGridView_UserData);
            this.groupbox_UserData.Location = new System.Drawing.Point(6, 128);
            this.groupbox_UserData.Name = "groupbox_UserData";
            this.groupbox_UserData.Size = new System.Drawing.Size(1336, 147);
            this.groupbox_UserData.TabIndex = 21;
            this.groupbox_UserData.TabStop = false;
            this.groupbox_UserData.Text = "Những báo cáo trước của bạn";
            // 
            // dataGridView_UserData
            // 
            this.dataGridView_UserData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_UserData.Location = new System.Drawing.Point(0, 21);
            this.dataGridView_UserData.Name = "dataGridView_UserData";
            this.dataGridView_UserData.ReadOnly = true;
            this.dataGridView_UserData.RowHeadersWidth = 51;
            this.dataGridView_UserData.RowTemplate.Height = 24;
            this.dataGridView_UserData.Size = new System.Drawing.Size(1326, 123);
            this.dataGridView_UserData.TabIndex = 0;
            // 
            // groupbox_main
            // 
            this.groupbox_main.Controls.Add(this.btn_EditReport);
            this.groupbox_main.Controls.Add(this.groupbox_UserData);
            this.groupbox_main.Controls.Add(this.cbb_Time);
            this.groupbox_main.Controls.Add(this.lb_GiangDuong);
            this.groupbox_main.Controls.Add(this.cbb_Zone);
            this.groupbox_main.Controls.Add(this.ckb_DaXuLy);
            this.groupbox_main.Controls.Add(this.ckb_ChuaXuLy);
            this.groupbox_main.Controls.Add(this.btnTaiKhoan);
            this.groupbox_main.Controls.Add(this.btnDangxuat);
            this.groupbox_main.Controls.Add(this.btnDulieu);
            this.groupbox_main.Controls.Add(this.btnTaobaocao);
            this.groupbox_main.Location = new System.Drawing.Point(13, 13);
            this.groupbox_main.Name = "groupbox_main";
            this.groupbox_main.Size = new System.Drawing.Size(1342, 275);
            this.groupbox_main.TabIndex = 0;
            this.groupbox_main.TabStop = false;
            this.groupbox_main.Text = "           Huỳnh Ngọc Thuật - 19TCLC_DT2";
            // 
            // btn_EditReport
            // 
            this.btn_EditReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_EditReport.Location = new System.Drawing.Point(1110, 14);
            this.btn_EditReport.Name = "btn_EditReport";
            this.btn_EditReport.Size = new System.Drawing.Size(201, 28);
            this.btn_EditReport.TabIndex = 4;
            this.btn_EditReport.Text = "Chỉnh sửa báo cáo";
            this.btn_EditReport.UseVisualStyleBackColor = false;
            this.btn_EditReport.Click += new System.EventHandler(this.btn_EditReport_Click);
            // 
            // FUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 559);
            this.Controls.Add(this.groupbox_alldata);
            this.Controls.Add(this.groupbox_main);
            this.Name = "FUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FUeser";
            this.groupbox_alldata.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllData)).EndInit();
            this.groupbox_UserData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UserData)).EndInit();
            this.groupbox_main.ResumeLayout(false);
            this.groupbox_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupbox_alldata;
        private System.Windows.Forms.DataGridView dataGridView_AllData;
        private System.Windows.Forms.Button btnTaobaocao;
        private System.Windows.Forms.Button btnDulieu;
        private System.Windows.Forms.Button btnDangxuat;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.CheckBox ckb_ChuaXuLy;
        private System.Windows.Forms.CheckBox ckb_DaXuLy;
        private System.Windows.Forms.ComboBox cbb_Zone;
        private System.Windows.Forms.Label lb_GiangDuong;
        private System.Windows.Forms.ComboBox cbb_Time;
        private System.Windows.Forms.GroupBox groupbox_UserData;
        private System.Windows.Forms.DataGridView dataGridView_UserData;
        private System.Windows.Forms.GroupBox groupbox_main;
        private System.Windows.Forms.Button btn_EditReport;
    }
}