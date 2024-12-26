namespace QLCasino
{
    partial class khachHangcs
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
            this.txttgcl = new System.Windows.Forms.TextBox();
            this.txt_tien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cl = new System.Windows.Forms.TextBox();
            this.btn_nap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtttg = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSoTienNap = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian còn lại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số tiền còn lại";
            // 
            // txttgcl
            // 
            this.txttgcl.Location = new System.Drawing.Point(170, 95);
            this.txttgcl.Name = "txttgcl";
            this.txttgcl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txttgcl.Size = new System.Drawing.Size(162, 22);
            this.txttgcl.TabIndex = 3;
            this.txttgcl.Text = "0.0.0";
            // 
            // txt_tien
            // 
            this.txt_tien.Location = new System.Drawing.Point(170, 162);
            this.txt_tien.Name = "txt_tien";
            this.txt_tien.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_tien.Size = new System.Drawing.Size(162, 22);
            this.txt_tien.TabIndex = 4;
            this.txt_tien.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số tiền hiện tại";
            // 
            // txt_cl
            // 
            this.txt_cl.Location = new System.Drawing.Point(170, 223);
            this.txt_cl.Name = "txt_cl";
            this.txt_cl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_cl.Size = new System.Drawing.Size(162, 22);
            this.txt_cl.TabIndex = 7;
            this.txt_cl.Text = "0";
            // 
            // btn_nap
            // 
            this.btn_nap.Location = new System.Drawing.Point(42, 353);
            this.btn_nap.Name = "btn_nap";
            this.btn_nap.Size = new System.Drawing.Size(75, 23);
            this.btn_nap.TabIndex = 8;
            this.btn_nap.Text = "nạp";
            this.btn_nap.UseVisualStyleBackColor = true;
            this.btn_nap.Click += new System.EventHandler(this.btn_nap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tổng thời gian";
            // 
            // txtttg
            // 
            this.txtttg.Location = new System.Drawing.Point(170, 44);
            this.txtttg.Name = "txtttg";
            this.txtttg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtttg.Size = new System.Drawing.Size(162, 22);
            this.txtttg.TabIndex = 10;
            this.txtttg.Text = "0.0.0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(42, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Dichvu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSoTienNap
            // 
            this.txtSoTienNap.Location = new System.Drawing.Point(150, 324);
            this.txtSoTienNap.Name = "txtSoTienNap";
            this.txtSoTienNap.Size = new System.Drawing.Size(100, 22);
            this.txtSoTienNap.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 354);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 13;
            // 
            // khachHangcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 414);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtSoTienNap);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtttg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_nap);
            this.Controls.Add(this.txt_cl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tien);
            this.Controls.Add(this.txttgcl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "khachHangcs";
            this.Text = "khachHangcs";
            this.Load += new System.EventHandler(this.khachHangcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttgcl;
        private System.Windows.Forms.TextBox txt_tien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cl;
        private System.Windows.Forms.Button btn_nap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtttg;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSoTienNap;
        private System.Windows.Forms.TextBox textBox1;
    }
}