
namespace QuanLyThuVien
{
    partial class FormCTmuontra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCTmuontra));
            this.btnXem = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dgvPhieuCT = new System.Windows.Forms.DataGridView();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtTenDocGia = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.cboTinhTrangTra = new System.Windows.Forms.ComboBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dtpNgayHenTra = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.txtTimKiemTra = new System.Windows.Forms.TextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.rdoNHT = new System.Windows.Forms.RadioButton();
            this.rdoTheLoai = new System.Windows.Forms.RadioButton();
            this.rdoTenSach = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuCT)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnXem.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXem.ImageKey = "in.jpg";
            this.btnXem.ImageList = this.imageList2;
            this.btnXem.Location = new System.Drawing.Point(400, 808);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(145, 73);
            this.btnXem.TabIndex = 49;
            this.btnXem.Text = "   In";
            this.btnXem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Xóa.png");
            this.imageList2.Images.SetKeyName(1, "Lưu.png");
            this.imageList2.Images.SetKeyName(2, "Hủy.jpg");
            this.imageList2.Images.SetKeyName(3, "");
            this.imageList2.Images.SetKeyName(4, "in.jpg");
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.dgvPhieuCT);
            this.groupBox8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox8.Location = new System.Drawing.Point(36, 475);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(1035, 306);
            this.groupBox8.TabIndex = 48;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Danh sách sách đang mượn";
            // 
            // dgvPhieuCT
            // 
            this.dgvPhieuCT.AllowUserToOrderColumns = true;
            this.dgvPhieuCT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPhieuCT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPhieuCT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPhieuCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuCT.Location = new System.Drawing.Point(6, 34);
            this.dgvPhieuCT.Name = "dgvPhieuCT";
            this.dgvPhieuCT.RowHeadersWidth = 82;
            this.dgvPhieuCT.RowTemplate.Height = 33;
            this.dgvPhieuCT.Size = new System.Drawing.Size(1021, 265);
            this.dgvPhieuCT.TabIndex = 0;
            this.dgvPhieuCT.SelectionChanged += new System.EventHandler(this.dgvPhieuCT_SelectionChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.textBox1);
            this.groupBox9.Controls.Add(this.txtTenDocGia);
            this.groupBox9.Controls.Add(this.txtGhiChu);
            this.groupBox9.Controls.Add(this.dtpNgayTra);
            this.groupBox9.Controls.Add(this.cboTinhTrangTra);
            this.groupBox9.Controls.Add(this.txtTenSach);
            this.groupBox9.Controls.Add(this.txtMaPhieu);
            this.groupBox9.Controls.Add(this.label25);
            this.groupBox9.Controls.Add(this.txtSoLuong);
            this.groupBox9.Controls.Add(this.label24);
            this.groupBox9.Controls.Add(this.label20);
            this.groupBox9.Controls.Add(this.label21);
            this.groupBox9.Controls.Add(this.dtpNgayHenTra);
            this.groupBox9.Controls.Add(this.dtpNgayMuon);
            this.groupBox9.Controls.Add(this.label22);
            this.groupBox9.Controls.Add(this.label23);
            this.groupBox9.Controls.Add(this.label26);
            this.groupBox9.Controls.Add(this.label27);
            this.groupBox9.Controls.Add(this.label28);
            this.groupBox9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox9.Location = new System.Drawing.Point(10, 170);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(1084, 299);
            this.groupBox9.TabIndex = 47;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Thông tin phiếu mượn";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(776, 242);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 35);
            this.textBox1.TabIndex = 32;
            // 
            // txtTenDocGia
            // 
            this.txtTenDocGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenDocGia.Location = new System.Drawing.Point(223, 94);
            this.txtTenDocGia.Name = "txtTenDocGia";
            this.txtTenDocGia.Size = new System.Drawing.Size(280, 35);
            this.txtTenDocGia.TabIndex = 31;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGhiChu.Location = new System.Drawing.Point(776, 195);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(280, 35);
            this.txtGhiChu.TabIndex = 16;
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTra.Location = new System.Drawing.Point(776, 96);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(280, 35);
            this.dtpNgayTra.TabIndex = 26;
            // 
            // cboTinhTrangTra
            // 
            this.cboTinhTrangTra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinhTrangTra.FormattingEnabled = true;
            this.cboTinhTrangTra.Location = new System.Drawing.Point(776, 141);
            this.cboTinhTrangTra.Name = "cboTinhTrangTra";
            this.cboTinhTrangTra.Size = new System.Drawing.Size(280, 35);
            this.cboTinhTrangTra.TabIndex = 33;
            // 
            // txtTenSach
            // 
            this.txtTenSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenSach.Location = new System.Drawing.Point(223, 142);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(280, 35);
            this.txtTenSach.TabIndex = 30;
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaPhieu.Location = new System.Drawing.Point(223, 46);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(280, 35);
            this.txtMaPhieu.TabIndex = 29;
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(565, 46);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(172, 48);
            this.label25.TabIndex = 3;
            this.label25.Text = "Số lượng mượn :";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLuong.Location = new System.Drawing.Point(776, 46);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(280, 35);
            this.txtSoLuong.TabIndex = 27;
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(565, 136);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(172, 48);
            this.label24.TabIndex = 4;
            this.label24.Text = "Tình trạng trả :";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(566, 181);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(172, 48);
            this.label20.TabIndex = 8;
            this.label20.Text = "Ghi chú :";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(566, 91);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(172, 48);
            this.label21.TabIndex = 7;
            this.label21.Text = "Ngày trả :";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpNgayHenTra
            // 
            this.dtpNgayHenTra.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayHenTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayHenTra.Location = new System.Drawing.Point(223, 238);
            this.dtpNgayHenTra.Name = "dtpNgayHenTra";
            this.dtpNgayHenTra.Size = new System.Drawing.Size(280, 35);
            this.dtpNgayHenTra.TabIndex = 25;
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayMuon.Location = new System.Drawing.Point(223, 190);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(280, 35);
            this.dtpNgayMuon.TabIndex = 23;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(21, 226);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(172, 48);
            this.label22.TabIndex = 6;
            this.label22.Text = "Ngày hẹn trả :";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(21, 181);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(172, 48);
            this.label23.TabIndex = 5;
            this.label23.Text = "Ngày mượn :";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(21, 136);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(172, 48);
            this.label26.TabIndex = 2;
            this.label26.Text = "Tên sách:";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label27
            // 
            this.label27.Location = new System.Drawing.Point(21, 91);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(172, 48);
            this.label27.TabIndex = 1;
            this.label27.Text = "Tên độc giả :";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label28
            // 
            this.label28.Location = new System.Drawing.Point(21, 46);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(172, 48);
            this.label28.TabIndex = 0;
            this.label28.Text = "Mã phiếu :";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.groupBox11);
            this.groupBox10.Controls.Add(this.groupBox12);
            this.groupBox10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox10.Location = new System.Drawing.Point(194, 10);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(900, 141);
            this.groupBox10.TabIndex = 46;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Tìm kiếm sách mượn";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.txtTimKiemTra);
            this.groupBox11.Location = new System.Drawing.Point(521, 30);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(343, 93);
            this.groupBox11.TabIndex = 1;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Nhập thông tin cần Tìm kiếm";
            // 
            // txtTimKiemTra
            // 
            this.txtTimKiemTra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiemTra.Location = new System.Drawing.Point(17, 34);
            this.txtTimKiemTra.Multiline = true;
            this.txtTimKiemTra.Name = "txtTimKiemTra";
            this.txtTimKiemTra.Size = new System.Drawing.Size(309, 41);
            this.txtTimKiemTra.TabIndex = 0;
            this.txtTimKiemTra.TextChanged += new System.EventHandler(this.txtTimKiemTra_TextChanged);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.rdoNHT);
            this.groupBox12.Controls.Add(this.rdoTheLoai);
            this.groupBox12.Controls.Add(this.rdoTenSach);
            this.groupBox12.Location = new System.Drawing.Point(17, 31);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(512, 92);
            this.groupBox12.TabIndex = 0;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Tìm theo";
            // 
            // rdoNHT
            // 
            this.rdoNHT.AutoSize = true;
            this.rdoNHT.Location = new System.Drawing.Point(330, 44);
            this.rdoNHT.Name = "rdoNHT";
            this.rdoNHT.Size = new System.Drawing.Size(167, 31);
            this.rdoNHT.TabIndex = 2;
            this.rdoNHT.TabStop = true;
            this.rdoNHT.Text = "Ngày hẹn trả";
            this.rdoNHT.UseVisualStyleBackColor = true;
            this.rdoNHT.CheckedChanged += new System.EventHandler(this.rdoNHT_CheckedChanged);
            // 
            // rdoTheLoai
            // 
            this.rdoTheLoai.AutoSize = true;
            this.rdoTheLoai.Location = new System.Drawing.Point(173, 44);
            this.rdoTheLoai.Name = "rdoTheLoai";
            this.rdoTheLoai.Size = new System.Drawing.Size(121, 31);
            this.rdoTheLoai.TabIndex = 1;
            this.rdoTheLoai.TabStop = true;
            this.rdoTheLoai.Text = "Thể loại";
            this.rdoTheLoai.UseVisualStyleBackColor = true;
            this.rdoTheLoai.CheckedChanged += new System.EventHandler(this.rdoTDG_CheckedChanged);
            // 
            // rdoTenSach
            // 
            this.rdoTenSach.AutoSize = true;
            this.rdoTenSach.Location = new System.Drawing.Point(16, 44);
            this.rdoTenSach.Name = "rdoTenSach";
            this.rdoTenSach.Size = new System.Drawing.Size(129, 31);
            this.rdoTenSach.TabIndex = 0;
            this.rdoTenSach.TabStop = true;
            this.rdoTenSach.Text = "Tên sách";
            this.rdoTenSach.UseVisualStyleBackColor = true;
            this.rdoTenSach.CheckedChanged += new System.EventHandler(this.rdoMaPhieuTra_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnReset.ImageIndex = 0;
            this.btnReset.ImageList = this.imageList1;
            this.btnReset.Location = new System.Drawing.Point(10, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(154, 122);
            this.btnReset.TabIndex = 51;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Logo.png");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ImageKey = "Xóa.png";
            this.button1.ImageList = this.imageList2;
            this.button1.Location = new System.Drawing.Point(42, 808);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 73);
            this.button1.TabIndex = 52;
            this.button1.Text = "   Trả";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCancel.ImageKey = "Hủy.jpg";
            this.btnCancel.ImageList = this.imageList2;
            this.btnCancel.Location = new System.Drawing.Point(221, 808);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 73);
            this.btnCancel.TabIndex = 53;
            this.btnCancel.Text = "   Hủy";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormCTmuontra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1125, 913);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.groupBox10);
            this.Name = "FormCTmuontra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách chi tiết";
            this.Load += new System.EventHandler(this.FormCTmuontra_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCTmuontra_KeyDown);
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuCT)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DataGridView dgvPhieuCT;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ComboBox cboTinhTrangTra;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtTenDocGia;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.DateTimePicker dtpNgayHenTra;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox txtTimKiemTra;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.RadioButton rdoNHT;
        private System.Windows.Forms.RadioButton rdoTheLoai;
        private System.Windows.Forms.RadioButton rdoTenSach;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancel;
    }
}