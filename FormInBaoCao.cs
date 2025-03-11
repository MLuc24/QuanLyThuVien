using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;


namespace QuanLyThuVien
{
    public partial class FormInBaoCao : Form
    {
        //private string connectionString = ConfigurationManager.ConnectionStrings["qltv"].ConnectionString;
        //private string loaiBaoCao;
        //private string tenNhanVien;
        //private string maTheLoai; 
        //private string maPhieu;

        public FormInBaoCao(/*string loaiBaoCao, string tenNV, string maTheLoai = null, string maPhieu = null*/)
        {
            InitializeComponent();
            //this.loaiBaoCao = loaiBaoCao;
            //this.tenNhanVien = tenNV;
            //this.maTheLoai = maTheLoai;
            //this.maPhieu = maPhieu;
        }

        private void FormInBaoCao_Load(object sender, EventArgs e)
        {

        }
    }
}
