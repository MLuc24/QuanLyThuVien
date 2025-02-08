﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.ComponentModel;

namespace QuanLyThuVien
{
    public partial class Form11 : Form
    {
        private string kn;
        private DataTable pt;
        public Form11()
        {
            InitializeComponent();
            kn = ConfigurationManager.ConnectionStrings["qltv"].ConnectionString;
            LoadData();
            btnXoa.Enabled = false;
        }



        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(kn))
            {
                string query = "SELECT * FROM v_DSPT";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                pt = new DataTable();
                adapter.Fill(pt);
                dgvPhieuMuonTra.DataSource = pt;
                dgvPhieuMuonTra.Columns["Ngày trả"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvPhieuMuonTra.Columns["Ngày hẹn trả"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void dgvPhieuMuonTra_SelectionChanged(object sender, EventArgs e)
        {
            btnXoa.Enabled = dgvPhieuMuonTra.SelectedRows.Count > 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvPhieuMuonTra.SelectedRows.Count > 0)
            {
                var selectedRow = dgvPhieuMuonTra.SelectedRows[0];
                string maPhieuTra = selectedRow.Cells["Mã phiếu"].Value.ToString();
                string maSach = selectedRow.Cells["Mã sách"].Value.ToString();

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu trả này không?", "Xác nhận xóa",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection cnn = new SqlConnection(kn))
                        {
                            cnn.Open();
                            using (SqlCommand cmd = cnn.CreateCommand())
                            {
                                cmd.CommandText = "UPDATE tblPhieutra SET IsDeleted = 1 WHERE sMaphieu = @MaPhieuTra AND sMasach = @MaSach";
                                cmd.Parameters.AddWithValue("@MaPhieuTra", maPhieuTra);
                                cmd.Parameters.AddWithValue("@MaSach", maSach);

                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Xóa phiếu trả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Không tìm thấy phiếu trả phù hợp để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }

                        LoadData(); // Cập nhật lại danh sách sau khi xóa
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa phiếu trả: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu trả cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
            

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}
