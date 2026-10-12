namespace BT4._8
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCuaSo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDongTatCa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSinhVien = new System.Windows.Forms.ToolStripButton();
            this.tsbSanPham = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCascade = new System.Windows.Forms.ToolStripButton();
            this.tsbTileHorizontal = new System.Windows.Forms.ToolStripButton();
            this.tsbTileVertical = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDangXuat = new System.Windows.Forms.ToolStripButton();
            this.tsbThoat = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblNguoiDung = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblThongBao = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTienTrinh = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspbTienTrinh = new System.Windows.Forms.ToolStripProgressBar();
            this.lblThoiGian = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDongTatCa = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrDongHo = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.cmsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuDanhMuc,
            this.mnuCuaSo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.mnuCuaSo;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1400, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangXuat,
            this.mnuSeparator1,
            this.mnuThoat});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(85, 24);
            this.mnuHeThong.Text = "&Hệ thống";
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.mnuDangXuat.Size = new System.Drawing.Size(209, 26);
            this.mnuDangXuat.Text = "Đăng xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.DangXuat_Click);
            // 
            // mnuSeparator1
            // 
            this.mnuSeparator1.Name = "mnuSeparator1";
            this.mnuSeparator1.Size = new System.Drawing.Size(206, 6);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuThoat.Size = new System.Drawing.Size(209, 26);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSinhVien,
            this.mnuSanPham});
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(90, 24);
            this.mnuDanhMuc.Text = "&Danh mục";
            // 
            // mnuSinhVien
            // 
            this.mnuSinhVien.Name = "mnuSinhVien";
            this.mnuSinhVien.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.mnuSinhVien.Size = new System.Drawing.Size(262, 26);
            this.mnuSinhVien.Text = "Quản lý Sinh viên";
            this.mnuSinhVien.Click += new System.EventHandler(this.MoFormSinhVien_Click);
            // 
            // mnuSanPham
            // 
            this.mnuSanPham.Name = "mnuSanPham";
            this.mnuSanPham.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.mnuSanPham.Size = new System.Drawing.Size(262, 26);
            this.mnuSanPham.Text = "Quản lý Sản phẩm";
            this.mnuSanPham.Click += new System.EventHandler(this.MoFormSanPham_Click);
            // 
            // mnuCuaSo
            // 
            this.mnuCuaSo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCascade,
            this.mnuTileHorizontal,
            this.mnuTileVertical,
            this.mnuSeparator2,
            this.mnuDongTatCa});
            this.mnuCuaSo.Name = "mnuCuaSo";
            this.mnuCuaSo.Size = new System.Drawing.Size(68, 24);
            this.mnuCuaSo.Text = "&Cửa sổ";
            // 
            // mnuCascade
            // 
            this.mnuCascade.Name = "mnuCascade";
            this.mnuCascade.Size = new System.Drawing.Size(276, 26);
            this.mnuCascade.Text = "Cascade (Xếp chồng)";
            this.mnuCascade.Click += new System.EventHandler(this.Cascade_Click);
            // 
            // mnuTileHorizontal
            // 
            this.mnuTileHorizontal.Name = "mnuTileHorizontal";
            this.mnuTileHorizontal.Size = new System.Drawing.Size(276, 26);
            this.mnuTileHorizontal.Text = "Tile Horizontal (Xếp ngang)";
            this.mnuTileHorizontal.Click += new System.EventHandler(this.TileHorizontal_Click);
            // 
            // mnuTileVertical
            // 
            this.mnuTileVertical.Name = "mnuTileVertical";
            this.mnuTileVertical.Size = new System.Drawing.Size(276, 26);
            this.mnuTileVertical.Text = "Tile Vertical (Xếp dọc)";
            this.mnuTileVertical.Click += new System.EventHandler(this.TileVertical_Click);
            // 
            // mnuSeparator2
            // 
            this.mnuSeparator2.Name = "mnuSeparator2";
            this.mnuSeparator2.Size = new System.Drawing.Size(273, 6);
            // 
            // mnuDongTatCa
            // 
            this.mnuDongTatCa.Name = "mnuDongTatCa";
            this.mnuDongTatCa.Size = new System.Drawing.Size(276, 26);
            this.mnuDongTatCa.Text = "Đóng tất cả cửa sổ";
            this.mnuDongTatCa.Click += new System.EventHandler(this.DongTatCa_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSinhVien,
            this.tsbSanPham,
            this.tsSeparator1,
            this.tsbCascade,
            this.tsbTileHorizontal,
            this.tsbTileVertical,
            this.tsSeparator2,
            this.tsbDangXuat,
            this.tsbThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1400, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSinhVien
            // 
            this.tsbSinhVien.Name = "tsbSinhVien";
            this.tsbSinhVien.Size = new System.Drawing.Size(72, 24);
            this.tsbSinhVien.Text = "Sinh viên";
            this.tsbSinhVien.ToolTipText = "Quản lý Sinh viên (Ctrl+1)";
            this.tsbSinhVien.Click += new System.EventHandler(this.MoFormSinhVien_Click);
            // 
            // tsbSanPham
            // 
            this.tsbSanPham.Name = "tsbSanPham";
            this.tsbSanPham.Size = new System.Drawing.Size(79, 24);
            this.tsbSanPham.Text = "Sản phẩm";
            this.tsbSanPham.ToolTipText = "Quản lý Sản phẩm (Ctrl+2)";
            this.tsbSanPham.Click += new System.EventHandler(this.MoFormSanPham_Click);
            // 
            // tsSeparator1
            // 
            this.tsSeparator1.Name = "tsSeparator1";
            this.tsSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbCascade
            // 
            this.tsbCascade.Name = "tsbCascade";
            this.tsbCascade.Size = new System.Drawing.Size(68, 24);
            this.tsbCascade.Text = "Cascade";
            this.tsbCascade.ToolTipText = "Sắp xếp cửa sổ kiểu Cascade";
            this.tsbCascade.Click += new System.EventHandler(this.Cascade_Click);
            // 
            // tsbTileHorizontal
            // 
            this.tsbTileHorizontal.Name = "tsbTileHorizontal";
            this.tsbTileHorizontal.Size = new System.Drawing.Size(85, 24);
            this.tsbTileHorizontal.Text = "Xếp ngang";
            this.tsbTileHorizontal.ToolTipText = "Sắp xếp cửa sổ kiểu Tile Horizontal";
            this.tsbTileHorizontal.Click += new System.EventHandler(this.TileHorizontal_Click);
            // 
            // tsbTileVertical
            // 
            this.tsbTileVertical.Name = "tsbTileVertical";
            this.tsbTileVertical.Size = new System.Drawing.Size(68, 24);
            this.tsbTileVertical.Text = "Xếp dọc";
            this.tsbTileVertical.ToolTipText = "Sắp xếp cửa sổ kiểu Tile Vertical";
            this.tsbTileVertical.Click += new System.EventHandler(this.TileVertical_Click);
            // 
            // tsSeparator2
            // 
            this.tsSeparator2.Name = "tsSeparator2";
            this.tsSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbDangXuat
            // 
            this.tsbDangXuat.Name = "tsbDangXuat";
            this.tsbDangXuat.Size = new System.Drawing.Size(81, 24);
            this.tsbDangXuat.Text = "Đăng xuất";
            this.tsbDangXuat.ToolTipText = "Đăng xuất (Ctrl+L)";
            this.tsbDangXuat.Click += new System.EventHandler(this.DangXuat_Click);
            // 
            // tsbThoat
            // 
            this.tsbThoat.Name = "tsbThoat";
            this.tsbThoat.Size = new System.Drawing.Size(51, 24);
            this.tsbThoat.Text = "Thoát";
            this.tsbThoat.ToolTipText = "Thoát chương trình";
            this.tsbThoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblNguoiDung,
            this.lblThongBao,
            this.lblTienTrinh,
            this.tspbTienTrinh,
            this.lblThoiGian});
            this.statusStrip1.Location = new System.Drawing.Point(0, 770);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1400, 30);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblNguoiDung
            // 
            this.lblNguoiDung.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblNguoiDung.Name = "lblNguoiDung";
            this.lblNguoiDung.Size = new System.Drawing.Size(100, 24);
            this.lblNguoiDung.Text = "Người dùng: ";
            // 
            // lblThongBao
            // 
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(775, 24);
            this.lblThongBao.Spring = true;
            this.lblThongBao.Text = "Sẵn sàng";
            this.lblThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblTienTrinh
            //
            this.lblTienTrinh.AutoSize = false;
            this.lblTienTrinh.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lblTienTrinh.Name = "lblTienTrinh";
            this.lblTienTrinh.Size = new System.Drawing.Size(130, 24);
            this.lblTienTrinh.Text = "Tiến trình: 0%";
            this.lblTienTrinh.Visible = false;
            //
            // tspbTienTrinh
            //
            this.tspbTienTrinh.Name = "tspbTienTrinh";
            this.tspbTienTrinh.Size = new System.Drawing.Size(200, 22);
            this.tspbTienTrinh.Visible = false;
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = false;
            this.lblThoiGian.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(170, 24);
            this.lblThoiGian.Text = "00/00/0000 00:00:00";
            // 
            // cmsMain
            // 
            this.cmsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsSinhVien,
            this.cmsSanPham,
            this.cmsSeparator1,
            this.cmsCascade,
            this.cmsDongTatCa});
            this.cmsMain.Name = "cmsMain";
            this.cmsMain.Size = new System.Drawing.Size(204, 106);
            // 
            // cmsSinhVien
            // 
            this.cmsSinhVien.Name = "cmsSinhVien";
            this.cmsSinhVien.Size = new System.Drawing.Size(203, 24);
            this.cmsSinhVien.Text = "Quản lý Sinh viên";
            this.cmsSinhVien.Click += new System.EventHandler(this.MoFormSinhVien_Click);
            // 
            // cmsSanPham
            // 
            this.cmsSanPham.Name = "cmsSanPham";
            this.cmsSanPham.Size = new System.Drawing.Size(203, 24);
            this.cmsSanPham.Text = "Quản lý Sản phẩm";
            this.cmsSanPham.Click += new System.EventHandler(this.MoFormSanPham_Click);
            // 
            // cmsSeparator1
            // 
            this.cmsSeparator1.Name = "cmsSeparator1";
            this.cmsSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // cmsCascade
            // 
            this.cmsCascade.Name = "cmsCascade";
            this.cmsCascade.Size = new System.Drawing.Size(203, 24);
            this.cmsCascade.Text = "Sắp xếp Cascade";
            this.cmsCascade.Click += new System.EventHandler(this.Cascade_Click);
            // 
            // cmsDongTatCa
            // 
            this.cmsDongTatCa.Name = "cmsDongTatCa";
            this.cmsDongTatCa.Size = new System.Drawing.Size(203, 24);
            this.cmsDongTatCa.Text = "Đóng tất cả cửa sổ";
            this.cmsDongTatCa.Click += new System.EventHandler(this.DongTatCa_Click);
            // 
            // tmrDongHo
            // 
            this.tmrDongHo.Interval = 1000;
            this.tmrDongHo.Tick += new System.EventHandler(this.tmrDongHo_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG QUẢN LÝ - MDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.cmsMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripSeparator mnuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuSinhVien;
        private System.Windows.Forms.ToolStripMenuItem mnuSanPham;
        private System.Windows.Forms.ToolStripMenuItem mnuCuaSo;
        private System.Windows.Forms.ToolStripMenuItem mnuCascade;
        private System.Windows.Forms.ToolStripMenuItem mnuTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem mnuTileVertical;
        private System.Windows.Forms.ToolStripSeparator mnuSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuDongTatCa;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSinhVien;
        private System.Windows.Forms.ToolStripButton tsbSanPham;
        private System.Windows.Forms.ToolStripSeparator tsSeparator1;
        private System.Windows.Forms.ToolStripButton tsbCascade;
        private System.Windows.Forms.ToolStripButton tsbTileHorizontal;
        private System.Windows.Forms.ToolStripButton tsbTileVertical;
        private System.Windows.Forms.ToolStripSeparator tsSeparator2;
        private System.Windows.Forms.ToolStripButton tsbDangXuat;
        private System.Windows.Forms.ToolStripButton tsbThoat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblNguoiDung;
        private System.Windows.Forms.ToolStripStatusLabel lblThongBao;
        private System.Windows.Forms.ToolStripStatusLabel lblTienTrinh;
        private System.Windows.Forms.ToolStripProgressBar tspbTienTrinh;
        private System.Windows.Forms.ToolStripStatusLabel lblThoiGian;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem cmsSinhVien;
        private System.Windows.Forms.ToolStripMenuItem cmsSanPham;
        private System.Windows.Forms.ToolStripSeparator cmsSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmsCascade;
        private System.Windows.Forms.ToolStripMenuItem cmsDongTatCa;
        private System.Windows.Forms.Timer tmrDongHo;
    }
}
