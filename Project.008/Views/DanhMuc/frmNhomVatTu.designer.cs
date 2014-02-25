namespace Project._008.Views.DanhMuc
{
    partial class frmNhomVatTu
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
            this.ucAction_Group = new Project._008.UserControls.ucAction();
            this.cmbMaVatTu = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.ledKhoVatTu = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblNhomVatTu = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblKhoVatTu = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenNhom = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.sTONhomVatTuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_kho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rleKhoVatTu = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTen_nhom_vat_tu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_vat_tu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledKhoVatTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTONhomVatTuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rleKhoVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ucAction_Group);
            this.panelControl1.Controls.Add(this.cmbMaVatTu);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.ledKhoVatTu);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.lblNhomVatTu);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.lblKhoVatTu);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtTenNhom);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(784, 72);
            this.panelControl1.TabIndex = 18;
            // 
            // ucAction_Group
            // 
            this.ucAction_Group.Location = new System.Drawing.Point(12, 35);
            this.ucAction_Group.nAction = 0;
            this.ucAction_Group.Name = "ucAction_Group";
            this.ucAction_Group.Size = new System.Drawing.Size(405, 29);
            this.ucAction_Group.TabIndex = 14;
            // 
            // cmbMaVatTu
            // 
            this.cmbMaVatTu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaVatTu.Enabled = false;
            this.cmbMaVatTu.FormattingEnabled = true;
            this.cmbMaVatTu.Location = new System.Drawing.Point(468, 41);
            this.cmbMaVatTu.Name = "cmbMaVatTu";
            this.cmbMaVatTu.Size = new System.Drawing.Size(154, 21);
            this.cmbMaVatTu.TabIndex = 13;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(438, 44);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Kiểu:";
            // 
            // ledKhoVatTu
            // 
            this.ledKhoVatTu.Location = new System.Drawing.Point(73, 9);
            this.ledKhoVatTu.Name = "ledKhoVatTu";
            this.ledKhoVatTu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledKhoVatTu.Size = new System.Drawing.Size(289, 20);
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
            this.lblNhomVatTu.Location = new System.Drawing.Point(447, 109);
            this.lblNhomVatTu.Name = "lblNhomVatTu";
            this.lblNhomVatTu.Size = new System.Drawing.Size(12, 13);
            this.lblNhomVatTu.TabIndex = 8;
            this.lblNhomVatTu.Text = "    ";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(339, 109);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(93, 13);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Nhóm vật tư trước:";
            // 
            // lblKhoVatTu
            // 
            this.lblKhoVatTu.Location = new System.Drawing.Point(102, 109);
            this.lblKhoVatTu.Name = "lblKhoVatTu";
            this.lblKhoVatTu.Size = new System.Drawing.Size(12, 13);
            this.lblKhoVatTu.TabIndex = 6;
            this.lblKhoVatTu.Text = "    ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 109);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(84, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Kho vật tư trước:";
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Enabled = false;
            this.txtTenNhom.Location = new System.Drawing.Point(468, 9);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(304, 20);
            this.txtTenNhom.TabIndex = 1;
            this.txtTenNhom.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenNhom_Validating);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(398, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nhóm vật tư:";
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.sTONhomVatTuBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 72);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rleKhoVatTu});
            this.gridControl.Size = new System.Drawing.Size(784, 489);
            this.gridControl.TabIndex = 19;
            this.gridControl.UseEmbeddedNavigator = true;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // sTONhomVatTuBindingSource
            // 
            this.sTONhomVatTuBindingSource.DataSource = typeof(Project._008.Models.STO_NhomVatTu);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_kho,
            this.colTen_nhom_vat_tu,
            this.colMa_vat_tu});
            this.gridView.GridControl = this.gridControl;
            this.gridView.GroupPanelText = "Kéo tiêu đề cột vào đây để nhóm theo cột đó";
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            this.gridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_RowClick);
            this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // colID_kho
            // 
            this.colID_kho.Caption = "Kho vật tư";
            this.colID_kho.ColumnEdit = this.rleKhoVatTu;
            this.colID_kho.FieldName = "ID_kho";
            this.colID_kho.Name = "colID_kho";
            this.colID_kho.OptionsColumn.ReadOnly = true;
            this.colID_kho.Visible = true;
            this.colID_kho.VisibleIndex = 0;
            // 
            // rleKhoVatTu
            // 
            this.rleKhoVatTu.AutoHeight = false;
            this.rleKhoVatTu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rleKhoVatTu.Name = "rleKhoVatTu";
            // 
            // colTen_nhom_vat_tu
            // 
            this.colTen_nhom_vat_tu.Caption = "Tên nhóm vật tư";
            this.colTen_nhom_vat_tu.FieldName = "Ten_nhom";
            this.colTen_nhom_vat_tu.Name = "colTen_nhom_vat_tu";
            this.colTen_nhom_vat_tu.Visible = true;
            this.colTen_nhom_vat_tu.VisibleIndex = 1;
            // 
            // colMa_vat_tu
            // 
            this.colMa_vat_tu.Caption = "Kiểu";
            this.colMa_vat_tu.FieldName = "Ma_nhom";
            this.colMa_vat_tu.Name = "colMa_vat_tu";
            this.colMa_vat_tu.Visible = true;
            this.colMa_vat_tu.VisibleIndex = 2;
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // frmGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmGroup";
            this.Text = "Danh sách nhóm vật tư";
            this.Load += new System.EventHandler(this.frmGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledKhoVatTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTONhomVatTuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rleKhoVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbMaVatTu;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit ledKhoVatTu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblNhomVatTu;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblKhoVatTu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTenNhom;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Project._008.UserControls.ucAction ucAction_Group;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colID_kho;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rleKhoVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_nhom_vat_tu;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_vat_tu;
        private System.Windows.Forms.BindingSource sTONhomVatTuBindingSource;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
    }
}