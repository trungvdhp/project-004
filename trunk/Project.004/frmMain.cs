using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Helpers;
using Library;
using Library.UI;
using Library.UI.Form;


namespace Project._004
{
    using Project._004.Controllers;

    public partial class frmMain : XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
            SkinHelper.InitSkinGallery(rgbiSkins, true);

            try
            {
                Program.ConnectionString = DbHelper.GetConnectionString();

                Context db = new Context();
                db.ExecuteQuery<string>(String.Format(DbHelper.FORMATGETTABLES, Properties.Settings.Default.DB));
            }
            catch (Exception)
            {
                INotify.ShowWarning("Không thể mở kết nối đến máy chủ.", "Kết nối máy chủ thất bại");

                if (IForm.ShowDialogForm(new Project._004.Systems.frmConfig(), FormWindowState.Normal, System.Windows.Forms.FormBorderStyle.None) != System.Windows.Forms.DialogResult.OK)
                {
                    Environment.Exit(0);
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            #region this.FormClosing += (sender1, e1)
            this.FormClosing += (sender1, e1) =>
                {
                    var result = XtraMessageBox.Show("Bạn chắc chắn thoát chương trình ?", "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        try
                        {
                            SYS_NguoiDungCtrl.LogOut();
                        }
                        catch (Exception)
                        {
                            //e1.Cancel = true;
                        }
                        finally
                        {
                            try
                            {
                                Environment.Exit(0);
                            }
                            catch
                            {
                                Application.ExitThread();
                            }
                        }
                    }
                    else
                    {
                        e1.Cancel = true;
                    }
                };
            #endregion

            #region this.KeyDown += (sender2, e2)
            this.KeyDown += (sender2, e2) =>
                {
                    if (e2.KeyCode == Keys.F4 && e2.Alt)
                    {
                        e2.Handled = true;
                        this.Close();
                    }
                };
            #endregion

            btnDangNhap.PerformClick();            
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rpgDieuKhien.Visible = false;

            var result = IForm.ShowDialogForm(new Project._004.Systems.frmLogin(), FormWindowState.Normal, System.Windows.Forms.FormBorderStyle.None);

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                btnDangNhap.Enabled = false;
                btnDangXuat.Enabled = true;
                btnThongTinTaiKhoan.Enabled = true;

                if (Program.CurrentUser.ID_nhan_vien == null)
                {
                    siCountDown.Caption = Program.CurrentUser.Ten_day_du;

                    if (Program.CurrentUser.Tai_khoan == "sadmin")
                    {
                        rpgPhanQuyen.Visible = true;
                    }
                }
                else
                {
                    //siInfo.Caption = String.Format("{0} : {1}", CAT_NhanVienCtrl.GetPhongBan(Program.CurrentUser.ID_nhan_vien.Value), Program.CurrentUser.Ten_day_du);
                }

                /* --------- Thông tin --------- */
                siUser.Caption = "Tài khoản: " + Program.CurrentUser.Tai_khoan;
                siClient.Caption = String.Format("Máy khách: {0} - {1}", MachineInfo.CSName, MachineInfo.RegisteredUser);
                siVersion.Caption = "Phiên bản: " + Application.ProductVersion;

                //siCountDown.Caption = String.Format("Thời gian: {0:HH:mm:ss}", new TimeSpan(0, 0, 5));
            }
            else
            {
                try
                {
                    Environment.Exit(0);
                }
                catch (Exception)
                {
                    Application.ExitThread();
                }
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SYS_NguoiDungCtrl.LogOut();

                Program.CurrentUser = null;

                IForm.CloseAllTabPage(tabControl);
                INotify.ShowInfo("Đăng xuất thành công khỏi hệ thống!", "Đăng xuất thành công");

                btnDangNhap.Enabled = true;
                btnDangXuat.Enabled = false;
                btnThongTinTaiKhoan.Enabled = false;

                btnDangNhap.PerformClick();
            }
            catch (Exception)
            {
                INotify.ShowError("Không thể đăng xuất khỏi hệ thống!", "Đăng xuất thất bại");
            }
        }

        private void btnThongTinTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnQuanLyNguoiDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnNhatKyHeThong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnCauHinhHeThong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (IForm.ShowDialogForm(new Project._004.Systems.frmConfig(), FormWindowState.Normal, System.Windows.Forms.FormBorderStyle.None) == System.Windows.Forms.DialogResult.OK)
            {
                btnDangXuat.PerformClick();
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnDanhSachDieuKhien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnLoaiDieuKhien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnVaiTro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnPhanVaiTro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnKhoVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnNhomVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnLoaiVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnNhaCungCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}