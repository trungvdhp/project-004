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
    public partial class frmNhomVatTu : DevExpress.XtraEditors.XtraForm
    {
        public frmNhomVatTu()
        {
            InitializeComponent();
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
        // Fields...
        private STO_NhomVatTu _NhomVatTu;
        public STO_NhomVatTu NhomVatTu
        {
            get
            {
                if (_NhomVatTu == null) _NhomVatTu = new STO_NhomVatTu();

                _NhomVatTu.ID_kho = ledKhoVatTu.EditValue == null ? 0 : (int)ledKhoVatTu.EditValue;
                _NhomVatTu.Ten_nhom = txtTenNhom.Text.Trim();
                _NhomVatTu.Ma_nhom = cmbMaVatTu.Text;
                return _NhomVatTu;
            }
            set
            {
                _NhomVatTu = value;

                if (value != null)
                {
                    ledKhoVatTu.EditValue = _NhomVatTu.ID_kho;
                    txtTenNhom.Text = _NhomVatTu.Ten_nhom;

                    cmbMaVatTu.SelectedIndex = (cmbMaVatTu.DataSource as List<string>).IndexOf(_NhomVatTu.Ma_nhom);
                }

                //Program.CurrentGroup = value;
            }
        }

        private void frmGroup_Load(object sender, EventArgs e)
        {
            gridView.Config(true, false, false, true);
            gridView.AppearanceColumns(new [] { colID_kho, colTen_nhom_vat_tu });
            //----------------------------------------------------------------------
            //var index1 = -1;
            //if (Program.CurrentGroup != null && Program.CurrentGroup.ID_nhom != 0)
            //{
            //    Program.CurrentWareHouse = STO_KhoVatTuCtrl.GetItem(Program.CurrentGroup.ID_kho);

            //    List<STO_NhomVatTu> entities = STO_NhomVatTuCtrl.LoadDataSource(Program.CurrentWareHouse.ID_kho);
            //    var item = entities.Single(w => w.ID_kho == Program.CurrentWareHouse.ID_kho && w.ID_nhom == Program.CurrentGroup.ID_nhom);
            //    index1 = entities.IndexOf(item);
            //}
            //----------------------------------------------------------------------
            STO_KhoVatTuCtrl.LoadDataSource(ledKhoVatTu);
            //if (Program.CurrentWareHouse != null && Program.CurrentWareHouse.ID_kho != 0)
            //{
            //    ledKhoVatTu.EditValue = Program.CurrentWareHouse.ID_kho;
            //}
            STO_KhoVatTuCtrl.LoadDataSource(rleKhoVatTu);
            //----------------------------------------------------------------------
            //if (index1 != -1)
            //{
            //    ledKhoVatTu.EditValue = Program.CurrentWareHouse.ID_kho;
            //    gridView.FocusedRowHandle = index1;
            //}

            //----------------------------------------------------------------------
            ucAction_Group.btnInsert.Click += btnInsert_Click;
            ucAction_Group.btnUpdate.Click += btnUpdate_Click;
            ucAction_Group.btnDelete.Click += btnDelete_Click;
            ucAction_Group.btnCommit.Click += btnCommit_Click;
            ucAction_Group.btnExit.Click += btnExit_Click;

            ArrayControls = new Control[] { txtTenNhom };
        }

        private Control[] ArrayControls;

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (IsAction) return;

            NhomVatTu = gridView.GetFocusedRow() as STO_NhomVatTu;
        }

        private void ledKhoVatTu_EditValueChanged(object sender, EventArgs e)
        {
            if (IsAction) return;

            List<string> maKhos = new List<string>();

            var kho = STO_KhoVatTuCtrl.GetItem((int)ledKhoVatTu.EditValue);

            if (kho.Ma_kho == "NLCC")
            {
                maKhos.Add(string.Empty);
                maKhos.Add("NAN");
            }
            else if (kho.Ma_kho == "NLCN")
            {
                maKhos.Add(string.Empty);
                maKhos.Add("PROFILE");
                maKhos.Add("LTGC");
            }
            else if (kho.Ma_kho == "CCDB")
            {
                maKhos.Add("CCDB");
            }
            else if (kho.Ma_kho == "KINH")
            {
                maKhos.Add("KINH");
            }
            else 
            {
                maKhos.Add(string.Empty);
            }

            cmbMaVatTu.DataSource = maKhos;
            cmbMaVatTu.SelectedIndex = 0;
            //----------------------------------------------------------------------
            STO_NhomVatTuCtrl.LoadBindingSource(sTONhomVatTuBindingSource, (int)ledKhoVatTu.EditValue);
            gridView.BestFitColumns();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.IsAction = false;

            if (ucAction_Group.nAction == 0)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
            }
            else if (ucAction_Group.nAction == -1)
            {
                dxErrorProvider.ClearErrors();
                gridView_FocusedRowChanged(gridView, new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs(-1, gridView.FocusedRowHandle));
                txtTenNhom.Enabled = cmbMaVatTu.Enabled = false;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            txtTenNhom.Enabled = cmbMaVatTu.Enabled = true;

            this.IsAction = true;

            txtTenNhom.Text = string.Empty;
            cmbMaVatTu.SelectedIndex = 0;

            txtTenNhom.SetFocus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtTenNhom.Enabled = cmbMaVatTu.Enabled = true;

            this.IsAction = true;

            txtTenNhom.SetFocus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridView.FocusedRowHandle < 0) return;

            if (INotify.ShowDeleteConfirm() == DialogResult.Yes)
            {
                try
                {
                    STO_NhomVatTuCtrl.Delete(NhomVatTu);

                    STO_NhomVatTuCtrl.LoadBindingSource(sTONhomVatTuBindingSource, (int)ledKhoVatTu.EditValue);
                    gridView.BestFitColumns();
                }
                catch
                {
                    INotify.ShowDeleteError();
                }
            }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (!Validator(ArrayControls)) return;

            if (ucAction_Group.nAction == 1)
            {
                try
                {
                    if (!STO_NhomVatTuCtrl.Insert(NhomVatTu)) throw new Exception();

                    STO_NhomVatTuCtrl.LoadBindingSource(sTONhomVatTuBindingSource, (int)ledKhoVatTu.EditValue);
                    gridView.BestFitColumns();
                }
                catch (Exception)
                {
                    INotify.ShowInsertError();
                }
            }
            else if (ucAction_Group.nAction == 2)
            {
                try
                {
                    if (!STO_NhomVatTuCtrl.Update(NhomVatTu)) throw new Exception();

                    STO_NhomVatTuCtrl.LoadBindingSource(sTONhomVatTuBindingSource, (int)ledKhoVatTu.EditValue);
                    gridView.BestFitColumns();
                }
                catch (Exception)
                {
                    INotify.ShowUpdateError();
                }
            }

            ucAction_Group.btnExit.PerformClick();
        }

        bool IsValid;
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

        private void txtTenNhom_Validating(object sender, CancelEventArgs e)
        {
            if (!IsAction) return;

            if (string.IsNullOrEmpty(txtTenNhom.Text.Trim()))
                txtTenNhom.SetError(dxErrorProvider, "Chưa nhập tên nhóm vật tư!", ref IsValid);
            else
                dxErrorProvider.ClearErrors();
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