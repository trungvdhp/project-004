namespace Project._008.Views.DanhMuc
{
    partial class frmLoaiVatTu
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
            this.ucLed = new Project._008.UserControls.ucLookUpEdit();
            this.ucAction = new Project._008.UserControls.ucAction();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lblLoaiVatTu = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.ledKhoVatTu = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblNhomVatTu = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblKhoVatTu = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenLoai = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.sTOLoaiVatTuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_nhom_vat_tu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rleNhomVatTu = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTen_loai_vat_tu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rleKhoVatTu = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledKhoVatTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOLoaiVatTuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rleNhomVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rleKhoVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ucLed);
            this.panelControl1.Controls.Add(this.ucAction);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.lblLoaiVatTu);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.ledKhoVatTu);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.lblNhomVatTu);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.lblKhoVatTu);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtTenLoai);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(784, 99);
            this.panelControl1.TabIndex = 20;
            // 
            // ucLed
            // 
            this.ucLed.Location = new System.Drawing.Point(444, 3);
            this.ucLed.Name = "ucLed";
            this.ucLed.Size = new System.Drawing.Size(315, 30);
            this.ucLed.TabIndex = 16;
            // 
            // ucAction
            // 
            this.ucAction.Location = new System.Drawing.Point(90, 65);
            this.ucAction.nAction = 0;
            this.ucAction.Name = "ucAction";
            this.ucAction.Size = new System.Drawing.Size(405, 29);
            this.ucAction.TabIndex = 15;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 38);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(56, 13);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Loại vật tư:";
            // 
            // lblLoaiVatTu
            // 
            this.lblLoaiVatTu.Location = new System.Drawing.Point(765, 123);
            this.lblLoaiVatTu.Name = "lblLoaiVatTu";
            this.lblLoaiVatTu.Size = new System.Drawing.Size(12, 13);
            this.lblLoaiVatTu.TabIndex = 12;
            this.lblLoaiVatTu.Text = "    ";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(665, 123);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(94, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Loại vật tư hiện tại:";
            // 
            // ledKhoVatTu
            // 
            this.ledKhoVatTu.Location = new System.Drawing.Point(90, 9);
            this.ledKhoVatTu.Name = "ledKhoVatTu";
            this.ledKhoVatTu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledKhoVatTu.Size = new System.Drawing.Size(244, 20);
            this.ledKhoVatTu.TabIndex = 10;
            this.ledKhoVatTu.EditValueChanged += new System.EventHandler(this.ledKhoVatTu_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Kho vật tư:";
            // 
            // lblNhomVatTu
            // 
            this.lblNhomVatTu.Location = new System.Drawing.Point(426, 122);
            this.lblNhomVatTu.Name = "lblNhomVatTu";
            this.lblNhomVatTu.Size = new System.Drawing.Size(12, 13);
            this.lblNhomVatTu.TabIndex = 8;
            this.lblNhomVatTu.Text = "    ";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(318, 123);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(102, 13);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Nhóm vật tư hiện tại:";
            // 
            // lblKhoVatTu
            // 
            this.lblKhoVatTu.Location = new System.Drawing.Point(111, 123);
            this.lblKhoVatTu.Name = "lblKhoVatTu";
            this.lblKhoVatTu.Size = new System.Drawing.Size(12, 13);
            this.lblKhoVatTu.TabIndex = 6;
            this.lblKhoVatTu.Text = "    ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 123);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(93, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Kho vật tư hiện tại:";
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Enabled = false;
            this.txtTenLoai.Location = new System.Drawing.Point(90, 35);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(669, 20);
            this.txtTenLoai.TabIndex = 1;
            this.txtTenLoai.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenLoai_Validating);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(374, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nhóm vật tư:";
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.sTOLoaiVatTuBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 99);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rleNhomVatTu,
            this.rleKhoVatTu});
            this.gridControl.Size = new System.Drawing.Size(784, 462);
            this.gridControl.TabIndex = 21;
            this.gridControl.UseEmbeddedNavigator = true;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // sTOLoaiVatTuBindingSource
            // 
            this.sTOLoaiVatTuBindingSource.DataSource = typeof(Project._008.Models.STO_LoaiVatTu);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_nhom_vat_tu,
            this.colTen_loai_vat_tu,
            this.colKieu});
            this.gridView.GridControl = this.gridControl;
            this.gridView.GroupPanelText = "Kéo tiêu đề cột vào đây để nhóm theo cột đó";
            this.gridView.Name = "gridView";
            this.gridView.NewItemRowText = "Thêm mới dữ liệu tại đây";
            this.gridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_RowClick);
            this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // colID_nhom_vat_tu
            // 
            this.colID_nhom_vat_tu.Caption = "Nhóm vật tư";
            this.colID_nhom_vat_tu.ColumnEdit = this.rleNhomVatTu;
            this.colID_nhom_vat_tu.FieldName = "ID_nhom";
            this.colID_nhom_vat_tu.Name = "colID_nhom_vat_tu";
            this.colID_nhom_vat_tu.OptionsColumn.ReadOnly = true;
            this.colID_nhom_vat_tu.Visible = true;
            this.colID_nhom_vat_tu.VisibleIndex = 0;
            // 
            // rleNhomVatTu
            // 
            this.rleNhomVatTu.AutoHeight = false;
            this.rleNhomVatTu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rleNhomVatTu.Name = "rleNhomVatTu";
            // 
            // colTen_loai_vat_tu
            // 
            this.colTen_loai_vat_tu.Caption = "Tên loại vật tư";
            this.colTen_loai_vat_tu.FieldName = "Ten_loai";
            this.colTen_loai_vat_tu.Name = "colTen_loai_vat_tu";
            this.colTen_loai_vat_tu.Visible = true;
            this.colTen_loai_vat_tu.VisibleIndex = 1;
            // 
            // colKieu
            // 
            this.colKieu.Caption = "Kiểu";
            this.colKieu.FieldName = "Ma_loai";
            this.colKieu.Name = "colKieu";
            this.colKieu.Visible = true;
            this.colKieu.VisibleIndex = 2;
            // 
            // rleKhoVatTu
            // 
            this.rleKhoVatTu.AutoHeight = false;
            this.rleKhoVatTu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rleKhoVatTu.Name = "rleKhoVatTu";
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // frmKind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmKind";
            this.Text = "Danh sách loại vật tư";
            this.Load += new System.EventHandler(this.frmKind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledKhoVatTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOLoaiVatTuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rleNhomVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rleKhoVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl lblLoaiVatTu;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit ledKhoVatTu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblNhomVatTu;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblKhoVatTu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTenLoai;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Project._008.UserControls.ucAction ucAction;
        private Project._008.UserControls.ucLookUpEdit ucLed;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rleKhoVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn colID_nhom_vat_tu;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rleNhomVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_loai_vat_tu;
        private DevExpress.XtraGrid.Columns.GridColumn colKieu;
        private System.Windows.Forms.BindingSource sTOLoaiVatTuBindingSource;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
    }
}