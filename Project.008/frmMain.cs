using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using Library;
using Library.UI;
using Library.UI.Form;
using Project._008.Controllers;

namespace Project._008
{
    using HeThong = Project._008.Views.HeThong;
    using DanhMuc = Project._008.Views.DanhMuc;

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

                if (IForm.ShowDialogForm(new Project._008.Systems.frmConfig(), FormWindowState.Normal, System.Windows.Forms.FormBorderStyle.None) != System.Windows.Forms.DialogResult.OK)
                {
                    Environment.Exit(0);
                }
            }
            finally
            {
                siClient.Caption = String.Format("Máy khách: {0} - {1}", MachineInfo.CSName, MachineInfo.RegisteredUser);
                siServer.Caption = String.Format("{0}/{1}", Properties.Settings.Default.DS, Properties.Settings.Default.DB);

                siVersion.Caption = "Phiên bản: " + Application.ProductVersion;
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
            siServer.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            var result = IForm.ShowDialogForm(new Project._008.Systems.frmLogin(), FormWindowState.Normal, System.Windows.Forms.FormBorderStyle.None);

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                btnDangNhap.Enabled = false;
                btnDangXuat.Enabled = true;
                btnThongTinTaiKhoan.Enabled = true;

                if (Program.CurrentUser.Tai_khoan == "sadmin")
                {
                    siServer.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    rpgDieuKhien.Visible = true;
                    //siCountDown.Caption = string.Empty;
                }
                else
                {
                    //siCountDown.Caption = String.Format("Thời gian: {0:HH:mm:ss}", (new TimeSpan(0, 0, 5)).ToString());
                }
                /* --------- Thông tin --------- */
                siUser.Caption = "Tài khoản: " + Program.CurrentUser.Tai_khoan;

                siServer.Caption = String.Format("{0}/{1}", Properties.Settings.Default.DS, Properties.Settings.Default.DB);

                siVersion.Caption = "Phiên bản: " + Application.ProductVersion;

                //Phân quyền ứng dụng
                SYS_VaiTroQuyenCtrl.ReconfigFormControls(this);
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
            IForm.ShowDialogForm(new HeThong.frmThongTinTaiKhoan(Program.CurrentUser), FormWindowState.Normal, System.Windows.Forms.FormBorderStyle.None);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnVaiTro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabControl.CloseAllTabPage();
            IForm.ShowDialogForm(new HeThong.frmVaiTro());
        }

        private void btnPhanVaiTro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabControl.CloseAllTabPage();
            IForm.ShowDialogForm(new HeThong.frmPhanVaiTro());
        }

        private void btnDanhSachDieuKhien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabControl.CloseAllTabPage();
            IForm.OpenTabPage(tabControl, new HeThong.frmQuyen());
        }

        private void btnLoaiDieuKhien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabControl.CloseAllTabPage();
            IForm.OpenTabPage(tabControl, new HeThong.frmLoaiDieuKhien());
        }

        private void btnPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabControl.CloseAllTabPage();
            IForm.OpenTabPage(tabControl, new HeThong.frmPhanQuyen());
        }

        private void btnCaiHinhHeThong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IForm.ShowDialogForm(new Project._008.Systems.frmConfig(), FormWindowState.Normal, System.Windows.Forms.FormBorderStyle.None);

            siServer.Caption = String.Format("{0}/{1}", Properties.Settings.Default.DS, Properties.Settings.Default.DB);
        }

        private void btnDonVi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IForm.ShowDialogForm(new DanhMuc.frmDonVi(), FormWindowState.Normal, System.Windows.Forms.FormBorderStyle.Sizable);
        }

        private void btnDiaDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IForm.ShowDialogForm(new DanhMuc.frmDiaDiem(), FormWindowState.Normal, System.Windows.Forms.FormBorderStyle.Sizable);
        }

        private void btnNguoiDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabControl.CloseAllTabPage();
            IForm.OpenTabPage(tabControl, new DanhMuc.frmQuanLyNguoiDung());
        }
    }
}