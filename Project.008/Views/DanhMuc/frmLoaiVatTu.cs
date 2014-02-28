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
    public partial class frmLoaiVatTu : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiVatTu()
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
        private STO_LoaiVatTu _LoaiVatTu;
        public STO_LoaiVatTu LoaiVatTu
        {
            get
            {
                if (_LoaiVatTu == null) _LoaiVatTu = new STO_LoaiVatTu();

                _LoaiVatTu.ID_nhom = ucLed.lookUpEdit.EditValue == null ? 0 : (int)ucLed.lookUpEdit.EditValue;
                _LoaiVatTu.Ten_loai = txtTenLoai.Text.Trim();

                var nhom = (new Context()).STO_NhomVatTus.SingleOrDefault(w => w.ID_nhom == _LoaiVatTu.ID_nhom);
                _LoaiVatTu.Ma_loai = nhom == null ? string.Empty : nhom.Ma_nhom;
                return _LoaiVatTu;
            }
            set
            {
                _LoaiVatTu = value;

                if (value != null)
                {
                    var nhom = (new Context()).STO_NhomVatTus.SingleOrDefault(w => w.ID_nhom == _LoaiVatTu.ID_nhom);
                    ledKhoVatTu.EditValue = nhom.ID_kho;
                    ucLed.lookUpEdit.EditValue = _LoaiVatTu.ID_nhom;
                    txtTenLoai.Text = _LoaiVatTu.Ten_loai;
                }

                //Program.CurrentKind = value;
            }
        }

        private void frmKind_Load(object sender, EventArgs e)
        {
            gridView.Config(true, false, false, true);
            gridView.AppearanceColumns(new[] { colID_nhom_vat_tu, colTen_loai_vat_tu });
            //----------------------------------------------------------------------
            ucLed.lookUpEdit.EditValueChanged += lookUpEdit_EditValueChanged;
            ucLed.btnAdd.Click += (sender1, e1) =>
            {
                IForm.ShowDialogForm(new frmNhomVatTu(), FormWindowState.Normal, System.Windows.Forms.FormBorderStyle.FixedSingle);
                STO_NhomVatTuCtrl.LoadDataSource(ucLed.lookUpEdit, (int)ledKhoVatTu.EditValue);
            };
            //----------------------------------------------------------------------
            Context db = new Context();
            //var index1 = -1;
            //if (Program.CurrentKind != null && Program.CurrentKind.ID_loai != 0)
            //{
            //    Program.CurrentGroup = STO_NhomVatTuCtrl.GetItem(Program.CurrentKind.ID_nhom, db);

            //    Program.CurrentWareHouse = STO_KhoVatTuCtrl.GetItem(Program.CurrentGroup.ID_kho, db);

            //    List<STO_LoaiVatTu> entities = STO_LoaiVatTuCtrl.LoadDataSource(Program.CurrentKind.ID_nhom);
            //    var item = entities.Single(w => w.ID_nhom == Program.CurrentKind.ID_nhom && w.ID_loai == Program.CurrentKind.ID_loai);
            //    index1 = entities.IndexOf(item);
            //}
            //----------------------------------------------------------------------
            STO_KhoVatTuCtrl.LoadDataSource(ledKhoVatTu, db);
            STO_NhomVatTuCtrl.LoadDataSource(rleNhomVatTu);
            //----------------------------------------------------------------------
            //if (Program.CurrentGroup != null && Program.CurrentGroup.ID_nhom != 0)
            //{
            //    ledKhoVatTu.EditValue = Program.CurrentGroup.ID_kho;
            //    ucLed.lookUpEdit.EditValue = Program.CurrentGroup.ID_nhom;
            //}
            //if (index1 != -1)
            //{
            //    ucLed.lookUpEdit.EditValue = Program.CurrentKind.ID_nhom;
            //    gridView.FocusedRowHandle = index1;
            //}
            //----------------------------------------------------------------------
            ucAction.btnInsert.Click += btnInsert_Click;
            ucAction.btnUpdate.Click += btnUpdate_Click;
            ucAction.btnDelete.Click += btnDelete_Click;
            ucAction.btnCommit.Click += btnCommit_Click;
            ucAction.btnExit.Click += btnExit_Click;

            ArrayControls = new Control[] { txtTenLoai };
        }

        private Control[] ArrayControls;

        private void ledKhoVatTu_EditValueChanged(object sender, EventArgs e)
        {
            //if (IsAction) return;

            STO_NhomVatTuCtrl.LoadDataSource(ucLed.lookUpEdit,(int)ledKhoVatTu.EditValue);
        }

        private void lookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (IsAction) return;

            if (ucLed.lookUpEdit.EditValue == null || (int)ucLed.lookUpEdit.EditValue == 0) return;

            STO_LoaiVatTuCtrl.LoadBindingSource(sTOLoaiVatTuBindingSource, (int)ucLed.lookUpEdit.EditValue);
            gridView.BestFitColumns();
        }


        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (IsAction) return;

            LoaiVatTu = gridView.GetFocusedRow() as STO_LoaiVatTu;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.IsAction = false;

            if (ucAction.nAction == 0)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
            }
            else if (ucAction.nAction == -1)
            {
                dxErrorProvider.ClearErrors();
                gridView_FocusedRowChanged(gridView, new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs(-1, gridView.FocusedRowHandle));
                txtTenLoai.Enabled = false;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            txtTenLoai.Enabled = true;

            this.IsAction = true;

            txtTenLoai.Text = string.Empty;

            txtTenLoai.SetFocus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtTenLoai.Enabled = true;

            this.IsAction = true;

            txtTenLoai.SetFocus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridView.FocusedRowHandle < 0) return;

            if (INotify.ShowDeleteConfirm() == DialogResult.Yes)
            {
                try
                {
                    STO_LoaiVatTuCtrl.Delete(LoaiVatTu);

                    STO_LoaiVatTuCtrl.LoadBindingSource(sTOLoaiVatTuBindingSource, (int)ucLed.lookUpEdit.EditValue);
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

            if (ucAction.nAction == 1)
            {
                try
                {
                    if (!STO_LoaiVatTuCtrl.Insert(LoaiVatTu)) throw new Exception();

                    STO_LoaiVatTuCtrl.LoadBindingSource(sTOLoaiVatTuBindingSource, (int)ucLed.lookUpEdit.EditValue);
                    gridView.BestFitColumns();
                }
                catch (Exception)
                {
                    INotify.ShowInsertError();
                }
            }
            else if (ucAction.nAction == 2)
            {
                try
                {
                    if (!STO_LoaiVatTuCtrl.Update(LoaiVatTu)) throw new Exception();

                    STO_LoaiVatTuCtrl.LoadBindingSource(sTOLoaiVatTuBindingSource, (int)ucLed.lookUpEdit.EditValue);
                    gridView.BestFitColumns();
                }
                catch (Exception)
                {
                    INotify.ShowUpdateError();
                }
            }

            ucAction.btnExit.PerformClick();
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

        private void txtTenLoai_Validating(object sender, CancelEventArgs e)
        {
            if (!IsAction) return;

            if (string.IsNullOrEmpty(txtTenLoai.Text.Trim()))
                txtTenLoai.SetError(dxErrorProvider, "Chưa nhập tên loại vật tư!", ref IsValid);
            else
                dxErrorProvider.ClearErrors();
        }

        private void gridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && e.Clicks == 2)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
    }
}