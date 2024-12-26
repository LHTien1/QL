using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCasino
{
    public partial class khachHangcs : Form
    {
        public khachHangcs()
        {
            InitializeComponent();
        }
        private double tongThoiGian = 0.0; // Tổng thời gian được sử dụng
        private double thoiGianConLai = 0.0; // Thời gian còn lại
        private int soTienHienTai = 0; // Số tiền hiện tại
        private int soTienConLai = 0; // Số tiền còn lại

        private void cmbkhuvuc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void khachHangcs_Load(object sender, EventArgs e)
        {
            
                tongThoiGian = 120.0; // Ví dụ: 120 phút
                thoiGianConLai = tongThoiGian;
                soTienHienTai = 0;
                soTienConLai = 0;

                // Cập nhật giao diện
                txtttg.Text = tongThoiGian.ToString("0.0");
                txttgcl.Text = thoiGianConLai.ToString("0.0");
                txt_tien.Text = soTienHienTai.ToString();
                txt_cl.Text = soTienConLai.ToString();
            
        }

        private void btn_nap_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    // Giả sử người dùng nhập số tiền vào TextBox (bạn cần thêm TextBox để nhập số tiền nạp)
                    int soTienNap = int.Parse(txtSoTienNap.Text); // TextBox để nhập tiền
                    soTienHienTai += soTienNap;
                    soTienConLai = soTienHienTai;

                    // Cập nhật giao diện
                    txt_tien.Text = soTienHienTai.ToString();
                    txt_cl.Text = soTienConLai.ToString();

                    MessageBox.Show("Nạp tiền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        
        {
             // Giả sử dịch vụ tiêu tốn 1000 đồng mỗi 10 phút
             int chiPhiDichVu = 1000;
              double thoiGianSuDung = 10; // Giả sử người dùng đã dùng 10 phút

                if (soTienHienTai >= chiPhiDichVu)
                {
                    soTienHienTai -= chiPhiDichVu;
                    soTienConLai = soTienHienTai;
                    thoiGianConLai -= thoiGianSuDung;

                    // Cập nhật giao diện
                    txttgcl.Text = thoiGianConLai.ToString("0.0");
                    txt_tien.Text = soTienHienTai.ToString();
                    txt_cl.Text = soTienConLai.ToString();

                    MessageBox.Show("Dịch vụ đã được sử dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không đủ tiền để sử dụng dịch vụ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
    }
}
