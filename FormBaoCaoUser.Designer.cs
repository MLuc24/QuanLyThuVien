
namespace QuanLyThuVien
{
    partial class FormBaoCaoUser
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTendocgia = new System.Windows.Forms.TextBox();
            this.cboMadocgia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(2, 90);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(2356, 1442);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(362, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Loại độc giả";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(1434, 16);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(119, 54);
            this.btnIn.TabIndex = 10;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên độc giả";
            // 
            // txtTendocgia
            // 
            this.txtTendocgia.Location = new System.Drawing.Point(158, 22);
            this.txtTendocgia.Name = "txtTendocgia";
            this.txtTendocgia.Size = new System.Drawing.Size(174, 31);
            this.txtTendocgia.TabIndex = 8;
            // 
            // cboMadocgia
            // 
            this.cboMadocgia.FormattingEnabled = true;
            this.cboMadocgia.Location = new System.Drawing.Point(508, 23);
            this.cboMadocgia.Name = "cboMadocgia";
            this.cboMadocgia.Size = new System.Drawing.Size(142, 33);
            this.cboMadocgia.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(678, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tháng";
            // 
            // cboThang
            // 
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Location = new System.Drawing.Point(765, 23);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(142, 33);
            this.cboThang.TabIndex = 12;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(1021, 26);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(154, 31);
            this.dtpFrom.TabIndex = 14;
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd/MM/yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(1257, 25);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(154, 31);
            this.dtpTo.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(973, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 31);
            this.label4.TabIndex = 16;
            this.label4.Text = "Từ";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(1205, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 31);
            this.label5.TabIndex = 17;
            this.label5.Text = "đến";
            // 
            // FormBaoCaoUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2355, 1533);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.cboThang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTendocgia);
            this.Controls.Add(this.cboMadocgia);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.label3);
            this.Name = "FormBaoCaoUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBaoCaoUser";
            this.Load += new System.EventHandler(this.FormBaoCaoUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTendocgia;
        private System.Windows.Forms.ComboBox cboMadocgia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}