namespace Project._008
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.appMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.ribbonImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.rgbiSkins = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.siUser = new DevExpress.XtraBars.BarStaticItem();
            this.siClient = new DevExpress.XtraBars.BarStaticItem();
            this.siServer = new DevExpress.XtraBars.BarStaticItem();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongTinTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.siVersion = new DevExpress.XtraBars.BarStaticItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnVaiTro = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhanVaiTro = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhSachDieuKhien = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaiDieuKhien = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhanQuyen = new DevExpress.XtraBars.BarButtonItem();
            this.btnCaiHinhHeThong = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonImageCollectionLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.rbgHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgQuanLyNguoiDung = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgVaiTro = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgDieuKhien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgHeThong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.helpRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.helpRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.tabControl = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ApplicationButtonDropDownControl = this.appMenu;
            this.ribbonControl.ApplicationButtonText = null;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Images = this.ribbonImageCollection;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.rgbiSkins,
            this.siUser,
            this.siClient,
            this.siServer,
            this.btnDangNhap,
            this.btnDangXuat,
            this.btnThongTinTaiKhoan,
            this.siVersion,
            this.btnThoat,
            this.btnVaiTro,
            this.btnPhanVaiTro,
            this.btnDanhSachDieuKhien,
            this.btnLoaiDieuKhien,
            this.btnPhanQuyen,
            this.btnCaiHinhHeThong});
            this.ribbonControl.LargeImages = this.ribbonImageCollectionLarge;
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 76;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.PageHeaderItemLinks.Add(this.siUser);
            this.ribbonControl.PageHeaderItemLinks.Add(this.siClient);
            this.ribbonControl.PageHeaderItemLinks.Add(this.siServer);
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbgHeThong,
            this.helpRibbonPage});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(1100, 104);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // appMenu
            // 
            this.appMenu.Name = "appMenu";
            this.appMenu.Ribbon = this.ribbonControl;
            this.appMenu.ShowRightPane = true;
            // 
            // ribbonImageCollection
            // 
            this.ribbonImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollection.ImageStream")));
            this.ribbonImageCollection.Images.SetKeyName(0, "System.Server.128.png");
            this.ribbonImageCollection.Images.SetKeyName(1, "Button.Find.16.png");
            this.ribbonImageCollection.Images.SetKeyName(2, "Button.Save.16.png");
            this.ribbonImageCollection.Images.SetKeyName(3, "System.Client.16.png");
            this.ribbonImageCollection.Images.SetKeyName(4, "System.Countdown.16.png");
            this.ribbonImageCollection.Images.SetKeyName(5, "System.Infomation.16.png");
            this.ribbonImageCollection.Images.SetKeyName(6, "System.User.16.png");
            this.ribbonImageCollection.Images.SetKeyName(7, "System.Version.16.png");
            // 
            // rgbiSkins
            // 
            this.rgbiSkins.Caption = "Skins";
            // 
            // 
            // 
            this.rgbiSkins.Gallery.AllowHoverImages = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rgbiSkins.Gallery.ColumnCount = 4;
            this.rgbiSkins.Gallery.FixedHoverImageSize = false;
            this.rgbiSkins.Gallery.ImageSize = new System.Drawing.Size(32, 17);
            this.rgbiSkins.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top;
            this.rgbiSkins.Gallery.RowCount = 4;
            this.rgbiSkins.Id = 60;
            this.rgbiSkins.Name = "rgbiSkins";
            // 
            // siUser
            // 
            this.siUser.Caption = "barStaticItem1";
            this.siUser.Id = 62;
            this.siUser.Name = "siUser";
            this.siUser.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // siClient
            // 
            this.siClient.Caption = "barStaticItem2";
            this.siClient.Id = 63;
            this.siClient.Name = "siClient";
            this.siClient.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // siServer
            // 
            this.siServer.Caption = "Server";
            this.siServer.Id = 64;
            this.siServer.ImageIndex = 0;
            this.siServer.Name = "siServer";
            this.siServer.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng nhập";
            this.btnDangNhap.Id = 65;
            this.btnDangNhap.LargeImageIndex = 9;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Id = 66;
            this.btnDangXuat.LargeImageIndex = 10;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnThongTinTaiKhoan
            // 
            this.btnThongTinTaiKhoan.Caption = "Thông tin tài khoản";
            this.btnThongTinTaiKhoan.Id = 67;
            this.btnThongTinTaiKhoan.LargeImageIndex = 13;
            this.btnThongTinTaiKhoan.Name = "btnThongTinTaiKhoan";
            this.btnThongTinTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThongTinTaiKhoan_ItemClick);
            // 
            // siVersion
            // 
            this.siVersion.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.siVersion.Caption = "barStaticItem1";
            this.siVersion.Id = 68;
            this.siVersion.Name = "siVersion";
            this.siVersion.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 69;
            this.btnThoat.LargeImageIndex = 19;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // btnVaiTro
            // 
            this.btnVaiTro.Caption = "Vai trò";
            this.btnVaiTro.Id = 70;
            this.btnVaiTro.LargeImageIndex = 18;
            this.btnVaiTro.Name = "btnVaiTro";
            this.btnVaiTro.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVaiTro_ItemClick);
            // 
            // btnPhanVaiTro
            // 
            this.btnPhanVaiTro.Caption = "Phân vai trò";
            this.btnPhanVaiTro.Id = 71;
            this.btnPhanVaiTro.LargeImageIndex = 17;
            this.btnPhanVaiTro.Name = "btnPhanVaiTro";
            this.btnPhanVaiTro.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhanVaiTro_ItemClick);
            // 
            // btnDanhSachDieuKhien
            // 
            this.btnDanhSachDieuKhien.Caption = "Danh sách điều khiển";
            this.btnDanhSachDieuKhien.Id = 72;
            this.btnDanhSachDieuKhien.LargeImageIndex = 4;
            this.btnDanhSachDieuKhien.Name = "btnDanhSachDieuKhien";
            this.btnDanhSachDieuKhien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanhSachDieuKhien_ItemClick);
            // 
            // btnLoaiDieuKhien
            // 
            this.btnLoaiDieuKhien.Caption = "Loại điều khiển";
            this.btnLoaiDieuKhien.Id = 73;
            this.btnLoaiDieuKhien.LargeImageIndex = 14;
            this.btnLoaiDieuKhien.Name = "btnLoaiDieuKhien";
            this.btnLoaiDieuKhien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoaiDieuKhien_ItemClick);
            // 
            // btnPhanQuyen
            // 
            this.btnPhanQuyen.Caption = "Phân quyền";
            this.btnPhanQuyen.Id = 74;
            this.btnPhanQuyen.LargeImageIndex = 15;
            this.btnPhanQuyen.Name = "btnPhanQuyen";
            this.btnPhanQuyen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhanQuyen_ItemClick);
            // 
            // btnCaiHinhHeThong
            // 
            this.btnCaiHinhHeThong.Caption = "Cấu hình hệ thống";
            this.btnCaiHinhHeThong.Id = 75;
            this.btnCaiHinhHeThong.LargeImageIndex = 3;
            this.btnCaiHinhHeThong.Name = "btnCaiHinhHeThong";
            this.btnCaiHinhHeThong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCaiHinhHeThong_ItemClick);
            // 
            // ribbonImageCollectionLarge
            // 
            this.ribbonImageCollectionLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.ribbonImageCollectionLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollectionLarge.ImageStream")));
            this.ribbonImageCollectionLarge.Images.SetKeyName(0, "Project.Blank.32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(1, "Project.ThongTin.32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(2, "System.CloudRefresh.32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(3, "System.Config.32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(4, "System.Controls.32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(5, "System.Dairy.32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(6, "System.Group.32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(7, "System.Infomation.32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(8, "System.Kind.32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(9, "System.Login.32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(10, "System.Logout.32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(11, "System.Personal.32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(12, "System.Product.32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(13, "System.Profile.32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(14, "System.Properties.32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(15, "System.PropertiesManagement.32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(16, "System.Provider.32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(17, "System.Role.32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(18, "System.RoleManagement.32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(19, "System.TurnOff.32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(20, "System.UserManagement.32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(21, "System.Ware.32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(22, "System.Warehouse.32.png");
            // 
            // rbgHeThong
            // 
            this.rbgHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgQuanLyNguoiDung,
            this.rpgVaiTro,
            this.rpgDieuKhien,
            this.rpgHeThong});
            this.rbgHeThong.Name = "rbgHeThong";
            this.rbgHeThong.Text = "Hệ thống";
            // 
            // rpgQuanLyNguoiDung
            // 
            this.rpgQuanLyNguoiDung.ItemLinks.Add(this.btnDangNhap);
            this.rpgQuanLyNguoiDung.ItemLinks.Add(this.btnDangXuat);
            this.rpgQuanLyNguoiDung.ItemLinks.Add(this.btnThongTinTaiKhoan);
            this.rpgQuanLyNguoiDung.ItemLinks.Add(this.btnThoat);
            this.rpgQuanLyNguoiDung.Name = "rpgQuanLyNguoiDung";
            this.rpgQuanLyNguoiDung.ShowCaptionButton = false;
            this.rpgQuanLyNguoiDung.Text = "Quản lý người dùng";
            // 
            // rpgVaiTro
            // 
            this.rpgVaiTro.ItemLinks.Add(this.btnVaiTro);
            this.rpgVaiTro.ItemLinks.Add(this.btnPhanVaiTro);
            this.rpgVaiTro.Name = "rpgVaiTro";
            this.rpgVaiTro.ShowCaptionButton = false;
            this.rpgVaiTro.Text = "Phân quyền";
            // 
            // rpgDieuKhien
            // 
            this.rpgDieuKhien.ItemLinks.Add(this.btnDanhSachDieuKhien);
            this.rpgDieuKhien.ItemLinks.Add(this.btnLoaiDieuKhien);
            this.rpgDieuKhien.ItemLinks.Add(this.btnPhanQuyen);
            this.rpgDieuKhien.Name = "rpgDieuKhien";
            this.rpgDieuKhien.ShowCaptionButton = false;
            // 
            // rpgHeThong
            // 
            this.rpgHeThong.ItemLinks.Add(this.btnCaiHinhHeThong);
            this.rpgHeThong.Name = "rpgHeThong";
            this.rpgHeThong.ShowCaptionButton = false;
            this.rpgHeThong.Text = "Hệ thống";
            // 
            // helpRibbonPage
            // 
            this.helpRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.helpRibbonPageGroup});
            this.helpRibbonPage.Name = "helpRibbonPage";
            this.helpRibbonPage.Text = "Help";
            // 
            // helpRibbonPageGroup
            // 
            this.helpRibbonPageGroup.ItemLinks.Add(this.rgbiSkins);
            this.helpRibbonPageGroup.Name = "helpRibbonPageGroup";
            this.helpRibbonPageGroup.Text = "Help";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.siVersion);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 248);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1100, 27);
            // 
            // tabControl
            // 
            this.tabControl.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageAndTabControlHeader;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.HeaderButtons = DevExpress.XtraTab.TabButtons.Close;
            this.tabControl.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.Always;
            this.tabControl.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.tabControl.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Vertical;
            this.tabControl.Location = new System.Drawing.Point(0, 104);
            this.tabControl.Name = "tabControl";
            this.tabControl.Size = new System.Drawing.Size(1100, 144);
            this.tabControl.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 275);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.ribbonControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM QUẢN LÝ KHO - CÔNG TY TNHH ĐỒNG LỰC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgbiSkins;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbgHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgQuanLyNguoiDung;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgVaiTro;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgDieuKhien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPage helpRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup helpRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu appMenu;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.Utils.ImageCollection ribbonImageCollection;
        private DevExpress.Utils.ImageCollection ribbonImageCollectionLarge;
        private DevExpress.XtraBars.BarStaticItem siUser;
        private DevExpress.XtraBars.BarStaticItem siClient;
        private DevExpress.XtraBars.BarStaticItem siServer;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnThongTinTaiKhoan;
        private DevExpress.XtraTab.XtraTabControl tabControl;
        private DevExpress.XtraBars.BarStaticItem siVersion;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem btnVaiTro;
        private DevExpress.XtraBars.BarButtonItem btnPhanVaiTro;
        private DevExpress.XtraBars.BarButtonItem btnDanhSachDieuKhien;
        private DevExpress.XtraBars.BarButtonItem btnLoaiDieuKhien;
        private DevExpress.XtraBars.BarButtonItem btnPhanQuyen;
        private DevExpress.XtraBars.BarButtonItem btnCaiHinhHeThong;

    }
}
