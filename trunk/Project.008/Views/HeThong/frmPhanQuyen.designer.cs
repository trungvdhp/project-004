namespace Project._008.Views.HeThong
{
    partial class frmPhanQuyen
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.treeList = new DevExpress.XtraTreeList.TreeList();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnMoRong = new DevExpress.XtraEditors.SimpleButton();
            this.btnKeThua = new DevExpress.XtraEditors.SimpleButton();
            this.ledVaiTroKeThua = new DevExpress.XtraEditors.LookUpEdit();
            this.ledVaiTro = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnThuGon = new DevExpress.XtraEditors.SimpleButton();
            this.btnChuaGanThuocTinh = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.grdThuocTinh = new DevExpress.XtraGrid.GridControl();
            this.grvThuocTinh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_thuoc_tinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repID_thuoc_tinh = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colGia_tri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnLuuThuocTinh = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamMoiThuocTinh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledVaiTroKeThua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledVaiTro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdThuocTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvThuocTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repID_thuoc_tinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.grdThuocTinh);
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1046, 616);
            this.splitContainerControl1.SplitterPosition = 400;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.treeList);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 62);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(641, 554);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Danh sách quyền cũ";
            // 
            // treeList
            // 
            this.treeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList.Location = new System.Drawing.Point(2, 21);
            this.treeList.Name = "treeList";
            this.treeList.Size = new System.Drawing.Size(637, 531);
            this.treeList.TabIndex = 1;
            this.treeList.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList_FocusedNodeChanged);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.btnMoRong);
            this.panelControl2.Controls.Add(this.btnKeThua);
            this.panelControl2.Controls.Add(this.ledVaiTroKeThua);
            this.panelControl2.Controls.Add(this.ledVaiTro);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.btnThuGon);
            this.panelControl2.Controls.Add(this.btnChuaGanThuocTinh);
            this.panelControl2.Controls.Add(this.btnLamMoi);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(641, 62);
            this.panelControl2.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Kế thừa:";
            // 
            // btnMoRong
            // 
            this.btnMoRong.Location = new System.Drawing.Point(456, 34);
            this.btnMoRong.Name = "btnMoRong";
            this.btnMoRong.Size = new System.Drawing.Size(75, 23);
            this.btnMoRong.TabIndex = 10;
            this.btnMoRong.Text = "Mở rộng";
            this.btnMoRong.Click += new System.EventHandler(this.btnMoRong_Click);
            // 
            // btnKeThua
            // 
            this.btnKeThua.Location = new System.Drawing.Point(294, 34);
            this.btnKeThua.Name = "btnKeThua";
            this.btnKeThua.Size = new System.Drawing.Size(75, 23);
            this.btnKeThua.TabIndex = 9;
            this.btnKeThua.Text = "Kế thừa";
            this.btnKeThua.Click += new System.EventHandler(this.btnKeThua_Click);
            // 
            // ledVaiTroKeThua
            // 
            this.ledVaiTroKeThua.Location = new System.Drawing.Point(60, 36);
            this.ledVaiTroKeThua.Name = "ledVaiTroKeThua";
            this.ledVaiTroKeThua.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledVaiTroKeThua.Size = new System.Drawing.Size(228, 20);
            this.ledVaiTroKeThua.TabIndex = 8;
            // 
            // ledVaiTro
            // 
            this.ledVaiTro.Location = new System.Drawing.Point(60, 7);
            this.ledVaiTro.Name = "ledVaiTro";
            this.ledVaiTro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledVaiTro.Size = new System.Drawing.Size(228, 20);
            this.ledVaiTro.TabIndex = 7;
            this.ledVaiTro.EditValueChanged += new System.EventHandler(this.ledVaiTro_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Vai trò:";
            // 
            // btnThuGon
            // 
            this.btnThuGon.Location = new System.Drawing.Point(375, 34);
            this.btnThuGon.Name = "btnThuGon";
            this.btnThuGon.Size = new System.Drawing.Size(75, 23);
            this.btnThuGon.TabIndex = 5;
            this.btnThuGon.Text = "Thu gọn";
            this.btnThuGon.Click += new System.EventHandler(this.btnThuGon_Click);
            // 
            // btnChuaGanThuocTinh
            // 
            this.btnChuaGanThuocTinh.Location = new System.Drawing.Point(375, 5);
            this.btnChuaGanThuocTinh.Name = "btnChuaGanThuocTinh";
            this.btnChuaGanThuocTinh.Size = new System.Drawing.Size(156, 23);
            this.btnChuaGanThuocTinh.TabIndex = 4;
            this.btnChuaGanThuocTinh.Text = "Chưa gán thuộc tính";
            this.btnChuaGanThuocTinh.Click += new System.EventHandler(this.btnChuaGanThuocTinh_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(294, 5);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // grdThuocTinh
            // 
            this.grdThuocTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdThuocTinh.Location = new System.Drawing.Point(0, 62);
            this.grdThuocTinh.MainView = this.grvThuocTinh;
            this.grdThuocTinh.Name = "grdThuocTinh";
            this.grdThuocTinh.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repID_thuoc_tinh});
            this.grdThuocTinh.Size = new System.Drawing.Size(400, 554);
            this.grdThuocTinh.TabIndex = 1;
            this.grdThuocTinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvThuocTinh});
            // 
            // grvThuocTinh
            // 
            this.grvThuocTinh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_thuoc_tinh,
            this.colGia_tri});
            this.grvThuocTinh.GridControl = this.grdThuocTinh;
            this.grvThuocTinh.Name = "grvThuocTinh";
            // 
            // colID_thuoc_tinh
            // 
            this.colID_thuoc_tinh.Caption = "Thuộc tính";
            this.colID_thuoc_tinh.ColumnEdit = this.repID_thuoc_tinh;
            this.colID_thuoc_tinh.FieldName = "ID_thuoc_tinh";
            this.colID_thuoc_tinh.Name = "colID_thuoc_tinh";
            this.colID_thuoc_tinh.Visible = true;
            this.colID_thuoc_tinh.VisibleIndex = 0;
            // 
            // repID_thuoc_tinh
            // 
            this.repID_thuoc_tinh.AutoHeight = false;
            this.repID_thuoc_tinh.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repID_thuoc_tinh.Name = "repID_thuoc_tinh";
            // 
            // colGia_tri
            // 
            this.colGia_tri.Caption = "Giá trị";
            this.colGia_tri.FieldName = "Gia_tri";
            this.colGia_tri.Name = "colGia_tri";
            this.colGia_tri.Visible = true;
            this.colGia_tri.VisibleIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnLuuThuocTinh);
            this.panelControl1.Controls.Add(this.btnLamMoiThuocTinh);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(400, 62);
            this.panelControl1.TabIndex = 0;
            // 
            // btnLuuThuocTinh
            // 
            this.btnLuuThuocTinh.Location = new System.Drawing.Point(5, 34);
            this.btnLuuThuocTinh.Name = "btnLuuThuocTinh";
            this.btnLuuThuocTinh.Size = new System.Drawing.Size(75, 23);
            this.btnLuuThuocTinh.TabIndex = 1;
            this.btnLuuThuocTinh.Text = "Lưu";
            this.btnLuuThuocTinh.Click += new System.EventHandler(this.btnLuuThuocTinh_Click);
            // 
            // btnLamMoiThuocTinh
            // 
            this.btnLamMoiThuocTinh.Location = new System.Drawing.Point(5, 5);
            this.btnLamMoiThuocTinh.Name = "btnLamMoiThuocTinh";
            this.btnLamMoiThuocTinh.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoiThuocTinh.TabIndex = 0;
            this.btnLamMoiThuocTinh.Text = "Làm mới";
            this.btnLamMoiThuocTinh.Click += new System.EventHandler(this.btnLamMoiThuocTinh_Click);
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 616);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmPhanQuyen";
            this.Text = "Phần quyền";
            this.Load += new System.EventHandler(this.frmPhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledVaiTroKeThua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledVaiTro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdThuocTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvThuocTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repID_thuoc_tinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl grdThuocTinh;
        private DevExpress.XtraGrid.Views.Grid.GridView grvThuocTinh;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraTreeList.TreeList treeList;
        private DevExpress.XtraGrid.Columns.GridColumn colID_thuoc_tinh;
        private DevExpress.XtraGrid.Columns.GridColumn colGia_tri;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repID_thuoc_tinh;
        private DevExpress.XtraEditors.SimpleButton btnLamMoiThuocTinh;
        private DevExpress.XtraEditors.SimpleButton btnLuuThuocTinh;
        private DevExpress.XtraEditors.SimpleButton btnThuGon;
        private DevExpress.XtraEditors.SimpleButton btnChuaGanThuocTinh;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit ledVaiTro;
        private DevExpress.XtraEditors.SimpleButton btnKeThua;
        private DevExpress.XtraEditors.LookUpEdit ledVaiTroKeThua;
        private DevExpress.XtraEditors.SimpleButton btnMoRong;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}