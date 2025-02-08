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
    public partial class Form4 : Form
    {
        private bool isPasswordVisible = false;
        private string taiKhoan;
        public Form4()
        {
            InitializeComponent();
            txtTaiKhoan.Text = "Nhập tài khoản";
            txtTaiKhoan.ForeColor = Color.Gray;
            txtMk.Text = "Nhập mật khẩu";
            txtMk.ForeColor = Color.Gray;

            btnHienMatKhau.ImageIndex = 1;
        }

        private void txtTaiKhoan_Enter(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "Nhập tài khoản")
            {
                txtTaiKhoan.Text = "";
                txtTaiKhoan.ForeColor = Color.Black;
            }
        }

        

        private void txtMk_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMk.Text))
            {
                txtMk.Text = "Nhập mật khẩu";
                txtMk.ForeColor = Color.Gray;
                txtMk.PasswordChar = '\0'; // Hiển thị văn bản bình thường
            }
        }

        private void txtTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text))
            {
                txtTaiKhoan.Text = "Nhập tài khoản";
                txtTaiKhoan.ForeColor = Color.Gray;
            }
        }

        private void btnHienMatKhau_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                txtMk.PasswordChar = '\0'; // Hiển thị mật khẩu
                btnHienMatKhau.ImageIndex = 0; // Biểu tượng mắt mở
            }
            else
            {
                txtMk.PasswordChar = '*'; // Ẩn mật khẩu
                btnHienMatKhau.ImageIndex = 1; // Biểu tượng mắt nhắm
            }
        }

        private void txtMk_Enter(object sender, EventArgs e)
        {
            if (txtMk.Text == "Nhập mật khẩu")
            {
                txtMk.Text = ""; // Xóa placeholder
                txtMk.ForeColor = Color.Black;
                txtMk.PasswordChar = '*'; // Kích hoạt ẩn mật khẩu
            }
        }

        private void txtMk_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMk.Text))
            {
                txtMk.Text = "Nhập mật khẩu";
                txtMk.ForeColor = Color.Gray;
                txtMk.PasswordChar = '\0'; // Hiển thị lại placeholder
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTaiKhoan.Text;
            string matKhau = txtMk.Text;

            // Kiểm tra nếu người dùng nhập placeholder
            if (tenDangNhap == "Nhập tài khoản" || matKhau == "Nhập mật khẩu")
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string ketnoi = ConfigurationManager.ConnectionStrings["qltv"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(ketnoi))
            {
                try
                {
                    cnn.Open(); // Mở kết nối

                    using (SqlCommand cmd = new SqlCommand(@"
                                SELECT tk.sLoaitk, tk.sMadocgia 
                                FROM tblTaiKhoan tk
                                LEFT JOIN tblDocGia dg ON tk.sMadocgia = dg.sMadocgia
                                WHERE tk.sTentk = @TenDangNhap 
                                AND tk.sMatkhau = @MatKhau
                                AND tk.isDeleted = 0
                                AND (dg.isDeleted = 0 OR tk.sMadocgia IS NULL)", cnn))
                    {
                        cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                        cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string loaiTaiKhoan = reader["sLoaitk"].ToString();
                                string maDocGia = reader["sMadocgia"]?.ToString();
                                taiKhoan = tenDangNhap; // Gán giá trị cho taiKhoan

                                if (loaiTaiKhoan == "Admin")
                                {
                                    Form1 formQuanLy = new Form1();
                                    formQuanLy.Show();
                                }
                                else if (loaiTaiKhoan == "Docgia")
                                {
                                    Form5 formDocGia = new Form5(maDocGia, taiKhoan);
                                    formDocGia.Show();
                                }

                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng, hoặc tài khoản đã bị xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu có lỗi xảy ra
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cnn.Close(); // Đóng kết nối sau khi hoàn thành
                }
            }
        }

        private void txtMk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick(); // Kích hoạt sự kiện Click của btnDangNhap
            }
        }

        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick(); // Kích hoạt sự kiện Click của btnDangNhap
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
