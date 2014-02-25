using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project._008.Models;
using Project._008.Controllers;
using Library;
using Library.UI;
using Library.UI.Form;
using Library.UI.Grid;

namespace Project._008.Views.HeThong
{
    public partial class frmPhanVaiTro : DevExpress.XtraEditors.XtraForm
    {
        public frmPhanVaiTro()
        {
            InitializeComponent();
        }

        private void frmPhanVaiTro_Load(object sender, EventArgs e)
        {
            grvVaiTro.Config(true);
            grvVaiTro.Config2(DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            grvVaiTro.AppearanceColumns(new[] { colTen_vai_tro, colMo_ta });

            grvNguoiDung.Config(true);
            grvNguoiDung.Config2(DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            grvNguoiDung.AppearanceColumns(new[] { colTai_khoan, colTen_day_du });
            grvNguoiDung.DisplayFormatColumn(colNgay_sinh, "dd/MM/yyyy", DevExpress.Utils.FormatType.DateTime);

            grdVaiTro.BeginUpdate();
            grdVaiTro.DataSource = SYS_VaiTroCtrl.LoadDataSource();
            grdVaiTro.RefreshDataSource();
            grdVaiTro.EndUpdate();
            grvVaiTro.BestFitAllColumns();

            CAT_PhongBanCtrl.LoadDataSource(repID_phong);
        }

        private void grvVaiTro_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var vaiTro = grvVaiTro.GetFocusedRow() as SYS_VaiTro;

            CAT_NhanVienCtrl.LoadBindingSource(eXTNhanVienBindingSource, vaiTro);
            grvNguoiDung.BestFitAllColumns();
        }

        private void grvNguoiDung_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                var state = (bool)grvNguoiDung.GetFocusedRowCellValue(colTrang_thai);

                grvNguoiDung.SetFocusedRowCellValue(colTrang_thai, !state);
            }
        }

        private void grvNguoiDung_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colTrang_thai)
            {
                var entity = grvNguoiDung.GetFocusedRow() as EXT_NguoiDung;
                var vaiTro = grvVaiTro.GetFocusedRow() as SYS_VaiTro;

                SYS_NguoiDungCtrl.Update(vaiTro, entity);
            }
        }
    }
}
