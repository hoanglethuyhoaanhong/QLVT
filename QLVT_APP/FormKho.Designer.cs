namespace QLVT_APP
{
    partial class FormKho
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
			System.Windows.Forms.Label maKhoLabel;
			System.Windows.Forms.Label tenKhoLabel;
			System.Windows.Forms.Label diaChiLabel;
			System.Windows.Forms.Label mACNLabel;
			this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.bar2 = new DevExpress.XtraBars.Bar();
			this.add = new DevExpress.XtraBars.BarButtonItem();
			this.remove = new DevExpress.XtraBars.BarButtonItem();
			this.save = new DevExpress.XtraBars.BarButtonItem();
			this.undo = new DevExpress.XtraBars.BarButtonItem();
			this.exit = new DevExpress.XtraBars.BarButtonItem();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.groupControl_Kho = new DevExpress.XtraEditors.GroupControl();
			this.khoGridControl = new DevExpress.XtraGrid.GridControl();
			this.khoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dS = new QLVT_APP.DS();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colMaKho = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTenKho = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
			this.groupControl_edit = new DevExpress.XtraEditors.GroupControl();
			this.TE_maCN = new DevExpress.XtraEditors.TextEdit();
			this.TE_DC = new DevExpress.XtraEditors.TextEdit();
			this.TE_tenKho = new DevExpress.XtraEditors.TextEdit();
			this.sp_MaKho = new DevExpress.XtraEditors.SpinEdit();
			this.khoTableAdapter = new QLVT_APP.DSTableAdapters.KhoTableAdapter();
			this.tableAdapterManager = new QLVT_APP.DSTableAdapters.TableAdapterManager();
			maKhoLabel = new System.Windows.Forms.Label();
			tenKhoLabel = new System.Windows.Forms.Label();
			diaChiLabel = new System.Windows.Forms.Label();
			mACNLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl_Kho)).BeginInit();
			this.groupControl_Kho.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.khoGridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl_edit)).BeginInit();
			this.groupControl_edit.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TE_maCN.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TE_DC.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TE_tenKho.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sp_MaKho.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// maKhoLabel
			// 
			maKhoLabel.AutoSize = true;
			maKhoLabel.Location = new System.Drawing.Point(83, 74);
			maKhoLabel.Name = "maKhoLabel";
			maKhoLabel.Size = new System.Drawing.Size(67, 19);
			maKhoLabel.TabIndex = 0;
			maKhoLabel.Text = "Ma Kho:";
			// 
			// tenKhoLabel
			// 
			tenKhoLabel.AutoSize = true;
			tenKhoLabel.Location = new System.Drawing.Point(490, 74);
			tenKhoLabel.Name = "tenKhoLabel";
			tenKhoLabel.Size = new System.Drawing.Size(74, 19);
			tenKhoLabel.TabIndex = 2;
			tenKhoLabel.Text = "Ten Kho:";
			// 
			// diaChiLabel
			// 
			diaChiLabel.AutoSize = true;
			diaChiLabel.Location = new System.Drawing.Point(84, 140);
			diaChiLabel.Name = "diaChiLabel";
			diaChiLabel.Size = new System.Drawing.Size(66, 19);
			diaChiLabel.TabIndex = 4;
			diaChiLabel.Text = "Dia Chi:";
			// 
			// mACNLabel
			// 
			mACNLabel.AutoSize = true;
			mACNLabel.Location = new System.Drawing.Point(505, 136);
			mACNLabel.Name = "mACNLabel";
			mACNLabel.Size = new System.Drawing.Size(59, 19);
			mACNLabel.TabIndex = 6;
			mACNLabel.Text = "MACN:";
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
            this.save,
            this.undo,
            this.exit});
			this.barManager1.MainMenu = this.bar2;
			this.barManager1.MaxItemId = 5;
			// 
			// bar2
			// 
			this.bar2.BarName = "Main menu";
			this.bar2.DockCol = 0;
			this.bar2.DockRow = 0;
			this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.add),
            new DevExpress.XtraBars.LinkPersistInfo(this.remove),
            new DevExpress.XtraBars.LinkPersistInfo(this.save),
            new DevExpress.XtraBars.LinkPersistInfo(this.undo),
            new DevExpress.XtraBars.LinkPersistInfo(this.exit)});
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
			// save
			// 
			this.save.Caption = "Lưu";
			this.save.Id = 2;
			this.save.Name = "save";
			this.save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.save_ItemClick);
			// 
			// undo
			// 
			this.undo.Caption = "Undo";
			this.undo.Id = 3;
			this.undo.Name = "undo";
			this.undo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.undo_ItemClick);
			// 
			// exit
			// 
			this.exit.Caption = "Thoát";
			this.exit.Id = 4;
			this.exit.Name = "exit";
			this.exit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.exit_ItemClick);
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.barManager1;
			this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
			this.barDockControlTop.Size = new System.Drawing.Size(948, 28);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 642);
			this.barDockControlBottom.Manager = this.barManager1;
			this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
			this.barDockControlBottom.Size = new System.Drawing.Size(948, 0);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 28);
			this.barDockControlLeft.Manager = this.barManager1;
			this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 614);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(948, 28);
			this.barDockControlRight.Manager = this.barManager1;
			this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
			this.barDockControlRight.Size = new System.Drawing.Size(0, 614);
			// 
			// groupControl_Kho
			// 
			this.groupControl_Kho.Controls.Add(this.khoGridControl);
			this.groupControl_Kho.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupControl_Kho.Location = new System.Drawing.Point(0, 28);
			this.groupControl_Kho.Name = "groupControl_Kho";
			this.groupControl_Kho.Size = new System.Drawing.Size(948, 427);
			this.groupControl_Kho.TabIndex = 4;
			this.groupControl_Kho.Text = "Bảng thông tin kho";
			// 
			// khoGridControl
			// 
			this.khoGridControl.DataSource = this.khoBindingSource;
			this.khoGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.khoGridControl.Location = new System.Drawing.Point(2, 34);
			this.khoGridControl.MainView = this.gridView1;
			this.khoGridControl.MenuManager = this.barManager1;
			this.khoGridControl.Name = "khoGridControl";
			this.khoGridControl.Size = new System.Drawing.Size(944, 391);
			this.khoGridControl.TabIndex = 0;
			this.khoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// khoBindingSource
			// 
			this.khoBindingSource.DataMember = "Kho";
			this.khoBindingSource.DataSource = this.dS;
			// 
			// dS
			// 
			this.dS.DataSetName = "DS";
			this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaKho,
            this.colTenKho,
            this.colDiaChi,
            this.colMACN});
			this.gridView1.GridControl = this.khoGridControl;
			this.gridView1.Name = "gridView1";
			// 
			// colMaKho
			// 
			this.colMaKho.FieldName = "MaKho";
			this.colMaKho.MinWidth = 30;
			this.colMaKho.Name = "colMaKho";
			this.colMaKho.OptionsColumn.ReadOnly = true;
			this.colMaKho.Visible = true;
			this.colMaKho.VisibleIndex = 0;
			this.colMaKho.Width = 112;
			// 
			// colTenKho
			// 
			this.colTenKho.FieldName = "TenKho";
			this.colTenKho.MinWidth = 30;
			this.colTenKho.Name = "colTenKho";
			this.colTenKho.OptionsColumn.ReadOnly = true;
			this.colTenKho.Visible = true;
			this.colTenKho.VisibleIndex = 1;
			this.colTenKho.Width = 112;
			// 
			// colDiaChi
			// 
			this.colDiaChi.FieldName = "DiaChi";
			this.colDiaChi.MinWidth = 30;
			this.colDiaChi.Name = "colDiaChi";
			this.colDiaChi.OptionsColumn.ReadOnly = true;
			this.colDiaChi.Visible = true;
			this.colDiaChi.VisibleIndex = 2;
			this.colDiaChi.Width = 112;
			// 
			// colMACN
			// 
			this.colMACN.FieldName = "MACN";
			this.colMACN.MinWidth = 30;
			this.colMACN.Name = "colMACN";
			this.colMACN.OptionsColumn.ReadOnly = true;
			this.colMACN.Visible = true;
			this.colMACN.VisibleIndex = 3;
			this.colMACN.Width = 112;
			// 
			// groupControl_edit
			// 
			this.groupControl_edit.Controls.Add(mACNLabel);
			this.groupControl_edit.Controls.Add(this.TE_maCN);
			this.groupControl_edit.Controls.Add(diaChiLabel);
			this.groupControl_edit.Controls.Add(this.TE_DC);
			this.groupControl_edit.Controls.Add(tenKhoLabel);
			this.groupControl_edit.Controls.Add(this.TE_tenKho);
			this.groupControl_edit.Controls.Add(maKhoLabel);
			this.groupControl_edit.Controls.Add(this.sp_MaKho);
			this.groupControl_edit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupControl_edit.Enabled = false;
			this.groupControl_edit.Location = new System.Drawing.Point(0, 455);
			this.groupControl_edit.Name = "groupControl_edit";
			this.groupControl_edit.Size = new System.Drawing.Size(948, 187);
			this.groupControl_edit.TabIndex = 5;
			this.groupControl_edit.Text = "Thông tin kho";
			// 
			// TE_maCN
			// 
			this.TE_maCN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoBindingSource, "MACN", true));
			this.TE_maCN.Enabled = false;
			this.TE_maCN.Location = new System.Drawing.Point(570, 133);
			this.TE_maCN.MenuManager = this.barManager1;
			this.TE_maCN.Name = "TE_maCN";
			this.TE_maCN.Size = new System.Drawing.Size(150, 26);
			this.TE_maCN.TabIndex = 7;
			// 
			// TE_DC
			// 
			this.TE_DC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoBindingSource, "DiaChi", true));
			this.TE_DC.Location = new System.Drawing.Point(156, 137);
			this.TE_DC.MenuManager = this.barManager1;
			this.TE_DC.Name = "TE_DC";
			this.TE_DC.Size = new System.Drawing.Size(150, 26);
			this.TE_DC.TabIndex = 5;
			// 
			// TE_tenKho
			// 
			this.TE_tenKho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoBindingSource, "TenKho", true));
			this.TE_tenKho.Location = new System.Drawing.Point(570, 71);
			this.TE_tenKho.MenuManager = this.barManager1;
			this.TE_tenKho.Name = "TE_tenKho";
			this.TE_tenKho.Size = new System.Drawing.Size(150, 26);
			this.TE_tenKho.TabIndex = 3;
			// 
			// sp_MaKho
			// 
			this.sp_MaKho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoBindingSource, "MaKho", true));
			this.sp_MaKho.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.sp_MaKho.Enabled = false;
			this.sp_MaKho.Location = new System.Drawing.Point(156, 71);
			this.sp_MaKho.MenuManager = this.barManager1;
			this.sp_MaKho.Name = "sp_MaKho";
			this.sp_MaKho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.sp_MaKho.Size = new System.Drawing.Size(150, 28);
			this.sp_MaKho.TabIndex = 1;
			// 
			// khoTableAdapter
			// 
			this.khoTableAdapter.ClearBeforeFill = true;
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
			this.tableAdapterManager.KhachHangTableAdapter = null;
			this.tableAdapterManager.KhoTableAdapter = this.khoTableAdapter;
			this.tableAdapterManager.LoaiHangTableAdapter = null;
			this.tableAdapterManager.NhaCungCapTableAdapter = null;
			this.tableAdapterManager.NhanVienTableAdapter = null;
			this.tableAdapterManager.PhieuNhapTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = QLVT_APP.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// FormKho
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(948, 642);
			this.Controls.Add(this.groupControl_edit);
			this.Controls.Add(this.groupControl_Kho);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FormKho";
			this.Text = "FormKho";
			this.Load += new System.EventHandler(this.FormKho_Load);
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl_Kho)).EndInit();
			this.groupControl_Kho.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.khoGridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl_edit)).EndInit();
			this.groupControl_edit.ResumeLayout(false);
			this.groupControl_edit.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.TE_maCN.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TE_DC.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TE_tenKho.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sp_MaKho.Properties)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem save;
        private DevExpress.XtraBars.BarButtonItem undo;
        private DevExpress.XtraBars.BarButtonItem exit;
        private System.Windows.Forms.BindingSource khoBindingSource;
        private DS dS;
        private DevExpress.XtraEditors.GroupControl groupControl_edit;
        private DevExpress.XtraEditors.GroupControl groupControl_Kho;
        private DSTableAdapters.KhoTableAdapter khoTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl khoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit TE_DC;
        private DevExpress.XtraEditors.TextEdit TE_tenKho;
        private DevExpress.XtraEditors.SpinEdit sp_MaKho;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKho;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKho;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraEditors.TextEdit TE_maCN;
    }
}