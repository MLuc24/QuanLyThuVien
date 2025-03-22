using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Collections.Generic;



namespace QuanLyThuVien
{
    public partial class FormBaoCaoUser : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["qltv"].ConnectionString;
        private DataTable dtDocGiaMuon;
        private string tenNhanVien;

        public FormBaoCaoUser(string tenNV)
        {
            InitializeComponent();
            this.tenNhanVien = tenNV;
        }

        private void FormBaoCaoUser_Load(object sender, EventArgs e)
        {
            LoadThang();
            LoadLoaiDocGia();
            LoadData("1=1"); // Mặc định load toàn bộ dữ liệu
            LoadReport(dtDocGiaMuon);
        }

        private void LoadLoaiDocGia()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT sMaloaidocgia, sTenloaidocgia FROM tblLoaidocgia";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboMadocgia.DataSource = dt;
                cboMadocgia.DisplayMember = "sTenloaidocgia";
                cboMadocgia.ValueMember = "sMaloaidocgia";
                cboMadocgia.SelectedIndex = -1; // Không chọn gì ban đầu
            }
        }

        private void LoadData(string dieuKien)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ThongKeDocGiaMuonSach", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DieuKien", dieuKien); // Truyền điều kiện lọc động vào

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dtDocGiaMuon = new DataTable();
                da.Fill(dtDocGiaMuon);
            }
        }

        private void LoadReport(DataTable data)
        {
            CR_TK_DG rpt = new CR_TK_DG(); 
            rpt.SetDataSource(data); 
            rpt.SetParameterValue("TenNhanVien", this.tenNhanVien);

            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }

        private void LoadThang()
        {
            cboThang.Items.Clear();

            Dictionary<int, string> thangDict = new Dictionary<int, string>();

            for (int i = 1; i <= 12; i++)
            {
                thangDict.Add(i, i.ToString("00") + "/25"); // 01/25 - 12/25
            }

            cboThang.DataSource = new BindingSource(thangDict, null);
            cboThang.DisplayMember = "Value"; // Hiển thị "01/25" - "12/25"
            cboThang.ValueMember = "Key"; // Giá trị thực là 1-12
            cboThang.SelectedIndex = -1; // Không chọn gì lúc đầu (cả năm)
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string dieuKien = "1=1"; // Điều kiện mặc định

            // Lọc theo tên độc giả
            if (!string.IsNullOrEmpty(txtTendocgia.Text.Trim()))
            {
                dieuKien += $" AND dg.sTendocgia LIKE N'%{txtTendocgia.Text.Trim()}%'";
            }

            // Lọc theo loại độc giả
            if (cboMadocgia.SelectedIndex >= 0)
            {
                dieuKien += $" AND dg.sMaloaidocgia = '{cboMadocgia.SelectedValue}'";
            }

            // Lọc theo tháng
            if (cboThang.SelectedIndex >= 0)
            {
                int thang = ((KeyValuePair<int, string>)cboThang.SelectedItem).Key; // Lấy giá trị thực (1-12)
                dieuKien += $" AND MONTH(pt.dNgaymuon) = {thang}";
            }

            // Lọc theo ngày từ - đến
            DateTime fromDate = dtpFrom.Value.Date;
            DateTime toDate = dtpTo.Value.Date;

            if (fromDate <= toDate)
            {
                dieuKien += $" AND pt.dNgaymuon BETWEEN '{fromDate:yyyy-MM-dd}' AND '{toDate:yyyy-MM-dd}'";
            }
            else
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadData(dieuKien); // Truyền điều kiện lọc vào LoadData()
            LoadReport(dtDocGiaMuon);
        }
    }
}
