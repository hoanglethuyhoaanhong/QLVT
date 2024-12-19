namespace QLVT_APP
{
    partial class Form_KH
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label maKHLabel;
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label hoLabel;
            System.Windows.Forms.Label tenLabel;
            System.Windows.Forms.Label maCNLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.add = new DevExpress.XtraBars.BarButtonItem();
            this.remove = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl_KH = new DevExpress.XtraEditors.GroupControl();
            this.khachHangGridControl = new DevExpress.XtraGrid.GridControl();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLVT_APP.DS();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaCN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl_edit = new DevExpress.XtraEditors.GroupControl();
            this.khachHangTableAdapter = new QLVT_APP.DSTableAdapters.KhachHangTableAdapter();
            this.tableAdapterManager = new QLVT_APP.DSTableAdapters.TableAdapterManager();
            this.maKHSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.diaChiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.sDTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tenTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.maCNTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.save = new DevExpress.XtraBars.BarButtonItem();
            maKHLabel = new System.Windows.Forms.Label();
            diaChiLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            hoLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            maCNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_KH)).BeginInit();
            this.groupControl_KH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_edit)).BeginInit();
            this.groupControl_edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maKHSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaChiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maCNTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.add,
            this.remove,
            this.save});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(558, 192);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.add),
            new DevExpress.XtraBars.LinkPersistInfo(this.remove),
            new DevExpress.XtraBars.LinkPersistInfo(this.save)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // add
            // 
            this.add.Caption = "Thêm";
            this.add.Id = 0;
            this.add.Name = "add";
            this.add.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.add_ItemClick);
            // 
            // remove
            // 
            this.remove.Caption = "Xóa";
            this.remove.Id = 1;
            this.remove.Name = "remove";
            this.remove.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.remove_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1059, 28);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 618);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1059, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 28);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 590);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1059, 28);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 590);
            // 
            // groupControl_KH
            // 
            this.groupControl_KH.Controls.Add(this.khachHangGridControl);
            this.groupControl_KH.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl_KH.Location = new System.Drawing.Point(0, 28);
            this.groupControl_KH.Name = "groupControl_KH";
            this.groupControl_KH.Size = new System.Drawing.Size(1059, 390);
            this.groupControl_KH.TabIndex = 4;
            this.groupControl_KH.Text = "Bảng Khách hàng";
            // 
            // khachHangGridControl
            // 
            this.khachHangGridControl.DataSource = this.khachHangBindingSource;
            this.khachHangGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.khachHangGridControl.Location = new System.Drawing.Point(2, 34);
            this.khachHangGridControl.MainView = this.gridView1;
            this.khachHangGridControl.MenuManager = this.barManager1;
            this.khachHangGridControl.Name = "khachHangGridControl";
            this.khachHangGridControl.Size = new System.Drawing.Size(1055, 354);
            this.khachHangGridControl.TabIndex = 0;
            this.khachHangGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaKH,
            this.colHo,
            this.colTen,
            this.colDiaChi,
            this.colSDT,
            this.colMaCN});
            this.gridView1.GridControl = this.khachHangGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMaKH
            // 
            this.colMaKH.FieldName = "MaKH";
            this.colMaKH.MinWidth = 30;
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.OptionsColumn.ReadOnly = true;
            this.colMaKH.Visible = true;
            this.colMaKH.VisibleIndex = 0;
            this.colMaKH.Width = 112;
            // 
            // colHo
            // 
            this.colHo.FieldName = "Ho";
            this.colHo.MinWidth = 30;
            this.colHo.Name = "colHo";
            this.colHo.OptionsColumn.ReadOnly = true;
            this.colHo.Visible = true;
            this.colHo.VisibleIndex = 1;
            this.colHo.Width = 112;
            // 
            // colTen
            // 
            this.colTen.FieldName = "Ten";
            this.colTen.MinWidth = 30;
            this.colTen.Name = "colTen";
            this.colTen.OptionsColumn.ReadOnly = true;
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 2;
            this.colTen.Width = 112;
            // 
            // colDiaChi
            // 
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.MinWidth = 30;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.OptionsColumn.ReadOnly = true;
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 3;
            this.colDiaChi.Width = 112;
            // 
            // colSDT
            // 
            this.colSDT.FieldName = "SDT";
            this.colSDT.MinWidth = 30;
            this.colSDT.Name = "colSDT";
            this.colSDT.OptionsColumn.ReadOnly = true;
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 4;
            this.colSDT.Width = 112;
            // 
            // colMaCN
            // 
            this.colMaCN.FieldName = "MaCN";
            this.colMaCN.MinWidth = 30;
            this.colMaCN.Name = "colMaCN";
            this.colMaCN.OptionsColumn.ReadOnly = true;
            this.colMaCN.Visible = true;
            this.colMaCN.VisibleIndex = 5;
            this.colMaCN.Width = 112;
            // 
            // groupControl_edit
            // 
            this.groupControl_edit.Controls.Add(maCNLabel);
            this.groupControl_edit.Controls.Add(this.maCNTextEdit);
            this.groupControl_edit.Controls.Add(tenLabel);
            this.groupControl_edit.Controls.Add(this.tenTextEdit);
            this.groupControl_edit.Controls.Add(hoLabel);
            this.groupControl_edit.Controls.Add(this.hoTextEdit);
            this.groupControl_edit.Controls.Add(sDTLabel);
            this.groupControl_edit.Controls.Add(this.sDTTextEdit);
            this.groupControl_edit.Controls.Add(diaChiLabel);
            this.groupControl_edit.Controls.Add(this.diaChiTextEdit);
            this.groupControl_edit.Controls.Add(maKHLabel);
            this.groupControl_edit.Controls.Add(this.maKHSpinEdit);
            this.groupControl_edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl_edit.Enabled = false;
            this.groupControl_edit.Location = new System.Drawing.Point(0, 418);
            this.groupControl_edit.Name = "groupControl_edit";
            this.groupControl_edit.Size = new System.Drawing.Size(1059, 200);
            this.groupControl_edit.TabIndex = 5;
            this.groupControl_edit.Text = "Thông tin khách";
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CT_DonDatHangTableAdapter = null;
            this.tableAdapterManager.CT_HoaDonTableAdapter = null;
            this.tableAdapterManager.CT_NhanVienTableAdapter = null;
            this.tableAdapterManager.CT_PhieuNhapTableAdapter = null;
            this.tableAdapterManager.DonDatHangTableAdapter = null;
            this.tableAdapterManager.HangHoaTableAdapter = null;
            this.tableAdapterManager.HoaDonTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = this.khachHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.LoaiHangTableAdapter = null;
            this.tableAdapterManager.NhaCungCapTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_APP.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // maKHLabel
            // 
            maKHLabel.AutoSize = true;
            maKHLabel.Location = new System.Drawing.Point(91, 66);
            maKHLabel.Name = "maKHLabel";
            maKHLabel.Size = new System.Drawing.Size(60, 19);
            maKHLabel.TabIndex = 0;
            maKHLabel.Text = "Ma KH:";
            // 
            // maKHSpinEdit
            // 
            this.maKHSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khachHangBindingSource, "MaKH", true));
            this.maKHSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.maKHSpinEdit.Enabled = false;
            this.maKHSpinEdit.Location = new System.Drawing.Point(157, 63);
            this.maKHSpinEdit.MenuManager = this.barManager1;
            this.maKHSpinEdit.Name = "maKHSpinEdit";
            this.maKHSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.maKHSpinEdit.Size = new System.Drawing.Size(150, 28);
            this.maKHSpinEdit.TabIndex = 1;
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Location = new System.Drawing.Point(413, 68);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(66, 19);
            diaChiLabel.TabIndex = 2;
            diaChiLabel.Text = "Dia Chi:";
            // 
            // diaChiTextEdit
            // 
            this.diaChiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khachHangBindingSource, "DiaChi", true));
            this.diaChiTextEdit.Location = new System.Drawing.Point(485, 65);
            this.diaChiTextEdit.MenuManager = this.barManager1;
            this.diaChiTextEdit.Name = "diaChiTextEdit";
            this.diaChiTextEdit.Size = new System.Drawing.Size(150, 26);
            this.diaChiTextEdit.TabIndex = 3;
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(778, 74);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(45, 19);
            sDTLabel.TabIndex = 4;
            sDTLabel.Text = "SDT:";
            // 
            // sDTTextEdit
            // 
            this.sDTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khachHangBindingSource, "SDT", true));
            this.sDTTextEdit.Location = new System.Drawing.Point(829, 71);
            this.sDTTextEdit.MenuManager = this.barManager1;
            this.sDTTextEdit.Name = "sDTTextEdit";
            this.sDTTextEdit.Size = new System.Drawing.Size(150, 26);
            this.sDTTextEdit.TabIndex = 5;
            // 
            // hoLabel
            // 
            hoLabel.AutoSize = true;
            hoLabel.Location = new System.Drawing.Point(116, 134);
            hoLabel.Name = "hoLabel";
            hoLabel.Size = new System.Drawing.Size(35, 19);
            hoLabel.TabIndex = 6;
            hoLabel.Text = "Ho:";
            // 
            // hoTextEdit
            // 
            this.hoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khachHangBindingSource, "Ho", true));
            this.hoTextEdit.Location = new System.Drawing.Point(157, 131);
            this.hoTextEdit.MenuManager = this.barManager1;
            this.hoTextEdit.Name = "hoTextEdit";
            this.hoTextEdit.Size = new System.Drawing.Size(150, 26);
            this.hoTextEdit.TabIndex = 7;
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Location = new System.Drawing.Point(437, 134);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(42, 19);
            tenLabel.TabIndex = 8;
            tenLabel.Text = "Ten:";
            // 
            // tenTextEdit
            // 
            this.tenTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khachHangBindingSource, "Ten", true));
            this.tenTextEdit.Location = new System.Drawing.Point(485, 131);
            this.tenTextEdit.MenuManager = this.barManager1;
            this.tenTextEdit.Name = "tenTextEdit";
            this.tenTextEdit.Size = new System.Drawing.Size(150, 26);
            this.tenTextEdit.TabIndex = 9;
            // 
            // maCNLabel
            // 
            maCNLabel.AutoSize = true;
            maCNLabel.Location = new System.Drawing.Point(762, 134);
            maCNLabel.Name = "maCNLabel";
            maCNLabel.Size = new System.Drawing.Size(61, 19);
            maCNLabel.TabIndex = 10;
            maCNLabel.Text = "Ma CN:";
            // 
            // maCNTextEdit
            // 
            this.maCNTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khachHangBindingSource, "MaCN", true));
            this.maCNTextEdit.Enabled = false;
            this.maCNTextEdit.Location = new System.Drawing.Point(829, 131);
            this.maCNTextEdit.MenuManager = this.barManager1;
            this.maCNTextEdit.Name = "maCNTextEdit";
            this.maCNTextEdit.Size = new System.Drawing.Size(150, 26);
            this.maCNTextEdit.TabIndex = 11;
            // 
            // save
            // 
            this.save.Caption = "Lưu";
            this.save.Id = 2;
            this.save.Name = "save";
            this.save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.save_ItemClick);
            // 
            // Form_KH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 618);
            this.Controls.Add(this.groupControl_edit);
            this.Controls.Add(this.groupControl_KH);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_KH";
            this.Text = "Form_KH";
            this.Load += new System.EventHandler(this.Form_KH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_KH)).EndInit();
            this.groupControl_KH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.khachHangGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_edit)).EndInit();
            this.groupControl_edit.ResumeLayout(false);
            this.groupControl_edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maKHSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaChiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maCNTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem add;
        private DevExpress.XtraBars.BarButtonItem remove;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private DS dS;
        private DevExpress.XtraEditors.GroupControl groupControl_edit;
        private DevExpress.XtraEditors.GroupControl groupControl_KH;
        private DSTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl khachHangGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKH;
        private DevExpress.XtraGrid.Columns.GridColumn colHo;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colMaCN;
        private DevExpress.XtraBars.BarButtonItem save;
        private DevExpress.XtraEditors.TextEdit maCNTextEdit;
        private DevExpress.XtraEditors.TextEdit tenTextEdit;
        private DevExpress.XtraEditors.TextEdit hoTextEdit;
        private DevExpress.XtraEditors.TextEdit sDTTextEdit;
        private DevExpress.XtraEditors.TextEdit diaChiTextEdit;
        private DevExpress.XtraEditors.SpinEdit maKHSpinEdit;
    }
}