namespace QLVT_APP
{
    partial class Frm_TongHopNX
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
            this.label2 = new System.Windows.Forms.Label();
            this.de_ngayBD = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.de_ngayKT = new DevExpress.XtraEditors.DateEdit();
            this.btn_Preview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayBD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayKT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayKT.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(204, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ngày Bắt Đầu:";
            // 
            // de_ngayBD
            // 
            this.de_ngayBD.EditValue = null;
            this.de_ngayBD.Location = new System.Drawing.Point(399, 92);
            this.de_ngayBD.Name = "de_ngayBD";
            this.de_ngayBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_ngayBD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_ngayBD.Size = new System.Drawing.Size(150, 26);
            this.de_ngayBD.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(204, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ngày Kết Thúc:";
            // 
            // de_ngayKT
            // 
            this.de_ngayKT.EditValue = null;
            this.de_ngayKT.Location = new System.Drawing.Point(399, 202);
            this.de_ngayKT.Name = "de_ngayKT";
            this.de_ngayKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_ngayKT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_ngayKT.Size = new System.Drawing.Size(150, 26);
            this.de_ngayKT.TabIndex = 11;
            // 
            // btn_Preview
            // 
            this.btn_Preview.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_Preview.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Preview.Location = new System.Drawing.Point(269, 311);
            this.btn_Preview.Name = "btn_Preview";
            this.btn_Preview.Size = new System.Drawing.Size(195, 39);
            this.btn_Preview.TabIndex = 15;
            this.btn_Preview.Text = "Preview";
            this.btn_Preview.UseVisualStyleBackColor = false;
            this.btn_Preview.Click += new System.EventHandler(this.btn_Preview_Click);
            // 
            // Frm_TongHopNX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Preview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.de_ngayKT);
            this.Controls.Add(this.de_ngayBD);
            this.Controls.Add(this.label2);
            this.Name = "Frm_TongHopNX";
            this.Text = "Frm_TongHopNX";
            this.Load += new System.EventHandler(this.Frm_TongHopNX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayBD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayKT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayKT.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit de_ngayBD;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit de_ngayKT;
        private System.Windows.Forms.Button btn_Preview;
    }
}