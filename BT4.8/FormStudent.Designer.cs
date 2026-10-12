namespace BT4._8
{
    partial class FormStudent
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnXuatCSV = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnChọnAnh = new System.Windows.Forms.Button();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.numTuoi = new System.Windows.Forms.NumericUpDown();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.cmsDgv = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsXemChiTiet = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsLamMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsXoaDong = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnNapDuLieu = new System.Windows.Forms.Button();
            this.chkGiaLapLoi = new System.Windows.Forms.CheckBox();
            this.pbNapDuLieu = new System.Windows.Forms.ProgressBar();
            this.lblPhanTram = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTuoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.cmsDgv.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnXuatCSV);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnChọnAnh);
            this.groupBox1.Controls.Add(this.picAvatar);
            this.groupBox1.Controls.Add(this.cboGioiTinh);
            this.groupBox1.Controls.Add(this.numTuoi);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 488);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 344);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(373, 22);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnXuatCSV
            // 
            this.btnXuatCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatCSV.Location = new System.Drawing.Point(10, 435);
            this.btnXuatCSV.Name = "btnXuatCSV";
            this.btnXuatCSV.Size = new System.Drawing.Size(373, 38);
            this.btnXuatCSV.TabIndex = 13;
            this.btnXuatCSV.Text = "Xuất FIle CSV";
            this.btnXuatCSV.UseVisualStyleBackColor = true;
            this.btnXuatCSV.Click += new System.EventHandler(this.btnXuatCSV_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(284, 382);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(99, 38);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(143, 382);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(99, 38);
            this.btnCapNhat.TabIndex = 11;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(10, 382);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(99, 38);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm Mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnChọnAnh
            // 
            this.btnChọnAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChọnAnh.Location = new System.Drawing.Point(10, 181);
            this.btnChọnAnh.Name = "btnChọnAnh";
            this.btnChọnAnh.Size = new System.Drawing.Size(99, 38);
            this.btnChọnAnh.TabIndex = 9;
            this.btnChọnAnh.Text = "Chọn ảnh";
            this.btnChọnAnh.UseVisualStyleBackColor = true;
            this.btnChọnAnh.Click += new System.EventHandler(this.btnChọnAnh_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatar.Location = new System.Drawing.Point(127, 181);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(256, 157);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 8;
            this.picAvatar.TabStop = false;
            this.picAvatar.Click += new System.EventHandler(this.picAvatar_Click);
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Location = new System.Drawing.Point(127, 125);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(256, 24);
            this.cboGioiTinh.TabIndex = 7;
            this.cboGioiTinh.SelectedIndexChanged += new System.EventHandler(this.cboGioiTinh_SelectedIndexChanged);
            // 
            // numTuoi
            // 
            this.numTuoi.Location = new System.Drawing.Point(127, 91);
            this.numTuoi.Name = "numTuoi";
            this.numTuoi.Size = new System.Drawing.Size(256, 22);
            this.numTuoi.TabIndex = 6;
            this.numTuoi.ValueChanged += new System.EventHandler(this.numTuoi_ValueChanged);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(127, 58);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(256, 22);
            this.txtHoTen.TabIndex = 5;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(127, 27);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(256, 22);
            this.txtMaSV.TabIndex = 4;
            this.txtMaSV.TextChanged += new System.EventHandler(this.txtMaSV_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tuổi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // dgvStudents
            // 
            this.dgvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.ContextMenuStrip = this.cmsDgv;
            this.dgvStudents.Location = new System.Drawing.Point(439, 13);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(676, 488);
            this.dgvStudents.TabIndex = 1;
            this.dgvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellContentClick);
            this.dgvStudents.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStudents_CellMouseDown);
            // 
            // cmsDgv
            // 
            this.cmsDgv.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsDgv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsXemChiTiet,
            this.cmsLamMoi,
            this.cmsSeparator1,
            this.cmsXoaDong});
            this.cmsDgv.Name = "cmsDgv";
            this.cmsDgv.Size = new System.Drawing.Size(211, 82);
            // 
            // cmsXemChiTiet
            // 
            this.cmsXemChiTiet.Name = "cmsXemChiTiet";
            this.cmsXemChiTiet.Size = new System.Drawing.Size(210, 24);
            this.cmsXemChiTiet.Text = "Xem chi tiết";
            this.cmsXemChiTiet.Click += new System.EventHandler(this.cmsXemChiTiet_Click);
            // 
            // cmsLamMoi
            // 
            this.cmsLamMoi.Name = "cmsLamMoi";
            this.cmsLamMoi.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.cmsLamMoi.Size = new System.Drawing.Size(210, 24);
            this.cmsLamMoi.Text = "Làm mới dữ liệu";
            this.cmsLamMoi.Click += new System.EventHandler(this.cmsLamMoi_Click);
            // 
            // cmsSeparator1
            // 
            this.cmsSeparator1.Name = "cmsSeparator1";
            this.cmsSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // cmsXoaDong
            // 
            this.cmsXoaDong.ForeColor = System.Drawing.Color.Red;
            this.cmsXoaDong.Name = "cmsXoaDong";
            this.cmsXoaDong.Size = new System.Drawing.Size(210, 24);
            this.cmsXoaDong.Text = "Xóa dòng";
            this.cmsXoaDong.Click += new System.EventHandler(this.cmsXoaDong_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            //
            // btnNapDuLieu
            //
            this.btnNapDuLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNapDuLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNapDuLieu.Location = new System.Drawing.Point(14, 515);
            this.btnNapDuLieu.Name = "btnNapDuLieu";
            this.btnNapDuLieu.Size = new System.Drawing.Size(200, 40);
            this.btnNapDuLieu.TabIndex = 2;
            this.btnNapDuLieu.Text = "Nạp dữ liệu (Async)";
            this.btnNapDuLieu.UseVisualStyleBackColor = true;
            this.btnNapDuLieu.Click += new System.EventHandler(this.btnNapDuLieu_Click);
            //
            // chkGiaLapLoi
            //
            this.chkGiaLapLoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkGiaLapLoi.AutoSize = true;
            this.chkGiaLapLoi.Location = new System.Drawing.Point(226, 525);
            this.chkGiaLapLoi.Name = "chkGiaLapLoi";
            this.chkGiaLapLoi.Size = new System.Drawing.Size(98, 20);
            this.chkGiaLapLoi.TabIndex = 3;
            this.chkGiaLapLoi.Text = "Giả lập lỗi";
            this.chkGiaLapLoi.UseVisualStyleBackColor = true;
            //
            // pbNapDuLieu
            //
            this.pbNapDuLieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbNapDuLieu.Location = new System.Drawing.Point(340, 520);
            this.pbNapDuLieu.Name = "pbNapDuLieu";
            this.pbNapDuLieu.Size = new System.Drawing.Size(700, 30);
            this.pbNapDuLieu.TabIndex = 4;
            //
            // lblPhanTram
            //
            this.lblPhanTram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhanTram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhanTram.Location = new System.Drawing.Point(1050, 524);
            this.lblPhanTram.Name = "lblPhanTram";
            this.lblPhanTram.Size = new System.Drawing.Size(65, 22);
            this.lblPhanTram.TabIndex = 5;
            this.lblPhanTram.Text = "0%";
            this.lblPhanTram.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // FormStudent
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 567);
            this.Controls.Add(this.lblPhanTram);
            this.Controls.Add(this.pbNapDuLieu);
            this.Controls.Add(this.chkGiaLapLoi);
            this.Controls.Add(this.btnNapDuLieu);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormStudent";
            this.Text = "Quản lý Sinh viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormStudent_FormClosing);
            this.Load += new System.EventHandler(this.FormStudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTuoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.cmsDgv.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnChọnAnh;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.NumericUpDown numTuoi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Button btnXuatCSV;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip cmsDgv;
        private System.Windows.Forms.ToolStripMenuItem cmsXemChiTiet;
        private System.Windows.Forms.ToolStripMenuItem cmsLamMoi;
        private System.Windows.Forms.ToolStripSeparator cmsSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmsXoaDong;
        private System.Windows.Forms.Button btnNapDuLieu;
        private System.Windows.Forms.CheckBox chkGiaLapLoi;
        private System.Windows.Forms.ProgressBar pbNapDuLieu;
        private System.Windows.Forms.Label lblPhanTram;
    }
}

