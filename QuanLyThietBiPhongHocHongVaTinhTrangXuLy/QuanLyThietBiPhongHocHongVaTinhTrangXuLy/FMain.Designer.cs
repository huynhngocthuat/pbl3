
namespace QuanLyThietBiPhongHocHongVaTinhTrangXuLy
{
    partial class FMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_Time = new System.Windows.Forms.ComboBox();
            this.lb_GiangDuong = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.dataGridView_showReport = new System.Windows.Forms.DataGridView();
            this.btnDulieu = new System.Windows.Forms.Button();
            this.cbb_Zone = new System.Windows.Forms.ComboBox();
            this.ckb_DaXuLy = new System.Windows.Forms.CheckBox();
            this.ckb_ChuaXuLy = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_showReport)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_Time);
            this.groupBox1.Controls.Add(this.lb_GiangDuong);
            this.groupBox1.Controls.Add(this.btnDangNhap);
            this.groupBox1.Controls.Add(this.dataGridView_showReport);
            this.groupBox1.Controls.Add(this.btnDulieu);
            this.groupBox1.Controls.Add(this.cbb_Zone);
            this.groupBox1.Controls.Add(this.ckb_DaXuLy);
            this.groupBox1.Controls.Add(this.ckb_ChuaXuLy);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1270, 537);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách lượt báo thiết bị hỏng";
            // 
            // cbb_Time
            // 
            this.cbb_Time.FormattingEnabled = true;
            this.cbb_Time.Location = new System.Drawing.Point(753, 44);
            this.cbb_Time.Name = "cbb_Time";
            this.cbb_Time.Size = new System.Drawing.Size(176, 24);
            this.cbb_Time.TabIndex = 11;
            // 
            // lb_GiangDuong
            // 
            this.lb_GiangDuong.AutoSize = true;
            this.lb_GiangDuong.Location = new System.Drawing.Point(22, 51);
            this.lb_GiangDuong.Name = "lb_GiangDuong";
            this.lb_GiangDuong.Size = new System.Drawing.Size(94, 17);
            this.lb_GiangDuong.TabIndex = 10;
            this.lb_GiangDuong.Text = "Giảng đường:";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDangNhap.Location = new System.Drawing.Point(1087, 42);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(93, 26);
            this.btnDangNhap.TabIndex = 9;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // dataGridView_showReport
            // 
            this.dataGridView_showReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_showReport.Location = new System.Drawing.Point(6, 98);
            this.dataGridView_showReport.Name = "dataGridView_showReport";
            this.dataGridView_showReport.ReadOnly = true;
            this.dataGridView_showReport.RowHeadersWidth = 51;
            this.dataGridView_showReport.RowTemplate.Height = 24;
            this.dataGridView_showReport.Size = new System.Drawing.Size(1246, 426);
            this.dataGridView_showReport.TabIndex = 8;
            // 
            // btnDulieu
            // 
            this.btnDulieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDulieu.Location = new System.Drawing.Point(973, 42);
            this.btnDulieu.Name = "btnDulieu";
            this.btnDulieu.Size = new System.Drawing.Size(75, 28);
            this.btnDulieu.TabIndex = 7;
            this.btnDulieu.Text = "Dữ liệu";
            this.btnDulieu.UseVisualStyleBackColor = false;
            this.btnDulieu.Click += new System.EventHandler(this.btnDulieu_Click);
            // 
            // cbb_Zone
            // 
            this.cbb_Zone.FormattingEnabled = true;
            this.cbb_Zone.IntegralHeight = false;
            this.cbb_Zone.ItemHeight = 16;
            this.cbb_Zone.Location = new System.Drawing.Point(149, 45);
            this.cbb_Zone.Name = "cbb_Zone";
            this.cbb_Zone.Size = new System.Drawing.Size(227, 24);
            this.cbb_Zone.TabIndex = 6;
            // 
            // ckb_DaXuLy
            // 
            this.ckb_DaXuLy.AutoSize = true;
            this.ckb_DaXuLy.Location = new System.Drawing.Point(587, 47);
            this.ckb_DaXuLy.Name = "ckb_DaXuLy";
            this.ckb_DaXuLy.Size = new System.Drawing.Size(102, 21);
            this.ckb_DaXuLy.TabIndex = 5;
            this.ckb_DaXuLy.Text = "Tin đã xử lý";
            this.ckb_DaXuLy.UseVisualStyleBackColor = true;
            // 
            // ckb_ChuaXuLy
            // 
            this.ckb_ChuaXuLy.AutoSize = true;
            this.ckb_ChuaXuLy.Location = new System.Drawing.Point(439, 47);
            this.ckb_ChuaXuLy.Name = "ckb_ChuaXuLy";
            this.ckb_ChuaXuLy.Size = new System.Drawing.Size(117, 21);
            this.ckb_ChuaXuLy.TabIndex = 4;
            this.ckb_ChuaXuLy.Text = "Tin chưa xử lý";
            this.ckb_ChuaXuLy.UseVisualStyleBackColor = true;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 548);
            this.Controls.Add(this.groupBox1);
            this.Name = "FMain";
            this.Text = "FMain";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_showReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckb_DaXuLy;
        private System.Windows.Forms.CheckBox ckb_ChuaXuLy;
        private System.Windows.Forms.ComboBox cbb_Zone;
        private System.Windows.Forms.DataGridView dataGridView_showReport;
        private System.Windows.Forms.Button btnDulieu;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.ComboBox cbb_Time;
        private System.Windows.Forms.Label lb_GiangDuong;
    }
}