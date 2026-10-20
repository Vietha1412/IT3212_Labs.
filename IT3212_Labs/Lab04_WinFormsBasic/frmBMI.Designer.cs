namespace Lab04_WinFormsBasic
{
    partial class frmBMI
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
            this.lblChieuCao = new System.Windows.Forms.Label();
            this.lblCanNang = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.lblPhanLoai = new System.Windows.Forms.Label();
            this.txtChieuCao = new System.Windows.Forms.TextBox();
            this.txtCanNang = new System.Windows.Forms.TextBox();
            this.btnTinhBMI = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChieuCao
            // 
            this.lblChieuCao.AutoSize = true;
            this.lblChieuCao.Location = new System.Drawing.Point(66, 26);
            this.lblChieuCao.Name = "lblChieuCao";
            this.lblChieuCao.Size = new System.Drawing.Size(70, 16);
            this.lblChieuCao.TabIndex = 0;
            this.lblChieuCao.Text = "Chiều cao:";
            // 
            // lblCanNang
            // 
            this.lblCanNang.AutoSize = true;
            this.lblCanNang.Location = new System.Drawing.Point(66, 72);
            this.lblCanNang.Name = "lblCanNang";
            this.lblCanNang.Size = new System.Drawing.Size(67, 16);
            this.lblCanNang.TabIndex = 1;
            this.lblCanNang.Text = "Cân nặng:";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(66, 113);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(55, 16);
            this.lblKetQua.TabIndex = 2;
            this.lblKetQua.Text = "Kết quả:";
            // 
            // lblPhanLoai
            // 
            this.lblPhanLoai.AutoSize = true;
            this.lblPhanLoai.Location = new System.Drawing.Point(66, 164);
            this.lblPhanLoai.Name = "lblPhanLoai";
            this.lblPhanLoai.Size = new System.Drawing.Size(70, 16);
            this.lblPhanLoai.TabIndex = 3;
            this.lblPhanLoai.Text = "Phân Loại:";
            // 
            // txtChieuCao
            // 
            this.txtChieuCao.Location = new System.Drawing.Point(151, 20);
            this.txtChieuCao.Name = "txtChieuCao";
            this.txtChieuCao.Size = new System.Drawing.Size(100, 22);
            this.txtChieuCao.TabIndex = 4;
            // 
            // txtCanNang
            // 
            this.txtCanNang.Location = new System.Drawing.Point(151, 66);
            this.txtCanNang.Name = "txtCanNang";
            this.txtCanNang.Size = new System.Drawing.Size(100, 22);
            this.txtCanNang.TabIndex = 5;
            // 
            // btnTinhBMI
            // 
            this.btnTinhBMI.Location = new System.Drawing.Point(131, 277);
            this.btnTinhBMI.Name = "btnTinhBMI";
            this.btnTinhBMI.Size = new System.Drawing.Size(75, 23);
            this.btnTinhBMI.TabIndex = 6;
            this.btnTinhBMI.Text = "Tính BMI";
            this.btnTinhBMI.UseVisualStyleBackColor = true;
            this.btnTinhBMI.Click += new System.EventHandler(this.btnTinhBMI_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(330, 277);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 7;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(482, 277);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmBMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnTinhBMI);
            this.Controls.Add(this.txtCanNang);
            this.Controls.Add(this.txtChieuCao);
            this.Controls.Add(this.lblPhanLoai);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblCanNang);
            this.Controls.Add(this.lblChieuCao);
            this.Name = "frmBMI";
            this.Text = "frmBMI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChieuCao;
        private System.Windows.Forms.Label lblCanNang;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label lblPhanLoai;
        private System.Windows.Forms.TextBox txtChieuCao;
        private System.Windows.Forms.TextBox txtCanNang;
        private System.Windows.Forms.Button btnTinhBMI;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThoat;
    }
}