using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.ComponentModel;

namespace QuanLyThuVien
{
    public partial class FormUserReport : Form
    {
        private string kn;
        private DataTable pm;
        private DataTable pt;
        private string tenNhanVien;

        public FormUserReport(string tenNV)
        {
            InitializeComponent();
            kn = ConfigurationManager.ConnectionStrings["qltv"].ConnectionString;
            LoadDataDocGia();
            LoadDataTreHan();
            this.tenNhanVien = tenNV;
        }

        private void LoadDataDocGia()
        {
            using (SqlConnection connection = new SqlConnection(kn))
            {
                string query = @"
            SELECT 
                dg.sMadocgia AS [Mã độc giả],
                sTendocgia AS [Tên độc giả], 
                sTenloaidocgia AS [Loại độc giả],
                count(sMasach) as [Số lần mượn],
                sum(iSlmuon) as [SL mượn]
                
            FROM 
                tblDocGia dg
                JOIN tblPhieumuon pt ON pt.sMadocgia = dg.sMadocgia
                JOIN tblCTmuontra ct ON ct.sMaphieu = pt.sMaphieu
                JOIN tblLoaidocgia l On l.sMaloaidocgia = dg.sMaloaidocgia
            Group by dg.sMadocgia,sTendocgia,sTenloaidocgia
            ORDER BY 
               count(sMasach) desc";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                pm = new DataTable();
                adapter.Fill(pm);
                dgvDocGia.DataSource = pm;
            }
        }

        private void LoadDataTreHan()
        {
            using (SqlConnection connection = new SqlConnection(kn))
            {
                string query = @"
            SELECT 
                dg.sMadocgia AS [Mã độc giả],
                sTendocgia AS [Tên độc giả], 
                sTensach as [Tên sách],
                ct.sTinhtrangtra as [Tình trạng],
                dNgaytra as [Ngày trả],
                DATEDIFF(day, dNgayhentra, dNgaytra) as [Trễ (ngày)]
            FROM 
                tblDocGia dg
                JOIN tblPhieumuon pt ON pt.sMadocgia = dg.sMadocgia
                JOIN tblCTmuontra ct ON ct.sMaphieu = pt.sMaphieu
                JOIN tblSach s On s.sMasach = ct.sMasach
            WHERE 
                dNgaytra > dNgayhentra
            ORDER BY 
               dNgaytra ASC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                pt = new DataTable();
                adapter.Fill(pt);
                dgvTreHan.DataSource = pt;
                dgvTreHan.Columns["Ngày trả"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void dgvTreHan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(kn))
            {
                string sql = @"
            SELECT 
                ct.sMaphieu, 
                dg.sTendocgia, 
                s.sTensach, 
                ct.dNgayhentra, 
                ct.dNgaytra, 
                ct.iSlmuon, 
                ct.sTinhtrangtra,
                ct.sGhichu
            FROM tblCTmuontra ct 
            JOIN tblPhieumuon pm ON pm.sMaphieu = ct.sMaphieu
            JOIN tblDocGia dg ON pm.sMadocgia = dg.sMadocgia
            JOIN tblSach s ON ct.sMasach = s.sMasach
            WHERE ct.sTinhtrangtra IS NOT NULL AND ct.dNgaytra > ct.dNgayhentra";

                SqlDataAdapter da = new SqlDataAdapter(sql, connection);
                DataSet1 ds = new DataSet1();
                da.Fill(ds, "Danhsach");

                // Tạo báo cáo Crystal Report
                CrystalReport1 rpt = new CrystalReport1();
                rpt.SetDataSource(ds.Tables[1]);

                // Truyền giá trị "Tên nhân viên" vào báo cáo
                rpt.SetParameterValue("TenNhanVien", this.tenNhanVien);

                // Hiển thị báo cáo trên CrystalReportViewer
                FormInBaoCao f = new FormInBaoCao();
                f.crystalReportViewer1.ReportSource = rpt;
                f.ShowDialog();
            }
        }
    }
}
