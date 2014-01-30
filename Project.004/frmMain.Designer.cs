namespace Project._004
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
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.btnThongTin = new DevExpress.XtraBars.BarButtonItem();
            this.siStatus = new DevExpress.XtraBars.BarStaticItem();
            this.siInfo = new DevExpress.XtraBars.BarStaticItem();
            this.rgbiSkins = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.ribbonImageCollectionLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.HeThongRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgQuanLyNguoiDung = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgPhanQuyen = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgHeThong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.BanQuyenRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgBanQuyen = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgSkins = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.tabControl = new DevExpress.XtraTab.XtraTabControl();
            this.rpgDieuKhien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnQuanLyNguoiDung = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongTinTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnCauHinhHeThong = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhatKyHeThong = new DevExpress.XtraBars.BarButtonItem();
            this.btnVaiTro = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhanVaiTro = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhSachDieuKhien = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaiDieuKhien = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhanQuyen = new DevExpress.XtraBars.BarButtonItem();
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
            this.btnThoat,
            this.btnThongTin,
            this.siStatus,
            this.siInfo,
            this.rgbiSkins,
            this.btnQuanLyNguoiDung,
            this.btnDangNhap,
            this.btnDangXuat,
            this.btnThongTinTaiKhoan,
            this.btnCauHinhHeThong,
            this.btnNhatKyHeThong,
            this.btnVaiTro,
            this.btnPhanVaiTro,
            this.btnDanhSachDieuKhien,
            this.btnLoaiDieuKhien,
            this.btnPhanQuyen});
            this.ribbonControl.LargeImages = this.ribbonImageCollectionLarge;
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 76;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.PageHeaderItemLinks.Add(this.btnThongTin);
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.HeThongRibbonPage,
            this.BanQuyenRibbonPage});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl.ShowToolbarCustomizeItem = false;
            this.ribbonControl.Size = new System.Drawing.Size(1100, 104);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // appMenu
            // 
            this.appMenu.ItemLinks.Add(this.btnThoat);
            this.appMenu.Name = "appMenu";
            this.appMenu.Ribbon = this.ribbonControl;
            this.appMenu.ShowRightPane = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Description = "Closes this program after prompting you to save unsaved data.";
            this.btnThoat.Hint = "Closes this program after prompting you to save unsaved data";
            this.btnThoat.Id = 20;
            this.btnThoat.ImageIndex = 6;
            this.btnThoat.LargeImageIndex = 6;
            this.btnThoat.Name = "btnThoat";
            // 
            // ribbonImageCollection
            // 
            this.ribbonImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollection.ImageStream")));
            this.ribbonImageCollection.Images.SetKeyName(0, "Ribbon_New_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(1, "Ribbon_Open_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(2, "Ribbon_Close_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(3, "Ribbon_Find_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(4, "Ribbon_Save_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(5, "Ribbon_SaveAs_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(6, "Ribbon_Exit_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(7, "Ribbon_Content_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(8, "Ribbon_Info_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(9, "Ribbon_Bold_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(10, "Ribbon_Italic_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(11, "Ribbon_Underline_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(12, "Ribbon_AlignLeft_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(13, "Ribbon_AlignCenter_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(14, "Ribbon_AlignRight_16x16.png");
            // 
            // btnThongTin
            // 
            this.btnThongTin.Caption = "Thông tin";
            this.btnThongTin.Description = "Displays general program information.";
            this.btnThongTin.Hint = "Displays general program information";
            this.btnThongTin.Id = 24;
            this.btnThongTin.ImageIndex = 8;
            this.btnThongTin.LargeImageIndex = 8;
            this.btnThongTin.Name = "btnThongTin";
            // 
            // siStatus
            // 
            this.siStatus.Caption = "Some Status Info";
            this.siStatus.Id = 31;
            this.siStatus.Name = "siStatus";
            this.siStatus.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // siInfo
            // 
            this.siInfo.Caption = "Some Info";
            this.siInfo.Id = 32;
            this.siInfo.Name = "siInfo";
            this.siInfo.TextAlignment = System.Drawing.StringAlignment.Near;
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
            // ribbonImageCollectionLarge
            // 
            this.ribbonImageCollectionLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.ribbonImageCollectionLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollectionLarge.ImageStream")));
            this.ribbonImageCollectionLarge.Images.SetKeyName(0, "Ribbon_New_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(1, "Ribbon_Open_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(2, "Ribbon_Close_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(3, "Ribbon_Find_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(4, "Ribbon_Save_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(5, "Ribbon_SaveAs_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(6, "Ribbon_Exit_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(7, "Ribbon_Content_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(8, "Ribbon_Info_32x32.png");
            // 
            // HeThongRibbonPage
            // 
            this.HeThongRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgQuanLyNguoiDung,
            this.rpgPhanQuyen,
            this.rpgDieuKhien,
            this.rpgHeThong});
            this.HeThongRibbonPage.Name = "HeThongRibbonPage";
            this.HeThongRibbonPage.Text = "Hệ thống";
            // 
            // rpgQuanLyNguoiDung
            // 
            this.rpgQuanLyNguoiDung.ItemLinks.Add(this.btnQuanLyNguoiDung);
            this.rpgQuanLyNguoiDung.ItemLinks.Add(this.btnDangNhap);
            this.rpgQuanLyNguoiDung.ItemLinks.Add(this.btnDangXuat);
            this.rpgQuanLyNguoiDung.ItemLinks.Add(this.btnThongTinTaiKhoan);
            this.rpgQuanLyNguoiDung.Name = "rpgQuanLyNguoiDung";
            this.rpgQuanLyNguoiDung.ShowCaptionButton = false;
            this.rpgQuanLyNguoiDung.Text = "Quản lý người dùng";
            // 
            // rpgPhanQuyen
            // 
            this.rpgPhanQuyen.ItemLinks.Add(this.btnVaiTro);
            this.rpgPhanQuyen.ItemLinks.Add(this.btnPhanVaiTro);
            this.rpgPhanQuyen.Name = "rpgPhanQuyen";
            this.rpgPhanQuyen.ShowCaptionButton = false;
            this.rpgPhanQuyen.Text = "Phân quyền";
            // 
            // rpgHeThong
            // 
            this.rpgHeThong.ItemLinks.Add(this.btnNhatKyHeThong);
            this.rpgHeThong.ItemLinks.Add(this.btnCauHinhHeThong);
            this.rpgHeThong.ItemLinks.Add(this.btnThoat);
            this.rpgHeThong.Name = "rpgHeThong";
            this.rpgHeThong.ShowCaptionButton = false;
            this.rpgHeThong.Text = "Hệ thống";
            // 
            // BanQuyenRibbonPage
            // 
            this.BanQuyenRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgBanQuyen,
            this.rpgSkins});
            this.BanQuyenRibbonPage.Name = "BanQuyenRibbonPage";
            this.BanQuyenRibbonPage.Text = "Bản quyền";
            // 
            // rpgBanQuyen
            // 
            this.rpgBanQuyen.ItemLinks.Add(this.btnThongTin);
            this.rpgBanQuyen.Name = "rpgBanQuyen";
            this.rpgBanQuyen.ShowCaptionButton = false;
            // 
            // rpgSkins
            // 
            this.rpgSkins.ItemLinks.Add(this.rgbiSkins);
            this.rpgSkins.Name = "rpgSkins";
            this.rpgSkins.ShowCaptionButton = false;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.siStatus);
            this.ribbonStatusBar.ItemLinks.Add(this.siInfo);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 250);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1100, 27);
            // 
            // tabControl
            // 
            this.tabControl.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageAndTabControlHeader;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.HeaderButtons = DevExpress.XtraTab.TabButtons.Close;
            this.tabControl.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.WhenNeeded;
            this.tabControl.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.tabControl.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Vertical;
            this.tabControl.Location = new System.Drawing.Point(0, 104);
            this.tabControl.Name = "tabControl";
            this.tabControl.Size = new System.Drawing.Size(1100, 146);
            this.tabControl.TabIndex = 2;
            // 
            // rpgDieuKhien
            // 
            this.rpgDieuKhien.ItemLinks.Add(this.btnDanhSachDieuKhien);
            this.rpgDieuKhien.ItemLinks.Add(this.btnLoaiDieuKhien);
            this.rpgDieuKhien.ItemLinks.Add(this.btnPhanQuyen);
            this.rpgDieuKhien.Name = "rpgDieuKhien";
            this.rpgDieuKhien.ShowCaptionButton = false;
            // 
            // btnQuanLyNguoiDung
            // 
            this.btnQuanLyNguoiDung.Caption = "Quản lý người dùng";
            this.btnQuanLyNguoiDung.Id = 65;
            this.btnQuanLyNguoiDung.Name = "btnQuanLyNguoiDung";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng nhập";
            this.btnDangNhap.Id = 66;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Enabled = false;
            this.btnDangXuat.Id = 67;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnThongTinTaiKhoan
            // 
            this.btnThongTinTaiKhoan.Caption = "Thông tin tài khoản";
            this.btnThongTinTaiKhoan.Id = 68;
            this.btnThongTinTaiKhoan.Name = "btnThongTinTaiKhoan";
            // 
            // btnCauHinhHeThong
            // 
            this.btnCauHinhHeThong.Caption = "Cấu hình hệ thống";
            this.btnCauHinhHeThong.Id = 69;
            this.btnCauHinhHeThong.Name = "btnCauHinhHeThong";
            // 
            // btnNhatKyHeThong
            // 
            this.btnNhatKyHeThong.Caption = "Nhật ký hệ thống";
            this.btnNhatKyHeThong.Id = 70;
            this.btnNhatKyHeThong.Name = "btnNhatKyHeThong";
            // 
            // btnVaiTro
            // 
            this.btnVaiTro.Caption = "Vai trò";
            this.btnVaiTro.Id = 71;
            this.btnVaiTro.Name = "btnVaiTro";
            // 
            // btnPhanVaiTro
            // 
            this.btnPhanVaiTro.Caption = "Phân vai trò";
            this.btnPhanVaiTro.Id = 72;
            this.btnPhanVaiTro.Name = "btnPhanVaiTro";
            // 
            // btnDanhSachDieuKhien
            // 
            this.btnDanhSachDieuKhien.Caption = "Danh sách điều khiển";
            this.btnDanhSachDieuKhien.Id = 73;
            this.btnDanhSachDieuKhien.Name = "btnDanhSachDieuKhien";
            // 
            // btnLoaiDieuKhien
            // 
            this.btnLoaiDieuKhien.Caption = "Loại điều khiển";
            this.btnLoaiDieuKhien.Id = 74;
            this.btnLoaiDieuKhien.Name = "btnLoaiDieuKhien";
            // 
            // btnPhanQuyen
            // 
            this.btnPhanQuyen.Caption = "Phân quyền";
            this.btnPhanQuyen.Id = 75;
            this.btnPhanQuyen.Name = "btnPhanQuyen";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 277);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.ribbonControl);
            this.Controls.Add(this.ribbonStatusBar);
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
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem btnThongTin;
        private DevExpress.XtraBars.BarStaticItem siStatus;
        private DevExpress.XtraBars.BarStaticItem siInfo;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgbiSkins;
        private DevExpress.XtraBars.Ribbon.RibbonPage HeThongRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgQuanLyNguoiDung;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgPhanQuyen;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSkins;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPage BanQuyenRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgBanQuyen;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu appMenu;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.Utils.ImageCollection ribbonImageCollection;
        private DevExpress.Utils.ImageCollection ribbonImageCollectionLarge;
        private DevExpress.XtraTab.XtraTabControl tabControl;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgDieuKhien;
        private DevExpress.XtraBars.BarButtonItem btnQuanLyNguoiDung;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnThongTinTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnCauHinhHeThong;
        private DevExpress.XtraBars.BarButtonItem btnNhatKyHeThong;
        private DevExpress.XtraBars.BarButtonItem btnVaiTro;
        private DevExpress.XtraBars.BarButtonItem btnPhanVaiTro;
        private DevExpress.XtraBars.BarButtonItem btnDanhSachDieuKhien;
        private DevExpress.XtraBars.BarButtonItem btnLoaiDieuKhien;
        private DevExpress.XtraBars.BarButtonItem btnPhanQuyen;

    }
}
