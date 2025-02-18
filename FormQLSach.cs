using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.ComponentModel;

namespace QuanLyThuVien
{
    public partial class FormQLSach : Form
    {
        private string ketnoi;
        private DataTable tb;
        private bool isAdding = false;


        public FormQLSach()
        {
            InitializeComponent();
            ketnoi = ConfigurationManager.ConnectionStrings["qltv"].ConnectionString;
            InitializeControls();
            this.KeyPreview = true;
        }

        private void LoadData()
        {
            using (SqlConnection cnn = new SqlConnection(ketnoi))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from v_DSS", cnn))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        tb = new DataTable();
                        ad.Fill(tb);
                        dssach.DataSource = tb;
                        dssach.Columns["Ngày nhập"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    }
                }
            }
        }

        private void LoadTheLoai()
        {
            using (SqlConnection cnn = new SqlConnection(ketnoi))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from tblTheloai", cnn))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable theLoaiTable = new DataTable();
                        ad.Fill(theLoaiTable);

                        cboMatheloai.DataSource = theLoaiTable;
                        cboMatheloai.DisplayMember = "sTentheloai";
                        cboMatheloai.ValueMember = "sMatheloai";   
                    }
                }
            }
        }

        private bool IsMaSachExists(string maSach)
        {
            using (SqlConnection cnn = new SqlConnection(ketnoi))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tblSach WHERE sMasach = @MaSach", cnn))
                {
                    cmd.Parameters.AddWithValue("@MaSach", maSach);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private bool IsTenSachExists(string tenSach)
        {
            using (SqlConnection cnn = new SqlConnection(ketnoi))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tblSach WHERE sTensach = @TenSach", cnn))
                {
                    cmd.Parameters.AddWithValue("@TenSach", tenSach);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void InitializeControls()
        {
            DisableTextBoxes();
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnAdd.Enabled = true;

            isAdding = false; 
            LoadTheLoai();

            cboMatheloai.SelectedIndex = 0; 
        }

        private void DisableTextBoxes()
        {
            txtMasach.Enabled = false;
            txtTensach.Enabled = false;
            txtNXB.Enabled = false;
            txtSl.Enabled = false;
            txtDongia.Enabled = false;
            cboMatheloai.Enabled = false;
            rdoMoi.Enabled = false;
            rdoCu.Enabled = false;
            dateTimePicker1.Enabled = false;
        }

        private void EnableTextBoxes()
        {
            txtMasach.Enabled = false;
            txtTensach.Enabled = true;
            txtNXB.Enabled = true;
            txtSl.Enabled = true;
            txtDongia.Enabled = true;
            cboMatheloai.Enabled = true;
            rdoMoi.Enabled = true;
            rdoCu.Enabled = true;
            dateTimePicker1.Enabled = true;

            
            txtMasach.Enabled = isAdding;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();

            rdoTenSach.Checked = false;
            rdoMaSach.Checked = false;
            rdoTheLoai.Checked = false;

            InitializeControls();
        }

        private void dssach_SelectionChanged(object sender, EventArgs e)
        {
            if (dssach.SelectedRows.Count > 0)
            {
                var selectedRow = dssach.SelectedRows[0];
                txtMasach.Text = selectedRow.Cells["Mã sách"].Value.ToString();
                txtTensach.Text = selectedRow.Cells["Tên sách"].Value.ToString();
                txtNXB.Text = selectedRow.Cells["NXB"].Value.ToString();
                txtSl.Text = selectedRow.Cells["Số lượng"].Value.ToString();
                txtDongia.Text = selectedRow.Cells["Đơn giá"].Value.ToString();
                cboMatheloai.SelectedValue = selectedRow.Cells["Mã thể loại"].Value.ToString();
                rdoMoi.Checked = selectedRow.Cells["Tình trạng"].Value.ToString() == "Mới";
                rdoCu.Checked = selectedRow.Cells["Tình trạng"].Value.ToString() == "Cũ";
                dateTimePicker1.Value = Convert.ToDateTime(selectedRow.Cells["Ngày nhập"].Value);

                DisableTextBoxes();
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                errorProvider1.SetError(txtMasach, "");
                errorProvider2.SetError(txtTensach, "");
                errorProvider3.SetError(txtSl, "");
                errorProvider4.SetError(txtDongia, "");
            }
        }

        private string GenerateNewMaSach()
        {
            using (SqlConnection cnn = new SqlConnection(ketnoi))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT TOP 1 sMasach FROM tblSach ORDER BY sMasach DESC", cnn))
                {
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        string lastMaSach = result.ToString();
                        int number = int.Parse(lastMaSach.Substring(1)) + 1; // Lấy số và tăng lên
                        return "S" + number.ToString("D4"); // Định dạng S0001
                    }
                    else
                    {
                        return "S0001"; // Nếu chưa có sách nào
                    }
                }
            }
        }

        private void ClearTextBoxes()
        {
            txtMasach.Text = string.Empty; // Đảm bảo mã sách không giữ lại
            txtTensach.Text = string.Empty;
            txtNXB.Text = string.Empty;
            txtSl.Text = string.Empty;
            txtDongia.Text = string.Empty;
            cboMatheloai.SelectedIndex = -1;
            rdoMoi.Checked = true;
            rdoCu.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAdding = true;
            EnableTextBoxes();
            ClearTextBoxes();

            txtMasach.Text = GenerateNewMaSach(); // Tự động gán mã sách mới
            txtMasach.Enabled = false;
            cboMatheloai.SelectedIndex = 0;
            rdoMoi.Checked = true;

            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dssach.SelectedRows.Count > 0)
            {
                isAdding = false; 
                EnableTextBoxes();

                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dssach.SelectedRows.Count > 0)
            {
                var selectedRow = dssach.SelectedRows[0];
                string maSach = selectedRow.Cells["Mã sách"].Value.ToString();

                // Hiển thị hộp thoại xác nhận xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sách này không?", "Xác nhận xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection cnn = new SqlConnection(ketnoi))
                        {
                            cnn.Open();
                            using (SqlCommand cmd = new SqlCommand("UPDATE tblSach SET IsDeleted = 1 WHERE sMasach = @MaSach", cnn))
                            {
                                cmd.Parameters.AddWithValue("@MaSach", maSach);

                                // Thực thi câu lệnh SQL và kiểm tra số dòng bị ảnh hưởng
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    // Hiển thị thông báo xóa thành công
                                    MessageBox.Show("Đã xóa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    // Hiển thị thông báo xóa thất bại
                                    MessageBox.Show("Xóa sách thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }

                        // Tải lại dữ liệu sau khi xóa
                        LoadData();
                        InitializeControls();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo lỗi nếu có ngoại lệ xảy ra
                        MessageBox.Show("Đã xảy ra lỗi khi xóa sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                ClearTextBoxes();
                dssach.ClearSelection();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtMasach, "");
            errorProvider2.SetError(txtTensach, "");
            errorProvider3.SetError(txtSl, "");
            errorProvider4.SetError(txtDongia, "");

            InitializeControls();
            isAdding = false;
            ClearTextBoxes(); // Xóa mã sách khi hủy
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Gọi các phương thức Validating một cách thủ công
            txtMasach_Validating(txtMasach, new CancelEventArgs());
            txtTensach_Validating(txtTensach, new CancelEventArgs());
            txtSl_Validating(txtSl, new CancelEventArgs());
            txtDongia_Validating(txtDongia, new CancelEventArgs());

            // Kiểm tra xem có lỗi nào không
            bool hasErrors =
                !string.IsNullOrEmpty(errorProvider1.GetError(txtMasach)) ||
                !string.IsNullOrEmpty(errorProvider2.GetError(txtTensach)) ||
                !string.IsNullOrEmpty(errorProvider3.GetError(txtSl)) ||
                !string.IsNullOrEmpty(errorProvider4.GetError(txtDongia));

            // Nếu có lỗi, không thực hiện lưu
            if (hasErrors)
            {
                MessageBox.Show("Vui lòng kiểm tra lại các thông tin nhập vào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection cnn = new SqlConnection(ketnoi))
            {
                cnn.Open();
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    if (isAdding)
                    {
                        // Chế độ thêm mới
                        cmd.CommandText = "INSERT INTO tblSach (sMasach, sTensach, sMatheloai, sNhaxuatban, dNgaynhap, fDongia, iSNhap, sTinhtrang, IsDeleted) " +
                                          "VALUES (@MaSach, @TenSach, @MaTheLoai, @NXB, @NgayNhap, @DonGia, @SoLuong, @TinhTrang, 0)"; // Thêm giá trị mặc định IsDeleted = 0
                    }
                    else
                    {
                        // Chế độ sửa
                        cmd.CommandText = "UPDATE tblSach SET sTensach = @TenSach, sNhaxuatban = @NXB, " +
                                          "iSNhap = @SoLuong, fDongia = @DonGia, sMatheloai = @MaTheLoai, " +
                                          "sTinhtrang = @TinhTrang, dNgaynhap = @NgayNhap WHERE sMasach = @MaSach";
                    }

                    cmd.Parameters.AddWithValue("@MaSach", txtMasach.Text);
                    cmd.Parameters.AddWithValue("@TenSach", txtTensach.Text);
                    cmd.Parameters.AddWithValue("@NXB", txtNXB.Text);
                    cmd.Parameters.AddWithValue("@SoLuong", int.Parse(txtSl.Text));
                    cmd.Parameters.AddWithValue("@DonGia", float.Parse(txtDongia.Text));
                    cmd.Parameters.AddWithValue("@MaTheLoai", cboMatheloai.SelectedValue);
                    cmd.Parameters.AddWithValue("@TinhTrang", rdoMoi.Checked ? "Mới" : "Cũ");
                    cmd.Parameters.AddWithValue("@NgayNhap", dateTimePicker1.Value);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Sách đã được lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // Sau khi lưu, đặt lại trạng thái ban đầu
            InitializeControls();
            LoadData();
        }



        private void txtSl_Validating(object sender, CancelEventArgs e)
        {
            if (txtSl.Text == "")
                errorProvider3.SetError(txtSl, "Số lượng không được để trống!");
            else
            {
                errorProvider3.SetError(txtSl, "");
                if (!int.TryParse(txtSl.Text, out int sl) || sl < 1)
                    errorProvider3.SetError(txtSl, "Số lượng tối thiểu là 1!");
                else errorProvider3.SetError(txtSl, "");
            }

        }

        private void PerformSearch()
        {
            string search = txtTimkiem.Text.Trim();
            string query = "";

            if (rdoMaSach.Checked)
                query = "SELECT * FROM v_DSS WHERE [Mã sách] = @Keyword "; // Thêm điều kiện IsDeleted = 0
            else if (rdoTenSach.Checked)
                query = "SELECT * FROM v_DSS WHERE [Tên sách] LIKE @Keyword "; // Thêm điều kiện IsDeleted = 0
            else if (rdoTheLoai.Checked)
                query = @"SELECT 
                sMasach AS [Mã sách],
                sTensach AS [Tên sách],
                s.sMatheloai AS [Mã thể loại],
                sNhaxuatban AS [NXB],
                dNgaynhap AS [Ngày nhập],
                fDongia AS [Đơn giá],
                iSNhap AS [Số lượng],
                sTinhtrang AS [Tình trạng]
            FROM tblSach s JOIN tblTheloai tl ON s.sMatheloai = tl.sMatheloai
            WHERE sTentheloai LIKE @Keyword AND isDeleted = 0"; // Thêm điều kiện IsDeleted = 0


            if (string.IsNullOrEmpty(search))
            {
                query = "SELECT * FROM v_DSS"; 
            }

            using (SqlConnection cnn = new SqlConnection(ketnoi))
            {
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    if (!string.IsNullOrEmpty(search))
                    {
                        if (rdoMaSach.Checked)
                            cmd.Parameters.AddWithValue("@Keyword", search);
                        else
                            cmd.Parameters.AddWithValue("@Keyword", "%" + search + "%");
                    }

                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable searchResult = new DataTable();
                        ad.Fill(searchResult);
                        dssach.DataSource = searchResult;
                        dssach.Refresh();
                    }
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadData();
            InitializeControls();
            ClearTextBoxes(); // Đảm bảo mã sách không còn hiển thị

            rdoTenSach.Checked = false;
            rdoMaSach.Checked = false;
            rdoTheLoai.Checked = false;

            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();

            txtTimkiem.Text = string.Empty;
        }

        private void txtTensach_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTensach.Text))
                errorProvider2.SetError(txtTensach, "Tên sách không được để trống!");
            else
            {
                if (isAdding && IsTenSachExists(txtTensach.Text))
                    errorProvider2.SetError(txtTensach, "Tên sách đã tồn tại!");
                else errorProvider2.SetError(txtTensach, "");
            }
        }

        private void txtDongia_Validating(object sender, CancelEventArgs e)
        {
            if (txtDongia.Text == "")
                errorProvider4.SetError(txtDongia, "Đơn giá không được để trống!");
            else
            {
                errorProvider4.SetError(txtDongia, "");
                if (!int.TryParse(txtDongia.Text, out int sl) || sl < 1)
                    errorProvider4.SetError(txtDongia, "Đơn giá không được âm!");
                else errorProvider4.SetError(txtDongia, "");
            }
        }

        private void txtMasach_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMasach.Text))
                errorProvider1.SetError(txtMasach, "Mã sách không được để trống!");
            else
            {
                if (isAdding && IsMaSachExists(txtMasach.Text))
                    errorProvider1.SetError(txtMasach, "Sách này đã tồn tại!");
                else errorProvider1.SetError(txtMasach, "");
            }
        }

        private void rdoMaSach_CheckedChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void rdoTenSach_CheckedChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }
    

        private void rdoTheLoai_CheckedChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }
    

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra nếu phím được nhấn là Esc
            if (e.KeyCode == Keys.Escape)
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn thoát form không?",
                    "Xác nhận thoát",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // Nếu người dùng chọn "Yes", đóng form
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }


        //private void btnRestore_Click(object sender, EventArgs e)
        //{
        //    if (dssach.SelectedRows.Count > 0)
        //    {
        //        var selectedRow = dssach.SelectedRows[0];
        //        string maSach = selectedRow.Cells["Mã sách"].Value.ToString();

        //        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn khôi phục sách này không?", "Xác nhận khôi phục",
        //            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //        if (result == DialogResult.Yes)
        //        {
        //            using (SqlConnection cnn = new SqlConnection(ketnoi))
        //            {
        //                cnn.Open();
        //                using (SqlCommand cmd = new SqlCommand("UPDATE tblSach SET IsDeleted = 0 WHERE sMasach = @MaSach", cnn))
        //                {
        //                    cmd.Parameters.AddWithValue("@MaSach", maSach);
        //                    cmd.ExecuteNonQuery();
        //                }
        //            }

        //            LoadData(); // Tải lại dữ liệu sau khi khôi phục
        //            InitializeControls();
        //        }
        //    }
        //}
    }
}