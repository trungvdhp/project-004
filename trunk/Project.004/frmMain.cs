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

            btnDangNhap.PerformClick();            
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rpgDieuKhien.Visible = false;

            var result = IForm.ShowDialogForm(new Project._004.Systems.frmLogin(), FormWindowState.Normal, System.Windows.Forms.FormBorderStyle.None);

            if (result == System.Windows.Forms.DialogResult.OK)
            {

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

                btnDangNhap.PerformClick();
            }
            catch (Exception)
            {
                INotify.ShowError("Không thể đăng xuất khỏi hệ thống!", "Đăng xuất thất bại");
            }
        }
    }
}