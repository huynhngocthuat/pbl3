
namespace QuanLyThietBiPhongHocHongVaTinhTrangXuLy
{
    partial class FAdmin
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
            this.grbAdmin = new System.Windows.Forms.GroupBox();
            this.ckbResolved = new System.Windows.Forms.CheckBox();
            this.ckbNotResolvedYet = new System.Windows.Forms.CheckBox();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.cbbReportTime = new System.Windows.Forms.ComboBox();
            this.lbZone = new System.Windows.Forms.Label();
            this.cbbZone = new System.Windows.Forms.ComboBox();
            this.lbFullName = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnZoneManage = new System.Windows.Forms.Button();
            this.btnRoomManage = new System.Windows.Forms.Button();
            this.btnEquipmentManage = new System.Windows.Forms.Button();
            this.btnStatusManage = new System.Windows.Forms.Button();
            this.btnCreateResponse = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnShowData = new System.Windows.Forms.Button();
            this.grbAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // grbAdmin
            // 
            this.grbAdmin.Controls.Add(this.btnShowData);
            this.grbAdmin.Controls.Add(this.btnEditProfile);
            this.grbAdmin.Controls.Add(this.btnCreateResponse);
            this.grbAdmin.Controls.Add(this.btnStatusManage);
            this.grbAdmin.Controls.Add(this.btnEquipmentManage);
            this.grbAdmin.Controls.Add(this.btnRoomManage);
            this.grbAdmin.Controls.Add(this.btnZoneManage);
            this.grbAdmin.Controls.Add(this.btnSignOut);
            this.grbAdmin.Controls.Add(this.lbFullName);
            this.grbAdmin.Controls.Add(this.ckbResolved);
            this.grbAdmin.Controls.Add(this.ckbNotResolvedYet);
            this.grbAdmin.Controls.Add(this.dgvReport);
            this.grbAdmin.Controls.Add(this.cbbReportTime);
            this.grbAdmin.Controls.Add(this.lbZone);
            this.grbAdmin.Controls.Add(this.cbbZone);
            this.grbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAdmin.Location = new System.Drawing.Point(12, 12);
            this.grbAdmin.Name = "grbAdmin";
            this.grbAdmin.Size = new System.Drawing.Size(1150, 520);
            this.grbAdmin.TabIndex = 0;
            this.grbAdmin.TabStop = false;
            this.grbAdmin.Text = "Thông tin báo hỏng trang thiết bị phòng học";
            // 
            // ckbResolved
            // 
            this.ckbResolved.AutoSize = true;
            this.ckbResolved.Location = new System.Drawing.Point(339, 48);
            this.ckbResolved.Name = "ckbResolved";
            this.ckbResolved.Size = new System.Drawing.Size(114, 21);
            this.ckbResolved.TabIndex = 10;
            this.ckbResolved.Text = "Tin đã xử lý";
            this.ckbResolved.UseVisualStyleBackColor = true;
            // 
            // ckbNotResolvedYet
            // 
            this.ckbNotResolvedYet.AutoSize = true;
            this.ckbNotResolvedYet.Location = new System.Drawing.Point(339, 21);
            this.ckbNotResolvedYet.Name = "ckbNotResolvedYet";
            this.ckbNotResolvedYet.Size = new System.Drawing.Size(131, 21);
            this.ckbNotResolvedYet.TabIndex = 9;
            this.ckbNotResolvedYet.Text = "Tin chưa xử lý";
            this.ckbNotResolvedYet.UseVisualStyleBackColor = true;
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(20, 144);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.Size = new System.Drawing.Size(1100, 350);
            this.dgvReport.TabIndex = 5;
            // 
            // cbbReportTime
            // 
            this.cbbReportTime.FormattingEnabled = true;
            this.cbbReportTime.Location = new System.Drawing.Point(476, 35);
            this.cbbReportTime.Name = "cbbReportTime";
            this.cbbReportTime.Size = new System.Drawing.Size(191, 24);
            this.cbbReportTime.TabIndex = 4;
            // 
            // lbZone
            // 
            this.lbZone.AutoSize = true;
            this.lbZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbZone.Location = new System.Drawing.Point(17, 38);
            this.lbZone.Name = "lbZone";
            this.lbZone.Size = new System.Drawing.Size(94, 17);
            this.lbZone.TabIndex = 3;
            this.lbZone.Text = "Giảng đường:";
            // 
            // cbbZone
            // 
            this.cbbZone.FormattingEnabled = true;
            this.cbbZone.Location = new System.Drawing.Point(117, 35);
            this.cbbZone.Name = "cbbZone";
            this.cbbZone.Size = new System.Drawing.Size(187, 24);
            this.cbbZone.TabIndex = 0;
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFullName.Location = new System.Drawing.Point(791, 35);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(90, 20);
            this.lbFullName.TabIndex = 11;
            this.lbFullName.Text = "Họ và tên";
            this.lbFullName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(1020, 31);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(100, 30);
            this.btnSignOut.TabIndex = 12;
            this.btnSignOut.Text = "Đăng xuất";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnZoneManage
            // 
            this.btnZoneManage.Location = new System.Drawing.Point(20, 92);
            this.btnZoneManage.Name = "btnZoneManage";
            this.btnZoneManage.Size = new System.Drawing.Size(150, 30);
            this.btnZoneManage.TabIndex = 13;
            this.btnZoneManage.Text = "Quản lý khu";
            this.btnZoneManage.UseVisualStyleBackColor = true;
            this.btnZoneManage.Click += new System.EventHandler(this.btnManageZone_Click);
            // 
            // btnRoomManage
            // 
            this.btnRoomManage.Location = new System.Drawing.Point(176, 92);
            this.btnRoomManage.Name = "btnRoomManage";
            this.btnRoomManage.Size = new System.Drawing.Size(150, 30);
            this.btnRoomManage.TabIndex = 14;
            this.btnRoomManage.Text = "Quản lý phòng";
            this.btnRoomManage.UseVisualStyleBackColor = true;
            this.btnRoomManage.Click += new System.EventHandler(this.btnManageRoom_Click);
            // 
            // btnEquipmentManage
            // 
            this.btnEquipmentManage.Location = new System.Drawing.Point(332, 92);
            this.btnEquipmentManage.Name = "btnEquipmentManage";
            this.btnEquipmentManage.Size = new System.Drawing.Size(200, 30);
            this.btnEquipmentManage.TabIndex = 15;
            this.btnEquipmentManage.Text = "Quản lý thiết bị phòng";
            this.btnEquipmentManage.UseVisualStyleBackColor = true;
            this.btnEquipmentManage.Click += new System.EventHandler(this.btnManageEquipment_Click);
            // 
            // btnStatusManage
            // 
            this.btnStatusManage.Location = new System.Drawing.Point(538, 92);
            this.btnStatusManage.Name = "btnStatusManage";
            this.btnStatusManage.Size = new System.Drawing.Size(200, 30);
            this.btnStatusManage.TabIndex = 16;
            this.btnStatusManage.Text = "Quản lý tình trạng TB";
            this.btnStatusManage.UseVisualStyleBackColor = true;
            this.btnStatusManage.Click += new System.EventHandler(this.btnManageStatus_Click);
            // 
            // btnCreateResponse
            // 
            this.btnCreateResponse.Location = new System.Drawing.Point(764, 92);
            this.btnCreateResponse.Name = "btnCreateResponse";
            this.btnCreateResponse.Size = new System.Drawing.Size(150, 30);
            this.btnCreateResponse.TabIndex = 17;
            this.btnCreateResponse.Text = "Tạo phản hồi";
            this.btnCreateResponse.UseVisualStyleBackColor = true;
            this.btnCreateResponse.Click += new System.EventHandler(this.btnCreateResponse_Click);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Location = new System.Drawing.Point(920, 92);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(200, 30);
            this.btnEditProfile.TabIndex = 18;
            this.btnEditProfile.Text = "Chỉnh sửa tài khoản";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(673, 31);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(100, 30);
            this.btnShowData.TabIndex = 19;
            this.btnShowData.Text = "Dữ liệu";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // FAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.grbAdmin);
            this.Name = "FAdmin";
            this.Text = "FAdmin";
            this.grbAdmin.ResumeLayout(false);
            this.grbAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAdmin;
        private System.Windows.Forms.ComboBox cbbZone;
        private System.Windows.Forms.ComboBox cbbReportTime;
        private System.Windows.Forms.Label lbZone;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.CheckBox ckbResolved;
        private System.Windows.Forms.CheckBox ckbNotResolvedYet;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnCreateResponse;
        private System.Windows.Forms.Button btnStatusManage;
        private System.Windows.Forms.Button btnEquipmentManage;
        private System.Windows.Forms.Button btnRoomManage;
        private System.Windows.Forms.Button btnZoneManage;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label lbFullName;
    }
}

