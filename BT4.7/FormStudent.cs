using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT4._7
{
    // Form Quản lý Sinh viên (lấy từ Bài 4.6), chạy dưới dạng MDI Child của FormMain
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }

        // ========================================================
        // 1. CLASS STUDENT
        // ========================================================
        public class Student
        {
            public string StudentId { get; set; }
            public string FullName { get; set; }
            public int Age { get; set; }
            public string Gender { get; set; }
            public string AvatarPath { get; set; }
        }

        // ========================================================
        // 2. KHAI BÁO BIẾN TOÀN CỤC
        // ========================================================
        BindingList<Student> studentList = new BindingList<Student>();
        BindingSource bs = new BindingSource();

        // ========================================================
        // 3. GỬI THÔNG ĐIỆP LÊN FORM CHA (MDI PARENT)
        //    MdiParent chính là FormMain -> gọi hàm public CapNhatTrangThai
        //    để cập nhật dòng chữ trên StatusStrip của FormMain.
        // ========================================================
        private void GuiThongBao(string thongBao)
        {
            FormMain main = this.MdiParent as FormMain;
            if (main != null)
            {
                main.CapNhatTrangThai("[Sinh viên] " + thongBao);
            }
        }

        // ========================================================
        // 4. FORM LOAD
        // ========================================================
        private void FormStudent_Load(object sender, EventArgs e)
        {
            // ComboBox giới tính: chỉ cho chọn, không cho gõ tự do
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.Items.Clear();
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });

            numTuoi.Minimum = 0;
            numTuoi.Maximum = 150;

            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            textBox1.ReadOnly = true; // Đường dẫn ảnh chỉ được đổi qua nút "Chọn"

            // TẠO SẴN 1 NGƯỜI TRONG BẢNG DỮ LIỆU
            studentList.Add(new Student
            {
                StudentId = "SV001",
                FullName = "Lê Minh Dũng",
                Age = 20,
                Gender = "Nam",
                AvatarPath = ""
            });

            // Cấu hình nguồn dữ liệu
            bs.DataSource = studentList;
            dgvStudents.DataSource = bs;

            // Lưới chỉ dùng để XEM và CHỌN dòng.
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.ReadOnly = true;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.MultiSelect = false;

            // Khi đổi dòng thì ĐỔ dữ liệu ra form,
            // còn Thêm / Cập nhật thì mới GHI dữ liệu từ form vào danh sách.
            bs.CurrentChanged += Bs_CurrentChanged;
            HienThiSinhVien(bs.Current as Student);
        }

        // ========================================================
        // 5. HÀM XỬ LÝ KHI ĐỔI DÒNG TRÊN LƯỚI
        // ========================================================
        private void Bs_CurrentChanged(object sender, EventArgs e)
        {
            HienThiSinhVien(bs.Current as Student);
        }

        // Đổ thông tin 1 sinh viên ra các ô nhập
        private void HienThiSinhVien(Student s)
        {
            if (s == null)
            {
                XoaTrangForm();
                return;
            }

            txtMaSV.Text = s.StudentId;
            txtHoTen.Text = s.FullName;
            numTuoi.Value = Math.Max(numTuoi.Minimum, Math.Min(numTuoi.Maximum, s.Age));
            cboGioiTinh.SelectedIndex = cboGioiTinh.Items.IndexOf(s.Gender ?? "");
            textBox1.Text = s.AvatarPath;
            HienThiAnh(s.AvatarPath);
        }

        // Làm trống các ô nhập
        private void XoaTrangForm()
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            numTuoi.Value = numTuoi.Minimum;
            cboGioiTinh.SelectedIndex = -1;
            textBox1.Clear();
            HienThiAnh(null);
            txtMaSV.Focus();
        }

        private void HienThiAnh(string path)
        {
            if (!string.IsNullOrEmpty(path) && File.Exists(path))
                picAvatar.ImageLocation = path;
            else
                picAvatar.ImageLocation = null;
        }

        // ========================================================
        // 6. KIỂM TRA DỮ LIỆU NHẬP
        //    dangSua = null      -> đang THÊM mới
        //    dangSua = sinh viên -> đang CẬP NHẬT sinh viên đó
        // ========================================================
        private bool KiemTraDuLieu(Student dangSua)
        {
            string maSV = txtMaSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();

            if (maSV == "")
            {
                MessageBox.Show("Vui lòng nhập Mã sinh viên!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaSV.Focus();
                return false;
            }

            if (hoTen == "")
            {
                MessageBox.Show("Vui lòng nhập Họ và tên!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                return false;
            }

            if (numTuoi.Value <= 0)
            {
                MessageBox.Show("Tuổi phải lớn hơn 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numTuoi.Focus();
                numTuoi.Select(0, numTuoi.Text.Length);
                return false;
            }

            if (cboGioiTinh.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn Giới tính!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboGioiTinh.Focus();
                return false;
            }

            // Không cho trùng mã sinh viên (bỏ qua chính sinh viên đang sửa)
            bool trungMa = studentList.Any(s => s != dangSua &&
                string.Equals(s.StudentId, maSV, StringComparison.OrdinalIgnoreCase));
            if (trungMa)
            {
                MessageBox.Show($"Mã sinh viên \"{maSV}\" đã tồn tại!", "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSV.Focus();
                txtMaSV.SelectAll();
                return false;
            }

            return true;
        }

        // ========================================================
        // 7. CHỨC NĂNG: CHỌN ẢNH ĐẠI DIỆN
        // ========================================================
        private void btnChọnAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Title = "Chọn ảnh đại diện";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = ofd.FileName;
                    HienThiAnh(ofd.FileName);
                    GuiThongBao("Đã chọn ảnh: " + Path.GetFileName(ofd.FileName) + " (bấm Thêm/Cập nhật để lưu).");
                }
            }
        }

        // ========================================================
        // 8. CÁC CHỨC NĂNG CRUD (THÊM, CẬP NHẬT, XÓA)
        //    Thành công -> gửi thông điệp lên StatusStrip của FormMain
        // ========================================================

        // THÊM: tạo một đối tượng Student MỚI từ dữ liệu trên form
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu(null)) return;

            Student sv = new Student
            {
                StudentId = txtMaSV.Text.Trim(),
                FullName = txtHoTen.Text.Trim(),
                Age = (int)numTuoi.Value,
                Gender = cboGioiTinh.SelectedItem.ToString(),
                AvatarPath = textBox1.Text
            };

            studentList.Add(sv);
            bs.Position = bs.IndexOf(sv); // Chọn luôn dòng vừa thêm

            GuiThongBao($"Thêm thành công sinh viên {sv.StudentId} - {sv.FullName}.");
        }

        // CẬP NHẬT: ghi dữ liệu trên form vào sinh viên ĐANG CHỌN
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Student current = bs.Current as Student;
            if (current == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần cập nhật trên bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!KiemTraDuLieu(current)) return;

            current.StudentId = txtMaSV.Text.Trim();
            current.FullName = txtHoTen.Text.Trim();
            current.Age = (int)numTuoi.Value;
            current.Gender = cboGioiTinh.SelectedItem.ToString();
            current.AvatarPath = textBox1.Text;

            bs.ResetCurrentItem(); // Làm mới dòng tương ứng trên lưới
            GuiThongBao($"Cập nhật thành công sinh viên {current.StudentId} - {current.FullName}.");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Student current = bs.Current as Student;
            if (current == null)
            {
                MessageBox.Show("Không có sinh viên nào để xóa!", "Thông báo");
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa sinh viên {current.FullName}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bs.RemoveCurrent();
                HienThiSinhVien(bs.Current as Student); // Hết dữ liệu thì form tự trống
                GuiThongBao($"Xóa thành công sinh viên {current.StudentId} - {current.FullName}.");
            }
        }

        // ========================================================
        // 9. CHỨC NĂNG: XUẤT FILE CSV
        // ========================================================
        private static string CsvField(string value)
        {
            if (string.IsNullOrEmpty(value)) return "";
            if (value.Contains(",") || value.Contains("\"") || value.Contains("\n"))
                return "\"" + value.Replace("\"", "\"\"") + "\"";
            return value;
        }

        private void btnXuatCSV_Click(object sender, EventArgs e)
        {
            if (studentList.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV File (*.csv)|*.csv";
                sfd.FileName = "DanhSachSinhVien.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // UTF-8 có BOM để Excel đọc đúng tiếng Việt
                        using (StreamWriter sw = new StreamWriter(sfd.FileName, false, new UTF8Encoding(true)))
                        {
                            sw.WriteLine("Mã SV,Họ và Tên,Tuổi,Giới tính,Đường dẫn ảnh");
                            foreach (Student std in studentList)
                            {
                                sw.WriteLine(string.Join(",",
                                    CsvField(std.StudentId),
                                    CsvField(std.FullName),
                                    std.Age,
                                    CsvField(std.Gender),
                                    CsvField(std.AvatarPath)));
                            }
                        }
                        GuiThongBao($"Xuất file CSV thành công ({studentList.Count} sinh viên): {sfd.FileName}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi xuất file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // ========================================================
        // 10. CONTEXTMENUSTRIP TRÊN DATAGRIDVIEW
        // ========================================================

        // Click chuột phải lên dòng nào thì chọn luôn dòng đó trước khi hiện menu
        private void dgvStudents_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                bs.Position = e.RowIndex;
            }
        }

        private void cmsXemChiTiet_Click(object sender, EventArgs e)
        {
            Student s = bs.Current as Student;
            if (s == null)
            {
                MessageBox.Show("Chưa chọn sinh viên nào!", "Thông báo");
                return;
            }

            string chiTiet =
                "Mã SV:          " + s.StudentId + "\n" +
                "Họ và tên:     " + s.FullName + "\n" +
                "Tuổi:             " + s.Age + "\n" +
                "Giới tính:      " + s.Gender + "\n" +
                "Ảnh đại diện: " + (string.IsNullOrEmpty(s.AvatarPath) ? "(chưa có)" : s.AvatarPath);

            MessageBox.Show(chiTiet, "Chi tiết sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GuiThongBao("Xem chi tiết sinh viên " + s.StudentId + ".");
        }

        private void cmsLamMoi_Click(object sender, EventArgs e)
        {
            bs.ResetBindings(false);                // Vẽ lại toàn bộ lưới
            HienThiSinhVien(bs.Current as Student); // Đổ lại dữ liệu dòng đang chọn
            GuiThongBao($"Đã làm mới dữ liệu ({studentList.Count} sinh viên).");
        }

        private void cmsXoaDong_Click(object sender, EventArgs e)
        {
            btnXoa_Click(sender, e); // Dùng lại chức năng của nút Xóa
        }

        // ========================================================
        // CÁC HÀM SỰ KIỆN RÁC (HÃY ĐỂ TRỐNG - TUYỆT ĐỐI KHÔNG XÓA)
        // ========================================================
        private void label4_Click(object sender, EventArgs e) { }
        private void txtMaSV_TextChanged(object sender, EventArgs e) { }
        private void txtHoTen_TextChanged(object sender, EventArgs e) { }
        private void numTuoi_ValueChanged(object sender, EventArgs e) { }
        private void cboGioiTinh_SelectedIndexChanged(object sender, EventArgs e) { }
        private void picAvatar_Click(object sender, EventArgs e) { }
        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
    }
}
