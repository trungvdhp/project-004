namespace Project._008.Views.TienIch
{
    partial class frmGiaVatTu
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
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.ledDiaDiem = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.ledLoaiVatTu = new DevExpress.XtraEditors.LookUpEdit();
            this.ledNhomVatTu = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.ledKhoVatTu = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.viewSTOVatTuCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_kho_tt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_kho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_nhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_loai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_vat_tu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_vat_tu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_don_vi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhau_do = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrong_luong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDo_day = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDo_cao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDo_rong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSo_luong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDon_gia_nhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDon_gia_xuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rleID_kho_tt = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledDiaDiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledLoaiVatTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledNhomVatTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledKhoVatTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSTOVatTuCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rleID_kho_tt)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnLuu);
            this.panelControl1.Controls.Add(this.ledDiaDiem);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.ledLoaiVatTu);
            this.panelControl1.Controls.Add(this.ledNhomVatTu);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.ledKhoVatTu);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(895, 62);
            this.panelControl1.TabIndex = 0;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Location = new System.Drawing.Point(815, 6);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 45;
            this.btnLuu.Text = "Lưu";
            // 
            // ledDiaDiem
            // 
            this.ledDiaDiem.Location = new System.Drawing.Point(82, 9);
            this.ledDiaDiem.Name = "ledDiaDiem";
            this.ledDiaDiem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledDiaDiem.Size = new System.Drawing.Size(285, 20);
            this.ledDiaDiem.TabIndex = 43;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 13);
            this.labelControl3.TabIndex = 44;
            this.labelControl3.Text = "Địa điểm:";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Location = new System.Drawing.Point(815, 33);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 42;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // ledLoaiVatTu
            // 
            this.ledLoaiVatTu.Location = new System.Drawing.Point(456, 35);
            this.ledLoaiVatTu.Name = "ledLoaiVatTu";
            this.ledLoaiVatTu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledLoaiVatTu.Size = new System.Drawing.Size(285, 20);
            this.ledLoaiVatTu.TabIndex = 41;
            this.ledLoaiVatTu.EditValueChanged += new System.EventHandler(this.ledLoaiVatTu_EditValueChanged);
            // 
            // ledNhomVatTu
            // 
            this.ledNhomVatTu.Location = new System.Drawing.Point(82, 35);
            this.ledNhomVatTu.Name = "ledNhomVatTu";
            this.ledNhomVatTu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledNhomVatTu.Size = new System.Drawing.Size(285, 20);
            this.ledNhomVatTu.TabIndex = 40;
            this.ledNhomVatTu.EditValueChanged += new System.EventHandler(this.ledNhomVatTu_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 13);
            this.labelControl1.TabIndex = 39;
            this.labelControl1.Text = "Nhóm vật tư:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(386, 38);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(56, 13);
            this.labelControl9.TabIndex = 38;
            this.labelControl9.Text = "Loại vật tư:";
            // 
            // ledKhoVatTu
            // 
            this.ledKhoVatTu.Location = new System.Drawing.Point(456, 9);
            this.ledKhoVatTu.Name = "ledKhoVatTu";
            this.ledKhoVatTu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledKhoVatTu.Size = new System.Drawing.Size(285, 20);
            this.ledKhoVatTu.TabIndex = 34;
            this.ledKhoVatTu.EditValueChanged += new System.EventHandler(this.ledKhoVatTu_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(386, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 13);
            this.labelControl2.TabIndex = 37;
            this.labelControl2.Text = "Kho vật tư:";
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.viewSTOVatTuCTBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 62);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rleID_kho_tt});
            this.gridControl.Size = new System.Drawing.Size(895, 425);
            this.gridControl.TabIndex = 1;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // viewSTOVatTuCTBindingSource
            // 
            this.viewSTOVatTuCTBindingSource.DataSource = typeof(Project._008.Models.viewSTOVatTuCT);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_kho_tt,
            this.colID_kho,
            this.colID_nhom,
            this.colID_loai,
            this.colMa_vat_tu,
            this.colTen_vat_tu,
            this.colID_don_vi,
            this.colKhau_do,
            this.colTrong_luong,
            this.colDo_day,
            this.colDo_cao,
            this.colDo_rong,
            this.colSo_luong,
            this.colDon_gia_nhap,
            this.colDon_gia_xuat});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            // 
            // colID_kho_tt
            // 
            this.colID_kho_tt.Caption = "Địa điểm";
            this.colID_kho_tt.ColumnEdit = this.rleID_kho_tt;
            this.colID_kho_tt.FieldName = "ID_kho_tt";
            this.colID_kho_tt.Name = "colID_kho_tt";
            this.colID_kho_tt.Visible = true;
            this.colID_kho_tt.VisibleIndex = 0;
            // 
            // colID_kho
            // 
            this.colID_kho.Caption = "Kho vật tư";
            this.colID_kho.FieldName = "ID_kho";
            this.colID_kho.Name = "colID_kho";
            // 
            // colID_nhom
            // 
            this.colID_nhom.Caption = "Nhóm vật tư";
            this.colID_nhom.FieldName = "ID_nhom";
            this.colID_nhom.Name = "colID_nhom";
            // 
            // colID_loai
            // 
            this.colID_loai.Caption = "Loại vật tư";
            this.colID_loai.FieldName = "ID_loai";
            this.colID_loai.Name = "colID_loai";
            // 
            // colMa_vat_tu
            // 
            this.colMa_vat_tu.Caption = "Mã vật tư";
            this.colMa_vat_tu.FieldName = "Ma_vat_tu";
            this.colMa_vat_tu.Name = "colMa_vat_tu";
            this.colMa_vat_tu.Visible = true;
            this.colMa_vat_tu.VisibleIndex = 1;
            // 
            // colTen_vat_tu
            // 
            this.colTen_vat_tu.Caption = "Tên vật tư";
            this.colTen_vat_tu.FieldName = "Ten_vat_tu";
            this.colTen_vat_tu.Name = "colTen_vat_tu";
            this.colTen_vat_tu.Visible = true;
            this.colTen_vat_tu.VisibleIndex = 2;
            // 
            // colID_don_vi
            // 
            this.colID_don_vi.Caption = "Đơn vị tính";
            this.colID_don_vi.FieldName = "ID_don_vi";
            this.colID_don_vi.Name = "colID_don_vi";
            this.colID_don_vi.Visible = true;
            this.colID_don_vi.VisibleIndex = 3;
            // 
            // colKhau_do
            // 
            this.colKhau_do.Caption = "Khẩu độ";
            this.colKhau_do.FieldName = "Khau_do";
            this.colKhau_do.Name = "colKhau_do";
            this.colKhau_do.Visible = true;
            this.colKhau_do.VisibleIndex = 4;
            // 
            // colTrong_luong
            // 
            this.colTrong_luong.Caption = "Trọng lượng";
            this.colTrong_luong.FieldName = "Trong_luong";
            this.colTrong_luong.Name = "colTrong_luong";
            this.colTrong_luong.Visible = true;
            this.colTrong_luong.VisibleIndex = 5;
            // 
            // colDo_day
            // 
            this.colDo_day.Caption = "Độ dày";
            this.colDo_day.FieldName = "Do_day";
            this.colDo_day.Name = "colDo_day";
            this.colDo_day.Visible = true;
            this.colDo_day.VisibleIndex = 6;
            // 
            // colDo_cao
            // 
            this.colDo_cao.Caption = "Độ cao";
            this.colDo_cao.FieldName = "Do_cao";
            this.colDo_cao.Name = "colDo_cao";
            this.colDo_cao.Visible = true;
            this.colDo_cao.VisibleIndex = 7;
            // 
            // colDo_rong
            // 
            this.colDo_rong.Caption = "Độ rộng";
            this.colDo_rong.FieldName = "Do_rong";
            this.colDo_rong.Name = "colDo_rong";
            this.colDo_rong.Visible = true;
            this.colDo_rong.VisibleIndex = 8;
            // 
            // colSo_luong
            // 
            this.colSo_luong.Caption = "Số lượng";
            this.colSo_luong.FieldName = "So_luong";
            this.colSo_luong.Name = "colSo_luong";
            this.colSo_luong.Visible = true;
            this.colSo_luong.VisibleIndex = 9;
            // 
            // colDon_gia_nhap
            // 
            this.colDon_gia_nhap.Caption = "Đơn giá nhập";
            this.colDon_gia_nhap.FieldName = "Don_gia_nhap";
            this.colDon_gia_nhap.Name = "colDon_gia_nhap";
            this.colDon_gia_nhap.Visible = true;
            this.colDon_gia_nhap.VisibleIndex = 10;
            // 
            // colDon_gia_xuat
            // 
            this.colDon_gia_xuat.Caption = "Đơn giá xuất";
            this.colDon_gia_xuat.FieldName = "Don_gia_xuat";
            this.colDon_gia_xuat.Name = "colDon_gia_xuat";
            this.colDon_gia_xuat.Visible = true;
            this.colDon_gia_xuat.VisibleIndex = 11;
            // 
            // rleID_kho_tt
            // 
            this.rleID_kho_tt.AutoHeight = false;
            this.rleID_kho_tt.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rleID_kho_tt.Name = "rleID_kho_tt";
            // 
            // frmGiaVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 487);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmGiaVatTu";
            this.Text = "Thiết lập giá vật tư";
            this.Load += new System.EventHandler(this.frmGiaVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledDiaDiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledLoaiVatTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledNhomVatTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledKhoVatTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSTOVatTuCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rleID_kho_tt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LookUpEdit ledKhoVatTu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit ledLoaiVatTu;
        private DevExpress.XtraEditors.LookUpEdit ledNhomVatTu;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private System.Windows.Forms.BindingSource viewSTOVatTuCTBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID_kho;
        private DevExpress.XtraGrid.Columns.GridColumn colID_nhom;
        private DevExpress.XtraGrid.Columns.GridColumn colID_loai;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_vat_tu;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_vat_tu;
        private DevExpress.XtraGrid.Columns.GridColumn colID_don_vi;
        private DevExpress.XtraGrid.Columns.GridColumn colKhau_do;
        private DevExpress.XtraGrid.Columns.GridColumn colTrong_luong;
        private DevExpress.XtraGrid.Columns.GridColumn colDo_day;
        private DevExpress.XtraGrid.Columns.GridColumn colDo_cao;
        private DevExpress.XtraGrid.Columns.GridColumn colDo_rong;
        private DevExpress.XtraGrid.Columns.GridColumn colID_kho_tt;
        private DevExpress.XtraGrid.Columns.GridColumn colSo_luong;
        private DevExpress.XtraGrid.Columns.GridColumn colDon_gia_nhap;
        private DevExpress.XtraGrid.Columns.GridColumn colDon_gia_xuat;
        private DevExpress.XtraEditors.LookUpEdit ledDiaDiem;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rleID_kho_tt;
    }
}