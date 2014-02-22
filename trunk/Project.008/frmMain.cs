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


namespace Project._008
{
    public partial class frmMain : XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
            SkinHelper.InitSkinGallery(rgbiSkins, true);

        }
    }
}