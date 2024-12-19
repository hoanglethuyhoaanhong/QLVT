namespace QLVT_APP
{
    partial class Frm_HDNV
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
            this.cmb_nhanVien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.de_ngayKT = new DevExpress.XtraEditors.DateEdit();
            this.de_ngayBD = new DevExpress.XtraEditors.DateEdit();
            this.btn_Preview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayKT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayKT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayBD.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOẠT ĐỘNG NHÂN VIÊN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmb_nhanVien
            // 
            this.cmb_nhanVien.FormattingEnabled = true;
            this.cmb_nhanVien.Location = new System.Drawing.Point(219, 157);
            this.cmb_nhanVien.Name = "cmb_nhanVien";
            this.cmb_nhanVien.Size = new System.Drawing.Size(89, 28);
            this.cmb_nhanVien.TabIndex = 1;
            this.cmb_nhanVien.SelectedIndexChanged += new System.EventHandler(this.cmb_nhanVien_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Họ Và tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Từ ngày:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Đến ngày:";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(541, 164);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(197, 26);
            this.tb_name.TabIndex = 6;
            // 
            // de_ngayKT
            // 
            this.de_ngayKT.EditValue = null;
            this.de_ngayKT.Location = new System.Drawing.Point(588, 266);
            this.de_ngayKT.Name = "de_ngayKT";
            this.de_ngayKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_ngayKT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_ngayKT.Size = new System.Drawing.Size(150, 26);
            this.de_ngayKT.TabIndex = 13;
            // 
            // de_ngayBD
            // 
            this.de_ngayBD.EditValue = null;
            this.de_ngayBD.Location = new System.Drawing.Point(173, 269);
            this.de_ngayBD.Name = "de_ngayBD";
            this.de_ngayBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_ngayBD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_ngayBD.Size = new System.Drawing.Size(150, 26);
            this.de_ngayBD.TabIndex = 12;
            // 
            // btn_Preview
            // 
            this.btn_Preview.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_Preview.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Preview.Location = new System.Drawing.Point(286, 358);
            this.btn_Preview.Name = "btn_Preview";
            this.btn_Preview.Size = new System.Drawing.Size(195, 39);
            this.btn_Preview.TabIndex = 16;
            this.btn_Preview.Text = "Preview";
            this.btn_Preview.UseVisualStyleBackColor = false;
            this.btn_Preview.Click += new System.EventHandler(this.btn_Preview_Click);
            // 
            // Frm_HDNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Preview);
            this.Controls.Add(this.de_ngayKT);
            this.Controls.Add(this.de_ngayBD);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_nhanVien);
            this.Controls.Add(this.label1);
            this.Name = "Frm_HDNV";
            this.Text = "Frm_HDNV";
            this.Load += new System.EventHandler(this.Frm_HDNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayKT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayKT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayBD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayBD.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_nhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_name;
        private DevExpress.XtraEditors.DateEdit de_ngayKT;
        private DevExpress.XtraEditors.DateEdit de_ngayBD;
        private System.Windows.Forms.Button btn_Preview;
    }
}