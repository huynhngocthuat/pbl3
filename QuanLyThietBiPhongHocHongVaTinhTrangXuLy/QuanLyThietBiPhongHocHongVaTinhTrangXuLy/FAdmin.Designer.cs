﻿
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
            this.btn_Account = new System.Windows.Forms.Button();
            this.btnShowData = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnCreateResponse = new System.Windows.Forms.Button();
            this.btnEquipmentManage = new System.Windows.Forms.Button();
            this.btnRoomManage = new System.Windows.Forms.Button();
            this.btnZoneManage = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.lbFullName = new System.Windows.Forms.Label();
            this.ckbResolved = new System.Windows.Forms.CheckBox();
            this.ckbNotResolvedYet = new System.Windows.Forms.CheckBox();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.cbbReportTime = new System.Windows.Forms.ComboBox();
            this.lbZone = new System.Windows.Forms.Label();
            this.cbbZone = new System.Windows.Forms.ComboBox();
            this.grbAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // grbAdmin
            // 
            this.grbAdmin.Controls.Add(this.btn_Account);
            this.grbAdmin.Controls.Add(this.btnShowData);
            this.grbAdmin.Controls.Add(this.btnEditProfile);
            this.grbAdmin.Controls.Add(this.btnCreateResponse);
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
            // btn_Account
            // 
            this.btn_Account.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Account.Location = new System.Drawing.Point(557, 92);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.Size = new System.Drawing.Size(168, 30);
            this.btn_Account.TabIndex = 9;
            this.btn_Account.Text = "Quản lý tài khoản";
            this.btn_Account.UseVisualStyleBackColor = true;
            this.btn_Account.Click += new System.EventHandler(this.btn_Account_Click);
            // 
            // btnShowData
            // 
            this.btnShowData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowData.Location = new System.Drawing.Point(673, 31);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(100, 30);
            this.btnShowData.TabIndex = 4;
            this.btnShowData.Text = "Dữ liệu";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProfile.Location = new System.Drawing.Point(920, 92);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(200, 30);
            this.btnEditProfile.TabIndex = 11;
            this.btnEditProfile.Text = "Chỉnh sửa tài khoản";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // btnCreateResponse
            // 
            this.btnCreateResponse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateResponse.Location = new System.Drawing.Point(764, 92);
            this.btnCreateResponse.Name = "btnCreateResponse";
            this.btnCreateResponse.Size = new System.Drawing.Size(150, 30);
            this.btnCreateResponse.TabIndex = 10;
            this.btnCreateResponse.Text = "Tạo phản hồi";
            this.btnCreateResponse.UseVisualStyleBackColor = true;
            this.btnCreateResponse.Click += new System.EventHandler(this.btnCreateResponse_Click);
            // 
            // btnEquipmentManage
            // 
            this.btnEquipmentManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEquipmentManage.Location = new System.Drawing.Point(369, 92);
            this.btnEquipmentManage.Name = "btnEquipmentManage";
            this.btnEquipmentManage.Size = new System.Drawing.Size(168, 30);
            this.btnEquipmentManage.TabIndex = 8;
            this.btnEquipmentManage.Text = "Quản lý thiết bị phòng";
            this.btnEquipmentManage.UseVisualStyleBackColor = true;
            this.btnEquipmentManage.Click += new System.EventHandler(this.btnManageEquipment_Click);
            // 
            // btnRoomManage
            // 
            this.btnRoomManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomManage.Location = new System.Drawing.Point(194, 92);
            this.btnRoomManage.Name = "btnRoomManage";
            this.btnRoomManage.Size = new System.Drawing.Size(169, 30);
            this.btnRoomManage.TabIndex = 7;
            this.btnRoomManage.Text = "Quản lý phòng";
            this.btnRoomManage.UseVisualStyleBackColor = true;
            this.btnRoomManage.Click += new System.EventHandler(this.btnManageRoom_Click);
            // 
            // btnZoneManage
            // 
            this.btnZoneManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZoneManage.Location = new System.Drawing.Point(20, 92);
            this.btnZoneManage.Name = "btnZoneManage";
            this.btnZoneManage.Size = new System.Drawing.Size(168, 30);
            this.btnZoneManage.TabIndex = 6;
            this.btnZoneManage.Text = "Quản lý khu";
            this.btnZoneManage.UseVisualStyleBackColor = true;
            this.btnZoneManage.Click += new System.EventHandler(this.btnManageZone_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignOut.Location = new System.Drawing.Point(1020, 31);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(100, 30);
            this.btnSignOut.TabIndex = 5;
            this.btnSignOut.Text = "Đăng xuất";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
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
            // ckbResolved
            // 
            this.ckbResolved.AutoSize = true;
            this.ckbResolved.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbResolved.Location = new System.Drawing.Point(339, 48);
            this.ckbResolved.Name = "ckbResolved";
            this.ckbResolved.Size = new System.Drawing.Size(114, 21);
            this.ckbResolved.TabIndex = 2;
            this.ckbResolved.Text = "Tin đã xử lý";
            this.ckbResolved.UseVisualStyleBackColor = true;
            // 
            // ckbNotResolvedYet
            // 
            this.ckbNotResolvedYet.AutoSize = true;
            this.ckbNotResolvedYet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbNotResolvedYet.Location = new System.Drawing.Point(339, 21);
            this.ckbNotResolvedYet.Name = "ckbNotResolvedYet";
            this.ckbNotResolvedYet.Size = new System.Drawing.Size(131, 21);
            this.ckbNotResolvedYet.TabIndex = 1;
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
            this.dgvReport.TabIndex = 50;
            // 
            // cbbReportTime
            // 
            this.cbbReportTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbReportTime.FormattingEnabled = true;
            this.cbbReportTime.Location = new System.Drawing.Point(476, 35);
            this.cbbReportTime.Name = "cbbReportTime";
            this.cbbReportTime.Size = new System.Drawing.Size(191, 24);
            this.cbbReportTime.TabIndex = 3;
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
            this.cbbZone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbZone.FormattingEnabled = true;
            this.cbbZone.Location = new System.Drawing.Point(117, 35);
            this.cbbZone.Name = "cbbZone";
            this.cbbZone.Size = new System.Drawing.Size(187, 24);
            this.cbbZone.TabIndex = 0;
            // 
            // FAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.grbAdmin);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
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
        private System.Windows.Forms.Button btnEquipmentManage;
        private System.Windows.Forms.Button btnRoomManage;
        private System.Windows.Forms.Button btnZoneManage;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Button btn_Account;
    }
}

