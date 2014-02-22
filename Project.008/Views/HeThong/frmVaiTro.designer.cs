namespace Project._008.Views.HeThong
{
    partial class frmVaiTro
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
            this.ucAction = new Project._008.UserControls.ucAction();
            this.txtMoTa = new DevExpress.XtraEditors.TextEdit();
            this.ledQuanLy = new DevExpress.XtraEditors.LookUpEdit();
            this.txtVaiTro = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.sYSVaiTroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTen_vai_tro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_cha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repID_cha = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colMo_Ta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledQuanLy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVaiTro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSVaiTroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repID_cha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ucAction);
            this.panelControl1.Controls.Add(this.txtMoTa);
            this.panelControl1.Controls.Add(this.ledQuanLy);
            this.panelControl1.Controls.Add(this.txtVaiTro);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 310);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(752, 109);
            this.panelControl1.TabIndex = 0;
            // 
            // ucAction
            // 
            this.ucAction.Location = new System.Drawing.Point(70, 67);
            this.ucAction.nAction = 0;
            this.ucAction.Name = "ucAction";
            this.ucAction.Size = new System.Drawing.Size(405, 29);
            this.ucAction.TabIndex = 6;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(70, 41);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(646, 20);
            this.txtMoTa.TabIndex = 5;
            // 
            // ledQuanLy
            // 
            this.ledQuanLy.Location = new System.Drawing.Point(453, 15);
            this.ledQuanLy.Name = "ledQuanLy";
            this.ledQuanLy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledQuanLy.Size = new System.Drawing.Size(263, 20);
            this.ledQuanLy.TabIndex = 4;
            // 
            // txtVaiTro
            // 
            this.txtVaiTro.Location = new System.Drawing.Point(70, 15);
            this.txtVaiTro.Name = "txtVaiTro";
            this.txtVaiTro.Size = new System.Drawing.Size(321, 20);
            this.txtVaiTro.TabIndex = 3;
            this.txtVaiTro.Validating += new System.ComponentModel.CancelEventHandler(this.txtVaiTro_Validating);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(406, 18);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Quản lý:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(29, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mô tả:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Vai trò:";
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.sYSVaiTroBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repID_cha});
            this.gridControl.Size = new System.Drawing.Size(752, 310);
            this.gridControl.TabIndex = 1;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // sYSVaiTroBindingSource
            // 
            this.sYSVaiTroBindingSource.DataSource = typeof(Project._008.Models.SYS_VaiTro);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTen_vai_tro,
            this.colID_cha,
            this.colMo_Ta});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // colTen_vai_tro
            // 
            this.colTen_vai_tro.Caption = "Vai trò";
            this.colTen_vai_tro.FieldName = "Ten_vai_tro";
            this.colTen_vai_tro.Name = "colTen_vai_tro";
            this.colTen_vai_tro.Visible = true;
            this.colTen_vai_tro.VisibleIndex = 0;
            // 
            // colID_cha
            // 
            this.colID_cha.Caption = "Quản lý";
            this.colID_cha.ColumnEdit = this.repID_cha;
            this.colID_cha.FieldName = "ID_cha";
            this.colID_cha.Name = "colID_cha";
            this.colID_cha.Visible = true;
            this.colID_cha.VisibleIndex = 1;
            // 
            // repID_cha
            // 
            this.repID_cha.AutoHeight = false;
            this.repID_cha.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repID_cha.Name = "repID_cha";
            // 
            // colMo_Ta
            // 
            this.colMo_Ta.Caption = "Mô tả";
            this.colMo_Ta.FieldName = "Mo_Ta";
            this.colMo_Ta.Name = "colMo_Ta";
            this.colMo_Ta.Visible = true;
            this.colMo_Ta.VisibleIndex = 2;
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // frmVaiTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 419);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmVaiTro";
            this.Text = "Vai trò";
            this.Load += new System.EventHandler(this.frmVaiTro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledQuanLy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVaiTro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSVaiTroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repID_cha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private System.Windows.Forms.BindingSource sYSVaiTroBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_vai_tro;
        private DevExpress.XtraGrid.Columns.GridColumn colID_cha;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repID_cha;
        private DevExpress.XtraGrid.Columns.GridColumn colMo_Ta;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtVaiTro;
        private DevExpress.XtraEditors.TextEdit txtMoTa;
        private DevExpress.XtraEditors.LookUpEdit ledQuanLy;
        private Project._008.UserControls.ucAction ucAction;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
    }
}