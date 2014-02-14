using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library;
using Library.UI;
using Library.UI.Form;
using Project._004.Controllers;

namespace Project._004.Views.DanhMuc
{
    public partial class frmQuanLyNguoiDung_TaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public frmQuanLyNguoiDung_TaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Abort;
        }

        private void frmQuanLyNguoiDung_TaoTaiKhoan_Load(object sender, EventArgs e)
        {
            SYS_VaiTroCtrl.LoadDataSource(ledVaiTro);
            //-------------------------------------------------------------
            txtTenDangNhap.SetFocus();

        }

        private void ledVaiTro_EditValueChanged(object sender, EventArgs e)
        {
            if (ledVaiTro.EditValue != null && (int)ledVaiTro.EditValue == 0)
            {
                ledNhanVien.Enabled = false;
                ledNhanVien.EditValue = null;
            }
            else
            {
                ledNhanVien.Enabled = true;
            }
        }

        private void ledNhanVien_EditValueChanged(object sender, EventArgs e)
        {
            txtTenDayDu.Enabled = ledNhanVien.EditValue == null ? false : true;

            if (ledNhanVien.EditValue == null)
            {
                txtTenDayDu.Text = string.Empty;
                txtTenDayDu.SetFocus();
            }
            else
            {
                var nv = CAT_NhanVienCtrl.GetItem((int)ledNhanVien.EditValue);
                txtTenDayDu.Text = string.Format("{0} {1}", nv.Ho_dem, nv.Ten);
            }
        }
    }
}
