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

namespace Project._008.Views.HeThong
{
    public partial class frmPhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        public frmPhanQuyen()
        {
            InitializeComponent();
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            treeList.Config("ID_quyen", "ID_cha");
            treeList.AddColumn("colTen_quyen", "Tên", "Ten_quyen");
            treeList.AddColumn("colMa_quyen", "Ký hiệu", "Ma_quyen");
            treeList.AddColumn("colLoai_dieu_khien", "Loại điều khiển", "Loai_dieu_khien");
            treeList.AddColumn("colTen_quyen", "Nhóm", "ID_goc");

            grvThuocTinh.Config(true, false);
            grvThuocTinh.AppearanceColumns(new[] { colID_thuoc_tinh });
            grvThuocTinh.UnReadOnlyColumns(new[] { colGia_tri });

            Context db = new Context();

            SYS_ThuocTinhCtrl.LoadDataSource(repID_thuoc_tinh, db);
            SYS_VaiTroCtrl.LoadDataSource(ledVaiTro, db);
            SYS_VaiTroCtrl.LoadDataSource(ledVaiTroKeThua, db);
        }

        private void ledVaiTro_EditValueChanged(object sender, EventArgs e)
        {
            treeList.BeginUpdate();
            treeList.DataSource = SYS_QuyenCtrl.LoadDataSource();
            treeList.RefreshDataSource();
            treeList.BestFitColumns();
            treeList.EndUpdate();
        }

        private void treeList_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            SYS_Quyen quyen = (SYS_Quyen)treeList.GetDataRecordByNode(e.Node);

            if (quyen == null || ledVaiTro.EditValue == null) return;

            grdThuocTinh.BeginUpdate();
            grdThuocTinh.DataSource = SYS_VaiTroQuyenCtrl.LoadDataSource(ledVaiTro.EditValue, quyen);
            grdThuocTinh.RefreshDataSource();
            grdThuocTinh.EndUpdate();
        }

        private void btnLamMoiThuocTinh_Click(object sender, EventArgs e)
        {
            treeList_FocusedNodeChanged(treeList, new DevExpress.XtraTreeList.FocusedNodeChangedEventArgs(null, treeList.FocusedNode));
        }

        private void btnLuuThuocTinh_Click(object sender, EventArgs e)
        {
            var entities = grdThuocTinh.DataSource as List<SYS_VaiTroQuyen>;

            if (entities == null || ledVaiTro.EditValue == null) return;

            SYS_Quyen quyen = (SYS_Quyen)treeList.GetDataRecordByNode(treeList.FocusedNode); 
            
            if (quyen == null || ledVaiTro.EditValue == null) return;

            try
            {
                SYS_VaiTroQuyenCtrl.Insert(entities, ledVaiTro.EditValue, quyen);
            }
            catch
            {
                INotify.ShowInsertError();
            }

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ledVaiTro.EditValue = ledVaiTroKeThua.EditValue = 0;

            treeList.BeginUpdate();
            treeList.DataSource = new List<SYS_Quyen>();
            treeList.RefreshDataSource();
            treeList.BestFitColumns();
            treeList.EndUpdate();

            grdThuocTinh.BeginUpdate();
            grdThuocTinh.DataSource = new List<SYS_VaiTroQuyen>();
            grdThuocTinh.RefreshDataSource();
            grdThuocTinh.EndUpdate();
        }

        private void btnKeThua_Click(object sender, EventArgs e)
        {
            if (ledVaiTro.EditValue == null || ledVaiTroKeThua.EditValue == null || ledVaiTro.EditValue == ledVaiTroKeThua.EditValue) return;
            
            try
            {
                SYS_VaiTroQuyenCtrl.Inheritance(ledVaiTroKeThua.EditValue, ledVaiTro.EditValue);

                ledVaiTroKeThua.EditValue = 0;
                treeList_FocusedNodeChanged(treeList, new DevExpress.XtraTreeList.FocusedNodeChangedEventArgs(null, treeList.FocusedNode));
            }
            catch
            {
                INotify.ShowError("Kế thừa thất bại", "Kế thừa");
            }
        }

        private void btnChuaGanThuocTinh_Click(object sender, EventArgs e)
        {

        }

        private void btnThuGon_Click(object sender, EventArgs e)
        {

        }

        private void btnMoRong_Click(object sender, EventArgs e)
        {

        }
    }
}