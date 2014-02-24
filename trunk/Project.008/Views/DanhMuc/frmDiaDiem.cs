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
    public partial class frmDiaDiem : DevExpress.XtraEditors.XtraForm
    {
        public frmDiaDiem()
        {
            InitializeComponent();
        }

        private void frmDonVi_Load(object sender, EventArgs e)
        {
            gridView.Config(false, false, false, false, false, false, false, false, true);
            gridView.AddNewItemRow();

            gridView.AppearanceColumns(new[] { colDia_diem });

            STO_KhoCtrl.LoadBindingSource(sTOKhoBindingSource);
        }

        private void gridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (gridView.IsNewItemRow(e.RowHandle))
            {
                //InsertCommand();
                try
                {
                    var dvt = (STO_Kho)gridView.GetFocusedRow();

                    if (dvt == null) return;

                    STO_KhoCtrl.Insert(dvt);

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
                    var dvt = (STO_Kho)gridView.GetFocusedRow();

                    if (dvt == null) return;

                    STO_KhoCtrl.Update(dvt);

                    INotify.ShowUpdateSuccess();
                }
                catch
                {
                    INotify.ShowUpdateError();
                }
            }

            STO_KhoCtrl.LoadBindingSource(sTOKhoBindingSource);
        }

        private void gridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control | e.KeyCode == Keys.Delete)
            {
                try
                {
                    if (gridView.IsNewItemRow(gridView.FocusedRowHandle)) return;

                    var dvt = (STO_Kho)gridView.GetFocusedRow();

                    if (dvt == null) return;

                    STO_KhoCtrl.Delete(dvt);

                    STO_KhoCtrl.LoadBindingSource(sTOKhoBindingSource);
                }
                catch
                {
                    INotify.ShowDeleteError();
                }
            }
        }
    }
}