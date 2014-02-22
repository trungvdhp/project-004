using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Project._008.Models;
using Project._008.Controllers;
using Library;
using Library.UI;
using Library.UI.Form;
using Library.UI.Grid;

namespace Project._008.Views.HeThong
{
    public partial class frmLoaiDieuKhien : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiDieuKhien()
        {
            InitializeComponent();
        }

        private void frmLoaiDieuKhien_Load(object sender, EventArgs e)
        {
            gridView.Config(true);
            gridView.GroupColumns(new[] { gridColumn1 }, true);

            grvLoaiDieuKhien.Config(false, false, false, true);
            grvLoaiDieuKhien.AddNewItemRow();

            grvThuocTinh.Config(false, false, false, true);
            grvThuocTinh.AddNewItemRow();

            SYS_LoaiDieuKhienThuocTinhCtrl.LoadBindingSourceView(viewLoaiDieuKhienThuocTinhBindingSource);
            gridView.BestFitAllColumns();

            SYS_LoaiDieuKhienCtrl.LoadBindingSource(sYSLoaiDieuKhienBindingSource);

            SYS_ThuocTinhCtrl.LoadBindingSource(sYSThuocTinhBindingSource);
        }

        private void grvLoaiDieuKhien_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            bool bError = false;

            var Ky_hieu = grvLoaiDieuKhien.GetRowCellValue(e.RowHandle, colKy_hieu_LDK);

            if (Ky_hieu == null || Ky_hieu.ToString() == string.Empty)
            {
                bError = true;
                grvLoaiDieuKhien.SetColumnError(colKy_hieu_LDK, INotify.InforNotifyHelper.NullOrEmpty);
            }

            var Ten_loai = grvLoaiDieuKhien.GetRowCellValue(e.RowHandle, colTen_loai_LDK);

            if (Ten_loai == null || Ten_loai.ToString() == string.Empty)
            {
                bError = true;
                grvLoaiDieuKhien.SetColumnError(colTen_loai_LDK, INotify.InforNotifyHelper.NullOrEmpty);
            }

            if (bError)
            {
                e.Valid = false;
                return;
            }

            if (grvLoaiDieuKhien.IsNewItemRow(e.RowHandle))
            {
                //InsertCommand();
                try
                {
                    var ldk = (SYS_LoaiDieuKhien)grvLoaiDieuKhien.GetFocusedRow();

                    if (ldk == null) return;

                    SYS_LoaiDieuKhienCtrl.Insert(ldk);
                }
                catch
                {
                    INotify.ShowInsertError();
                }
            }
            else
            {
                //UpdateCommand();
                try
                {
                    var ldk = (SYS_LoaiDieuKhien)grvLoaiDieuKhien.GetFocusedRow();

                    if (ldk == null) return;

                    SYS_LoaiDieuKhienCtrl.Update(ldk);
                }
                catch
                {
                    INotify.ShowUpdateError();
                }
            }
        }

        private void grvThuocTinh_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            bool bError = false;

            var Ky_hieu = grvThuocTinh.GetRowCellValue(e.RowHandle, colKy_hieu_LTT);

            if (Ky_hieu == null || Ky_hieu.ToString() == string.Empty)
            {
                bError = true;
                grvThuocTinh.SetColumnError(colKy_hieu_LTT, INotify.InforNotifyHelper.NullOrEmpty);
            }

            var Ten_thuoc_tinh = grvThuocTinh.GetRowCellValue(e.RowHandle, colTen_thuoc_tinh_LTT);

            if (Ten_thuoc_tinh == null || Ten_thuoc_tinh.ToString() == string.Empty)
            {
                bError = true;
                grvThuocTinh.SetColumnError(colTen_thuoc_tinh_LTT, INotify.InforNotifyHelper.NullOrEmpty);
            }

            var Loai_gia_tri = grvThuocTinh.GetRowCellValue(e.RowHandle, colLoai_gia_tri_LTT);

            if (Loai_gia_tri == null || Loai_gia_tri.ToString() == string.Empty)
            {
                bError = true;
                grvThuocTinh.SetColumnError(colLoai_gia_tri_LTT, INotify.InforNotifyHelper.NullOrEmpty);
            }

            if (bError)
            {
                e.Valid = false;
                return;
            }

            if (grvThuocTinh.IsNewItemRow(e.RowHandle))
            {
                //InsertCommand();
                try
                {
                    var ltt = (SYS_ThuocTinh)grvThuocTinh.GetFocusedRow();

                    if (ltt == null) return;

                    SYS_ThuocTinhCtrl.Insert(ltt);
                }
                catch
                {
                    INotify.ShowInsertError();
                }
            }
            else
            {
                //UpdateCommand();
                try
                {
                    var ltt = (SYS_ThuocTinh)grvThuocTinh.GetFocusedRow();

                    if (ltt == null) return;

                    SYS_ThuocTinhCtrl.Update(ltt);
                }
                catch
                {
                    INotify.ShowUpdateError();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            (this.Parent).CloseCurrentTabPage();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (grvLoaiDieuKhien.IsNewItemRow(grvThuocTinh.FocusedRowHandle) || grvThuocTinh.IsNewItemRow(grvThuocTinh.FocusedRowHandle)) return;

                var ldt = (SYS_LoaiDieuKhien)grvLoaiDieuKhien.GetFocusedRow();
                var ltt = (SYS_ThuocTinh)grvThuocTinh.GetFocusedRow();

                SYS_LoaiDieuKhienThuocTinhCtrl.Insert(ldt, ltt);
                SYS_LoaiDieuKhienThuocTinhCtrl.LoadBindingSourceView(viewLoaiDieuKhienThuocTinhBindingSource);
                gridView.BestFitAllColumns();
            }
            catch
            {
                INotify.ShowInsertError();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gridView.IsGroupRow(gridView.FocusedRowHandle)) return;

            var entity = gridView.GetFocusedRow() as viewLoaiDieuKhien_ThuocTinh;

            if (entity == null) return;

            if (INotify.ShowDeleteConfirm() == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    SYS_LoaiDieuKhienThuocTinhCtrl.Delete(entity);
                    SYS_LoaiDieuKhienThuocTinhCtrl.LoadBindingSourceView(viewLoaiDieuKhienThuocTinhBindingSource);
                    gridView.BestFitAllColumns();
                }
                catch
                {
                    INotify.ShowDeleteError();
                }
            }
        }

        private void tsmValue1_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnThoat.Enabled = btnXoa.Enabled = false;

            tsmValue12.Enabled = true;

            //Load Controls
            sYSLoaiDieuKhienBindingSource.DataSource = SYS_QuyenCtrl.LoadCollectionControls();
        }

        private void tsmValue4_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnThoat.Enabled = btnXoa.Enabled = false;

            tsmValue25.Enabled = tsmValue27.Enabled = true;

            tsmValue18.Enabled = tsmValue28.Enabled = false;

            var ldt = (SYS_LoaiDieuKhien)grvLoaiDieuKhien.GetFocusedRow();

            if (ldt == null) return;

            //Load Properties
            sYSThuocTinhBindingSource.DataSource = SYS_QuyenCtrl.LoadCollectionProperties(ldt.Ky_hieu);
        }

        private void tsmValue3_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnThoat.Enabled = btnXoa.Enabled = true;

            tsmValue12.Enabled = false;

            //Refreh Controls
            SYS_LoaiDieuKhienCtrl.LoadBindingSource(sYSLoaiDieuKhienBindingSource);
        }

        private void tsmValue6_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnThoat.Enabled = btnXoa.Enabled = true;
            tsmValue25.Enabled = tsmValue27.Enabled = false;

            tsmValue18.Enabled = tsmValue28.Enabled = true;

            //Refreh Properties
            SYS_ThuocTinhCtrl.LoadBindingSource(sYSThuocTinhBindingSource);

        }

        private void tsmValue2_Click(object sender, EventArgs e)
        {
            //Save Controls
            var loadDieuKhiens = sYSLoaiDieuKhienBindingSource.DataSource as List<SYS_LoaiDieuKhien>;
            SYS_LoaiDieuKhienCtrl.Insert(loadDieuKhiens);

            tsmValue13.PerformClick();
            SYS_LoaiDieuKhienThuocTinhCtrl.LoadBindingSourceView(viewLoaiDieuKhienThuocTinhBindingSource);
            gridView.BestFitAllColumns();
        }

        private void tsmValue5_Click(object sender, EventArgs e)
        {
            //Save Properties
            var thuocTinhs = sYSThuocTinhBindingSource.DataSource as List<SYS_ThuocTinh>;

            SYS_ThuocTinhCtrl.Insert(thuocTinhs);

            tsmValue26.PerformClick();
            SYS_LoaiDieuKhienThuocTinhCtrl.LoadBindingSourceView(viewLoaiDieuKhienThuocTinhBindingSource);
            gridView.BestFitAllColumns();
        }

        private void tsmValue7_Click(object sender, EventArgs e)
        {
            //Delete Properties
            var ltt = (SYS_ThuocTinh)grvThuocTinh.GetFocusedRow();
            if (ltt == null) return;

            sYSThuocTinhBindingSource.Remove(ltt);
        }

        private void tsmValue8_Click(object sender, EventArgs e)
        {
            //Delete Properties

            var thuocTinhOlds = sYSThuocTinhBindingSource.DataSource as List<SYS_ThuocTinh>;

            var ldt = (SYS_LoaiDieuKhien)grvLoaiDieuKhien.GetFocusedRow();
            if (ldt == null) return;

            var thuocTinhNews = SYS_QuyenCtrl.LoadCollectionProperties(ldt.Ky_hieu);

            //Load Controls
            sYSThuocTinhBindingSource.DataSource = SYS_ThuocTinhCtrl.LoadCollectionProperties(thuocTinhOlds, thuocTinhNews);
        }
    }
}