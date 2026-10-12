using System;
using System.Windows.Forms;

namespace BT4._7
{
    public partial class FormMain : Form
    {
        // Tên người dùng đang đăng nhập: lấy tên tài khoản Windows của máy
        private string tenNguoiDung = Environment.UserName;

        // Trạng thái đăng nhập (dùng cho chức năng Đăng xuất)
        private bool daDangNhap = true;

        public FormMain()
        {
            InitializeComponent();
        }

        // ========================================================
        // 1. FORM LOAD
        // ========================================================
        private void FormMain_Load(object sender, EventArgs e)
        {
            lblNguoiDung.Text = "Người dùng: " + tenNguoiDung;
            lblThoiGian.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            tmrDongHo.Start();

            // Gắn ContextMenuStrip vào vùng nền MDI (MdiClient) để click chuột phải lên nền
            foreach (Control c in this.Controls)
            {
                if (c is MdiClient)
                {
                    c.ContextMenuStrip = cmsMain;
                }
            }

            CapNhatTrangThai("Xin chào " + tenNguoiDung + "!");
        }

        // ========================================================
        // 2. GIAO TIẾP CHA - CON
        //    Hàm public: Form con gọi hàm này để gửi thông điệp
        //    lên thanh StatusStrip của Form cha.
        // ========================================================
        public void CapNhatTrangThai(string thongBao)
        {
            lblThongBao.Text = DateTime.Now.ToString("HH:mm:ss") + "  |  " + thongBao;
        }

        // ========================================================
        // 3. THUẬT TOÁN MỞ FORM CON (KHÔNG MỞ LẶP)
        //    - Duyệt các Form con đang mở (MdiChildren)
        //    - Nếu đã có Form cùng loại -> chỉ Activate đưa lên trên
        //    - Nếu chưa có -> khởi tạo mới và hiển thị
        // ========================================================
        private void MoFormCon<T>() where T : Form, new()
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is T)
                {
                    if (f.WindowState == FormWindowState.Minimized)
                        f.WindowState = FormWindowState.Normal;

                    f.Activate();
                    CapNhatTrangThai("Cửa sổ \"" + f.Text + "\" đang mở -> đưa lên trên cùng.");
                    return;
                }
            }

            T frm = new T();
            frm.MdiParent = this; // Nhúng làm MDI Child của FormMain
            frm.FormClosed += (s, e) => CapNhatTrangThai("Đã đóng cửa sổ \"" + frm.Text + "\".");
            frm.Show();
            CapNhatTrangThai("Đã mở cửa sổ \"" + frm.Text + "\".");
        }

        // ========================================================
        // 4. MENU DANH MỤC + TOOLSTRIP + CONTEXTMENU
        // ========================================================
        private void MoFormSinhVien_Click(object sender, EventArgs e)
        {
            MoFormCon<FormStudent>();
        }

        private void MoFormSanPham_Click(object sender, EventArgs e)
        {
            MoFormCon<FormProduct>();
        }

        // ========================================================
        // 5. MENU CỬA SỔ (WINDOW): SẮP XẾP CỬA SỔ CON
        // ========================================================
        private void Cascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
            CapNhatTrangThai("Đã sắp xếp cửa sổ kiểu Cascade.");
        }

        private void TileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
            CapNhatTrangThai("Đã sắp xếp cửa sổ kiểu Tile Horizontal.");
        }

        private void TileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
            CapNhatTrangThai("Đã sắp xếp cửa sổ kiểu Tile Vertical.");
        }

        private void DongTatCa_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
            CapNhatTrangThai("Đã đóng tất cả cửa sổ.");
        }

        // ========================================================
        // 6. MENU HỆ THỐNG: ĐĂNG XUẤT, THOÁT
        // ========================================================
        // Nút Đăng xuất / Đăng nhập lại (bấm luân phiên)
        private void DangXuat_Click(object sender, EventArgs e)
        {
            if (daDangNhap)
            {
                if (MessageBox.Show("Bạn có muốn đăng xuất?", "Đăng xuất",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                // Đóng toàn bộ Form con
                foreach (Form f in this.MdiChildren)
                {
                    f.Close();
                }

                daDangNhap = false;
                CapNhatGiaoDienDangNhap();
                CapNhatTrangThai("Đã đăng xuất. Chọn \"Đăng nhập\" để sử dụng lại.");
            }
            else
            {
                daDangNhap = true;
                CapNhatGiaoDienDangNhap();
                CapNhatTrangThai("Đăng nhập lại thành công. Xin chào " + tenNguoiDung + "!");
            }
        }

        // Bật / tắt các chức năng theo trạng thái đăng nhập
        private void CapNhatGiaoDienDangNhap()
        {
            mnuDanhMuc.Enabled = daDangNhap;
            mnuCuaSo.Enabled = daDangNhap;
            tsbSinhVien.Enabled = daDangNhap;
            tsbSanPham.Enabled = daDangNhap;
            tsbCascade.Enabled = daDangNhap;
            tsbTileHorizontal.Enabled = daDangNhap;
            tsbTileVertical.Enabled = daDangNhap;
            cmsMain.Enabled = daDangNhap;

            mnuDangXuat.Text = daDangNhap ? "Đăng xuất" : "Đăng nhập";
            tsbDangXuat.Text = mnuDangXuat.Text;
            lblNguoiDung.Text = "Người dùng: " + (daDangNhap ? tenNguoiDung : "(chưa đăng nhập)");
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // ========================================================
        // 7. ĐỒNG HỒ HỆ THỐNG TRÊN STATUSSTRIP
        // ========================================================
        private void tmrDongHo_Tick(object sender, EventArgs e)
        {
            lblThoiGian.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
