namespace Project._008.Views.DanhMuc
{
    partial class frmKhoVatTu
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
            this.ucAction_WareHourse = new Project._008.UserControls.ucAction();
            this.txtDiaDiem = new DevExpress.XtraEditors.TextEdit();
            this.txtTenKho = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.sTOKhoVatTuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTen_kho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDia_diem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.Ten_kho_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.Dia_diem_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ID_kho_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaDiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOKhoVatTuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ten_kho_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dia_diem_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_kho_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ucAction_WareHourse);
            this.panelControl1.Controls.Add(this.txtDiaDiem);
            this.panelControl1.Controls.Add(this.txtTenKho);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(784, 70);
            this.panelControl1.TabIndex = 0;
            // 
            // ucAction_WareHourse
            // 
            this.ucAction_WareHourse.Location = new System.Drawing.Point(82, 35);
            this.ucAction_WareHourse.nAction = 0;
            this.ucAction_WareHourse.Name = "ucAction_WareHourse";
            this.ucAction_WareHourse.Size = new System.Drawing.Size(405, 29);
            this.ucAction_WareHourse.TabIndex = 7;
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Enabled = false;
            this.txtDiaDiem.Location = new System.Drawing.Point(82, 127);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(680, 20);
            this.txtDiaDiem.TabIndex = 6;
            this.txtDiaDiem.Visible = false;
            this.txtDiaDiem.Validating += new System.ComponentModel.CancelEventHandler(this.txtDiaDiem_Validating);
            // 
            // txtTenKho
            // 
            this.txtTenKho.Enabled = false;
            this.txtTenKho.Location = new System.Drawing.Point(82, 9);
            this.txtTenKho.Name = "txtTenKho";
            this.txtTenKho.Size = new System.Drawing.Size(467, 20);
            this.txtTenKho.TabIndex = 5;
            this.txtTenKho.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenKho_Validating);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 130);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Địa điểm:";
            this.labelControl2.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Kho vật tư:";
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.sTOKhoVatTuBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 70);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Margin = new System.Windows.Forms.Padding(0);
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.Ten_kho_edit,
            this.Dia_diem_edit,
            this.ID_kho_edit});
            this.gridControl.Size = new System.Drawing.Size(784, 491);
            this.gridControl.TabIndex = 17;
            this.gridControl.UseEmbeddedNavigator = true;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // sTOKhoVatTuBindingSource
            // 
            this.sTOKhoVatTuBindingSource.DataSource = typeof(Project._008.Models.STO_KhoVatTu);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTen_kho,
            this.colDia_diem});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.NewItemRowText = "Thêm mới dữ liệu tại đây";
            this.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsView.EnableAppearanceOddRow = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_RowClick);
            this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // colTen_kho
            // 
            this.colTen_kho.AppearanceHeader.Options.UseTextOptions = true;
            this.colTen_kho.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTen_kho.Caption = "Tên kho";
            this.colTen_kho.FieldName = "Ten_kho";
            this.colTen_kho.Name = "colTen_kho";
            this.colTen_kho.Visible = true;
            this.colTen_kho.VisibleIndex = 0;
            // 
            // colDia_diem
            // 
            this.colDia_diem.AppearanceHeader.Options.UseTextOptions = true;
            this.colDia_diem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDia_diem.Caption = "Địa điểm";
            this.colDia_diem.FieldName = "Dia_diem";
            this.colDia_diem.Name = "colDia_diem";
            this.colDia_diem.OptionsFilter.AllowAutoFilter = false;
            this.colDia_diem.OptionsFilter.AllowFilter = false;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // Ten_kho_edit
            // 
            this.Ten_kho_edit.AutoHeight = false;
            this.Ten_kho_edit.Name = "Ten_kho_edit";
            // 
            // Dia_diem_edit
            // 
            this.Dia_diem_edit.AutoHeight = false;
            this.Dia_diem_edit.Name = "Dia_diem_edit";
            // 
            // ID_kho_edit
            // 
            this.ID_kho_edit.AutoHeight = false;
            this.ID_kho_edit.Name = "ID_kho_edit";
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // frmKhoVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmKhoVatTu";
            this.Text = "Danh sách kho vật tư";
            this.Load += new System.EventHandler(this.frmWarehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaDiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOKhoVatTuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ten_kho_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dia_diem_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_kho_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTenKho;
        private DevExpress.XtraEditors.TextEdit txtDiaDiem;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_kho;
        private DevExpress.XtraGrid.Columns.GridColumn colDia_diem;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit Ten_kho_edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit Dia_diem_edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ID_kho_edit;
        private Project._008.UserControls.ucAction ucAction_WareHourse;
        private System.Windows.Forms.BindingSource sTOKhoVatTuBindingSource;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
    }
}