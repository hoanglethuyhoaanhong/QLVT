namespace QLVT_APP
{
    partial class Form_NCC
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
            System.Windows.Forms.Label maNCCLabel;
            System.Windows.Forms.Label tenNCCLabel;
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label sDTLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.add = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.remove = new DevExpress.XtraBars.BarButtonItem();
            this.save = new DevExpress.XtraBars.BarButtonItem();
            this.groupControl_NCC = new DevExpress.XtraEditors.GroupControl();
            this.groupControl_edit = new DevExpress.XtraEditors.GroupControl();
            this.dS = new QLVT_APP.DS();
            this.nhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhaCungCapTableAdapter = new QLVT_APP.DSTableAdapters.NhaCungCapTableAdapter();
            this.tableAdapterManager = new QLVT_APP.DSTableAdapters.TableAdapterManager();
            this.nhaCungCapGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.maNCCSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.tenNCCTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.diaChiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.sDTTextEdit = new DevExpress.XtraEditors.TextEdit();
            maNCCLabel = new System.Windows.Forms.Label();
            tenNCCLabel = new System.Windows.Forms.Label();
            diaChiLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_NCC)).BeginInit();
            this.groupControl_NCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_edit)).BeginInit();
            this.groupControl_edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maNCCSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenNCCTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaChiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDTTextEdit.Properties)).BeginInit();
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 637);
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
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 609);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(948, 28);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 609);
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
            // groupControl_NCC
            // 
            this.groupControl_NCC.Controls.Add(this.nhaCungCapGridControl);
            this.groupControl_NCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl_NCC.Location = new System.Drawing.Point(0, 28);
            this.groupControl_NCC.Name = "groupControl_NCC";
            this.groupControl_NCC.Size = new System.Drawing.Size(948, 419);
            this.groupControl_NCC.TabIndex = 4;
            this.groupControl_NCC.Text = "Bảng Nhà Cung Cấp";
            // 
            // groupControl_edit
            // 
            this.groupControl_edit.Controls.Add(sDTLabel);
            this.groupControl_edit.Controls.Add(this.sDTTextEdit);
            this.groupControl_edit.Controls.Add(diaChiLabel);
            this.groupControl_edit.Controls.Add(this.diaChiTextEdit);
            this.groupControl_edit.Controls.Add(tenNCCLabel);
            this.groupControl_edit.Controls.Add(this.tenNCCTextEdit);
            this.groupControl_edit.Controls.Add(maNCCLabel);
            this.groupControl_edit.Controls.Add(this.maNCCSpinEdit);
            this.groupControl_edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl_edit.Enabled = false;
            this.groupControl_edit.Location = new System.Drawing.Point(0, 447);
            this.groupControl_edit.Name = "groupControl_edit";
            this.groupControl_edit.Size = new System.Drawing.Size(948, 190);
            this.groupControl_edit.TabIndex = 5;
            this.groupControl_edit.Text = "Thông tin nhà cung cấp";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.LoaiHangTableAdapter = null;
            this.tableAdapterManager.NhaCungCapTableAdapter = this.nhaCungCapTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_APP.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nhaCungCapGridControl
            // 
            this.nhaCungCapGridControl.DataSource = this.nhaCungCapBindingSource;
            this.nhaCungCapGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhaCungCapGridControl.Location = new System.Drawing.Point(2, 34);
            this.nhaCungCapGridControl.MainView = this.gridView1;
            this.nhaCungCapGridControl.MenuManager = this.barManager1;
            this.nhaCungCapGridControl.Name = "nhaCungCapGridControl";
            this.nhaCungCapGridControl.Size = new System.Drawing.Size(944, 383);
            this.nhaCungCapGridControl.TabIndex = 0;
            this.nhaCungCapGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNCC,
            this.colTenNCC,
            this.colDiaChi,
            this.colSDT});
            this.gridView1.GridControl = this.nhaCungCapGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMaNCC
            // 
            this.colMaNCC.FieldName = "MaNCC";
            this.colMaNCC.MinWidth = 30;
            this.colMaNCC.Name = "colMaNCC";
            this.colMaNCC.OptionsColumn.ReadOnly = true;
            this.colMaNCC.Visible = true;
            this.colMaNCC.VisibleIndex = 0;
            this.colMaNCC.Width = 112;
            // 
            // colTenNCC
            // 
            this.colTenNCC.FieldName = "TenNCC";
            this.colTenNCC.MinWidth = 30;
            this.colTenNCC.Name = "colTenNCC";
            this.colTenNCC.OptionsColumn.ReadOnly = true;
            this.colTenNCC.Visible = true;
            this.colTenNCC.VisibleIndex = 1;
            this.colTenNCC.Width = 112;
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
            // colSDT
            // 
            this.colSDT.FieldName = "SDT";
            this.colSDT.MinWidth = 30;
            this.colSDT.Name = "colSDT";
            this.colSDT.OptionsColumn.ReadOnly = true;
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 3;
            this.colSDT.Width = 112;
            // 
            // maNCCLabel
            // 
            maNCCLabel.AutoSize = true;
            maNCCLabel.Location = new System.Drawing.Point(89, 66);
            maNCCLabel.Name = "maNCCLabel";
            maNCCLabel.Size = new System.Drawing.Size(71, 19);
            maNCCLabel.TabIndex = 0;
            maNCCLabel.Text = "Ma NCC:";
            // 
            // maNCCSpinEdit
            // 
            this.maNCCSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhaCungCapBindingSource, "MaNCC", true));
            this.maNCCSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.maNCCSpinEdit.Enabled = false;
            this.maNCCSpinEdit.Location = new System.Drawing.Point(166, 63);
            this.maNCCSpinEdit.MenuManager = this.barManager1;
            this.maNCCSpinEdit.Name = "maNCCSpinEdit";
            this.maNCCSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.maNCCSpinEdit.Size = new System.Drawing.Size(150, 28);
            this.maNCCSpinEdit.TabIndex = 1;
            // 
            // tenNCCLabel
            // 
            tenNCCLabel.AutoSize = true;
            tenNCCLabel.Location = new System.Drawing.Point(476, 68);
            tenNCCLabel.Name = "tenNCCLabel";
            tenNCCLabel.Size = new System.Drawing.Size(78, 19);
            tenNCCLabel.TabIndex = 2;
            tenNCCLabel.Text = "Ten NCC:";
            // 
            // tenNCCTextEdit
            // 
            this.tenNCCTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhaCungCapBindingSource, "TenNCC", true));
            this.tenNCCTextEdit.Location = new System.Drawing.Point(560, 65);
            this.tenNCCTextEdit.MenuManager = this.barManager1;
            this.tenNCCTextEdit.Name = "tenNCCTextEdit";
            this.tenNCCTextEdit.Size = new System.Drawing.Size(150, 26);
            this.tenNCCTextEdit.TabIndex = 3;
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Location = new System.Drawing.Point(94, 122);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(66, 19);
            diaChiLabel.TabIndex = 4;
            diaChiLabel.Text = "Dia Chi:";
            // 
            // diaChiTextEdit
            // 
            this.diaChiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhaCungCapBindingSource, "DiaChi", true));
            this.diaChiTextEdit.Location = new System.Drawing.Point(166, 119);
            this.diaChiTextEdit.MenuManager = this.barManager1;
            this.diaChiTextEdit.Name = "diaChiTextEdit";
            this.diaChiTextEdit.Size = new System.Drawing.Size(267, 26);
            this.diaChiTextEdit.TabIndex = 5;
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(509, 131);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(45, 19);
            sDTLabel.TabIndex = 6;
            sDTLabel.Text = "SDT:";
            // 
            // sDTTextEdit
            // 
            this.sDTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhaCungCapBindingSource, "SDT", true));
            this.sDTTextEdit.Location = new System.Drawing.Point(560, 128);
            this.sDTTextEdit.MenuManager = this.barManager1;
            this.sDTTextEdit.Name = "sDTTextEdit";
            this.sDTTextEdit.Size = new System.Drawing.Size(150, 26);
            this.sDTTextEdit.TabIndex = 7;
            // 
            // Form_NCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 637);
            this.Controls.Add(this.groupControl_edit);
            this.Controls.Add(this.groupControl_NCC);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_NCC";
            this.Text = "Form_NCC";
            this.Load += new System.EventHandler(this.Form_NCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_NCC)).EndInit();
            this.groupControl_NCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_edit)).EndInit();
            this.groupControl_edit.ResumeLayout(false);
            this.groupControl_edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maNCCSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenNCCTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaChiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDTTextEdit.Properties)).EndInit();
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
        private DevExpress.XtraEditors.GroupControl groupControl_NCC;
        private System.Windows.Forms.BindingSource nhaCungCapBindingSource;
        private DS dS;
        private DevExpress.XtraEditors.GroupControl groupControl_edit;
        private DSTableAdapters.NhaCungCapTableAdapter nhaCungCapTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit sDTTextEdit;
        private DevExpress.XtraEditors.TextEdit diaChiTextEdit;
        private DevExpress.XtraEditors.TextEdit tenNCCTextEdit;
        private DevExpress.XtraEditors.SpinEdit maNCCSpinEdit;
        private DevExpress.XtraGrid.GridControl nhaCungCapGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNCC;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNCC;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
    }
}