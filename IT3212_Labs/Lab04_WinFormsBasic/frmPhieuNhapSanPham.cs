using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab04_WinFormsBasic
{
    public partial class frmPhieuNhapSanPham : Form
    {
        private string imagePath = "";

        public frmPhieuNhapSanPham()
        {
            InitializeComponent();
            LoadComboBoxLoai();
        }

        private void LoadComboBoxLoai()
        {
            cmbLoaiSP.Items.Add("Điện tử");
            cmbLoaiSP.Items.Add("Gia dụng");
            cmbLoaiSP.Items.Add("Thời trang");
            cmbLoaiSP.Items.Add("Thực phẩm");
            cmbLoaiSP.SelectedIndex = 0;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại chọn file ảnh từ máy tính
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
                picAnh.Image = Image.FromFile(imagePath);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin bắt buộc
            if (string.IsNullOrWhiteSpace(txtMaSP.Text) || string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã và tên sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSP.Focus();
                return;
            }

            // Kiểm tra tính hợp lệ của số lượng
            if (!int.TryParse(txtSoLuong.Text.Trim(), out int soLuong) || soLuong < 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuong.Focus();
                return;
            }

            // Kiểm tra tính hợp lệ của đơn giá
            if (!decimal.TryParse(txtDonGia.Text.Trim(), out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDonGia.Focus();
                return;
            }

            string maSP = txtMaSP.Text.Trim();
            string tenSP = txtTenSP.Text.Trim();
            string loaiSP = cmbLoaiSP.SelectedItem.ToString();
            DateTime ngayNhap = dtpNgayNhap.Value;
            decimal thanhTien = soLuong * donGia;

            // Hiển thị thông tin phiếu nhập sản phẩm hoàn chỉnh
            string thongTin = string.Format("Mã sản phẩm: {0}\nTên sản phẩm: {1}\nLoại: {2}\nSố lượng: {3}\nĐơn giá: {4:N0}\nNgày nhập: {5:dd/MM/yyyy}\nThành tiền: {6:N0}",
                maSP, tenSP, loaiSP, soLuong, donGia, ngayNhap, thanhTien);

            MessageBox.Show(thongTin, "Thông tin phiếu nhập sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            cmbLoaiSP.SelectedIndex = 0;
            txtSoLuong.Clear();
            txtDonGia.Clear();
            dtpNgayNhap.Value = DateTime.Now;
            picAnh.Image = null;
            imagePath = "";
            txtMaSP.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}