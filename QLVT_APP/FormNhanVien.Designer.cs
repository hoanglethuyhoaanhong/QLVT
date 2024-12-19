namespace QLVT_APP
{
    partial class FormNhanVien
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
			System.Windows.Forms.Label maNVLabel;
			this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.bar2 = new DevExpress.XtraBars.Bar();
			this.bar_btn_add = new DevExpress.XtraBars.BarButtonItem();
			this.bar_btn_update = new DevExpress.XtraBars.BarButtonItem();
			this.bar_btn_remove = new DevExpress.XtraBars.BarButtonItem();
			this.bar_btn_save = new DevExpress.XtraBars.BarButtonItem();
			this.bar_btn_undo = new DevExpress.XtraBars.BarButtonItem();
			this.bar_btn_refresh = new DevExpress.XtraBars.BarButtonItem();
			this.bar_btn_exit = new DevExpress.XtraBars.BarButtonItem();
			this.bar_btn_ccn = new DevExpress.XtraBars.BarButtonItem();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.groupControl_nv = new DevExpress.XtraEditors.GroupControl();
			this.vIEW_NHANVIENGridControl = new DevExpress.XtraGrid.GridControl();
			this.bds_nv = new System.Windows.Forms.BindingSource(this.components);
			this.dS = new QLVT_APP.DS();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSÐT = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNgayBatDau = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNgayKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
			this.groupControl_edit = new DevExpress.XtraEditors.GroupControl();
			this.CK_TTX = new System.Windows.Forms.CheckBox();
			this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DE_NS = new DevExpress.XtraEditors.DateEdit();
			this.TE_DC = new DevExpress.XtraEditors.TextEdit();
			this.TE_SDT = new DevExpress.XtraEditors.TextEdit();
			this.TE_ten = new DevExpress.XtraEditors.TextEdit();
			this.TE_ho = new DevExpress.XtraEditors.TextEdit();
			this.TE_maNV = new DevExpress.XtraEditors.TextEdit();
			this.DE_NKT = new DevExpress.XtraEditors.DateEdit();
			this.DE_NBD = new DevExpress.XtraEditors.DateEdit();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.vIEW_NHANVIENTableAdapter = new QLVT_APP.DSTableAdapters.VIEW_NHANVIENTableAdapter();
			this.tableAdapterManager = new QLVT_APP.DSTableAdapters.TableAdapterManager();
			this.nhanVienTableAdapter = new QLVT_APP.DSTableAdapters.NhanVienTableAdapter();
			this.cT_NhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cT_NhanVienTableAdapter = new QLVT_APP.DSTableAdapters.CT_NhanVienTableAdapter();
			maNVLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl_nv)).BeginInit();
			this.groupControl_nv.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vIEW_NHANVIENGridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bds_nv)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl_edit)).BeginInit();
			this.groupControl_edit.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DE_NS.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DE_NS.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TE_DC.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TE_SDT.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TE_ten.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TE_ho.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TE_maNV.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DE_NKT.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DE_NKT.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DE_NBD.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DE_NBD.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cT_NhanVienBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// maNVLabel
			// 
			maNVLabel.AutoSize = true;
			maNVLabel.Location = new System.Drawing.Point(132, 100);
			maNVLabel.Name = "maNVLabel";
			maNVLabel.Size = new System.Drawing.Size(61, 19);
			maNVLabel.TabIndex = 17;
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
            this.bar_btn_add,
            this.bar_btn_update,
            this.bar_btn_remove,
            this.bar_btn_save,
            this.bar_btn_undo,
            this.bar_btn_refresh,
            this.bar_btn_exit,
            this.bar_btn_ccn});
			this.barManager1.MainMenu = this.bar2;
			this.barManager1.MaxItemId = 9;
			// 
			// bar2
			// 
			this.bar2.BarName = "Main menu";
			this.bar2.DockCol = 0;
			this.bar2.DockRow = 0;
			this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar2.FloatLocation = new System.Drawing.Point(566, 242);
			this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_btn_add),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_btn_update),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_btn_remove),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_btn_save),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_btn_undo),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_btn_refresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_btn_exit),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_btn_ccn)});
			this.bar2.OptionsBar.MultiLine = true;
			this.bar2.OptionsBar.UseWholeRow = true;
			this.bar2.Text = "Main menu";
			// 
			// bar_btn_add
			// 
			this.bar_btn_add.Caption = "Thêm";
			this.bar_btn_add.Id = 0;
			this.bar_btn_add.Name = "bar_btn_add";
			this.bar_btn_add.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_btn_add_ItemClick);
			// 
			// bar_btn_update
			// 
			this.bar_btn_update.Caption = "Sửa";
			this.bar_btn_update.Id = 1;
			this.bar_btn_update.Name = "bar_btn_update";
			this.bar_btn_update.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
			// 
			// bar_btn_remove
			// 
			this.bar_btn_remove.Caption = "Xóa";
			this.bar_btn_remove.Id = 3;
			this.bar_btn_remove.Name = "bar_btn_remove";
			this.bar_btn_remove.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick_1);
			// 
			// bar_btn_save
			// 
			this.bar_btn_save.Caption = "Lưu";
			this.bar_btn_save.Id = 4;
			this.bar_btn_save.Name = "bar_btn_save";
			this.bar_btn_save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_btn_save_ItemClick);
			// 
			// bar_btn_undo
			// 
			this.bar_btn_undo.Caption = "undo";
			this.bar_btn_undo.Id = 5;
			this.bar_btn_undo.Name = "bar_btn_undo";
			this.bar_btn_undo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_btn_undo_ItemClick);
			// 
			// bar_btn_refresh
			// 
			this.bar_btn_refresh.Caption = "Refresh";
			this.bar_btn_refresh.Id = 6;
			this.bar_btn_refresh.Name = "bar_btn_refresh";
			this.bar_btn_refresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
			// 
			// bar_btn_exit
			// 
			this.bar_btn_exit.Caption = "Thoát";
			this.bar_btn_exit.Id = 7;
			this.bar_btn_exit.Name = "bar_btn_exit";
			this.bar_btn_exit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_btn_exit_ItemClick);
			// 
			// bar_btn_ccn
			// 
			this.bar_btn_ccn.Caption = "Chuyển chi nhánh";
			this.bar_btn_ccn.Id = 8;
			this.bar_btn_ccn.Name = "bar_btn_ccn";
			this.bar_btn_ccn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_btn_ccn_ItemClick);
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.barManager1;
			this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
			this.barDockControlTop.Size = new System.Drawing.Size(1250, 28);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 814);
			this.barDockControlBottom.Manager = this.barManager1;
			this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
			this.barDockControlBottom.Size = new System.Drawing.Size(1250, 0);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 28);
			this.barDockControlLeft.Manager = this.barManager1;
			this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 786);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(1250, 28);
			this.barDockControlRight.Manager = this.barManager1;
			this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
			this.barDockControlRight.Size = new System.Drawing.Size(0, 786);
			// 
			// groupControl_nv
			// 
			this.groupControl_nv.Controls.Add(this.vIEW_NHANVIENGridControl);
			this.groupControl_nv.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupControl_nv.Location = new System.Drawing.Point(0, 28);
			this.groupControl_nv.Name = "groupControl_nv";
			this.groupControl_nv.Size = new System.Drawing.Size(1250, 386);
			this.groupControl_nv.TabIndex = 4;
			this.groupControl_nv.Text = "Bảng nhân viên";
			// 
			// vIEW_NHANVIENGridControl
			// 
			this.vIEW_NHANVIENGridControl.DataSource = this.bds_nv;
			this.vIEW_NHANVIENGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vIEW_NHANVIENGridControl.Location = new System.Drawing.Point(2, 34);
			this.vIEW_NHANVIENGridControl.MainView = this.gridView1;
			this.vIEW_NHANVIENGridControl.MenuManager = this.barManager1;
			this.vIEW_NHANVIENGridControl.Name = "vIEW_NHANVIENGridControl";
			this.vIEW_NHANVIENGridControl.Size = new System.Drawing.Size(1246, 350);
			this.vIEW_NHANVIENGridControl.TabIndex = 0;
			this.vIEW_NHANVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			this.vIEW_NHANVIENGridControl.Click += new System.EventHandler(this.vIEW_NHANVIENGridControl_Click);
			// 
			// bds_nv
			// 
			this.bds_nv.DataMember = "VIEW_NHANVIEN";
			this.bds_nv.DataSource = this.dS;
			// 
			// dS
			// 
			this.dS.DataSetName = "DS";
			this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNV,
            this.colHo,
            this.colTen,
            this.colDiaChi,
            this.colSÐT,
            this.colNgaySinh,
            this.colNgayBatDau,
            this.colNgayKetThuc,
            this.colTrangThaiXoa});
			this.gridView1.GridControl = this.vIEW_NHANVIENGridControl;
			this.gridView1.Name = "gridView1";
			// 
			// colMaNV
			// 
			this.colMaNV.FieldName = "MaNV";
			this.colMaNV.MinWidth = 30;
			this.colMaNV.Name = "colMaNV";
			this.colMaNV.OptionsColumn.ReadOnly = true;
			this.colMaNV.Visible = true;
			this.colMaNV.VisibleIndex = 0;
			this.colMaNV.Width = 112;
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
			// colSÐT
			// 
			this.colSÐT.FieldName = "SÐT";
			this.colSÐT.MinWidth = 30;
			this.colSÐT.Name = "colSÐT";
			this.colSÐT.OptionsColumn.ReadOnly = true;
			this.colSÐT.Visible = true;
			this.colSÐT.VisibleIndex = 4;
			this.colSÐT.Width = 112;
			// 
			// colNgaySinh
			// 
			this.colNgaySinh.FieldName = "NgaySinh";
			this.colNgaySinh.MinWidth = 30;
			this.colNgaySinh.Name = "colNgaySinh";
			this.colNgaySinh.OptionsColumn.ReadOnly = true;
			this.colNgaySinh.Visible = true;
			this.colNgaySinh.VisibleIndex = 5;
			this.colNgaySinh.Width = 112;
			// 
			// colNgayBatDau
			// 
			this.colNgayBatDau.FieldName = "NgayBatDau";
			this.colNgayBatDau.MinWidth = 30;
			this.colNgayBatDau.Name = "colNgayBatDau";
			this.colNgayBatDau.OptionsColumn.ReadOnly = true;
			this.colNgayBatDau.Visible = true;
			this.colNgayBatDau.VisibleIndex = 6;
			this.colNgayBatDau.Width = 112;
			// 
			// colNgayKetThuc
			// 
			this.colNgayKetThuc.FieldName = "NgayKetThuc";
			this.colNgayKetThuc.MinWidth = 30;
			this.colNgayKetThuc.Name = "colNgayKetThuc";
			this.colNgayKetThuc.OptionsColumn.ReadOnly = true;
			this.colNgayKetThuc.Visible = true;
			this.colNgayKetThuc.VisibleIndex = 7;
			this.colNgayKetThuc.Width = 112;
			// 
			// colTrangThaiXoa
			// 
			this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
			this.colTrangThaiXoa.MinWidth = 30;
			this.colTrangThaiXoa.Name = "colTrangThaiXoa";
			this.colTrangThaiXoa.OptionsColumn.ReadOnly = true;
			this.colTrangThaiXoa.Visible = true;
			this.colTrangThaiXoa.VisibleIndex = 8;
			this.colTrangThaiXoa.Width = 112;
			// 
			// groupControl_edit
			// 
			this.groupControl_edit.Controls.Add(this.CK_TTX);
			this.groupControl_edit.Controls.Add(this.DE_NS);
			this.groupControl_edit.Controls.Add(this.TE_DC);
			this.groupControl_edit.Controls.Add(this.TE_SDT);
			this.groupControl_edit.Controls.Add(this.TE_ten);
			this.groupControl_edit.Controls.Add(this.TE_ho);
			this.groupControl_edit.Controls.Add(maNVLabel);
			this.groupControl_edit.Controls.Add(this.TE_maNV);
			this.groupControl_edit.Controls.Add(this.DE_NKT);
			this.groupControl_edit.Controls.Add(this.DE_NBD);
			this.groupControl_edit.Controls.Add(this.label7);
			this.groupControl_edit.Controls.Add(this.label5);
			this.groupControl_edit.Controls.Add(this.label10);
			this.groupControl_edit.Controls.Add(this.label3);
			this.groupControl_edit.Controls.Add(this.label8);
			this.groupControl_edit.Controls.Add(this.label9);
			this.groupControl_edit.Controls.Add(this.label6);
			this.groupControl_edit.Controls.Add(this.label2);
			this.groupControl_edit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupControl_edit.Enabled = false;
			this.groupControl_edit.Location = new System.Drawing.Point(0, 414);
			this.groupControl_edit.Name = "groupControl_edit";
			this.groupControl_edit.Size = new System.Drawing.Size(1250, 400);
			this.groupControl_edit.TabIndex = 5;
			this.groupControl_edit.Text = "Thông tin nhân viên";
			// 
			// CK_TTX
			// 
			this.CK_TTX.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.nhanVienBindingSource, "TrangThaiXoa", true));
			this.CK_TTX.Location = new System.Drawing.Point(888, 275);
			this.CK_TTX.Name = "CK_TTX";
			this.CK_TTX.Size = new System.Drawing.Size(172, 24);
			this.CK_TTX.TabIndex = 24;
			this.CK_TTX.Text = "Đang hoạt động";
			this.CK_TTX.UseVisualStyleBackColor = true;
			// 
			// nhanVienBindingSource
			// 
			this.nhanVienBindingSource.DataMember = "NhanVien";
			this.nhanVienBindingSource.DataSource = this.dS;
			// 
			// DE_NS
			// 
			this.DE_NS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "NgaySinh", true));
			this.DE_NS.EditValue = null;
			this.DE_NS.Location = new System.Drawing.Point(528, 186);
			this.DE_NS.MenuManager = this.barManager1;
			this.DE_NS.Name = "DE_NS";
			this.DE_NS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.DE_NS.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.DE_NS.Size = new System.Drawing.Size(150, 26);
			this.DE_NS.TabIndex = 23;
			// 
			// TE_DC
			// 
			this.TE_DC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "DiaChi", true));
			this.TE_DC.Location = new System.Drawing.Point(842, 186);
			this.TE_DC.MenuManager = this.barManager1;
			this.TE_DC.Name = "TE_DC";
			this.TE_DC.Size = new System.Drawing.Size(364, 26);
			this.TE_DC.TabIndex = 22;
			// 
			// TE_SDT
			// 
			this.TE_SDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "SÐT", true));
			this.TE_SDT.Location = new System.Drawing.Point(208, 182);
			this.TE_SDT.MenuManager = this.barManager1;
			this.TE_SDT.Name = "TE_SDT";
			this.TE_SDT.Size = new System.Drawing.Size(150, 26);
			this.TE_SDT.TabIndex = 21;
			// 
			// TE_ten
			// 
			this.TE_ten.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "Ten", true));
			this.TE_ten.Location = new System.Drawing.Point(842, 95);
			this.TE_ten.MenuManager = this.barManager1;
			this.TE_ten.Name = "TE_ten";
			this.TE_ten.Size = new System.Drawing.Size(150, 26);
			this.TE_ten.TabIndex = 20;
			// 
			// TE_ho
			// 
			this.TE_ho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "Ho", true));
			this.TE_ho.Location = new System.Drawing.Point(528, 95);
			this.TE_ho.MenuManager = this.barManager1;
			this.TE_ho.Name = "TE_ho";
			this.TE_ho.Size = new System.Drawing.Size(281, 26);
			this.TE_ho.TabIndex = 19;
			// 
			// TE_maNV
			// 
			this.TE_maNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "MaNV", true));
			this.TE_maNV.Enabled = false;
			this.TE_maNV.Location = new System.Drawing.Point(208, 97);
			this.TE_maNV.MenuManager = this.barManager1;
			this.TE_maNV.Name = "TE_maNV";
			this.TE_maNV.Size = new System.Drawing.Size(150, 26);
			this.TE_maNV.TabIndex = 18;
			// 
			// DE_NKT
			// 
			this.DE_NKT.EditValue = null;
			this.DE_NKT.Enabled = false;
			this.DE_NKT.Location = new System.Drawing.Point(532, 273);
			this.DE_NKT.Name = "DE_NKT";
			this.DE_NKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.DE_NKT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.DE_NKT.Size = new System.Drawing.Size(150, 26);
			this.DE_NKT.TabIndex = 4;
			// 
			// DE_NBD
			// 
			this.DE_NBD.EditValue = null;
			this.DE_NBD.Enabled = false;
			this.DE_NBD.Location = new System.Drawing.Point(208, 273);
			this.DE_NBD.Name = "DE_NBD";
			this.DE_NBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.DE_NBD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.DE_NBD.Size = new System.Drawing.Size(150, 26);
			this.DE_NBD.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(752, 275);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(112, 19);
			this.label7.TabIndex = 1;
			this.label7.Text = "Trạng thái xóa";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(91, 185);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(102, 19);
			this.label5.TabIndex = 1;
			this.label5.Text = "Số điện thoại";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(752, 189);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(57, 19);
			this.label10.TabIndex = 1;
			this.label10.Text = "Địa chỉ";
			this.label10.Click += new System.EventHandler(this.label4_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(410, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 19);
			this.label3.TabIndex = 1;
			this.label3.Text = "Họ Tên";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(410, 185);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(79, 19);
			this.label8.TabIndex = 0;
			this.label8.Text = "Ngày sinh";
			this.label8.Click += new System.EventHandler(this.label8_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(410, 275);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(106, 19);
			this.label9.TabIndex = 0;
			this.label9.Text = "Ngày kết thúc";
			this.label9.Click += new System.EventHandler(this.label9_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(91, 275);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(103, 19);
			this.label6.TabIndex = 0;
			this.label6.Text = "Ngày bắt đầu";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(311, 185);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 19);
			this.label2.TabIndex = 1;
			// 
			// vIEW_NHANVIENTableAdapter
			// 
			this.vIEW_NHANVIENTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.ChiNhanhTableAdapter = null;
			this.tableAdapterManager.Connection = null;
			this.tableAdapterManager.CT_DonDatHangTableAdapter = null;
			this.tableAdapterManager.CT_HoaDonTableAdapter = null;
			this.tableAdapterManager.CT_NhanVienTableAdapter = null;
			this.tableAdapterManager.CT_PhieuNhapTableAdapter = null;
			this.tableAdapterManager.DonDatHangTableAdapter = null;
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
			// nhanVienTableAdapter
			// 
			this.nhanVienTableAdapter.ClearBeforeFill = true;
			// 
			// cT_NhanVienBindingSource
			// 
			this.cT_NhanVienBindingSource.DataMember = "FK_CT_NhanVien_NhanVien";
			this.cT_NhanVienBindingSource.DataSource = this.nhanVienBindingSource;
			// 
			// cT_NhanVienTableAdapter
			// 
			this.cT_NhanVienTableAdapter.ClearBeforeFill = true;
			// 
			// FormNhanVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1250, 814);
			this.Controls.Add(this.groupControl_edit);
			this.Controls.Add(this.groupControl_nv);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FormNhanVien";
			this.Text = "FormNhanVien";
			this.Load += new System.EventHandler(this.FormNhanVien_Load);
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl_nv)).EndInit();
			this.groupControl_nv.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vIEW_NHANVIENGridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bds_nv)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl_edit)).EndInit();
			this.groupControl_edit.ResumeLayout(false);
			this.groupControl_edit.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DE_NS.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DE_NS.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TE_DC.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TE_SDT.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TE_ten.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TE_ho.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TE_maNV.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DE_NKT.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DE_NKT.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DE_NBD.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DE_NBD.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cT_NhanVienBindingSource)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem bar_btn_add;
        private DevExpress.XtraBars.BarButtonItem bar_btn_update;
        private System.Windows.Forms.BindingSource bds_nv;
        private DS dS;
        private DevExpress.XtraEditors.GroupControl groupControl_edit;
        private DevExpress.XtraEditors.GroupControl groupControl_nv;
        private DSTableAdapters.VIEW_NHANVIENTableAdapter vIEW_NHANVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl vIEW_NHANVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colHo;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colSÐT;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayBatDau;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayKetThuc;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
		private System.Windows.Forms.BindingSource nhanVienBindingSource;
		private DSTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
		private System.Windows.Forms.BindingSource cT_NhanVienBindingSource;
		private DSTableAdapters.CT_NhanVienTableAdapter cT_NhanVienTableAdapter;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private DevExpress.XtraBars.BarButtonItem bar_btn_remove;
		private DevExpress.XtraBars.BarButtonItem bar_btn_save;
		private DevExpress.XtraBars.BarButtonItem bar_btn_undo;
		private DevExpress.XtraBars.BarButtonItem bar_btn_refresh;
		private DevExpress.XtraEditors.DateEdit DE_NKT;
		private DevExpress.XtraEditors.DateEdit DE_NBD;
		private DevExpress.XtraBars.BarButtonItem bar_btn_exit;
		private DevExpress.XtraBars.BarButtonItem bar_btn_ccn;
		private DevExpress.XtraEditors.TextEdit TE_maNV;
		private DevExpress.XtraEditors.TextEdit TE_ho;
		private DevExpress.XtraEditors.TextEdit TE_ten;
		private DevExpress.XtraEditors.DateEdit DE_NS;
		private DevExpress.XtraEditors.TextEdit TE_DC;
		private DevExpress.XtraEditors.TextEdit TE_SDT;
		private System.Windows.Forms.CheckBox CK_TTX;
	}
}