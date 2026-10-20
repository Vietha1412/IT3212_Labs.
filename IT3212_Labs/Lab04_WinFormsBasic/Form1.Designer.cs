namespace Lab04_WinFormsBasic
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblTuoi = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.lblSoThich = new System.Windows.Forms.Label();
            this.chkDocSach = new System.Windows.Forms.CheckBox();
            this.chkTheThao = new System.Windows.Forms.CheckBox();
            this.chkLapTrinh = new System.Windows.Forms.CheckBox();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnSoThich = new System.Windows.Forms.Button();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.txtDuongDanAnh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(80, 46);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(84, 16);
            this.lblMaSV.TabIndex = 1;
            this.lblMaSV.Text = "Mã sinh viên:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(170, 40);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(100, 22);
            this.txtMaSV.TabIndex = 2;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(80, 90);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(67, 16);
            this.lblHoTen.TabIndex = 3;
            this.lblHoTen.Text = "Họ và tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(170, 84);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(100, 22);
            this.txtHoTen.TabIndex = 4;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(80, 125);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(70, 16);
            this.lblNgaySinh.TabIndex = 5;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(170, 119);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dtpNgaySinh.TabIndex = 6;
            // 
            // lblTuoi
            // 
            this.lblTuoi.AutoSize = true;
            this.lblTuoi.Location = new System.Drawing.Point(80, 159);
            this.lblTuoi.Name = "lblTuoi";
            this.lblTuoi.Size = new System.Drawing.Size(40, 16);
            this.lblTuoi.TabIndex = 7;
            this.lblTuoi.Text = "Tuổi: ";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(80, 200);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(57, 16);
            this.lblGioiTinh.TabIndex = 8;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Checked = true;
            this.radNam.Location = new System.Drawing.Point(164, 196);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(57, 20);
            this.radNam.TabIndex = 9;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(242, 198);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(45, 20);
            this.radNu.TabIndex = 10;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            this.radNu.CheckedChanged += new System.EventHandler(this.radNu_CheckedChanged);
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(80, 233);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(41, 16);
            this.lblKhoa.TabIndex = 11;
            this.lblKhoa.Text = "Khoa:";
            // 
            // cboKhoa
            // 
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(164, 225);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(121, 24);
            this.cboKhoa.TabIndex = 12;
            this.cboKhoa.Click += new System.EventHandler(this.Form1_Load);
            // 
            // lblSoThich
            // 
            this.lblSoThich.AutoSize = true;
            this.lblSoThich.Location = new System.Drawing.Point(80, 272);
            this.lblSoThich.Name = "lblSoThich";
            this.lblSoThich.Size = new System.Drawing.Size(57, 16);
            this.lblSoThich.TabIndex = 13;
            this.lblSoThich.Text = "Sở thích:";
            // 
            // chkDocSach
            // 
            this.chkDocSach.AutoSize = true;
            this.chkDocSach.Location = new System.Drawing.Point(170, 268);
            this.chkDocSach.Name = "chkDocSach";
            this.chkDocSach.Size = new System.Drawing.Size(85, 20);
            this.chkDocSach.TabIndex = 14;
            this.chkDocSach.Text = "Đọc sách";
            this.chkDocSach.UseVisualStyleBackColor = true;
            // 
            // chkTheThao
            // 
            this.chkTheThao.AutoSize = true;
            this.chkTheThao.Location = new System.Drawing.Point(304, 268);
            this.chkTheThao.Name = "chkTheThao";
            this.chkTheThao.Size = new System.Drawing.Size(82, 20);
            this.chkTheThao.TabIndex = 15;
            this.chkTheThao.Text = "Thể thao";
            this.chkTheThao.UseVisualStyleBackColor = true;
            // 
            // chkLapTrinh
            // 
            this.chkLapTrinh.AutoSize = true;
            this.chkLapTrinh.Location = new System.Drawing.Point(428, 268);
            this.chkLapTrinh.Name = "chkLapTrinh";
            this.chkLapTrinh.Size = new System.Drawing.Size(79, 20);
            this.chkLapTrinh.TabIndex = 16;
            this.chkLapTrinh.Text = "Lập trình";
            this.chkLapTrinh.UseVisualStyleBackColor = true;
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(226, 351);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(126, 23);
            this.btnHienThi.TabIndex = 17;
            this.btnHienThi.Text = "Hiển thị thông tin";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnSoThich
            // 
            this.btnSoThich.Location = new System.Drawing.Point(419, 351);
            this.btnSoThich.Name = "btnSoThich";
            this.btnSoThich.Size = new System.Drawing.Size(109, 23);
            this.btnSoThich.TabIndex = 18;
            this.btnSoThich.Text = "Xem sở thích";
            this.btnSoThich.UseVisualStyleBackColor = true;
            this.btnSoThich.Click += new System.EventHandler(this.btnSoThich_Click);
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(419, 40);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(163, 23);
            this.btnChonAnh.TabIndex = 19;
            this.btnChonAnh.Text = "Chọn ảnh đại diện";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // picAnh
            // 
            this.picAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnh.Location = new System.Drawing.Point(419, 90);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(269, 159);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnh.TabIndex = 20;
            this.picAnh.TabStop = false;
            // 
            // txtDuongDanAnh
            // 
            this.txtDuongDanAnh.Location = new System.Drawing.Point(588, 40);
            this.txtDuongDanAnh.Name = "txtDuongDanAnh";
            this.txtDuongDanAnh.ReadOnly = true;
            this.txtDuongDanAnh.Size = new System.Drawing.Size(100, 22);
            this.txtDuongDanAnh.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDuongDanAnh);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.btnSoThich);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.chkLapTrinh);
            this.Controls.Add(this.chkTheThao);
            this.Controls.Add(this.chkDocSach);
            this.Controls.Add(this.lblSoThich);
            this.Controls.Add(this.cboKhoa);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.radNu);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblTuoi);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblTuoi;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Label lblSoThich;
        private System.Windows.Forms.CheckBox chkDocSach;
        private System.Windows.Forms.CheckBox chkTheThao;
        private System.Windows.Forms.CheckBox chkLapTrinh;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnSoThich;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.TextBox txtDuongDanAnh;
    }
}

