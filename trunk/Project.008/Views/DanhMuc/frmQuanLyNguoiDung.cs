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
using Library.UI.Form;
using Project._008.Models;
using Project._008.Controllers;
using Library.Data;

namespace Project._008.Views.DanhMuc
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
            var nguoiDung = gridView.GetFocusedRow() as SYS_NguoiDung;

            if (nguoiDung == null || nguoiDung.ID_nhan_vien == null) return;

            IForm.ShowDialogForm(new HeThong.frmThongTinTaiKhoan(nguoiDung), FormWindowState.Normal, System.Windows.Forms.FormBorderStyle.None);

            SYS_NguoiDungCtrl.LoadBindingSource(sYSNguoiDungBindingSource);
            gridView.BestFitAllColumns();
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            var nguoiDung = gridView.GetFocusedRow() as SYS_NguoiDung;

            if (nguoiDung == null || nguoiDung.ID_nhan_vien == null) return;

            try
            {
                nguoiDung.ID_trang_thai = (int)USERSTATE.LOCK;

                SYS_NguoiDungCtrl.Update(nguoiDung);

                INotify.ShowUpdateSuccess("Khóa tài khoản người dùng thành công!");
            }
            catch
            {
                INotify.ShowUpdateError("Khóa tài khoản người dùng thất bại!");
            }

            SYS_NguoiDungCtrl.LoadBindingSource(sYSNguoiDungBindingSource);
            gridView.BestFitAllColumns();
        }

        private void btnMoTaiKhoan_Click(object sender, EventArgs e)
        {
            var nguoiDung = gridView.GetFocusedRow() as SYS_NguoiDung;

            if (nguoiDung == null || nguoiDung.ID_nhan_vien == null) return;

            try
            {
                nguoiDung.ID_trang_thai = 0;

                SYS_NguoiDungCtrl.Update(nguoiDung);

                INotify.ShowUpdateSuccess("Khóa tài khoản người dùng thành công!");
            }
            catch
            {
                INotify.ShowUpdateError("Khóa tài khoản người dùng thất bại!");
            }

            SYS_NguoiDungCtrl.LoadBindingSource(sYSNguoiDungBindingSource);
            gridView.BestFitAllColumns();
        }
    }
}