using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Library;
using Library.UI;
using Library.UI.Grid;
using Project._004.Controllers;

namespace Project._004.Views.DanhMuc
{
    public partial class frmQuanLyNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        public frmQuanLyNguoiDung()
        {
            InitializeComponent();
        }

        private void frmQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            gridView.Config(true, false, false, true);
            gridView.Config2(DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            gridView.AppearanceColumns(new[] { colTai_khoan, colTen_day_du, colID_nhan_vien, colMay_tram });

            gridView.DisplayFormatColumn(colLan_dang_nhap_cuoi, "dd/MM/yyyy", DevExpress.Utils.FormatType.DateTime);
            //-----------------------------------------------------------------------------------------------
            CAT_NhanVienCtrl.LoadDataSource(rleID_nhan_vien);

            //-----------------------------------------------------------------------------------------------
            SYS_NguoiDungCtrl.LoadBindingSource(sYSNguoiDungBindingSource);
            gridView.BestFitAllColumns();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            IForm.CloseCurrentTabPage(this.Parent);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            IForm.ShowDialogForm(new frmQuanLyNguoiDung_TaoTaiKhoan(), FormWindowState.Normal, System.Windows.Forms.FormBorderStyle.None);
            SYS_NguoiDungCtrl.LoadBindingSource(sYSNguoiDungBindingSource);
            gridView.BestFitAllColumns();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {

        }

        private void btnMoTaiKhoan_Click(object sender, EventArgs e)
        {

        }
    }
}