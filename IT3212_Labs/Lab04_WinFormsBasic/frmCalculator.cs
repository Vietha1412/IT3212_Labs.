using System;
using System.Windows.Forms;

namespace Lab04_WinFormsBasic
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        // Hàm kiểm tra và lấy dữ liệu nhập từ 2 TextBox
        private bool LayDuLieu(out double so1, out double so2)
        {
            so1 = 0;
            so2 = 0;

            if (!double.TryParse(txtSo1.Text.Trim(), out so1))
            {
                MessageBox.Show("Số thứ nhất không hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSo1.Focus();
                return false;
            }

            if (!double.TryParse(txtSo2.Text.Trim(), out so2))
            {
                MessageBox.Show("Số thứ hai không hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSo2.Focus();
                return false;
            }

            return true;
        }

        // Phép Cộng
        private void btnCong_Click(object sender, EventArgs e)
        {
            if (LayDuLieu(out double a, out double b))
            {
                txtKetQua.Text = (a + b).ToString();
            }
        }

        // Phép Trừ
        private void btnTru_Click(object sender, EventArgs e)
        {
            if (LayDuLieu(out double a, out double b))
            {
                txtKetQua.Text = (a - b).ToString();
            }
        }

        // Phép Nhân
        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (LayDuLieu(out double a, out double b))
            {
                txtKetQua.Text = (a * b).ToString();
            }
        }

        // Phép Chia (Xử lý ngoại lệ chia cho 0)
        private void btnChia_Click(object sender, EventArgs e)
        {
            if (LayDuLieu(out double a, out double b))
            {
                if (b == 0)
                {
                    MessageBox.Show("Không thể chia cho số 0!", "Lỗi toán học", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtKetQua.Text = "Lỗi (Chia cho 0)";
                    return;
                }
                txtKetQua.Text = (a / b).ToString();
            }
        }

        // Nút Làm mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtSo1.Clear();
            txtSo2.Clear();
            txtKetQua.Clear();
            txtSo1.Focus();
        }

        // Nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}