using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Project._008.Models;
using Project._008.Controllers;
using Library;
using Library.UI;
using Library.UI.Form;
using Library.UI.Grid;

namespace Project._008.Views.TienIch
{
    public partial class frmGiaVatTu : DevExpress.XtraEditors.XtraForm
    {
        public frmGiaVatTu()
        {
            InitializeComponent();
        }

        private void frmGiaVatTu_Load(object sender, EventArgs e)
        {
            gridView.Config(true, false, false, true);
            gridView.AppearanceColumns(new[] { colID_kho_tt, colID_kho, colID_nhom, colID_loai, colMa_vat_tu, colTen_vat_tu });
            gridView.AppearanceColumns(new[] { colKhau_do, colTrong_luong, colDon_gia_nhap, colDon_gia_xuat }, DevExpress.Utils.HorzAlignment.Far);

            gridView.UnReadOnlyColumns(new[] { colDon_gia_nhap, colDon_gia_xuat });
            //---------------------------------------------------------
            STO_KhoCtrl.LoadDataSource(ledDiaDiem);
            STO_KhoVatTuCtrl.LoadDataSource(ledKhoVatTu);
            //-------------------------------------------------------
            STO_KhoCtrl.LoadDataSource(rleID_kho_tt);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            IForm.CloseCurrentTabPage(this.Parent);
        }

        private void ledKhoVatTu_EditValueChanged(object sender, EventArgs e)
        {
            STO_NhomVatTuCtrl.LoadDataSource(ledNhomVatTu, (int)ledKhoVatTu.EditValue);
        }

        private void ledNhomVatTu_EditValueChanged(object sender, EventArgs e)
        {
            colKhau_do.Visible = colTrong_luong.Visible = false;
            colDo_day.Visible = colDo_cao.Visible = colDo_rong.Visible = false;

            viewSTOVatTuCTBindingSource.DataSource = new List<viewSTOVatTu>();

            if (ledNhomVatTu.EditValue == null || (int)ledNhomVatTu.EditValue == 0)
            {
                ledLoaiVatTu.Properties.DataSource = new List<STO_LoaiVatTu>();
                ledLoaiVatTu.EditValue = null;

                viewSTOVatTuCTBindingSource.DataSource = new List<viewSTOVatTu>();
                return;
            }

            STO_LoaiVatTuCtrl.LoadDataSource(ledLoaiVatTu, (int)ledNhomVatTu.EditValue);

            ledLoaiVatTu.ItemIndex = 0;
        }

        private void ledLoaiVatTu_EditValueChanged(object sender, EventArgs e)
        {
            colKhau_do.Visible = colTrong_luong.Visible = false;
            colDo_day.Visible = colDo_cao.Visible = colDo_rong.Visible = false;

            if (ledLoaiVatTu.EditValue == null || (int)ledLoaiVatTu.EditValue == 0)
            {
                viewSTOVatTuCTBindingSource.DataSource = new List<viewSTOVatTu>();
                return;
            }

            STO_VatTuCtrl.LoadBindingSource(viewSTOVatTuCTBindingSource, (int)ledDiaDiem.EditValue, (int)ledLoaiVatTu.EditValue);
            gridView.BestFitColumns();

            var LoaiVatTu = STO_LoaiVatTuCtrl.GetItem((int)ledLoaiVatTu.EditValue);

            if (LoaiVatTu != null)
            {
                string[] Ma_nhom = { "NAN", "PROFILE", "LTGC", "KINH" };

                switch (LoaiVatTu.Ma_loai)
                {
                    case "NAN":
                        colKhau_do.Visible = colTrong_luong.Visible = false;
                        colDo_day.Visible = colDo_cao.Visible = false;

                        colKhau_do.VisibleIndex = 6;
                        colTrong_luong.VisibleIndex = 7;
                        colDo_day.VisibleIndex = 8;
                        colDo_cao.VisibleIndex = 9;
                        break;
                    case "PROFILE":
                    case "LTGC":
                        colKhau_do.Visible = colTrong_luong.Visible = false;

                        colKhau_do.VisibleIndex = 6;
                        colTrong_luong.VisibleIndex = 7;
                        break;
                    case "KINH":
                        colDo_cao.Visible = colDo_rong.Visible = false;

                        colDo_cao.VisibleIndex = 6;
                        colDo_rong.VisibleIndex = 7;
                        break;
                }
            }
        }
    }
}