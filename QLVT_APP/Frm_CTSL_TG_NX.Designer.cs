namespace QLVT_APP
{
    partial class Frm_CTSL_TG_NX
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.de_ngayKT = new DevExpress.XtraEditors.DateEdit();
            this.de_ngayBD = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Loai = new System.Windows.Forms.ComboBox();
            this.btn_Preview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayKT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayKT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayBD.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(385, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ngày Kết Thúc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(385, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ngày Bắt Đầu:";
            // 
            // de_ngayKT
            // 
            this.de_ngayKT.EditValue = null;
            this.de_ngayKT.Location = new System.Drawing.Point(509, 190);
            this.de_ngayKT.Name = "de_ngayKT";
            this.de_ngayKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_ngayKT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_ngayKT.Size = new System.Drawing.Size(150, 26);
            this.de_ngayKT.TabIndex = 7;
            // 
            // de_ngayBD
            // 
            this.de_ngayBD.EditValue = null;
            this.de_ngayBD.Location = new System.Drawing.Point(509, 80);
            this.de_ngayBD.Name = "de_ngayBD";
            this.de_ngayBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_ngayBD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_ngayBD.Size = new System.Drawing.Size(150, 26);
            this.de_ngayBD.TabIndex = 6;
            this.de_ngayBD.EditValueChanged += new System.EventHandler(this.de_ngayBD_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(28, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "TRA CỨU";
            // 
            // cmb_Loai
            // 
            this.cmb_Loai.FormattingEnabled = true;
            this.cmb_Loai.Items.AddRange(new object[] {
            "NHẬP,",
            "XUẤT"});
            this.cmb_Loai.Location = new System.Drawing.Point(170, 126);
            this.cmb_Loai.Name = "cmb_Loai";
            this.cmb_Loai.Size = new System.Drawing.Size(190, 28);
            this.cmb_Loai.TabIndex = 10;
            this.cmb_Loai.Text = "NHẬP";
            // 
            // btn_Preview
            // 
            this.btn_Preview.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_Preview.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Preview.Location = new System.Drawing.Point(294, 315);
            this.btn_Preview.Name = "btn_Preview";
            this.btn_Preview.Size = new System.Drawing.Size(195, 39);
            this.btn_Preview.TabIndex = 14;
            this.btn_Preview.Text = "Preview";
            this.btn_Preview.UseVisualStyleBackColor = false;
            this.btn_Preview.Click += new System.EventHandler(this.btn_Preview_Click);
            // 
            // Frm_CTSL_TG_NX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Preview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Loai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.de_ngayKT);
            this.Controls.Add(this.de_ngayBD);
            this.Name = "Frm_CTSL_TG_NX";
            this.Text = "Frm_CTSL_TG_NX";
            this.Load += new System.EventHandler(this.Frm_CTSL_TG_NX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayKT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayKT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayBD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayBD.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit de_ngayKT;
        private DevExpress.XtraEditors.DateEdit de_ngayBD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Loai;
        private System.Windows.Forms.Button btn_Preview;
    }
}