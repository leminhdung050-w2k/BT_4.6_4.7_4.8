using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT4._8
{
    // Form Quản lý Sản phẩm, chạy dưới dạng MDI Child của FormMain
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }

        // ========================================================
        // 1. CLASS PRODUCT
        // ========================================================
        public class Product
        {
            public string ProductId { get; set; }
            public string ProductName { get; set; }
            public decimal UnitPrice { get; set; }
            public int Quantity { get; set; }
            public string Category { get; set; }
        }

        // ========================================================
        // 2. KHAI BÁO BIẾN TOÀN CỤC
        // ========================================================
        BindingList<Product> productList = new BindingList<Product>();
        BindingSource bs = new BindingSource();

        // ========================================================
        // 3. GỬI THÔNG ĐIỆP LÊN FORM CHA (MDI PARENT)
        // ========================================================
        private void GuiThongBao(string thongBao)
        {
            FormMain main = this.MdiParent as FormMain;
            if (main != null)
            {
                main.CapNhatTrangThai("[Sản phẩm] " + thongBao);
            }
        }

        // ========================================================
        // 4. FORM LOAD
        // ========================================================
        private void FormProduct_Load(object sender, EventArgs e)
        {
            cboDanhMuc.Items.AddRange(new object[] { "Điện thoại", "Laptop", "Máy tính bảng", "Phụ kiện" });

            // Dữ liệu mẫu
            productList.Add(new Product { ProductId = "SP01", ProductName = "iPhone 15", UnitPrice = 22000000, Quantity = 10, Category = "Điện thoại" });
            productList.Add(new Product { ProductId = "SP02", ProductName = "Dell XPS 13", UnitPrice = 30000000, Quantity = 5, Category = "Laptop" });
            productList.Add(new Product { ProductId = "SP03", ProductName = "Tai nghe AirPods", UnitPrice = 4500000, Quantity = 20, Category = "Phụ kiện" });

            bs.DataSource = productList;
            dgvProducts.DataSource = bs;

            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.ReadOnly = true;
            dgvProducts.MultiSelect = false;

            dgvProducts.Columns["ProductId"].HeaderText = "Mã SP";
            dgvProducts.Columns["ProductName"].HeaderText = "Tên sản phẩm";
            dgvProducts.Columns["UnitPrice"].HeaderText = "Đơn giá";
            dgvProducts.Columns["Quantity"].HeaderText = "Số lượng";
            dgvProducts.Columns["Category"].HeaderText = "Danh mục";
            dgvProducts.Columns["UnitPrice"].DefaultCellStyle.Format = "N0";

            bs.CurrentChanged += Bs_CurrentChanged;
            HienThiSanPham(bs.Current as Product);
        }

        // ========================================================
        // 5. ĐỔI DÒNG -> ĐỔ DỮ LIỆU RA CÁC Ô NHẬP
        // ========================================================
        private void Bs_CurrentChanged(object sender, EventArgs e)
        {
            HienThiSanPham(bs.Current as Product);
        }

        private void HienThiSanPham(Product p)
        {
            if (p == null)
            {
                txtMaSP.Clear();
                txtTenSP.Clear();
                numDonGia.Value = 0;
                numSoLuong.Value = 0;
                cboDanhMuc.SelectedIndex = -1;
                return;
            }

            txtMaSP.Text = p.ProductId;
            txtTenSP.Text = p.ProductName;
            numDonGia.Value = Math.Min(numDonGia.Maximum, p.UnitPrice);
            numSoLuong.Value = Math.Min(numSoLuong.Maximum, p.Quantity);
            cboDanhMuc.SelectedIndex = cboDanhMuc.Items.IndexOf(p.Category ?? "");
        }

        // ========================================================
        // 6. KIỂM TRA DỮ LIỆU NHẬP
        // ========================================================
        private bool KiemTraDuLieu(Product dangSua)
        {
            string maSP = txtMaSP.Text.Trim();

            if (maSP == "" || txtTenSP.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Mã và Tên sản phẩm!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cboDanhMuc.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn Danh mục!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboDanhMuc.Focus();
                return false;
            }

            bool trungMa = productList.Any(p => p != dangSua &&
                string.Equals(p.ProductId, maSP, StringComparison.OrdinalIgnoreCase));
            if (trungMa)
            {
                MessageBox.Show($"Mã sản phẩm \"{maSP}\" đã tồn tại!", "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSP.Focus();
                return false;
            }

            return true;
        }

        // ========================================================
        // 7. THÊM, CẬP NHẬT, XÓA
        // ========================================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu(null)) return;

            Product p = new Product
            {
                ProductId = txtMaSP.Text.Trim(),
                ProductName = txtTenSP.Text.Trim(),
                UnitPrice = numDonGia.Value,
                Quantity = (int)numSoLuong.Value,
                Category = cboDanhMuc.SelectedItem.ToString()
            };

            productList.Add(p);
            bs.Position = bs.IndexOf(p);
            GuiThongBao($"Thêm thành công sản phẩm {p.ProductId} - {p.ProductName}.");
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Product current = bs.Current as Product;
            if (current == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!KiemTraDuLieu(current)) return;

            current.ProductId = txtMaSP.Text.Trim();
            current.ProductName = txtTenSP.Text.Trim();
            current.UnitPrice = numDonGia.Value;
            current.Quantity = (int)numSoLuong.Value;
            current.Category = cboDanhMuc.SelectedItem.ToString();

            bs.ResetCurrentItem();
            GuiThongBao($"Cập nhật thành công sản phẩm {current.ProductId} - {current.ProductName}.");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Product current = bs.Current as Product;
            if (current == null)
            {
                MessageBox.Show("Không có sản phẩm nào để xóa!", "Thông báo");
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa sản phẩm {current.ProductName}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bs.RemoveCurrent();
                HienThiSanPham(bs.Current as Product);
                GuiThongBao($"Xóa thành công sản phẩm {current.ProductId} - {current.ProductName}.");
            }
        }

        // ========================================================
        // 8. CONTEXTMENUSTRIP TRÊN DATAGRIDVIEW
        // ========================================================
        private void dgvProducts_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                bs.Position = e.RowIndex;
            }
        }

        private void cmsXemChiTiet_Click(object sender, EventArgs e)
        {
            Product p = bs.Current as Product;
            if (p == null)
            {
                MessageBox.Show("Chưa chọn sản phẩm nào!", "Thông báo");
                return;
            }

            string chiTiet =
                "Mã SP:        " + p.ProductId + "\n" +
                "Tên SP:       " + p.ProductName + "\n" +
                "Đơn giá:     " + p.UnitPrice.ToString("N0") + " đ\n" +
                "Số lượng:    " + p.Quantity + "\n" +
                "Danh mục:   " + p.Category + "\n" +
                "Thành tiền: " + (p.UnitPrice * p.Quantity).ToString("N0") + " đ";

            MessageBox.Show(chiTiet, "Chi tiết sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GuiThongBao("Xem chi tiết sản phẩm " + p.ProductId + ".");
        }

        private void cmsLamMoi_Click(object sender, EventArgs e)
        {
            bs.ResetBindings(false);
            HienThiSanPham(bs.Current as Product);
            GuiThongBao($"Đã làm mới dữ liệu ({productList.Count} sản phẩm).");
        }

        private void cmsXoaDong_Click(object sender, EventArgs e)
        {
            btnXoa_Click(sender, e);
        }

        // ========================================================
        // 9. NẠP DỮ LIỆU BẤT ĐỒNG BỘ (ASYNC/AWAIT) + PROGRESSBAR
        // ========================================================

        // Dùng để hủy tác vụ nếu người dùng đóng Form khi đang nạp dữ liệu
        private CancellationTokenSource cts;

        // Phương thức nạp dữ liệu bất đồng bộ dạng async Task<List<T>>
        private async Task<List<Product>> NapDanhSachSanPhamAsync(int soLuong, bool giaLapLoi,
            IProgress<int> progress, CancellationToken token)
        {
            List<Product> ketQua = await Task.Run(() =>
            {
                string[] danhMuc = { "Điện thoại", "Laptop", "Máy tính bảng", "Phụ kiện" };
                string[] thuongHieu = { "Samsung", "Apple", "Xiaomi", "Dell", "Asus", "Lenovo", "Sony", "Oppo" };
                Random rnd = new Random();
                List<Product> ds = new List<Product>();

                for (int i = 1; i <= soLuong; i++)
                {
                    token.ThrowIfCancellationRequested(); // Form đã đóng -> dừng ngay

                    Thread.Sleep(30); // Giả lập thời gian đọc 1 bản ghi từ CSDL / File

                    if (giaLapLoi && i == soLuong / 2)
                        throw new IOException("Không đọc được file dữ liệu sản phẩm tại dòng " + i + "!");

                    string dm = danhMuc[rnd.Next(danhMuc.Length)];
                    ds.Add(new Product
                    {
                        ProductId = "SP" + i.ToString("D3"),
                        ProductName = dm + " " + thuongHieu[rnd.Next(thuongHieu.Length)] + " " + rnd.Next(10, 99),
                        UnitPrice = rnd.Next(5, 400) * 100000,
                        Quantity = rnd.Next(0, 100),
                        Category = dm
                    });

                    progress.Report(i * 100 / soLuong); // Báo % về UI Thread
                }
                return ds;
            }, token);

            return ketQua;
        }

        private async void btnNapDuLieu_Click(object sender, EventArgs e)
        {
            FormMain main = this.MdiParent as FormMain;

            // Progress<int> tạo trên UI Thread -> hàm cập nhật luôn chạy trên UI Thread
            Progress<int> progress = new Progress<int>(phanTram =>
            {
                if (this.IsDisposed) return;
                pbNapDuLieu.Value = phanTram;
                lblPhanTram.Text = phanTram + "%";
                if (main != null) main.CapNhatTienTrinh("Nạp sản phẩm", phanTram);
            });

            btnNapDuLieu.Enabled = false; // Khóa nút để tránh bấm trùng lặp
            pbNapDuLieu.Value = 0;
            lblPhanTram.Text = "0%";
            GuiThongBao("Đang nạp dữ liệu sản phẩm...");
            cts = new CancellationTokenSource();

            try
            {
                List<Product> ds = await NapDanhSachSanPhamAsync(150, chkGiaLapLoi.Checked, progress, cts.Token);
                if (this.IsDisposed) return;

                productList.RaiseListChangedEvents = false;
                productList.Clear();
                foreach (Product p in ds)
                {
                    productList.Add(p);
                }
                productList.RaiseListChangedEvents = true;
                bs.ResetBindings(false);
                HienThiSanPham(bs.Current as Product);

                GuiThongBao($"Nạp dữ liệu hoàn tất: {ds.Count} sản phẩm.");
                MessageBox.Show($"Nạp dữ liệu hoàn tất!\nĐã nạp {ds.Count} sản phẩm.", "Hoàn tất",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OperationCanceledException)
            {
                // Người dùng đóng Form khi đang nạp -> bỏ qua, không báo lỗi
            }
            catch (Exception ex)
            {
                GuiThongBao("Nạp dữ liệu sản phẩm thất bại: " + ex.Message);
                MessageBox.Show("Lỗi khi nạp dữ liệu:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (!this.IsDisposed) btnNapDuLieu.Enabled = true;
                if (main != null) main.KetThucTienTrinh();
                cts.Dispose();
                cts = null;
            }
        }

        // Đóng Form khi đang nạp -> hủy tác vụ ngầm
        private void FormProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cts != null) cts.Cancel();
        }
    }
}
