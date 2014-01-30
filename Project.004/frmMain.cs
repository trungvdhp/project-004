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


namespace Project._004
{
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
            IForm.ShowDialogForm(new Project._004.Systems.frmLogin(), FormWindowState.Normal, System.Windows.Forms.FormBorderStyle.None);
        }
    }
}