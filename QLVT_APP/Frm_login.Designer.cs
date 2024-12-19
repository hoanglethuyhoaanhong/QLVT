namespace QLVT_APP
{
    partial class Frm_login
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
            this.cmb_chiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.cb_pass = new System.Windows.Forms.CheckBox();
            this.btn_dangNhap = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cmb_chiNhanh
            // 
            this.cmb_chiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_chiNhanh.FormattingEnabled = true;
            this.cmb_chiNhanh.Location = new System.Drawing.Point(196, 48);
            this.cmb_chiNhanh.Name = "cmb_chiNhanh";
            this.cmb_chiNhanh.Size = new System.Drawing.Size(282, 28);
            this.cmb_chiNhanh.TabIndex = 0;
            this.cmb_chiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmb_chiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(175, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(175, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password     ";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(331, 153);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(239, 26);
            this.txt_user.TabIndex = 3;
            this.txt_user.Click += new System.EventHandler(this.txt_user_Click);
            this.txt_user.TextChanged += new System.EventHandler(this.txt_user_TextChanged);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(331, 213);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(239, 26);
            this.txt_pass.TabIndex = 4;
            this.txt_pass.UseSystemPasswordChar = true;
            this.txt_pass.Click += new System.EventHandler(this.txt_pass_TextChanged);
            // 
            // cb_pass
            // 
            this.cb_pass.AutoSize = true;
            this.cb_pass.Location = new System.Drawing.Point(331, 271);
            this.cb_pass.Name = "cb_pass";
            this.cb_pass.Size = new System.Drawing.Size(95, 24);
            this.cb_pass.TabIndex = 5;
            this.cb_pass.Text = "Hiện MK";
            this.cb_pass.UseVisualStyleBackColor = true;
            this.cb_pass.CheckedChanged += new System.EventHandler(this.cb_pass_CheckedChanged);
            // 
            // btn_dangNhap
            // 
            this.btn_dangNhap.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_dangNhap.Location = new System.Drawing.Point(167, 348);
            this.btn_dangNhap.Name = "btn_dangNhap";
            this.btn_dangNhap.Size = new System.Drawing.Size(119, 36);
            this.btn_dangNhap.TabIndex = 6;
            this.btn_dangNhap.Text = "Đăng Nhập";
            this.btn_dangNhap.UseVisualStyleBackColor = false;
            this.btn_dangNhap.Click += new System.EventHandler(this.btn_dangNhap_Click_1);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_thoat.Location = new System.Drawing.Point(432, 348);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(122, 36);
            this.btn_thoat.TabIndex = 7;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(196, 97);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(123, 24);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Khách Hàng";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_dangNhap);
            this.Controls.Add(this.cb_pass);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_chiNhanh);
            this.Name = "Frm_login";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.Frm_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.ComboBox cmb_chiNhanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.CheckBox cb_pass;
        private System.Windows.Forms.Button btn_dangNhap;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.CheckBox checkBox1;
        #endregion
    }
}