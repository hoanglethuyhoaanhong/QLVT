namespace QLVT_APP
{
	partial class FormVatTu
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
            System.Windows.Forms.Label maHHLabel;
            System.Windows.Forms.Label tenHHLabel;
            System.Windows.Forms.Label dVTLabel;
            System.Windows.Forms.Label mALHLabel;
            System.Windows.Forms.Label tenLHLabel;
            System.Windows.Forms.Label soLuongTonLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.add = new DevExpress.XtraBars.BarButtonItem();
            this.update = new DevExpress.XtraBars.BarButtonItem();
            this.remove = new DevExpress.XtraBars.BarButtonItem();
            this.save = new DevExpress.XtraBars.BarButtonItem();
            this.btn_undo = new DevExpress.XtraBars.BarButtonItem();
            this.refresh = new DevExpress.XtraBars.BarButtonItem();
            this.exit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl_VT = new DevExpress.XtraEditors.GroupControl();
            this.vIEW_HANGHOAGridControl = new DevExpress.XtraGrid.GridControl();
            this.vIEW_HANGHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLVT_APP.DS();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuongTon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenLH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl_edit = new DevExpress.XtraEditors.GroupControl();
            this.CBB_tenLH = new System.Windows.Forms.ComboBox();
            this.SP_soLuongTon = new DevExpress.XtraEditors.SpinEdit();
            this.SP_MALH = new DevExpress.XtraEditors.SpinEdit();
            this.hangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TE_DVT = new DevExpress.XtraEditors.TextEdit();
            this.TE_tenHH = new DevExpress.XtraEditors.TextEdit();
            this.TE_maHH = new DevExpress.XtraEditors.TextEdit();
            this.loaiHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hangHoaTableAdapter = new QLVT_APP.DSTableAdapters.HangHoaTableAdapter();
            this.tableAdapterManager = new QLVT_APP.DSTableAdapters.TableAdapterManager();
            this.vIEW_HANGHOATableAdapter = new QLVT_APP.DSTableAdapters.VIEW_HANGHOATableAdapter();
            this.loaiHangTableAdapter = new QLVT_APP.DSTableAdapters.LoaiHangTableAdapter();
            maHHLabel = new System.Windows.Forms.Label();
            tenHHLabel = new System.Windows.Forms.Label();
            dVTLabel = new System.Windows.Forms.Label();
            mALHLabel = new System.Windows.Forms.Label();
            tenLHLabel = new System.Windows.Forms.Label();
            soLuongTonLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_VT)).BeginInit();
            this.groupControl_VT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vIEW_HANGHOAGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEW_HANGHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_edit)).BeginInit();
            this.groupControl_edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SP_soLuongTon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_MALH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TE_DVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TE_tenHH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TE_maHH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // maHHLabel
            // 
            maHHLabel.AutoSize = true;
            maHHLabel.Location = new System.Drawing.Point(81, 74);
            maHHLabel.Name = "maHHLabel";
            maHHLabel.Size = new System.Drawing.Size(62, 19);
            maHHLabel.TabIndex = 0;
            maHHLabel.Text = "Ma HH:";
            // 
            // tenHHLabel
            // 
            tenHHLabel.AutoSize = true;
            tenHHLabel.Location = new System.Drawing.Point(376, 74);
            tenHHLabel.Name = "tenHHLabel";
            tenHHLabel.Size = new System.Drawing.Size(69, 19);
            tenHHLabel.TabIndex = 2;
            tenHHLabel.Text = "Ten HH:";
            // 
            // dVTLabel
            // 
            dVTLabel.AutoSize = true;
            dVTLabel.Location = new System.Drawing.Point(719, 74);
            dVTLabel.Name = "dVTLabel";
            dVTLabel.Size = new System.Drawing.Size(46, 19);
            dVTLabel.TabIndex = 4;
            dVTLabel.Text = "DVT:";
            // 
            // mALHLabel
            // 
            mALHLabel.AutoSize = true;
            mALHLabel.Location = new System.Drawing.Point(86, 135);
            mALHLabel.Name = "mALHLabel";
            mALHLabel.Size = new System.Drawing.Size(57, 19);
            mALHLabel.TabIndex = 6;
            mALHLabel.Text = "MALH:";
            // 
            // tenLHLabel
            // 
            tenLHLabel.AutoSize = true;
            tenLHLabel.Location = new System.Drawing.Point(368, 139);
            tenLHLabel.Name = "tenLHLabel";
            tenLHLabel.Size = new System.Drawing.Size(66, 19);
            tenLHLabel.TabIndex = 8;
            tenLHLabel.Text = "Ten LH:";
            // 
            // soLuongTonLabel
            // 
            soLuongTonLabel.AutoSize = true;
            soLuongTonLabel.Location = new System.Drawing.Point(650, 138);
            soLuongTonLabel.Name = "soLuongTonLabel";
            soLuongTonLabel.Size = new System.Drawing.Size(115, 19);
            soLuongTonLabel.TabIndex = 10;
            soLuongTonLabel.Text = "So Luong Ton:";
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
            this.update,
            this.remove,
            this.save,
            this.refresh,
            this.exit,
            this.btn_undo});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(563, 193);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.add),
            new DevExpress.XtraBars.LinkPersistInfo(this.update),
            new DevExpress.XtraBars.LinkPersistInfo(this.remove),
            new DevExpress.XtraBars.LinkPersistInfo(this.save),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_undo),
            new DevExpress.XtraBars.LinkPersistInfo(this.refresh),
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
            // update
            // 
            this.update.Caption = "Sửa";
            this.update.Id = 1;
            this.update.Name = "update";
            this.update.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.update_ItemClick);
            // 
            // remove
            // 
            this.remove.Caption = "Xóa";
            this.remove.Id = 2;
            this.remove.Name = "remove";
            this.remove.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.remove_ItemClick);
            // 
            // save
            // 
            this.save.Caption = "Lưu";
            this.save.Id = 3;
            this.save.Name = "save";
            this.save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.save_ItemClick);
            // 
            // btn_undo
            // 
            this.btn_undo.Caption = "Undo";
            this.btn_undo.Enabled = false;
            this.btn_undo.Id = 7;
            this.btn_undo.Name = "btn_undo";
            this.btn_undo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_undo_ItemClick);
            // 
            // refresh
            // 
            this.refresh.Caption = "Refresh";
            this.refresh.Id = 5;
            this.refresh.Name = "refresh";
            this.refresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.refresh_ItemClick);
            // 
            // exit
            // 
            this.exit.Caption = "Thoát";
            this.exit.Id = 6;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1174, 28);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 608);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1174, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 28);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 580);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1174, 28);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 580);
            // 
            // groupControl_VT
            // 
            this.groupControl_VT.Controls.Add(this.vIEW_HANGHOAGridControl);
            this.groupControl_VT.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl_VT.Location = new System.Drawing.Point(0, 28);
            this.groupControl_VT.Name = "groupControl_VT";
            this.groupControl_VT.Size = new System.Drawing.Size(1174, 395);
            this.groupControl_VT.TabIndex = 4;
            this.groupControl_VT.Text = "Bảng Hàng Hóa";
            // 
            // vIEW_HANGHOAGridControl
            // 
            this.vIEW_HANGHOAGridControl.DataSource = this.vIEW_HANGHOABindingSource;
            this.vIEW_HANGHOAGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vIEW_HANGHOAGridControl.Location = new System.Drawing.Point(2, 34);
            this.vIEW_HANGHOAGridControl.MainView = this.gridView1;
            this.vIEW_HANGHOAGridControl.MenuManager = this.barManager1;
            this.vIEW_HANGHOAGridControl.Name = "vIEW_HANGHOAGridControl";
            this.vIEW_HANGHOAGridControl.Size = new System.Drawing.Size(1170, 359);
            this.vIEW_HANGHOAGridControl.TabIndex = 0;
            this.vIEW_HANGHOAGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.vIEW_HANGHOAGridControl.Click += new System.EventHandler(this.vIEW_HANGHOAGridControl_Click_1);
            // 
            // vIEW_HANGHOABindingSource
            // 
            this.vIEW_HANGHOABindingSource.DataMember = "VIEW_HANGHOA";
            this.vIEW_HANGHOABindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaHH,
            this.colTenHH,
            this.colDVT,
            this.colSoLuongTon,
            this.colTenLH});
            this.gridView1.GridControl = this.vIEW_HANGHOAGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMaHH
            // 
            this.colMaHH.FieldName = "MaHH";
            this.colMaHH.MinWidth = 30;
            this.colMaHH.Name = "colMaHH";
            this.colMaHH.OptionsColumn.ReadOnly = true;
            this.colMaHH.Visible = true;
            this.colMaHH.VisibleIndex = 0;
            this.colMaHH.Width = 112;
            // 
            // colTenHH
            // 
            this.colTenHH.FieldName = "TenHH";
            this.colTenHH.MinWidth = 30;
            this.colTenHH.Name = "colTenHH";
            this.colTenHH.OptionsColumn.ReadOnly = true;
            this.colTenHH.Visible = true;
            this.colTenHH.VisibleIndex = 1;
            this.colTenHH.Width = 112;
            // 
            // colDVT
            // 
            this.colDVT.FieldName = "DVT";
            this.colDVT.MinWidth = 30;
            this.colDVT.Name = "colDVT";
            this.colDVT.OptionsColumn.ReadOnly = true;
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            this.colDVT.Width = 112;
            // 
            // colSoLuongTon
            // 
            this.colSoLuongTon.FieldName = "SoLuongTon";
            this.colSoLuongTon.MinWidth = 30;
            this.colSoLuongTon.Name = "colSoLuongTon";
            this.colSoLuongTon.OptionsColumn.ReadOnly = true;
            this.colSoLuongTon.Visible = true;
            this.colSoLuongTon.VisibleIndex = 3;
            this.colSoLuongTon.Width = 112;
            // 
            // colTenLH
            // 
            this.colTenLH.FieldName = "TenLH";
            this.colTenLH.MinWidth = 30;
            this.colTenLH.Name = "colTenLH";
            this.colTenLH.OptionsColumn.ReadOnly = true;
            this.colTenLH.Visible = true;
            this.colTenLH.VisibleIndex = 4;
            this.colTenLH.Width = 112;
            // 
            // groupControl_edit
            // 
            this.groupControl_edit.Controls.Add(this.CBB_tenLH);
            this.groupControl_edit.Controls.Add(soLuongTonLabel);
            this.groupControl_edit.Controls.Add(this.SP_soLuongTon);
            this.groupControl_edit.Controls.Add(tenLHLabel);
            this.groupControl_edit.Controls.Add(mALHLabel);
            this.groupControl_edit.Controls.Add(this.SP_MALH);
            this.groupControl_edit.Controls.Add(dVTLabel);
            this.groupControl_edit.Controls.Add(this.TE_DVT);
            this.groupControl_edit.Controls.Add(tenHHLabel);
            this.groupControl_edit.Controls.Add(this.TE_tenHH);
            this.groupControl_edit.Controls.Add(maHHLabel);
            this.groupControl_edit.Controls.Add(this.TE_maHH);
            this.groupControl_edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl_edit.Enabled = false;
            this.groupControl_edit.Location = new System.Drawing.Point(0, 423);
            this.groupControl_edit.Name = "groupControl_edit";
            this.groupControl_edit.Size = new System.Drawing.Size(1174, 185);
            this.groupControl_edit.TabIndex = 5;
            this.groupControl_edit.Text = "Thông TIn Hàng Hóa";
            // 
            // CBB_tenLH
            // 
            this.CBB_tenLH.FormattingEnabled = true;
            this.CBB_tenLH.Location = new System.Drawing.Point(440, 135);
            this.CBB_tenLH.Name = "CBB_tenLH";
            this.CBB_tenLH.Size = new System.Drawing.Size(121, 27);
            this.CBB_tenLH.TabIndex = 12;
            this.CBB_tenLH.SelectedIndexChanged += new System.EventHandler(this.CBB_tenLH_SelectedIndexChanged);
            // 
            // SP_soLuongTon
            // 
            this.SP_soLuongTon.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vIEW_HANGHOABindingSource, "SoLuongTon", true));
            this.SP_soLuongTon.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SP_soLuongTon.Enabled = false;
            this.SP_soLuongTon.Location = new System.Drawing.Point(771, 135);
            this.SP_soLuongTon.MenuManager = this.barManager1;
            this.SP_soLuongTon.Name = "SP_soLuongTon";
            this.SP_soLuongTon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SP_soLuongTon.Size = new System.Drawing.Size(150, 28);
            this.SP_soLuongTon.TabIndex = 11;
            // 
            // SP_MALH
            // 
            this.SP_MALH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hangHoaBindingSource, "MALH", true));
            this.SP_MALH.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SP_MALH.Enabled = false;
            this.SP_MALH.Location = new System.Drawing.Point(149, 132);
            this.SP_MALH.MenuManager = this.barManager1;
            this.SP_MALH.Name = "SP_MALH";
            this.SP_MALH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SP_MALH.Size = new System.Drawing.Size(150, 28);
            this.SP_MALH.TabIndex = 7;
            // 
            // hangHoaBindingSource
            // 
            this.hangHoaBindingSource.DataMember = "HangHoa";
            this.hangHoaBindingSource.DataSource = this.dS;
            // 
            // TE_DVT
            // 
            this.TE_DVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hangHoaBindingSource, "DVT", true));
            this.TE_DVT.Location = new System.Drawing.Point(771, 71);
            this.TE_DVT.MenuManager = this.barManager1;
            this.TE_DVT.Name = "TE_DVT";
            this.TE_DVT.Size = new System.Drawing.Size(150, 26);
            this.TE_DVT.TabIndex = 5;
            // 
            // TE_tenHH
            // 
            this.TE_tenHH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hangHoaBindingSource, "TenHH", true));
            this.TE_tenHH.Location = new System.Drawing.Point(451, 71);
            this.TE_tenHH.MenuManager = this.barManager1;
            this.TE_tenHH.Name = "TE_tenHH";
            this.TE_tenHH.Size = new System.Drawing.Size(150, 26);
            this.TE_tenHH.TabIndex = 3;
            // 
            // TE_maHH
            // 
            this.TE_maHH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hangHoaBindingSource, "MaHH", true));
            this.TE_maHH.Enabled = false;
            this.TE_maHH.Location = new System.Drawing.Point(149, 71);
            this.TE_maHH.MenuManager = this.barManager1;
            this.TE_maHH.Name = "TE_maHH";
            this.TE_maHH.Size = new System.Drawing.Size(150, 26);
            this.TE_maHH.TabIndex = 1;
            // 
            // loaiHangBindingSource
            // 
            this.loaiHangBindingSource.DataMember = "LoaiHang";
            this.loaiHangBindingSource.DataSource = this.dS;
            // 
            // hangHoaTableAdapter
            // 
            this.hangHoaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.HangHoaTableAdapter = this.hangHoaTableAdapter;
            this.tableAdapterManager.HoaDonTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.LoaiHangTableAdapter = null;
            this.tableAdapterManager.NhaCungCapTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_APP.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // vIEW_HANGHOATableAdapter
            // 
            this.vIEW_HANGHOATableAdapter.ClearBeforeFill = true;
            // 
            // loaiHangTableAdapter
            // 
            this.loaiHangTableAdapter.ClearBeforeFill = true;
            // 
            // FormVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 608);
            this.Controls.Add(this.groupControl_edit);
            this.Controls.Add(this.groupControl_VT);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormVatTu";
            this.Text = "FormVatTu";
            this.Load += new System.EventHandler(this.FormVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_VT)).EndInit();
            this.groupControl_VT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vIEW_HANGHOAGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEW_HANGHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_edit)).EndInit();
            this.groupControl_edit.ResumeLayout(false);
            this.groupControl_edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SP_soLuongTon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_MALH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TE_DVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TE_tenHH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TE_maHH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHangBindingSource)).EndInit();
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
		private DevExpress.XtraBars.BarButtonItem update;
		private DevExpress.XtraBars.BarButtonItem remove;
		private DevExpress.XtraBars.BarButtonItem save;
		private DevExpress.XtraBars.BarButtonItem refresh;
		private DevExpress.XtraBars.BarButtonItem exit;
		private System.Windows.Forms.BindingSource hangHoaBindingSource;
		private DS dS;
		private DevExpress.XtraEditors.GroupControl groupControl_edit;
		private DevExpress.XtraEditors.GroupControl groupControl_VT;
		private DSTableAdapters.HangHoaTableAdapter hangHoaTableAdapter;
		private DSTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingSource vIEW_HANGHOABindingSource;
		private DSTableAdapters.VIEW_HANGHOATableAdapter vIEW_HANGHOATableAdapter;
		private DevExpress.XtraEditors.SpinEdit SP_MALH;
		private DevExpress.XtraEditors.TextEdit TE_DVT;
		private DevExpress.XtraEditors.TextEdit TE_tenHH;
		private DevExpress.XtraEditors.TextEdit TE_maHH;
		private System.Windows.Forms.BindingSource loaiHangBindingSource;
		private DSTableAdapters.LoaiHangTableAdapter loaiHangTableAdapter;
        private DevExpress.XtraGrid.GridControl vIEW_HANGHOAGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHH;
        private DevExpress.XtraGrid.Columns.GridColumn colTenHH;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuongTon;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLH;
        private DevExpress.XtraEditors.SpinEdit SP_soLuongTon;
        private System.Windows.Forms.ComboBox CBB_tenLH;
        private DevExpress.XtraBars.BarButtonItem btn_undo;
    }
}