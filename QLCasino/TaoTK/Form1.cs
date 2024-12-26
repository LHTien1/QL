using DangKiTK;
using QLCasino;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaoTK
{
    public partial class frm_TaoTK : Form
    {
        public frm_TaoTK()
        {
            InitializeComponent();
        }
        List<(string TenTaiKhoan, string MatKhau)> danhSachTaiKhoan = new List<(string, string)>()
    {
        ("user1", "password1"), // Tài khoản mẫu
        ("user2", "password2")  // Bạn có thể thêm nhiều tài khoản
    };
        private void bnt_DK_Click(object sender, EventArgs e)
        {
            // Khởi tạo Form Đăng Ký
            frm_DKTK formDangKy = new frm_DKTK();

            // Hiển thị Form Đăng Ký dưới dạng modal (chặn các thao tác khác cho đến khi đóng form này)
            formDangKy.ShowDialog();

            // Nếu không muốn modal, bạn có thể dùng:
            // formDangKy.Show();
        }

        private void frm_TaoTK_Load(object sender, EventArgs e)
        {

        }

        private void bnt_DN_Click(object sender, EventArgs e)
        {
            // Lấy thông tin người dùng nhập vào
            string tenTaiKhoan = txt_TTK.Text.Trim();
            string matKhau = txt_MK.Text.Trim();

            // Kiểm tra nếu trường nhập bị trống
            // Nếu người dùng để trống Tên Tài Khoản hoặc Mật Khẩu, hiển thị thông báo yêu cầu nhập thông tin.
            if (string.IsNullOrWhiteSpace(tenTaiKhoan) || string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show("Tên tài khoản và mật khẩu không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tìm tài khoản trong danh sách (hoặc từ database)
            var taiKhoanTonTai = danhSachTaiKhoan
                .FirstOrDefault(tk => tk.TenTaiKhoan == tenTaiKhoan && tk.MatKhau == matKhau);

            if (!taiKhoanTonTai.Equals(default((string, string))))
            {
                // Nếu tài khoản hợp lệ
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hiển thị FormKhach
                frm_casino frm_Casino = new frm_casino();
                frm_Casino.Show();

                // Ẩn Form đăng nhập hiện tại
                this.Hide();
                return;
            }
            else
            {
                // Nếu tài khoản không tồn tại
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng! Nếu bạn chưa có tài khoản, hãy đăng ký.",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
