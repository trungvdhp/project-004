namespace Project._008.Views.DanhMuc
{
    partial class frmQuanLyNguoiDung
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnMoTaiKhoan = new DevExpress.XtraEditors.SimpleButton();
            this.btnKhoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.sYSNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTai_khoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_day_du = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThoi_gian_cho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_nhan_vien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rleID_nhan_vien = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colLan_dang_nhap_cuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMay_tram = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_trang_thai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrang_thai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSNguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rleID_nhan_vien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.btnMoTaiKhoan);
            this.panelControl1.Controls.Add(this.btnKhoa);
            this.panelControl1.Controls.Add(this.btnThem);
            this.panelControl1.Controls.Add(this.btnSua);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(804, 46);
            this.panelControl1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Location = new System.Drawing.Point(707, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 25);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnMoTaiKhoan
            // 
            this.btnMoTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoTaiKhoan.Location = new System.Drawing.Point(525, 12);
            this.btnMoTaiKhoan.Name = "btnMoTaiKhoan";
            this.btnMoTaiKhoan.Size = new System.Drawing.Size(85, 25);
            this.btnMoTaiKhoan.TabIndex = 10;
            this.btnMoTaiKhoan.Text = "Mở tài khoản";
            this.btnMoTaiKhoan.Click += new System.EventHandler(this.btnMoTaiKhoan_Click);
            // 
            // btnKhoa
            // 
            this.btnKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKhoa.Location = new System.Drawing.Point(616, 12);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Size = new System.Drawing.Size(85, 25);
            this.btnKhoa.TabIndex = 11;
            this.btnKhoa.Text = "Khóa tài khoản";
            this.btnKhoa.Click += new System.EventHandler(this.btnKhoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Location = new System.Drawing.Point(343, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 25);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Tạo tài khoản";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Location = new System.Drawing.Point(434, 12);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 25);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa tài khoản";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.sYSNguoiDungBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 46);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rleID_nhan_vien,
            this.repositoryItemTextEdit1});
            this.gridControl.Size = new System.Drawing.Size(804, 411);
            this.gridControl.TabIndex = 1;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // sYSNguoiDungBindingSource
            // 
            this.sYSNguoiDungBindingSource.DataSource = typeof(Project._008.Models.SYS_NguoiDung);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTai_khoan,
            this.colTen_day_du,
            this.colThoi_gian_cho,
            this.colID_nhan_vien,
            this.colLan_dang_nhap_cuoi,
            this.colMay_tram,
            this.colID_trang_thai,
            this.colTrang_thai});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            // 
            // colTai_khoan
            // 
            this.colTai_khoan.Caption = "Tài khoản";
            this.colTai_khoan.FieldName = "Tai_khoan";
            this.colTai_khoan.Name = "colTai_khoan";
            this.colTai_khoan.Visible = true;
            this.colTai_khoan.VisibleIndex = 0;
            // 
            // colTen_day_du
            // 
            this.colTen_day_du.Caption = "Tên hiển thị";
            this.colTen_day_du.FieldName = "Ten_day_du";
            this.colTen_day_du.Name = "colTen_day_du";
            this.colTen_day_du.Visible = true;
            this.colTen_day_du.VisibleIndex = 1;
            // 
            // colThoi_gian_cho
            // 
            this.colThoi_gian_cho.Caption = "Thời gian chờ";
            this.colThoi_gian_cho.FieldName = "Thoi_gian_cho";
            this.colThoi_gian_cho.Name = "colThoi_gian_cho";
            this.colThoi_gian_cho.Visible = true;
            this.colThoi_gian_cho.VisibleIndex = 2;
            // 
            // colID_nhan_vien
            // 
            this.colID_nhan_vien.Caption = "Nhân viên";
            this.colID_nhan_vien.ColumnEdit = this.rleID_nhan_vien;
            this.colID_nhan_vien.FieldName = "ID_nhan_vien";
            this.colID_nhan_vien.Name = "colID_nhan_vien";
            this.colID_nhan_vien.Visible = true;
            this.colID_nhan_vien.VisibleIndex = 3;
            // 
            // rleID_nhan_vien
            // 
            this.rleID_nhan_vien.AutoHeight = false;
            this.rleID_nhan_vien.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rleID_nhan_vien.Name = "rleID_nhan_vien";
            // 
            // colLan_dang_nhap_cuoi
            // 
            this.colLan_dang_nhap_cuoi.Caption = "Lần đăng nhập cuối";
            this.colLan_dang_nhap_cuoi.FieldName = "Lan_dang_nhap_cuoi";
            this.colLan_dang_nhap_cuoi.Name = "colLan_dang_nhap_cuoi";
            this.colLan_dang_nhap_cuoi.Visible = true;
            this.colLan_dang_nhap_cuoi.VisibleIndex = 4;
            // 
            // colMay_tram
            // 
            this.colMay_tram.Caption = "Máy trạm";
            this.colMay_tram.FieldName = "May_tram";
            this.colMay_tram.Name = "colMay_tram";
            this.colMay_tram.Visible = true;
            this.colMay_tram.VisibleIndex = 5;
            // 
            // colID_trang_thai
            // 
            this.colID_trang_thai.FieldName = "ID_trang_thai";
            this.colID_trang_thai.Name = "colID_trang_thai";
            // 
            // colTrang_thai
            // 
            this.colTrang_thai.Caption = "Trạng thái";
            this.colTrang_thai.FieldName = "colTrang_thai";
            this.colTrang_thai.Name = "colTrang_thai";
            this.colTrang_thai.UnboundExpression = "Iif([ID_trang_thai] == 0,  \'Chưa kích hoạt\', Iif([ID_trang_thai] == 1,  \' \', Iif(" +
    "[ID_trang_thai] == 2,  \'Đang sử dụng\', \'Đã khóa\')))";
            this.colTrang_thai.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colTrang_thai.Visible = true;
            this.colTrang_thai.VisibleIndex = 6;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.MaxLength = 8;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.PasswordChar = '*';
            // 
            // frmQuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 457);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmQuanLyNguoiDung";
            this.Text = "Quản lý người dùng";
            this.Load += new System.EventHandler(this.frmQuanLyNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSNguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rleID_nhan_vien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private System.Windows.Forms.BindingSource sYSNguoiDungBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTai_khoan;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_day_du;
        private DevExpress.XtraGrid.Columns.GridColumn colID_trang_thai;
        private DevExpress.XtraGrid.Columns.GridColumn colID_nhan_vien;
        private DevExpress.XtraGrid.Columns.GridColumn colLan_dang_nhap_cuoi;
        private DevExpress.XtraGrid.Columns.GridColumn colThoi_gian_cho;
        private DevExpress.XtraGrid.Columns.GridColumn colMay_tram;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rleID_nhan_vien;
        private DevExpress.XtraGrid.Columns.GridColumn colTrang_thai;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnMoTaiKhoan;
        private DevExpress.XtraEditors.SimpleButton btnKhoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
    }
}