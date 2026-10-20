using System;
using System.Windows.Forms;

namespace Lab04_WinFormsBasic
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        // Xử lý nút Hiển thị/Ẩn mật khẩu
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0'; // Hiện mật khẩu (bỏ ẩn ký tự)
            }
            else
            {
                txtPassword.PasswordChar = '*'; // Ẩn mật khẩu thành dấu *
            }
        }

        // Xử lý nút Đăng nhập
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();

            // Kiểm tra tài khoản mẫu (Ví dụ: admin / 123456)
            if (user == "admin" && pass == "123456")
            {
                string msg = "Đăng nhập thành công!";
                if (chkRemember.Checked)
                {
                    msg += "\n(Đã ghi nhớ thông tin đăng nhập của bạn)";
                }
                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ở đây có thể mở form chính của ứng dụng
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
        }

        // Xử lý nút Thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}