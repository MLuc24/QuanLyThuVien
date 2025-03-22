
namespace QuanLyThuVien
{
    partial class FormBookReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBookReport));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCT = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvTKS_TL = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKS_TL)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Hủy.jpg");
            this.imageList2.Images.SetKeyName(1, "Lưu.png");
            this.imageList2.Images.SetKeyName(2, "Sửa.jpg");
            this.imageList2.Images.SetKeyName(3, "Thêm.png");
            this.imageList2.Images.SetKeyName(4, "Xóa.png");
            this.imageList2.Images.SetKeyName(5, "in.jpg");
            this.imageList2.Images.SetKeyName(6, "gia hạn.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Logo.png");
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrint.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPrint.ImageIndex = 5;
            this.btnPrint.ImageList = this.imageList2;
            this.btnPrint.Location = new System.Drawing.Point(563, 1007);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(145, 73);
            this.btnPrint.TabIndex = 69;
            this.btnPrint.Text = "  Xuất";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            this.btnPrint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnPrint_KeyDown);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnReset.ImageIndex = 0;
            this.btnReset.ImageList = this.imageList1;
            this.btnReset.Location = new System.Drawing.Point(9, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(154, 122);
            this.btnReset.TabIndex = 68;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCT);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(203, 660);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(866, 326);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sách mượn";
            // 
            // dgvCT
            // 
            this.dgvCT.AllowUserToOrderColumns = true;
            this.dgvCT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT.Location = new System.Drawing.Point(7, 35);
            this.dgvCT.Name = "dgvCT";
            this.dgvCT.RowHeadersWidth = 82;
            this.dgvCT.RowTemplate.Height = 33;
            this.dgvCT.Size = new System.Drawing.Size(852, 285);
            this.dgvCT.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(30, 504);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(798, 300);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            // 
            // cboThang
            // 
            this.cboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThang.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Location = new System.Drawing.Point(528, 134);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(105, 37);
            this.cboThang.TabIndex = 63;
            this.cboThang.SelectedIndexChanged += new System.EventHandler(this.cboThang_SelectedIndexChanged);
            // 
            // cboNam
            // 
            this.cboNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNam.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Location = new System.Drawing.Point(729, 134);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(105, 37);
            this.cboNam.TabIndex = 65;
            this.cboNam.SelectedIndexChanged += new System.EventHandler(this.cboNam_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(639, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 48);
            this.label2.TabIndex = 67;
            this.label2.Text = "/ Năm :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(438, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 48);
            this.label6.TabIndex = 66;
            this.label6.Text = "Tháng :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvTKS_TL);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox5.Location = new System.Drawing.Point(203, 177);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(866, 477);
            this.groupBox5.TabIndex = 62;
            this.groupBox5.TabStop = false;
            // 
            // dgvTKS_TL
            // 
            this.dgvTKS_TL.AllowUserToOrderColumns = true;
            this.dgvTKS_TL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTKS_TL.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTKS_TL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTKS_TL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKS_TL.Location = new System.Drawing.Point(7, 35);
            this.dgvTKS_TL.Name = "dgvTKS_TL";
            this.dgvTKS_TL.RowHeadersWidth = 82;
            this.dgvTKS_TL.RowTemplate.Height = 33;
            this.dgvTKS_TL.Size = new System.Drawing.Size(852, 430);
            this.dgvTKS_TL.TabIndex = 0;
            this.dgvTKS_TL.SelectionChanged += new System.EventHandler(this.dgvTKS_TL_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(30, 504);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 300);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1250, 126);
            this.label1.TabIndex = 61;
            this.label1.Text = "             BÁO CÁO THỐNG KÊ TÌNH HÌNH SÁCH MƯỢN THEO THỂ LOẠI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormBookReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1250, 1142);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cboThang);
            this.Controls.Add(this.cboNam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label1);
            this.Name = "FormBookReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo thống kê Sách";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormBookReport_KeyDown);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKS_TL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.ComboBox cboNam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvTKS_TL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}