namespace QLVT_APP
{
    partial class Form_TaoTK
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
            this.btn_Submit = new System.Windows.Forms.Button();
            this.txt_nhom = new System.Windows.Forms.TextBox();
            this.txt_confirm = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.cmb_nhanVien = new System.Windows.Forms.ComboBox();
            this.cmb_chiNhanh = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(219, 364);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(195, 39);
            this.btn_Submit.TabIndex = 25;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // txt_nhom
            // 
            this.txt_nhom.Location = new System.Drawing.Point(354, 319);
            this.txt_nhom.Name = "txt_nhom";
            this.txt_nhom.ReadOnly = true;
            this.txt_nhom.Size = new System.Drawing.Size(126, 26);
            this.txt_nhom.TabIndex = 28;
            // 
            // txt_confirm
            // 
            this.txt_confirm.Location = new System.Drawing.Point(354, 270);
            this.txt_confirm.Name = "txt_confirm";
            this.txt_confirm.Size = new System.Drawing.Size(262, 26);
            this.txt_confirm.TabIndex = 24;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(354, 218);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(262, 26);
            this.txt_pass.TabIndex = 23;
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(354, 162);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(262, 26);
            this.txt_login.TabIndex = 22;
            // 
            // cmb_nhanVien
            // 
            this.cmb_nhanVien.FormattingEnabled = true;
            this.cmb_nhanVien.Location = new System.Drawing.Point(354, 107);
            this.cmb_nhanVien.Name = "cmb_nhanVien";
            this.cmb_nhanVien.Size = new System.Drawing.Size(262, 28);
            this.cmb_nhanVien.TabIndex = 18;
            // 
            // cmb_chiNhanh
            // 
            this.cmb_chiNhanh.FormattingEnabled = true;
            this.cmb_chiNhanh.Location = new System.Drawing.Point(354, 48);
            this.cmb_chiNhanh.Name = "cmb_chiNhanh";
            this.cmb_chiNhanh.Size = new System.Drawing.Size(262, 28);
            this.cmb_chiNhanh.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(185, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 22);
            this.label7.TabIndex = 27;
            this.label7.Text = "Nhóm          ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(185, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 22);
            this.label6.TabIndex = 21;
            this.label6.Text = "Confirm      ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(185, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "Password   ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(185, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Login Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(185, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nhân Viên  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(185, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Chi Nhánh  ";
            // 
            // Form_TaoTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txt_nhom);
            this.Controls.Add(this.txt_confirm);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.cmb_nhanVien);
            this.Controls.Add(this.cmb_chiNhanh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form_TaoTK";
            this.Text = "Form_TaoTK";
            this.Load += new System.EventHandler(this.Form_TaoTK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox txt_nhom;
        private System.Windows.Forms.TextBox txt_confirm;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.ComboBox cmb_nhanVien;
        private System.Windows.Forms.ComboBox cmb_chiNhanh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}