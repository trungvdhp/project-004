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

namespace Project._008.Views.DanhMuc
{
    public partial class frmDonVi : DevExpress.XtraEditors.XtraForm
    {
        public frmDonVi()
        {
            InitializeComponent();
        }

        private void frmDonVi_Load(object sender, EventArgs e)
        {
            gridView.Config(false, false, false, false, false, false, false, false, true);
            gridView.AddNewItemRow();

            gridView.AppearanceColumns(new[] { colTen_don_vi });

            STO_DonViTinhCtrl.LoadBindingSource(sTODonViTinhBindingSource);
        }

        private void gridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (gridView.IsNewItemRow(e.RowHandle))
            {
                //InsertCommand();
                try
                {
                    var dvt = (STO_DonViTinh)gridView.GetFocusedRow();

                    if (dvt == null) return;

                    STO_DonViTinhCtrl.Insert(dvt);

                    INotify.ShowInsertSuccess();
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
                    var dvt = (STO_DonViTinh)gridView.GetFocusedRow();

                    if (dvt == null) return;

                    STO_DonViTinhCtrl.Update(dvt);

                    INotify.ShowUpdateSuccess();
                }
                catch
                {
                    INotify.ShowUpdateError();
                }
            }
            STO_DonViTinhCtrl.LoadBindingSource(sTODonViTinhBindingSource);
        }

        private void gridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control | e.KeyCode == Keys.Delete)
            {
                try
                {
                    if (gridView.IsNewItemRow(gridView.FocusedRowHandle)) return;

                    var dvt = (STO_DonViTinh)gridView.GetFocusedRow();

                    if (dvt == null) return;

                    STO_DonViTinhCtrl.Delete(dvt);
                }
                catch
                {
                    INotify.ShowDeleteError();
                }
                STO_DonViTinhCtrl.LoadBindingSource(sTODonViTinhBindingSource);
            }
        }
    }
}