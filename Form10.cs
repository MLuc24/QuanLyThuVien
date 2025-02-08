using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.ComponentModel;

namespace QuanLyThuVien
{
    public partial class Form10 : Form
    {
        private string kn;
        private DataTable pm;
        private DataTable pt;
        public Form10()
        {
            InitializeComponent();
            kn = ConfigurationManager.ConnectionStrings["qltv"].ConnectionString;
            LoadDataDocGia();
            LoadDataTreHan();
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
                sum(iSlmuon) as [SL mượn],
                count(sMasach) as [Số lần mượn]
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
                ct.sTinhtrang as [Tình trạng],
                dNgaytra as [Ngày trả],
                DATEDIFF(day, dNgayhentra, dNgaytra) as [Trễ (ngày)]
            FROM 
                tblDocGia dg
                JOIN tblPhieumuon pt ON pt.sMadocgia = dg.sMadocgia
                JOIN tblPhieutra ct ON ct.sMaphieu = pt.sMaphieu
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

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
