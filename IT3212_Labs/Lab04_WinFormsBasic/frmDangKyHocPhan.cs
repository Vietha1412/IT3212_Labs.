using System;
using System.Windows.Forms;

namespace Lab04_WinFormsBasic
{
    public partial class frmDangKyHocPhan : Form
    {
        public frmDangKyHocPhan()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (clbMonHoc.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một môn học!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int tongTinChi = 0;
            string danhSachMon = "";

            foreach (var item in clbMonHoc.CheckedItems)
            {
                string mon = item.ToString();
                danhSachMon += "\n- " + mon;

                if (mon.Contains("4 tín chỉ"))
                {
                    tongTinChi += 4;
                }
                else
                {
                    tongTinChi += 3;
                }
            }

            lblThongBao.Text = "Tổng số tín chỉ đăng ký: " + tongTinChi;

            string thongTin = string.Format("Mã SV: {0}\nHọ tên: {1}\nMôn học đã đăng ký:{2}\nTổng số tín chỉ: {3}",
                txtMaSV.Text.Trim(), txtHoTen.Text.Trim(), danhSachMon, tongTinChi);

            MessageBox.Show(thongTin, "Kết quả đăng ký học phần", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            for (int i = 0; i < clbMonHoc.Items.Count; i++)
            {
                clbMonHoc.SetItemChecked(i, false);
            }
            lblThongBao.Text = "Tổng số tín chỉ đăng ký: 0";
            txtMaSV.Focus();
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