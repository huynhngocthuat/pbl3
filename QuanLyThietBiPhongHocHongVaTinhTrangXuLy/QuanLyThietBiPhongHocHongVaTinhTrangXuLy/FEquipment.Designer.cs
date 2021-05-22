
namespace QuanLyThietBiPhongHocHongVaTinhTrangXuLy
{
    partial class FEquipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEquipment));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_search = new System.Windows.Forms.Label();
            this.txb_Search = new System.Windows.Forms.TextBox();
            this.btnXemtinhtrang = new System.Windows.Forms.Button();
            this.dataGridView_Equipment = new System.Windows.Forms.DataGridView();
            this.cbbSort = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Equipment)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lb_search);
            this.groupBox1.Controls.Add(this.txb_Search);
            this.groupBox1.Controls.Add(this.btnXemtinhtrang);
            this.groupBox1.Controls.Add(this.dataGridView_Equipment);
            this.groupBox1.Controls.Add(this.cbbSort);
            this.groupBox1.Controls.Add(this.btnSort);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("#9Slide03 Comfortaa Bold", 9F);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1246, 580);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách trang thiết bị";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack.Location = new System.Drawing.Point(954, 69);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 35);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Trở về";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(150, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Chọn thuộc tính:";
            // 
            // lb_search
            // 
            this.lb_search.AutoSize = true;
            this.lb_search.BackColor = System.Drawing.Color.Transparent;
            this.lb_search.Location = new System.Drawing.Point(150, 74);
            this.lb_search.Name = "lb_search";
            this.lb_search.Size = new System.Drawing.Size(141, 25);
            this.lb_search.TabIndex = 27;
            this.lb_search.Text = "Nhập mã phòng:";
            // 
            // txb_Search
            // 
            this.txb_Search.Location = new System.Drawing.Point(331, 71);
            this.txb_Search.Name = "txb_Search";
            this.txb_Search.Size = new System.Drawing.Size(169, 31);
            this.txb_Search.TabIndex = 0;
            // 
            // btnXemtinhtrang
            // 
            this.btnXemtinhtrang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnXemtinhtrang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemtinhtrang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemtinhtrang.ForeColor = System.Drawing.Color.Transparent;
            this.btnXemtinhtrang.Location = new System.Drawing.Point(777, 69);
            this.btnXemtinhtrang.Name = "btnXemtinhtrang";
            this.btnXemtinhtrang.Size = new System.Drawing.Size(170, 35);
            this.btnXemtinhtrang.TabIndex = 2;
            this.btnXemtinhtrang.Text = "Xem tình trạng";
            this.btnXemtinhtrang.UseVisualStyleBackColor = false;
            this.btnXemtinhtrang.Click += new System.EventHandler(this.btnXemtinhtrang_Click);
            // 
            // dataGridView_Equipment
            // 
            this.dataGridView_Equipment.AllowUserToAddRows = false;
            this.dataGridView_Equipment.AllowUserToResizeRows = false;
            this.dataGridView_Equipment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Equipment.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Equipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Equipment.Location = new System.Drawing.Point(46, 198);
            this.dataGridView_Equipment.Name = "dataGridView_Equipment";
            this.dataGridView_Equipment.ReadOnly = true;
            this.dataGridView_Equipment.RowHeadersVisible = false;
            this.dataGridView_Equipment.RowHeadersWidth = 51;
            this.dataGridView_Equipment.RowTemplate.Height = 24;
            this.dataGridView_Equipment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Equipment.Size = new System.Drawing.Size(1153, 339);
            this.dataGridView_Equipment.TabIndex = 50;
            // 
            // cbbSort
            // 
            this.cbbSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbSort.FormattingEnabled = true;
            this.cbbSort.Location = new System.Drawing.Point(331, 124);
            this.cbbSort.Name = "cbbSort";
            this.cbbSort.Size = new System.Drawing.Size(169, 33);
            this.cbbSort.TabIndex = 4;
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.ForeColor = System.Drawing.Color.Transparent;
            this.btnSort.Location = new System.Drawing.Point(506, 122);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(100, 35);
            this.btnSort.TabIndex = 5;
            this.btnSort.Text = "Dữ liệu";
            this.btnSort.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.ForeColor = System.Drawing.Color.Transparent;
            this.btnDel.Location = new System.Drawing.Point(991, 122);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(70, 35);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.Transparent;
            this.btnEdit.Location = new System.Drawing.Point(889, 122);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(70, 35);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(777, 122);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 35);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.ForeColor = System.Drawing.Color.Transparent;
            this.btnShow.Location = new System.Drawing.Point(506, 69);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 35);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Xem";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // FEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 580);
            this.Controls.Add(this.groupBox1);
            this.Name = "FEquipment";
            this.Text = "FEquipment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Equipment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXemtinhtrang;
        private System.Windows.Forms.DataGridView dataGridView_Equipment;
        private System.Windows.Forms.ComboBox cbbSort;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txb_Search;
        private System.Windows.Forms.Label lb_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}