namespace DangKiTK
{
    partial class frm_DKTK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_MK = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Hoten = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_TK = new System.Windows.Forms.TextBox();
            this.txt_NLMK = new System.Windows.Forms.TextBox();
            this.txt_MK = new System.Windows.Forms.TextBox();
            this.bnt_DK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Điện Thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // lbl_MK
            // 
            this.lbl_MK.AutoSize = true;
            this.lbl_MK.Location = new System.Drawing.Point(53, 227);
            this.lbl_MK.Name = "lbl_MK";
            this.lbl_MK.Size = new System.Drawing.Size(53, 13);
            this.lbl_MK.TabIndex = 4;
            this.lbl_MK.Text = "Mật Khẩu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nhập lại Mật Khẩu";
            // 
            // txt_Hoten
            // 
            this.txt_Hoten.Location = new System.Drawing.Point(203, 51);
            this.txt_Hoten.Name = "txt_Hoten";
            this.txt_Hoten.Size = new System.Drawing.Size(200, 20);
            this.txt_Hoten.TabIndex = 6;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(203, 85);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(200, 20);
            this.txt_SDT.TabIndex = 7;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(203, 131);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(200, 20);
            this.txt_Email.TabIndex = 8;
            // 
            // txt_TK
            // 
            this.txt_TK.Location = new System.Drawing.Point(203, 180);
            this.txt_TK.Name = "txt_TK";
            this.txt_TK.Size = new System.Drawing.Size(200, 20);
            this.txt_TK.TabIndex = 9;
            // 
            // txt_NLMK
            // 
            this.txt_NLMK.Location = new System.Drawing.Point(203, 275);
            this.txt_NLMK.Name = "txt_NLMK";
            this.txt_NLMK.Size = new System.Drawing.Size(200, 20);
            this.txt_NLMK.TabIndex = 10;
            // 
            // txt_MK
            // 
            this.txt_MK.Location = new System.Drawing.Point(203, 227);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.Size = new System.Drawing.Size(200, 20);
            this.txt_MK.TabIndex = 11;
            this.txt_MK.TextChanged += new System.EventHandler(this.txt_MK_TextChanged);
            // 
            // bnt_DK
            // 
            this.bnt_DK.Location = new System.Drawing.Point(345, 354);
            this.bnt_DK.Name = "bnt_DK";
            this.bnt_DK.Size = new System.Drawing.Size(75, 23);
            this.bnt_DK.TabIndex = 12;
            this.bnt_DK.Text = "Đăng Kí";
            this.bnt_DK.UseVisualStyleBackColor = true;
            this.bnt_DK.Click += new System.EventHandler(this.bnt_DK_Click);
            // 
            // frm_DKTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 416);
            this.Controls.Add(this.bnt_DK);
            this.Controls.Add(this.txt_MK);
            this.Controls.Add(this.txt_NLMK);
            this.Controls.Add(this.txt_TK);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_Hoten);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_MK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_DKTK";
            this.Text = "Đăng Kí Tài Khoản";
            this.Load += new System.EventHandler(this.frm_DKTK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_MK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Hoten;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_TK;
        private System.Windows.Forms.TextBox txt_NLMK;
        private System.Windows.Forms.TextBox txt_MK;
        private System.Windows.Forms.Button bnt_DK;
    }
}

