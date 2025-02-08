using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.ComponentModel;
namespace QuanLyThuVien
{
    public partial class Form8 : Form
    {
        private string kn;
        private DataTable pm;
        public Form8()
        {
            InitializeComponent();
            kn = ConfigurationManager.ConnectionStrings["qltv"].ConnectionString;
            LoadData();
        }
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(kn))
            {
                string query = "SELECT * FROM tblPhieuTra";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                pm = new DataTable();
                adapter.Fill(pm);
                dgvPhieuMuon.DataSource = pm;
            }
        }


        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
