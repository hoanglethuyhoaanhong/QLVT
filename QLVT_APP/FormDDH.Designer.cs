namespace QLVT_APP
{
	partial class FormDDH
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
            System.Windows.Forms.Label soDDHLabel;
            System.Windows.Forms.Label ngayLapLabel;
            System.Windows.Forms.Label maNCCLabel;
            System.Windows.Forms.Label maKhoLabel;
            System.Windows.Forms.Label soDDHLabel1;
            System.Windows.Forms.Label maHHLabel;
            System.Windows.Forms.Label soLuongLabel;
            System.Windows.Forms.Label donGiaLabel;
            System.Windows.Forms.Label maNVLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.add = new DevExpress.XtraBars.BarButtonItem();
            this.update = new DevExpress.XtraBars.BarButtonItem();
            this.remove = new DevExpress.XtraBars.BarButtonItem();
            this.save = new DevExpress.XtraBars.BarButtonItem();
            this.undo = new DevExpress.XtraBars.BarButtonItem();
            this.refresh = new DevExpress.XtraBars.BarButtonItem();
            this.exit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl_DDH = new DevExpress.XtraEditors.GroupControl();
            this.donDatHangGridControl = new DevExpress.XtraGrid.GridControl();
            this.donDatHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLVT_APP.DS();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl_CTDDH = new DevExpress.XtraEditors.GroupControl();
            this.btn_HH = new System.Windows.Forms.Button();
            this.btn_DDH = new System.Windows.Forms.Button();
            this.cT_DonDatHangDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cT_DonDatHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl_editCT = new DevExpress.XtraEditors.GroupControl();
            this.CBB_HH = new System.Windows.Forms.ComboBox();
            this.SP_DG = new DevExpress.XtraEditors.SpinEdit();
            this.SP_SL = new DevExpress.XtraEditors.SpinEdit();
            this.SP_maHH = new DevExpress.XtraEditors.SpinEdit();
            this.SP_SDDH_CT = new DevExpress.XtraEditors.SpinEdit();
            this.groupControl_edit = new DevExpress.XtraEditors.GroupControl();
            this.SP_maNV = new DevExpress.XtraEditors.SpinEdit();
            this.CBB_Kho = new System.Windows.Forms.ComboBox();
            this.CBB_NCC = new System.Windows.Forms.ComboBox();
            this.SP_maKho = new DevExpress.XtraEditors.SpinEdit();
            this.SP_maNCC = new DevExpress.XtraEditors.SpinEdit();
            this.DE_NT = new DevExpress.XtraEditors.DateEdit();
            this.SP_SDDH = new DevExpress.XtraEditors.SpinEdit();
            this.donDatHangTableAdapter = new QLVT_APP.DSTableAdapters.DonDatHangTableAdapter();
            this.tableAdapterManager = new QLVT_APP.DSTableAdapters.TableAdapterManager();
            this.cT_DonDatHangTableAdapter = new QLVT_APP.DSTableAdapters.CT_DonDatHangTableAdapter();
            this.khoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoTableAdapter = new QLVT_APP.DSTableAdapters.KhoTableAdapter();
            this.nhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhaCungCapTableAdapter = new QLVT_APP.DSTableAdapters.NhaCungCapTableAdapter();
            this.hangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hangHoaTableAdapter = new QLVT_APP.DSTableAdapters.HangHoaTableAdapter();
            soDDHLabel = new System.Windows.Forms.Label();
            ngayLapLabel = new System.Windows.Forms.Label();
            maNCCLabel = new System.Windows.Forms.Label();
            maKhoLabel = new System.Windows.Forms.Label();
            soDDHLabel1 = new System.Windows.Forms.Label();
            maHHLabel = new System.Windows.Forms.Label();
            soLuongLabel = new System.Windows.Forms.Label();
            donGiaLabel = new System.Windows.Forms.Label();
            maNVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_DDH)).BeginInit();
            this.groupControl_DDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donDatHangGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donDatHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_CTDDH)).BeginInit();
            this.groupControl_CTDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cT_DonDatHangDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_DonDatHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_editCT)).BeginInit();
            this.groupControl_editCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SP_DG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_SL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_maHH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_SDDH_CT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_edit)).BeginInit();
            this.groupControl_edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SP_maNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_maKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_maNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DE_NT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DE_NT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_SDDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // soDDHLabel
            // 
            soDDHLabel.AutoSize = true;
            soDDHLabel.Location = new System.Drawing.Point(70, 42);
            soDDHLabel.Name = "soDDHLabel";
            soDDHLabel.Size = new System.Drawing.Size(71, 19);
            soDDHLabel.TabIndex = 0;
            soDDHLabel.Text = "So DDH:";
            soDDHLabel.Click += new System.EventHandler(this.soDDHLabel_Click);
            // 
            // ngayLapLabel
            // 
            ngayLapLabel.AutoSize = true;
            ngayLapLabel.Location = new System.Drawing.Point(389, 44);
            ngayLapLabel.Name = "ngayLapLabel";
            ngayLapLabel.Size = new System.Drawing.Size(81, 19);
            ngayLapLabel.TabIndex = 2;
            ngayLapLabel.Text = "Ngay Lap:";
            ngayLapLabel.Click += new System.EventHandler(this.ngayLapLabel_Click);
            // 
            // maNCCLabel
            // 
            maNCCLabel.AutoSize = true;
            maNCCLabel.Location = new System.Drawing.Point(72, 92);
            maNCCLabel.Name = "maNCCLabel";
            maNCCLabel.Size = new System.Drawing.Size(71, 19);
            maNCCLabel.TabIndex = 6;
            maNCCLabel.Text = "Ma NCC:";
            maNCCLabel.Click += new System.EventHandler(this.maNCCLabel_Click);
            // 
            // maKhoLabel
            // 
            maKhoLabel.AutoSize = true;
            maKhoLabel.Location = new System.Drawing.Point(561, 92);
            maKhoLabel.Name = "maKhoLabel";
            maKhoLabel.Size = new System.Drawing.Size(67, 19);
            maKhoLabel.TabIndex = 8;
            maKhoLabel.Text = "Ma Kho:";
            // 
            // soDDHLabel1
            // 
            soDDHLabel1.AutoSize = true;
            soDDHLabel1.Location = new System.Drawing.Point(57, 74);
            soDDHLabel1.Name = "soDDHLabel1";
            soDDHLabel1.Size = new System.Drawing.Size(71, 19);
            soDDHLabel1.TabIndex = 0;
            soDDHLabel1.Text = "So DDH:";
            // 
            // maHHLabel
            // 
            maHHLabel.AutoSize = true;
            maHHLabel.Location = new System.Drawing.Point(371, 74);
            maHHLabel.Name = "maHHLabel";
            maHHLabel.Size = new System.Drawing.Size(62, 19);
            maHHLabel.TabIndex = 2;
            maHHLabel.Text = "Ma HH:";
            // 
            // soLuongLabel
            // 
            soLuongLabel.AutoSize = true;
            soLuongLabel.Location = new System.Drawing.Point(46, 147);
            soLuongLabel.Name = "soLuongLabel";
            soLuongLabel.Size = new System.Drawing.Size(82, 19);
            soLuongLabel.TabIndex = 4;
            soLuongLabel.Text = "So Luong:";
            // 
            // donGiaLabel
            // 
            donGiaLabel.AutoSize = true;
            donGiaLabel.Location = new System.Drawing.Point(361, 147);
            donGiaLabel.Name = "donGiaLabel";
            donGiaLabel.Size = new System.Drawing.Size(72, 19);
            donGiaLabel.TabIndex = 6;
            donGiaLabel.Text = "Don Gia:";
            // 
            // maNVLabel
            // 
            maNVLabel.AutoSize = true;
            maNVLabel.Location = new System.Drawing.Point(712, 43);
            maNVLabel.Name = "maNVLabel";
            maNVLabel.Size = new System.Drawing.Size(61, 19);
            maNVLabel.TabIndex = 13;
            maNVLabel.Text = "Ma NV:";
            maNVLabel.Click += new System.EventHandler(this.maNVLabel_Click);
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
            this.undo,
            this.refresh,
            this.exit});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.add),
            new DevExpress.XtraBars.LinkPersistInfo(this.update),
            new DevExpress.XtraBars.LinkPersistInfo(this.remove),
            new DevExpress.XtraBars.LinkPersistInfo(this.save),
            new DevExpress.XtraBars.LinkPersistInfo(this.undo),
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
            // undo
            // 
            this.undo.Caption = "Undo";
            this.undo.Id = 4;
            this.undo.Name = "undo";
            this.undo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.undo_ItemClick);
            // 
            // refresh
            // 
            this.refresh.Caption = "Reload";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1944, 28);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 745);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1944, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 28);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 717);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1944, 28);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 717);
            // 
            // groupControl_DDH
            // 
            this.groupControl_DDH.Controls.Add(this.donDatHangGridControl);
            this.groupControl_DDH.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl_DDH.Location = new System.Drawing.Point(0, 28);
            this.groupControl_DDH.Name = "groupControl_DDH";
            this.groupControl_DDH.Size = new System.Drawing.Size(1944, 340);
            this.groupControl_DDH.TabIndex = 4;
            this.groupControl_DDH.Text = "Bảng Đơn đặt hàng";
            // 
            // donDatHangGridControl
            // 
            this.donDatHangGridControl.DataSource = this.donDatHangBindingSource;
            this.donDatHangGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.donDatHangGridControl.Location = new System.Drawing.Point(2, 34);
            this.donDatHangGridControl.MainView = this.gridView1;
            this.donDatHangGridControl.MenuManager = this.barManager1;
            this.donDatHangGridControl.Name = "donDatHangGridControl";
            this.donDatHangGridControl.Size = new System.Drawing.Size(1940, 304);
            this.donDatHangGridControl.TabIndex = 0;
            this.donDatHangGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // donDatHangBindingSource
            // 
            this.donDatHangBindingSource.DataMember = "DonDatHang";
            this.donDatHangBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSoDDH,
            this.colNgayLap,
            this.colMaNV,
            this.colMaKho,
            this.colMaNCC});
            this.gridView1.GridControl = this.donDatHangGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colSoDDH
            // 
            this.colSoDDH.FieldName = "SoDDH";
            this.colSoDDH.MinWidth = 30;
            this.colSoDDH.Name = "colSoDDH";
            this.colSoDDH.OptionsColumn.ReadOnly = true;
            this.colSoDDH.Visible = true;
            this.colSoDDH.VisibleIndex = 0;
            this.colSoDDH.Width = 112;
            // 
            // colNgayLap
            // 
            this.colNgayLap.FieldName = "NgayLap";
            this.colNgayLap.MinWidth = 30;
            this.colNgayLap.Name = "colNgayLap";
            this.colNgayLap.OptionsColumn.ReadOnly = true;
            this.colNgayLap.Visible = true;
            this.colNgayLap.VisibleIndex = 1;
            this.colNgayLap.Width = 112;
            // 
            // colMaNV
            // 
            this.colMaNV.FieldName = "MaNV";
            this.colMaNV.MinWidth = 30;
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.OptionsColumn.ReadOnly = true;
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 2;
            this.colMaNV.Width = 112;
            // 
            // colMaKho
            // 
            this.colMaKho.FieldName = "MaKho";
            this.colMaKho.MinWidth = 30;
            this.colMaKho.Name = "colMaKho";
            this.colMaKho.OptionsColumn.ReadOnly = true;
            this.colMaKho.Visible = true;
            this.colMaKho.VisibleIndex = 3;
            this.colMaKho.Width = 112;
            // 
            // colMaNCC
            // 
            this.colMaNCC.FieldName = "MaNCC";
            this.colMaNCC.MinWidth = 30;
            this.colMaNCC.Name = "colMaNCC";
            this.colMaNCC.OptionsColumn.ReadOnly = true;
            this.colMaNCC.Visible = true;
            this.colMaNCC.VisibleIndex = 4;
            this.colMaNCC.Width = 112;
            // 
            // groupControl_CTDDH
            // 
            this.groupControl_CTDDH.Controls.Add(this.btn_HH);
            this.groupControl_CTDDH.Controls.Add(this.btn_DDH);
            this.groupControl_CTDDH.Controls.Add(this.cT_DonDatHangDataGridView);
            this.groupControl_CTDDH.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl_CTDDH.Location = new System.Drawing.Point(1209, 368);
            this.groupControl_CTDDH.Name = "groupControl_CTDDH";
            this.groupControl_CTDDH.Size = new System.Drawing.Size(735, 377);
            this.groupControl_CTDDH.TabIndex = 6;
            this.groupControl_CTDDH.Text = "Bảng chi tiết Đơn đặt hàng";
            // 
            // btn_HH
            // 
            this.btn_HH.Enabled = false;
            this.btn_HH.Location = new System.Drawing.Point(381, 46);
            this.btn_HH.Name = "btn_HH";
            this.btn_HH.Size = new System.Drawing.Size(193, 45);
            this.btn_HH.TabIndex = 9;
            this.btn_HH.Text = "Chọn Hàng";
            this.btn_HH.UseVisualStyleBackColor = true;
            this.btn_HH.Click += new System.EventHandler(this.btn_HH_Click);
            // 
            // btn_DDH
            // 
            this.btn_DDH.Location = new System.Drawing.Point(83, 44);
            this.btn_DDH.Name = "btn_DDH";
            this.btn_DDH.Size = new System.Drawing.Size(145, 42);
            this.btn_DDH.TabIndex = 15;
            this.btn_DDH.Text = "Chọn Đơn đặt hàng";
            this.btn_DDH.UseVisualStyleBackColor = true;
            this.btn_DDH.Click += new System.EventHandler(this.btn_DDH_Click);
            // 
            // cT_DonDatHangDataGridView
            // 
            this.cT_DonDatHangDataGridView.AutoGenerateColumns = false;
            this.cT_DonDatHangDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cT_DonDatHangDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.cT_DonDatHangDataGridView.DataSource = this.cT_DonDatHangBindingSource;
            this.cT_DonDatHangDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cT_DonDatHangDataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cT_DonDatHangDataGridView.Location = new System.Drawing.Point(2, 95);
            this.cT_DonDatHangDataGridView.Name = "cT_DonDatHangDataGridView";
            this.cT_DonDatHangDataGridView.ReadOnly = true;
            this.cT_DonDatHangDataGridView.RowHeadersWidth = 62;
            this.cT_DonDatHangDataGridView.RowTemplate.Height = 28;
            this.cT_DonDatHangDataGridView.Size = new System.Drawing.Size(731, 280);
            this.cT_DonDatHangDataGridView.TabIndex = 0;
            this.cT_DonDatHangDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cT_DonDatHangDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SoDDH";
            this.dataGridViewTextBoxColumn1.HeaderText = "SoDDH";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaHH";
            this.dataGridViewTextBoxColumn2.HeaderText = "MaHH";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SoLuong";
            this.dataGridViewTextBoxColumn3.HeaderText = "SoLuong";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DonGia";
            this.dataGridViewTextBoxColumn4.HeaderText = "DonGia";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // cT_DonDatHangBindingSource
            // 
            this.cT_DonDatHangBindingSource.DataMember = "FK__CT_DonDat__SoDDH__147C05D0";
            this.cT_DonDatHangBindingSource.DataSource = this.donDatHangBindingSource;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl_editCT);
            this.panelControl1.Controls.Add(this.groupControl_edit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 368);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1209, 377);
            this.panelControl1.TabIndex = 7;
            // 
            // groupControl_editCT
            // 
            this.groupControl_editCT.Controls.Add(this.CBB_HH);
            this.groupControl_editCT.Controls.Add(donGiaLabel);
            this.groupControl_editCT.Controls.Add(this.SP_DG);
            this.groupControl_editCT.Controls.Add(soLuongLabel);
            this.groupControl_editCT.Controls.Add(this.SP_SL);
            this.groupControl_editCT.Controls.Add(maHHLabel);
            this.groupControl_editCT.Controls.Add(this.SP_maHH);
            this.groupControl_editCT.Controls.Add(soDDHLabel1);
            this.groupControl_editCT.Controls.Add(this.SP_SDDH_CT);
            this.groupControl_editCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl_editCT.Enabled = false;
            this.groupControl_editCT.Location = new System.Drawing.Point(2, 165);
            this.groupControl_editCT.Name = "groupControl_editCT";
            this.groupControl_editCT.Size = new System.Drawing.Size(1205, 210);
            this.groupControl_editCT.TabIndex = 7;
            this.groupControl_editCT.Text = "Thông tin chi tiết Đơn đặt hàng";
            this.groupControl_editCT.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl_editCT_Paint);
            // 
            // CBB_HH
            // 
            this.CBB_HH.FormattingEnabled = true;
            this.CBB_HH.Location = new System.Drawing.Point(633, 72);
            this.CBB_HH.Name = "CBB_HH";
            this.CBB_HH.Size = new System.Drawing.Size(266, 27);
            this.CBB_HH.TabIndex = 8;
            this.CBB_HH.SelectedIndexChanged += new System.EventHandler(this.CBB_HH_SelectedIndexChanged);
            // 
            // SP_DG
            // 
            this.SP_DG.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cT_DonDatHangBindingSource, "DonGia", true));
            this.SP_DG.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SP_DG.Location = new System.Drawing.Point(439, 144);
            this.SP_DG.MenuManager = this.barManager1;
            this.SP_DG.Name = "SP_DG";
            this.SP_DG.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SP_DG.Size = new System.Drawing.Size(150, 28);
            this.SP_DG.TabIndex = 7;
            // 
            // SP_SL
            // 
            this.SP_SL.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cT_DonDatHangBindingSource, "SoLuong", true));
            this.SP_SL.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SP_SL.Location = new System.Drawing.Point(134, 144);
            this.SP_SL.MenuManager = this.barManager1;
            this.SP_SL.Name = "SP_SL";
            this.SP_SL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SP_SL.Size = new System.Drawing.Size(150, 28);
            this.SP_SL.TabIndex = 5;
            // 
            // SP_maHH
            // 
            this.SP_maHH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cT_DonDatHangBindingSource, "MaHH", true));
            this.SP_maHH.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SP_maHH.Enabled = false;
            this.SP_maHH.Location = new System.Drawing.Point(439, 71);
            this.SP_maHH.MenuManager = this.barManager1;
            this.SP_maHH.Name = "SP_maHH";
            this.SP_maHH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SP_maHH.Size = new System.Drawing.Size(150, 28);
            this.SP_maHH.TabIndex = 3;
            this.SP_maHH.EditValueChanged += new System.EventHandler(this.SP_maHH_EditValueChanged);
            // 
            // SP_SDDH_CT
            // 
            this.SP_SDDH_CT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cT_DonDatHangBindingSource, "SoDDH", true));
            this.SP_SDDH_CT.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SP_SDDH_CT.Enabled = false;
            this.SP_SDDH_CT.Location = new System.Drawing.Point(134, 71);
            this.SP_SDDH_CT.MenuManager = this.barManager1;
            this.SP_SDDH_CT.Name = "SP_SDDH_CT";
            this.SP_SDDH_CT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SP_SDDH_CT.Size = new System.Drawing.Size(150, 28);
            this.SP_SDDH_CT.TabIndex = 1;
            // 
            // groupControl_edit
            // 
            this.groupControl_edit.Controls.Add(maNVLabel);
            this.groupControl_edit.Controls.Add(this.SP_maNV);
            this.groupControl_edit.Controls.Add(this.CBB_Kho);
            this.groupControl_edit.Controls.Add(this.CBB_NCC);
            this.groupControl_edit.Controls.Add(maKhoLabel);
            this.groupControl_edit.Controls.Add(this.SP_maKho);
            this.groupControl_edit.Controls.Add(maNCCLabel);
            this.groupControl_edit.Controls.Add(this.SP_maNCC);
            this.groupControl_edit.Controls.Add(ngayLapLabel);
            this.groupControl_edit.Controls.Add(this.DE_NT);
            this.groupControl_edit.Controls.Add(soDDHLabel);
            this.groupControl_edit.Controls.Add(this.SP_SDDH);
            this.groupControl_edit.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl_edit.Enabled = false;
            this.groupControl_edit.Location = new System.Drawing.Point(2, 2);
            this.groupControl_edit.Name = "groupControl_edit";
            this.groupControl_edit.Size = new System.Drawing.Size(1205, 163);
            this.groupControl_edit.TabIndex = 6;
            this.groupControl_edit.Text = "Thông tin Đơn đặt hàng";
            this.groupControl_edit.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl_edit_Paint);
            // 
            // SP_maNV
            // 
            this.SP_maNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.donDatHangBindingSource, "MaNV", true));
            this.SP_maNV.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SP_maNV.Enabled = false;
            this.SP_maNV.Location = new System.Drawing.Point(779, 40);
            this.SP_maNV.MenuManager = this.barManager1;
            this.SP_maNV.Name = "SP_maNV";
            this.SP_maNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SP_maNV.Size = new System.Drawing.Size(150, 28);
            this.SP_maNV.TabIndex = 14;
            // 
            // CBB_Kho
            // 
            this.CBB_Kho.FormattingEnabled = true;
            this.CBB_Kho.Location = new System.Drawing.Point(791, 89);
            this.CBB_Kho.Name = "CBB_Kho";
            this.CBB_Kho.Size = new System.Drawing.Size(150, 27);
            this.CBB_Kho.TabIndex = 13;
            this.CBB_Kho.SelectedIndexChanged += new System.EventHandler(this.CBB_Kho_SelectedIndexChanged);
            // 
            // CBB_NCC
            // 
            this.CBB_NCC.FormattingEnabled = true;
            this.CBB_NCC.Location = new System.Drawing.Point(339, 93);
            this.CBB_NCC.Name = "CBB_NCC";
            this.CBB_NCC.Size = new System.Drawing.Size(157, 27);
            this.CBB_NCC.TabIndex = 12;
            this.CBB_NCC.SelectedIndexChanged += new System.EventHandler(this.CBB_NCC_SelectedIndexChanged);
            // 
            // SP_maKho
            // 
            this.SP_maKho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.donDatHangBindingSource, "MaKho", true));
            this.SP_maKho.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SP_maKho.Enabled = false;
            this.SP_maKho.Location = new System.Drawing.Point(635, 89);
            this.SP_maKho.MenuManager = this.barManager1;
            this.SP_maKho.Name = "SP_maKho";
            this.SP_maKho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SP_maKho.Size = new System.Drawing.Size(150, 28);
            this.SP_maKho.TabIndex = 9;
            this.SP_maKho.EditValueChanged += new System.EventHandler(this.SP_maKho_EditValueChanged);
            // 
            // SP_maNCC
            // 
            this.SP_maNCC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.donDatHangBindingSource, "MaNCC", true));
            this.SP_maNCC.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SP_maNCC.Enabled = false;
            this.SP_maNCC.Location = new System.Drawing.Point(149, 89);
            this.SP_maNCC.MenuManager = this.barManager1;
            this.SP_maNCC.Name = "SP_maNCC";
            this.SP_maNCC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SP_maNCC.Size = new System.Drawing.Size(150, 28);
            this.SP_maNCC.TabIndex = 7;
            this.SP_maNCC.EditValueChanged += new System.EventHandler(this.SP_NCC_EditValueChanged);
            // 
            // DE_NT
            // 
            this.DE_NT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.donDatHangBindingSource, "NgayLap", true));
            this.DE_NT.EditValue = null;
            this.DE_NT.Enabled = false;
            this.DE_NT.Location = new System.Drawing.Point(476, 41);
            this.DE_NT.MenuManager = this.barManager1;
            this.DE_NT.Name = "DE_NT";
            this.DE_NT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DE_NT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DE_NT.Size = new System.Drawing.Size(150, 26);
            this.DE_NT.TabIndex = 3;
            this.DE_NT.EditValueChanged += new System.EventHandler(this.DE_NT_EditValueChanged);
            // 
            // SP_SDDH
            // 
            this.SP_SDDH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.donDatHangBindingSource, "SoDDH", true));
            this.SP_SDDH.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SP_SDDH.Enabled = false;
            this.SP_SDDH.Location = new System.Drawing.Point(147, 39);
            this.SP_SDDH.MenuManager = this.barManager1;
            this.SP_SDDH.Name = "SP_SDDH";
            this.SP_SDDH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SP_SDDH.Size = new System.Drawing.Size(150, 28);
            this.SP_SDDH.TabIndex = 1;
            this.SP_SDDH.EditValueChanged += new System.EventHandler(this.SP_SDDH_EditValueChanged);
            // 
            // donDatHangTableAdapter
            // 
            this.donDatHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CT_DonDatHangTableAdapter = this.cT_DonDatHangTableAdapter;
            this.tableAdapterManager.CT_HoaDonTableAdapter = null;
            this.tableAdapterManager.CT_NhanVienTableAdapter = null;
            this.tableAdapterManager.CT_PhieuNhapTableAdapter = null;
            this.tableAdapterManager.DonDatHangTableAdapter = this.donDatHangTableAdapter;
            this.tableAdapterManager.HangHoaTableAdapter = null;
            this.tableAdapterManager.HoaDonTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.LoaiHangTableAdapter = null;
            this.tableAdapterManager.NhaCungCapTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_APP.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cT_DonDatHangTableAdapter
            // 
            this.cT_DonDatHangTableAdapter.ClearBeforeFill = true;
            // 
            // khoBindingSource
            // 
            this.khoBindingSource.DataMember = "Kho";
            this.khoBindingSource.DataSource = this.dS;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // nhaCungCapBindingSource
            // 
            this.nhaCungCapBindingSource.DataMember = "NhaCungCap";
            this.nhaCungCapBindingSource.DataSource = this.dS;
            // 
            // nhaCungCapTableAdapter
            // 
            this.nhaCungCapTableAdapter.ClearBeforeFill = true;
            // 
            // hangHoaBindingSource
            // 
            this.hangHoaBindingSource.DataMember = "HangHoa";
            this.hangHoaBindingSource.DataSource = this.dS;
            // 
            // hangHoaTableAdapter
            // 
            this.hangHoaTableAdapter.ClearBeforeFill = true;
            // 
            // FormDDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1944, 745);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl_CTDDH);
            this.Controls.Add(this.groupControl_DDH);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDDH";
            this.Text = "FormDDH";
            this.Load += new System.EventHandler(this.FormDDH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_DDH)).EndInit();
            this.groupControl_DDH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.donDatHangGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donDatHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_CTDDH)).EndInit();
            this.groupControl_CTDDH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cT_DonDatHangDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_DonDatHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_editCT)).EndInit();
            this.groupControl_editCT.ResumeLayout(false);
            this.groupControl_editCT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SP_DG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_SL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_maHH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_SDDH_CT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_edit)).EndInit();
            this.groupControl_edit.ResumeLayout(false);
            this.groupControl_edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SP_maNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_maKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_maNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DE_NT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DE_NT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_SDDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).EndInit();
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
		private DevExpress.XtraBars.BarButtonItem undo;
		private DevExpress.XtraBars.BarButtonItem refresh;
		private DevExpress.XtraBars.BarButtonItem exit;
		private DevExpress.XtraEditors.GroupControl groupControl_DDH;
		private DevExpress.XtraEditors.GroupControl groupControl_CTDDH;
		private System.Windows.Forms.BindingSource donDatHangBindingSource;
		private DS dS;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.GroupControl groupControl_editCT;
		private DevExpress.XtraEditors.GroupControl groupControl_edit;
		private DSTableAdapters.DonDatHangTableAdapter donDatHangTableAdapter;
		private DSTableAdapters.TableAdapterManager tableAdapterManager;
		private DSTableAdapters.CT_DonDatHangTableAdapter cT_DonDatHangTableAdapter;
		private System.Windows.Forms.BindingSource cT_DonDatHangBindingSource;
		private DevExpress.XtraEditors.SpinEdit SP_SL;
		private DevExpress.XtraEditors.SpinEdit SP_maHH;
		private DevExpress.XtraEditors.SpinEdit SP_SDDH_CT;
		private DevExpress.XtraEditors.SpinEdit SP_maKho;
		private DevExpress.XtraEditors.SpinEdit SP_maNCC;
		private DevExpress.XtraEditors.DateEdit DE_NT;
		private DevExpress.XtraEditors.SpinEdit SP_DG;
		private System.Windows.Forms.DataGridView cT_DonDatHangDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.BindingSource khoBindingSource;
		private DSTableAdapters.KhoTableAdapter khoTableAdapter;
		private System.Windows.Forms.BindingSource nhaCungCapBindingSource;
		private DSTableAdapters.NhaCungCapTableAdapter nhaCungCapTableAdapter;
		private System.Windows.Forms.BindingSource hangHoaBindingSource;
		private DSTableAdapters.HangHoaTableAdapter hangHoaTableAdapter;
		private System.Windows.Forms.ComboBox CBB_HH;
		private System.Windows.Forms.ComboBox CBB_Kho;
		private System.Windows.Forms.ComboBox CBB_NCC;
        private DevExpress.XtraGrid.GridControl donDatHangGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayLap;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKho;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNCC;
        private DevExpress.XtraEditors.SpinEdit SP_SDDH;
        private DevExpress.XtraEditors.SpinEdit SP_maNV;
        private System.Windows.Forms.Button btn_DDH;
        private System.Windows.Forms.Button btn_HH;
    }
}