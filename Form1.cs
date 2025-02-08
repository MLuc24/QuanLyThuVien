using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Owner = this;
            f2.Show();
        }

        private void quảnLýĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f2 = new Form3();
            f2.Owner = this;
            f2.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 formDangNhap = new Form4();
            formDangNhap.Show();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýMượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f2 = new Form7();
            f2.Owner = this;
            f2.Show();
        }

        private void báoCáoPhiếuTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f2 = new Form9();
            f2.Owner = this;
            f2.Show();
        }

        private void báoCáoThểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 f2 = new Form10();
            f2.Owner = this;
            f2.Show();
        }

        private void lịchSửPhiếuTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 f2 = new Form11();
            f2.Owner = this;
            f2.Show();
        }
    }
}
