using System;
using System.Windows.Forms;

namespace Lab04_WinFormsBasic
{
    public partial class frmBMI : Form
    {
        public frmBMI()
        {
            InitializeComponent();
        }

        private void btnTinhBMI_Click(object sender, EventArgs e)
        {
            // Kiểm tra và lấy giá trị chiều cao từ ô nhập liệu
            if (!double.TryParse(txtChieuCao.Text.Trim(), out double chieuCao) || chieuCao <= 0)
            {
                MessageBox.Show("Chiều cao không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtChieuCao.Focus();
                return;
            }

            // Kiểm tra và lấy giá trị cân nặng từ ô nhập liệu
            if (!double.TryParse(txtCanNang.Text.Trim(), out double canNang) || canNang <= 0)
            {
                MessageBox.Show("Cân nặng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCanNang.Focus();
                return;
            }

            // Tính toán chỉ số BMI theo công thức chuẩn
            double bmi = canNang / (chieuCao * chieuCao);
            lblKetQua.Text = "BMI: " + bmi.ToString("0.00");

            // Phân loại tình trạng cơ thể dựa vào chỉ số BMI
            string phanLoai = "";
            if (bmi < 18.5)
            {
                phanLoai = "Phân loại: Gầy";
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                phanLoai = "Phân loại: Bình thường";
            }
            else if (bmi >= 25 && bmi < 30)
            {
                phanLoai = "Phân loại: Thừa cân";
            }
            else
            {
                phanLoai = "Phân loại: Béo phì";
            }

            lblPhanLoai.Text = phanLoai;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            // Làm sạch các ô nhập liệu và kết quả
            txtChieuCao.Clear();
            txtCanNang.Clear();
            lblKetQua.Text = "BMI: ";
            lblPhanLoai.Text = "Phân loại: ";
            txtChieuCao.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Hộp thoại xác nhận trước khi đóng form
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}