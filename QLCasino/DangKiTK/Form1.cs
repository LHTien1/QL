using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangKiTK
{
    public partial class frm_DKTK : Form
    {
        public frm_DKTK()
        {
            InitializeComponent();
        }
        private void frm_DKTK_Load(object sender, EventArgs e)
        {
          
        }

        private void bnt_DK_Click(object sender, EventArgs e)
        {
            // Kiểm tra Họ Tên
            if (string.IsNullOrWhiteSpace(txt_Hoten.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ Tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Hoten.Focus();
                return;
            }

            // Kiểm tra Số Điện Thoại
            if (string.IsNullOrWhiteSpace(txt_SDT.Text) || !IsPhoneNumber(txt_SDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đúng Số Điện Thoại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_SDT.Focus();
                return;
            }

            // Kiểm tra Email
            if (string.IsNullOrWhiteSpace(txt_Email.Text) || !IsValidEmail(txt_Email.Text))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng Email!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Email.Focus();
                return;
            }

            // Kiểm tra Tên Tài Khoản
            if (string.IsNullOrWhiteSpace(txt_TK.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên Tài Khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_TK.Focus();
                return;
            }

            // Kiểm tra Mật Khẩu
            if (string.IsNullOrWhiteSpace(txt_MK.Text))
            {
                MessageBox.Show("Vui lòng nhập Mật Khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_MK.Focus();
                return;
            }

            // Kiểm tra Nhập Lại Mật Khẩu
            if (txt_NLMK.Text != txt_NLMK.Text)
            {
                MessageBox.Show("Mật khẩu không khớp. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_NLMK.Focus();
                return;
            }

            // Kiểm tra mật khẩu và "Nhập lại mật khẩu" phải khớp nhau
            if (txt_MK.Text != txt_NLMK.Text)
            {
                MessageBox.Show("Mật khẩu và mật khẩu nhập lại không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_NLMK.Focus();
                return;
            }
            // Kiểm tra độ mạnh của mật khẩu
            if (!IsStrongPassword(txt_MK.Text))
            {
                MessageBox.Show("Mật khẩu không đủ mạnh! Vui lòng sử dụng ít nhất 8 ký tự, bao gồm chữ hoa, chữ thường, số và ký tự đặc biệt.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MK.Focus();
                return;
            }
            // Nếu tất cả đều hợp lệ
            MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Đóng form đăng ký
        }

        private bool IsPhoneNumber(string phoneNumber)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^\d{9,11}$");
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsStrongPassword(string password)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");

        }

        private void txt_MK_TextChanged(object sender, EventArgs e)
        {
            if (IsStrongPassword(txt_MK.Text))
            {
                lbl_MK.Text = "Mật khẩu mạnh.";
                lbl_MK.ForeColor = Color.Green;
            }
            else
            {
                lbl_MK.Text = "Mật khẩu chưa đủ mạnh.";
                lbl_MK.ForeColor = Color.Red;
            }
        }

        private string GetPasswordFeedback(string password)
        {
            List<string> feedback = new List<string>();

            if (password.Length < 8)
                feedback.Add("Ít nhất 8 ký tự.");
            if (!password.Any(char.IsUpper))
                feedback.Add("Ít nhất 1 chữ cái viết hoa.");
            if (!password.Any(char.IsLower))
                feedback.Add("Ít nhất 1 chữ cái viết thường.");
            if (!password.Any(char.IsDigit))
                feedback.Add("Ít nhất 1 số.");
            if (!System.Text.RegularExpressions.Regex.IsMatch(password, @"[@$!%*?&]"))
                feedback.Add("Ít nhất 1 ký tự đặc biệt (@, $, !, %, *, ?, &).");

           

            if (!IsStrongPassword(txt_MK.Text))
            {
                MessageBox.Show("Mật khẩu không đủ mạnh! Vui lòng cải thiện mật khẩu:\n" + GetPasswordFeedback(txt_MK.Text), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);            
            }
            return string.Join("\n", feedback);
        }


    }
}
