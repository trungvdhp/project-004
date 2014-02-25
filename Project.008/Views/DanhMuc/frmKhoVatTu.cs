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

namespace Project._008.Views.DanhMuc
{

    public partial class frmKhoVatTu : DevExpress.XtraEditors.XtraForm
    {
        public frmKhoVatTu()
        {
            InitializeComponent();
        }

        private void frmWarehouse_Load(object sender, EventArgs e)
        {
            gridView.Config(true, false, false, true);
            gridView.AppearanceColumns(new[] { colTen_kho, colDia_diem });

            ucAction_WareHourse.btnDelete.Enabled = false;
            //----------------------------------------------------------------------
            //var index = -1;
            //if (Program.CurrentWareHouse != null && Program.CurrentWareHouse.ID_kho != 0)
            //{
            //    List<STO_KhoVatTu> entities = STO_KhoVatTuCtrl.LoadDataSource();
            //    var item = entities.Single(w => w.ID_kho == Program.CurrentWareHouse.ID_kho);
            //    index = entities.IndexOf(item);
            //}
            //----------------------------------------------------------------------
            STO_KhoVatTuCtrl.LoadBindingSource(sTOKhoVatTuBindingSource);
            gridView.BestFitColumns();

            //if (index != -1)
            //{
            //    gridView.FocusedRowHandle = index;
            //}
            //----------------------------------------------------------------------
            ucAction_WareHourse.btnInsert.Click += btnInsert_Click;
            ucAction_WareHourse.btnUpdate.Click += btnUpdate_Click;
            ucAction_WareHourse.btnDelete.Click += btnDelete_Click;
            ucAction_WareHourse.btnCommit.Click += btnCommit_Click;
            ucAction_WareHourse.btnExit.Click += btnExit_Click;

            ArrayControls = new Control[] { txtDiaDiem, txtTenKho };
        }

        private Control[] ArrayControls; 

        // Fields...
        private STO_KhoVatTu _KhoVatTu;
        public STO_KhoVatTu KhoVatTu
        {
            get 
            {
                _KhoVatTu.Ten_kho = txtTenKho.Text.Trim();
                _KhoVatTu.Dia_diem = txtDiaDiem.Text.Trim();
                return _KhoVatTu; 
            }
            set 
            { 
                _KhoVatTu = value;

                if (value != null)
                {
                    txtTenKho.Text = _KhoVatTu.Ten_kho;
                    txtDiaDiem.Text = _KhoVatTu.Dia_diem;
                }

                //Program.CurrentWareHouse = value;
            }
        }

        private bool _IsAction;
        public bool IsAction
        {
            get { return _IsAction; }
            set 
            { 
                _IsAction = value;
                gridControl.Enabled = !value;
            }
        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (IsAction) return;
            KhoVatTu = gridView.GetFocusedRow() as STO_KhoVatTu;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.IsAction = false;

            if (ucAction_WareHourse.nAction == 0)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
            }
            else if (ucAction_WareHourse.nAction == -1)
            {
                dxErrorProvider.ClearErrors();
                gridView_FocusedRowChanged(gridView, new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs(-1, gridView.FocusedRowHandle));
                txtTenKho.Enabled = txtDiaDiem.Enabled = false;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            txtTenKho.Enabled = txtDiaDiem.Enabled =  true;

            this.IsAction = true;

            txtTenKho.Text = txtDiaDiem.Text = string.Empty;

            txtTenKho.SetFocus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtTenKho.Enabled = txtDiaDiem.Enabled = true;

            this.IsAction = true;

            txtTenKho.SetFocus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Do not anything
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (!Validator(ArrayControls)) return;

            if (ucAction_WareHourse.nAction == 1)
            {
                try
                {
                    if (!STO_KhoVatTuCtrl.Insert(KhoVatTu)) throw new Exception();
                }
                catch (Exception)
                {
                    INotify.ShowInsertError();
                }
            }
            else if (ucAction_WareHourse.nAction == 2)
            {
                try
                {
                    if (!STO_KhoVatTuCtrl.Update(KhoVatTu)) throw new Exception();
                }
                catch (Exception)
                {
                    INotify.ShowUpdateError();
                }
            }

            STO_KhoVatTuCtrl.LoadBindingSource(sTOKhoVatTuBindingSource);
            gridView.BestFitColumns();

            ucAction_WareHourse.btnExit.PerformClick();
        }

        private bool IsValid;
        private bool Validator(Control[] controls = null)
        {
            IsValid = true;

            if (controls == null) return false;

            foreach (var control in controls)
            {
                control.Select();
            }

            return IsValid;
        }

        private void txtTenKho_Validating(object sender, CancelEventArgs e)
        {
            if (!IsAction) return;

            if (string.IsNullOrEmpty(txtTenKho.Text.Trim()))
                txtTenKho.SetError(dxErrorProvider, "Chưa nhập tên kho!", ref IsValid);
            else
                dxErrorProvider.ClearErrors();
        }

        private void txtDiaDiem_Validating(object sender, CancelEventArgs e)
        {
            //if (!IsAction) return;

            //if (string.IsNullOrEmpty(txtDiaDiem.Text.Trim()))
            //    txtDiaDiem.SetError(dxErrorProvider, "Chưa nhập địa điểm!", ref IsValid);
            //else
            //    dxErrorProvider.ClearErrors();
        }

        private void gridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && e.Clicks == 2)
            {
                //this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

    }
}