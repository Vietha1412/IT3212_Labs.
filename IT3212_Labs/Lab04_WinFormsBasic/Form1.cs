using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab04_WinFormsBasic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Bài 2: Khởi tạo ComboBox và trạng thái Form khi Load
        private void Form1_Load(object sender, EventArgs e)
        {
            cboKhoa.Items.Clear();
            cboKhoa.Items.Add("Công nghệ thông tin");
            cboKhoa.Items.Add("Công nghệ kỹ thuật ô tô");
            cboKhoa.Items.Add("Kinh tế");
            cboKhoa.DropDownStyle = ComboBoxStyle.DropDownList;

            if (cboKhoa.Items.Count > 0)
                cboKhoa.SelectedIndex = 0;

            radNam.Checked = true;
        }

        // Bài 3: Hàm tính tuổi chuẩn xác từ DateTimePicker
        private int TinhTuoi(DateTime ngaySinh)
        {
            int tuoi = DateTime.Today.Year - ngaySinh.Year;
            if (ngaySinh.Date > DateTime.Today.AddYears(-tuoi))
                tuoi--;
            return tuoi;
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            lblTuoi.Text = "Tuổi: " + TinhTuoi(dtpNgaySinh.Value);
        }

        // Bài 1: Nút Hiển thị thông tin tổng hợp
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã SV và Họ Tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
            string thongTin = string.Format(
                "Mã SV: {0}\nHọ tên: {1}\nNgày sinh: {2:dd/MM/yyyy} ({3} tuổi)\nKhoa: {4}\nGiới tính: {5}",
                txtMaSV.Text.Trim(),
                txtHoTen.Text.Trim(),
                dtpNgaySinh.Value,
                TinhTuoi(dtpNgaySinh.Value),
                cboKhoa.Text,
                gioiTinh);

            MessageBox.Show(thongTin, "Thông tin sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Bài 4: Kiểm tra danh sách sở thích bằng CheckBox
        private void btnSoThich_Click(object sender, EventArgs e)
        {
            List<string> dsSoThich = new List<string>();
            if (chkDocSach.Checked) dsSoThich.Add("Đọc sách");
            if (chkTheThao.Checked) dsSoThich.Add("Thể thao");
            if (chkLapTrinh.Checked) dsSoThich.Add("Lập trình");

            string kq = dsSoThich.Count == 0 ? "Chưa chọn sở thích nào!" : "Sở thích đã chọn: " + string.Join(", ", dsSoThich);
            MessageBox.Show(kq, "Sở thích", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Bài 5: Chọn ảnh đại diện qua OpenFileDialog
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Chọn ảnh đại diện sinh viên";
                dlg.Filter = "Tệp hình ảnh|*.jpg;*.jpeg;*.png;*.bmp";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    picAnh.SizeMode = PictureBoxSizeMode.Zoom;
                    picAnh.ImageLocation = dlg.FileName;
                    txtDuongDanAnh.Text = dlg.FileName;
                }
            }
        }

        private void radNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}