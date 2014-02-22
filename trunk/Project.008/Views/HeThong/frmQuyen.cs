using System;
using System.Collections;
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
    public partial class frmQuyen : DevExpress.XtraEditors.XtraForm
    {
        public frmQuyen()
        {
            InitializeComponent();
        }

        private void frmQuyen_Load(object sender, EventArgs e)
        {
            treeListNew.Config("ID_quyen", "ID_cha");
            treeListNew.AddColumn("colTen_quyen", "Tên", "Ten_quyen");
            treeListNew.AddColumn("colMa_quyen", "Ký hiệu", "Ma_quyen");
            treeListNew.AddColumn("colLoai_dieu_khien", "Loại điều khiển", "Loai_dieu_khien");
            treeListNew.AddColumn("colTen_quyen", "Nhóm", "ID_goc");
            /*-----------------------------------------------------------------------------------*/
            treeListOld.Config("ID_quyen", "ID_cha");
            treeListOld.AddColumn("colTen_quyen", "Tên", "Ten_quyen");
            treeListOld.AddColumn("colMa_quyen", "Ký hiệu", "Ma_quyen");
            treeListOld.AddColumn("colLoai_dieu_khien", "Loại điều khiển", "Loai_dieu_khien");
            treeListOld.AddColumn("colTen_quyen", "Nhóm", "ID_goc");
            /*-----------------------------------------------------------------------------------*/
            btnLamMoi.PerformClick();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            treeListOld.BeginUpdate();
            treeListOld.DataSource = SYS_QuyenCtrl.LoadDataSource(); 
            treeListOld.RefreshDataSource();
            treeListOld.BestFitColumns();
            treeListOld.EndUpdate();

            treeListOld.ExpandAll();
        }

        private void btnQuetMa_Click(object sender, EventArgs e)
        {
            treeListNew.BeginUpdate();
            treeListNew.DataSource = SYS_QuyenCtrl.LoadSourceControls();
            treeListNew.RefreshDataSource();
            treeListNew.BestFitColumns();
            treeListNew.EndUpdate();
        }

        private void btnMoRong_Click(object sender, EventArgs e)
        {
            treeListNew.ExpandAll();
        }

        private void btnThuGon_Click(object sender, EventArgs e)
        {
            treeListNew.CollapseAll();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (treeListNew.AllNodesCount == 0) return;

            if (INotify.ShowDeleteConfirm("Bạn có chắc bạn muốn xóa các hàng đã chọn trong cây mới?") == DialogResult.Yes)
            {
                treeListNew.LockReloadNodes();

                try
                {
                    Hashtable sel = treeListNew.GetNodesForDeleting();
                    IDictionaryEnumerator nodes = sel.GetEnumerator();
                    nodes.Reset();

                    while (nodes.MoveNext())
                    {
                        treeListNew.DeleteNode((DevExpress.XtraTreeList.Nodes.TreeListNode)nodes.Value);
                    }
                }
                finally
                {
                    treeListNew.UnlockReloadNodes();
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                List<SYS_Quyen> list = (List<SYS_Quyen>)treeListNew.DataSource;

                SYS_QuyenCtrl.Insert(list);

                INotify.ShowInsertSuccess("Lưu các quyền mới thành công");
                btnLamMoi.PerformClick();
            }
            catch
            {
                INotify.ShowInsertError("Lưu các quyền mới không thành công");
            }

        }
    }
}