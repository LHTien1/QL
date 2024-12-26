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
    public partial class frm_casino : Form
    {
        public frm_casino()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Tạo một DataTable giả để hiển thị dữ liệu trong DataGridView
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Tên");

            // Thêm một vài dòng dữ liệu
            dt.Rows.Add(1, "Người dùng 1");
            dt.Rows.Add(2, "Người dùng 2");
            dataGridView1.DataSource = new DataGridView();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
