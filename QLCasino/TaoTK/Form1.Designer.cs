namespace TaoTK
{
    partial class frm_TaoTK
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
            this.txt_TTK = new System.Windows.Forms.TextBox();
            this.txt_MK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bnt_DN = new System.Windows.Forms.Button();
            this.bnt_DK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_TTK
            // 
            this.txt_TTK.Location = new System.Drawing.Point(198, 87);
            this.txt_TTK.Name = "txt_TTK";
            this.txt_TTK.Size = new System.Drawing.Size(155, 20);
            this.txt_TTK.TabIndex = 0;
            // 
            // txt_MK
            // 
            this.txt_MK.Location = new System.Drawing.Point(198, 133);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.Size = new System.Drawing.Size(155, 20);
            this.txt_MK.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(105, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = " カジノ(Casino) F88";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Tài Khoản ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật Khẩu ";
            // 
            // bnt_DN
            // 
            this.bnt_DN.Location = new System.Drawing.Point(278, 177);
            this.bnt_DN.Name = "bnt_DN";
            this.bnt_DN.Size = new System.Drawing.Size(75, 23);
            this.bnt_DN.TabIndex = 5;
            this.bnt_DN.Text = "Đăng Nhập";
            this.bnt_DN.UseVisualStyleBackColor = true;
            this.bnt_DN.Click += new System.EventHandler(this.bnt_DN_Click);
            // 
            // bnt_DK
            // 
            this.bnt_DK.Location = new System.Drawing.Point(278, 222);
            this.bnt_DK.Name = "bnt_DK";
            this.bnt_DK.Size = new System.Drawing.Size(75, 23);
            this.bnt_DK.TabIndex = 6;
            this.bnt_DK.Text = "Đăng Ký";
            this.bnt_DK.UseVisualStyleBackColor = true;
            this.bnt_DK.Click += new System.EventHandler(this.bnt_DK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(150, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chưa có tài khoản ?";
            // 
            // frm_TaoTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 271);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bnt_DK);
            this.Controls.Add(this.bnt_DN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_MK);
            this.Controls.Add(this.txt_TTK);
            this.Name = "frm_TaoTK";
            this.Text = "Tai Khoan";
            this.Load += new System.EventHandler(this.frm_TaoTK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_TTK;
        private System.Windows.Forms.TextBox txt_MK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bnt_DN;
        private System.Windows.Forms.Button bnt_DK;
        private System.Windows.Forms.Label label4;
    }
}

