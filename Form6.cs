using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace QuanLyThuVien
{
    public partial class Form6 : Form
    {
        private string ketnoi;
        private string taiKhoan;
        private bool isPasswordVisible = false;

        public Form6(string taiKhoan)
        {
            InitializeComponent();
            this.taiKhoan = taiKhoan;
            ketnoi = ConfigurationManager.ConnectionStrings["qltv"].ConnectionString;

            txtTaiKhoan.Text = taiKhoan;
            txtTaiKhoan.Enabled = false;
            button5.ImageIndex = 1;
            button4.ImageIndex = 1;
            button1.ImageIndex = 1;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string matKhauCu = txtMatKhauCu.Text;
            string matKhauMoi = txtMatKhauMoi.Text;
            string xacNhanMatKhau = txtXacNhanMatKhau.Text;

            // Kiểm tra các trường không được để trống
            if (string.IsNullOrEmpty(matKhauCu) || string.IsNullOrEmpty(matKhauMoi) || string.IsNullOrEmpty(xacNhanMatKhau))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra mật khẩu mới và xác nhận mật khẩu phải giống nhau
            if (matKhauMoi != xacNhanMatKhau)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra mật khẩu cũ có đúng không
            if (!KiemTraMatKhauCu(taiKhoan, matKhauCu))
            {
                MessageBox.Show("Mật khẩu cũ không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cập nhật mật khẩu mới vào cơ sở dữ liệu
            if (DoiMatKhau(taiKhoan, matKhauMoi))
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool KiemTraMatKhauCu(string taiKhoan, string matKhauCu)
        {
            using (SqlConnection cnn = new SqlConnection(ketnoi))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tblTaiKhoan WHERE sTentk = @TaiKhoan AND sMatkhau = @MatKhauCu", cnn))
                {
                    cmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                    cmd.Parameters.AddWithValue("@MatKhauCu", matKhauCu);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0; // Trả về true nếu mật khẩu cũ đúng
                }
            }
        }

        private bool DoiMatKhau(string taiKhoan, string matKhauMoi)
        {
            using (SqlConnection cnn = new SqlConnection(ketnoi))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE tblTaiKhoan SET sMatkhau = @MatKhauMoi WHERE sTentk = @TaiKhoan", cnn))
                {
                    cmd.Parameters.AddWithValue("@MatKhauMoi", matKhauMoi);
                    cmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0; // Trả về true nếu cập nhật thành công
                }
            }
        }

        private void txtMatKhauCu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDoiMatKhau.PerformClick(); // Kích hoạt sự kiện Click của btnDangNhap
            }
        }

        private void txtMatKhauMoi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDoiMatKhau.PerformClick(); // Kích hoạt sự kiện Click của btnDangNhap
            }
        }

        private void txtXacNhanMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDoiMatKhau.PerformClick(); // Kích hoạt sự kiện Click của btnDangNhap
            }
        }

        private void btnHienMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                txtMatKhauCu.PasswordChar = '\0'; // Hiển thị mật khẩu
                button1.ImageIndex = 0; // Biểu tượng mắt mở
            }
            else
            {
                txtMatKhauCu.PasswordChar = '*'; // Ẩn mật khẩu
                button1.ImageIndex = 1; // Biểu tượng mắt nhắm
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                txtMatKhauMoi.PasswordChar = '\0'; // Hiển thị mật khẩu
                button4.ImageIndex = 0; // Biểu tượng mắt mở
            }
            else
            {
                txtMatKhauMoi.PasswordChar = '*'; // Ẩn mật khẩu
                button4.ImageIndex = 1; // Biểu tượng mắt nhắm
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                txtXacNhanMatKhau.PasswordChar = '\0'; // Hiển thị mật khẩu
                button5.ImageIndex = 0; // Biểu tượng mắt mở
            }
            else
            {
                txtXacNhanMatKhau.PasswordChar = '*'; // Ẩn mật khẩu
                button5.ImageIndex = 1; // Biểu tượng mắt nhắm
            }
        }
    }
}
