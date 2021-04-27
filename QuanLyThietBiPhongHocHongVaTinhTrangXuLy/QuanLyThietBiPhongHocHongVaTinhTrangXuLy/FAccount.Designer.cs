
namespace QuanLyThietBiPhongHocHongVaTinhTrangXuLy
{
    partial class FAccount
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
            this.txtmkm2 = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtmkmoi1 = new System.Windows.Forms.TextBox();
            this.txtmkcu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtlop = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtkhoa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbFullname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmkm2);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txtmkmoi1);
            this.groupBox1.Controls.Add(this.txtmkcu);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtlop);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtkhoa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbFullname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 373);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết tài khoản";
            // 
            // txtmkm2
            // 
            this.txtmkm2.Location = new System.Drawing.Point(170, 235);
            this.txtmkm2.MaxLength = 20;
            this.txtmkm2.Name = "txtmkm2";
            this.txtmkm2.Size = new System.Drawing.Size(225, 22);
            this.txtmkm2.TabIndex = 10;
            this.txtmkm2.UseSystemPasswordChar = true;
            this.txtmkm2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmkcu_KeyPress);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(157, 338);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 29);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtmkmoi1
            // 
            this.txtmkmoi1.Location = new System.Drawing.Point(170, 204);
            this.txtmkmoi1.MaxLength = 20;
            this.txtmkmoi1.Name = "txtmkmoi1";
            this.txtmkmoi1.Size = new System.Drawing.Size(225, 22);
            this.txtmkmoi1.TabIndex = 10;
            this.txtmkmoi1.UseSystemPasswordChar = true;
            this.txtmkmoi1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmkcu_KeyPress);
            // 
            // txtmkcu
            // 
            this.txtmkcu.Location = new System.Drawing.Point(170, 169);
            this.txtmkcu.MaxLength = 20;
            this.txtmkcu.Name = "txtmkcu";
            this.txtmkcu.Size = new System.Drawing.Size(225, 22);
            this.txtmkcu.TabIndex = 8;
            this.txtmkcu.UseSystemPasswordChar = true;
            this.txtmkcu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmkcu_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Xác nhận mật khẩu mới";
            // 
            // txtlop
            // 
            this.txtlop.Location = new System.Drawing.Point(170, 114);
            this.txtlop.Name = "txtlop";
            this.txtlop.Size = new System.Drawing.Size(225, 22);
            this.txtlop.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mật khẩu mới";
            // 
            // txtkhoa
            // 
            this.txtkhoa.Location = new System.Drawing.Point(170, 79);
            this.txtkhoa.Name = "txtkhoa";
            this.txtkhoa.Size = new System.Drawing.Size(225, 22);
            this.txtkhoa.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mật khẩu cũ";
            // 
            // txbFullname
            // 
            this.txbFullname.Location = new System.Drawing.Point(170, 40);
            this.txbFullname.Name = "txbFullname";
            this.txbFullname.Size = new System.Drawing.Size(225, 22);
            this.txbFullname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên";
            // 
            // FAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 397);
            this.Controls.Add(this.groupBox1);
            this.Name = "FAccount";
            this.Text = "FormAccount";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbFullname;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtmkm2;
        private System.Windows.Forms.TextBox txtmkmoi1;
        private System.Windows.Forms.TextBox txtmkcu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtlop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtkhoa;
        private System.Windows.Forms.Label label5;
    }
}