namespace Project._008.Views.HeThong
{
    partial class frmPhanVaiTro
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.grdVaiTro = new DevExpress.XtraGrid.GridControl();
            this.grvVaiTro = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTen_vai_tro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMo_ta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.grdNguoiDung = new DevExpress.XtraGrid.GridControl();
            this.eXTNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvNguoiDung = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTrang_thai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTai_khoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_day_du = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioi_tinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioi_tinh_ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay_sinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_phong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repID_phong = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVaiTro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvVaiTro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXTNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repID_phong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.grdVaiTro);
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.grdNguoiDung);
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(984, 566);
            this.splitContainerControl1.SplitterPosition = 650;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // grdVaiTro
            // 
            this.grdVaiTro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdVaiTro.Location = new System.Drawing.Point(0, 33);
            this.grdVaiTro.MainView = this.grvVaiTro;
            this.grdVaiTro.Name = "grdVaiTro";
            this.grdVaiTro.Size = new System.Drawing.Size(650, 533);
            this.grdVaiTro.TabIndex = 1;
            this.grdVaiTro.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvVaiTro});
            // 
            // grvVaiTro
            // 
            this.grvVaiTro.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTen_vai_tro,
            this.colMo_ta});
            this.grvVaiTro.GridControl = this.grdVaiTro;
            this.grvVaiTro.Name = "grvVaiTro";
            this.grvVaiTro.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grvVaiTro_FocusedRowChanged);
            // 
            // colTen_vai_tro
            // 
            this.colTen_vai_tro.Caption = "Vai trò";
            this.colTen_vai_tro.FieldName = "Ten_vai_tro";
            this.colTen_vai_tro.Name = "colTen_vai_tro";
            this.colTen_vai_tro.Visible = true;
            this.colTen_vai_tro.VisibleIndex = 0;
            // 
            // colMo_ta
            // 
            this.colMo_ta.Caption = "Mô tả";
            this.colMo_ta.FieldName = "Mo_Ta";
            this.colMo_ta.Name = "colMo_ta";
            this.colMo_ta.Visible = true;
            this.colMo_ta.VisibleIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(650, 33);
            this.panelControl1.TabIndex = 0;
            // 
            // grdNguoiDung
            // 
            this.grdNguoiDung.DataSource = this.eXTNhanVienBindingSource;
            this.grdNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdNguoiDung.Location = new System.Drawing.Point(0, 33);
            this.grdNguoiDung.MainView = this.grvNguoiDung;
            this.grdNguoiDung.Name = "grdNguoiDung";
            this.grdNguoiDung.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemProgressBar1,
            this.repID_phong});
            this.grdNguoiDung.Size = new System.Drawing.Size(329, 533);
            this.grdNguoiDung.TabIndex = 2;
            this.grdNguoiDung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvNguoiDung});
            // 
            // eXTNhanVienBindingSource
            // 
            this.eXTNhanVienBindingSource.DataSource = typeof(Project._008.Models.EXT_NguoiDung);
            // 
            // grvNguoiDung
            // 
            this.grvNguoiDung.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTrang_thai,
            this.colTai_khoan,
            this.colTen_day_du,
            this.colGioi_tinh,
            this.colGioi_tinh_ten,
            this.colNgay_sinh,
            this.colID_phong});
            this.grvNguoiDung.GridControl = this.grdNguoiDung;
            this.grvNguoiDung.Name = "grvNguoiDung";
            this.grvNguoiDung.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grvNguoiDung_RowClick);
            this.grvNguoiDung.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grvNguoiDung_CellValueChanged);
            // 
            // colTrang_thai
            // 
            this.colTrang_thai.Caption = " ";
            this.colTrang_thai.FieldName = "Trang_thai";
            this.colTrang_thai.Name = "colTrang_thai";
            this.colTrang_thai.Visible = true;
            this.colTrang_thai.VisibleIndex = 0;
            // 
            // colTai_khoan
            // 
            this.colTai_khoan.Caption = "Tài khoản";
            this.colTai_khoan.FieldName = "View.Tai_khoan";
            this.colTai_khoan.Name = "colTai_khoan";
            this.colTai_khoan.Visible = true;
            this.colTai_khoan.VisibleIndex = 1;
            // 
            // colTen_day_du
            // 
            this.colTen_day_du.Caption = "Họ và tên";
            this.colTen_day_du.FieldName = "View.Ten_day_du";
            this.colTen_day_du.Name = "colTen_day_du";
            this.colTen_day_du.Visible = true;
            this.colTen_day_du.VisibleIndex = 2;
            // 
            // colGioi_tinh
            // 
            this.colGioi_tinh.Caption = "colGioi_tinh";
            this.colGioi_tinh.FieldName = "View.Gioi_tinh";
            this.colGioi_tinh.Name = "colGioi_tinh";
            // 
            // colGioi_tinh_ten
            // 
            this.colGioi_tinh_ten.Caption = "Giới tính";
            this.colGioi_tinh_ten.FieldName = "colGioi_tinh_ten";
            this.colGioi_tinh_ten.Name = "colGioi_tinh_ten";
            this.colGioi_tinh_ten.UnboundExpression = "Iif([View.Gioi_tinh] == True,  \'Nam\', \'Nữ\')";
            this.colGioi_tinh_ten.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colGioi_tinh_ten.Visible = true;
            this.colGioi_tinh_ten.VisibleIndex = 3;
            // 
            // colNgay_sinh
            // 
            this.colNgay_sinh.Caption = "Ngày sinh";
            this.colNgay_sinh.FieldName = "View.Ngay_sinh";
            this.colNgay_sinh.Name = "colNgay_sinh";
            this.colNgay_sinh.Visible = true;
            this.colNgay_sinh.VisibleIndex = 4;
            // 
            // colID_phong
            // 
            this.colID_phong.Caption = "Phòng ban";
            this.colID_phong.ColumnEdit = this.repID_phong;
            this.colID_phong.FieldName = "View.ID_phong";
            this.colID_phong.Name = "colID_phong";
            this.colID_phong.Visible = true;
            this.colID_phong.VisibleIndex = 5;
            // 
            // repID_phong
            // 
            this.repID_phong.AutoHeight = false;
            this.repID_phong.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repID_phong.Name = "repID_phong";
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            // 
            // panelControl2
            // 
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(329, 33);
            this.panelControl2.TabIndex = 1;
            // 
            // frmPhanVaiTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 566);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmPhanVaiTro";
            this.Text = "Phân vai trò";
            this.Load += new System.EventHandler(this.frmPhanVaiTro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdVaiTro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvVaiTro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXTNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repID_phong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl grdVaiTro;
        private DevExpress.XtraGrid.Views.Grid.GridView grvVaiTro;
        private DevExpress.XtraGrid.GridControl grdNguoiDung;
        private DevExpress.XtraGrid.Views.Grid.GridView grvNguoiDung;
        private System.Windows.Forms.BindingSource eXTNhanVienBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_vai_tro;
        private DevExpress.XtraGrid.Columns.GridColumn colMo_ta;
        private DevExpress.XtraGrid.Columns.GridColumn colTrang_thai;
        private DevExpress.XtraGrid.Columns.GridColumn colTai_khoan;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_day_du;
        private DevExpress.XtraGrid.Columns.GridColumn colGioi_tinh;
        private DevExpress.XtraGrid.Columns.GridColumn colGioi_tinh_ten;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay_sinh;
        private DevExpress.XtraGrid.Columns.GridColumn colID_phong;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repID_phong;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
    }
}