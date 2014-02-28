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
    public partial class frmVatTu1 : DevExpress.XtraEditors.XtraForm
    {
        public frmVatTu1()
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
        private viewSTOVatTu _VatTu;
        public viewSTOVatTu VatTu
        {
            get
            {
                if (_VatTu == null) _VatTu = new viewSTOVatTu();
                _VatTu.ID_loai = ucLedLoaiVatTu.lookUpEdit.EditValue == null ? 0 : (int)ucLedLoaiVatTu.lookUpEdit.EditValue;
                _VatTu.Ma_vat_tu = txtMaVatTu.Text.Trim();
                _VatTu.Ten_vat_tu = txtVatTu.Text.Trim();

                _VatTu.ID_don_vi = ledDonVi.EditValue == null ? (int?)null : (int)ledDonVi.EditValue;

                _VatTu.Khau_do = sedKhauDo.Value == 0 ? (decimal?)null : decimal.Parse(sedKhauDo.Value.ToString());
                _VatTu.Trong_luong = sedKhoiLuong.Value == 0 ? (decimal?)null : decimal.Parse(sedKhoiLuong.Value.ToString());

                _VatTu.Do_day = sedDoDay.Value == 0 ? (decimal?)null : decimal.Parse(sedDoDay.Value.ToString());
                _VatTu.Do_cao = sedDoCao.Value == 0 ? (decimal?)null : decimal.Parse(sedDoCao.Value.ToString());
                _VatTu.Do_rong = sedDoRong.Value == 0 ? (decimal?)null : decimal.Parse(sedDoRong.Value.ToString());

                return _VatTu;
            }
            set
            {
                _VatTu = value;

                if (value != null)
                {
                    ledKhoVatTu.EditValue = _VatTu.ID_kho;
                    ucLedNhomVatTu.lookUpEdit.EditValue = _VatTu.ID_nhom;
                    ucLedLoaiVatTu.lookUpEdit.EditValue = _VatTu.ID_loai;
                    txtMaVatTu.Text = _VatTu == null || _VatTu.Ma_vat_tu == null ? string.Empty : _VatTu.Ma_vat_tu;
                    txtVatTu.Text = _VatTu == null || _VatTu.Ten_vat_tu == null ? string.Empty : _VatTu.Ten_vat_tu;

                    ledDonVi.EditValue = _VatTu == null || _VatTu.ID_don_vi == null ? 0 : _VatTu.ID_don_vi;

                    sedKhauDo.Value = decimal.Parse(_VatTu == null || _VatTu.Khau_do == null ? "0" : _VatTu.Khau_do.ToString());
                    sedKhoiLuong.Value = decimal.Parse(_VatTu == null || _VatTu.Trong_luong == null ? "0" : _VatTu.Trong_luong.ToString());

                    sedDoDay.Value = decimal.Parse(_VatTu == null || _VatTu.Do_day == null ? "0" : _VatTu.Do_day.ToString());
                    sedDoCao.Value = decimal.Parse(_VatTu == null || _VatTu.Do_cao == null ? "0" : _VatTu.Do_cao.ToString());
                    sedDoRong.Value = decimal.Parse(_VatTu == null || _VatTu.Do_rong == null ? "0" : _VatTu.Do_rong.ToString());
                }
            }
        }

        private void frmWare_Load(object sender, EventArgs e)
        {
            gridView.Config(true, false, false, true);
            gridView.AppearanceColumns(new[] { colID_kho, colID_nhom, colID_loai, colMa_vat_tu, colTen_vat_tu });
            gridView.AppearanceColumns(new[] { colKhau_do, colTrong_luong } , DevExpress.Utils.HorzAlignment.Far);
            //----------------------------------------------------------------------
            ucLedNhomVatTu.lookUpEdit.EditValueChanged += lookUpEdit_NhomVatTu_EditValueChanged;
            ucLedNhomVatTu.btnAdd.Click += (sender1, e1) =>
            {
                IForm.ShowDialogForm(new frmNhomVatTu(), FormWindowState.Normal, System.Windows.Forms.FormBorderStyle.FixedSingle);
                STO_NhomVatTuCtrl.LoadDataSource(ucLedNhomVatTu.lookUpEdit, (int)ledKhoVatTu.EditValue);
            };
            ucLedLoaiVatTu.lookUpEdit.EditValueChanged += lookUpEdit_LoaiVatTu_EditValueChanged;
            ucLedLoaiVatTu.btnAdd.Click += (sender1, e1) =>
            {
                IForm.ShowDialogForm(new frmLoaiVatTu(), FormWindowState.Normal, System.Windows.Forms.FormBorderStyle.FixedSingle);
                STO_LoaiVatTuCtrl.LoadDataSource(ucLedLoaiVatTu.lookUpEdit, (int)ucLedNhomVatTu.lookUpEdit.EditValue);
            };
            //----------------------------------------------------------------------
            Context db = new Context();
            STO_KhoVatTuCtrl.LoadDataSource(ledKhoVatTu, db);
            STO_DonViTinhCtrl.LoadDataSource(ledDonVi, db);

            STO_KhoVatTuCtrl.LoadDataSource(rleKhoVatTu, db);
            STO_NhomVatTuCtrl.LoadDataSource(rleNhomVatTu, db);
            STO_LoaiVatTuCtrl.LoadDataSource(rleLoaiVatTu, db);
            STO_DonViTinhCtrl.LoadDataSource(rleID_don_vi, db);
            //----------------------------------------------------------------------
            ucAction.btnInsert.Click += btnInsert_Click;
            ucAction.btnUpdate.Click += btnUpdate_Click;
            ucAction.btnDelete.Click += btnDelete_Click;
            ucAction.btnCommit.Click += btnCommit_Click;
            ucAction.btnExit.Click += btnExit_Click;

            ArrayControls = new Control[] { txtMaVatTu, txtVatTu };
        }

        private Control[] ArrayControls;

        private void ledKhoVatTu_EditValueChanged(object sender, EventArgs e)
        {
            STO_NhomVatTuCtrl.LoadDataSource(ucLedNhomVatTu.lookUpEdit, (int)ledKhoVatTu.EditValue);
        }

        private void lookUpEdit_NhomVatTu_EditValueChanged(object sender, EventArgs e)
        {
            viewSTOVatTuBindingSource.DataSource = new List<viewSTOVatTu>();

            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;

            colDo_cao.Visible = false;
            colDo_day.Visible = false;
            colTrong_luong.Visible = false;
            colKhau_do.Visible = false;

            if (ucLedNhomVatTu.lookUpEdit.EditValue == null || (int)ucLedNhomVatTu.lookUpEdit.EditValue == 0) return;

            STO_LoaiVatTuCtrl.LoadDataSource(ucLedLoaiVatTu.lookUpEdit, (int)ucLedNhomVatTu.lookUpEdit.EditValue);

            ucLedLoaiVatTu.lookUpEdit.ItemIndex = 0;
        }

        STO_LoaiVatTu LoaiVatTu = new STO_LoaiVatTu();
        private void lookUpEdit_LoaiVatTu_EditValueChanged(object sender, EventArgs e)
        {
            if (IsAction) return;

            viewSTOVatTuBindingSource.DataSource = new List<viewSTOVatTu>();

            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;

            colDo_cao.Visible = false;
            colDo_day.Visible = false;
            colTrong_luong.Visible = false;
            colKhau_do.Visible = false;

            if (ucLedLoaiVatTu.lookUpEdit.EditValue == null || (int)ucLedLoaiVatTu.lookUpEdit.EditValue == 0) return;

            STO_VatTuCtrl.LoadBindingSource(viewSTOVatTuBindingSource, (int)ucLedLoaiVatTu.lookUpEdit.EditValue);
            gridView.BestFitColumns();

            LoaiVatTu = STO_LoaiVatTuCtrl.GetItem((int)ucLedLoaiVatTu.lookUpEdit.EditValue);

            if (LoaiVatTu == null)
            {
                pnl1.Visible = false;
                pnl2.Visible = false;
                pnl3.Visible = false;

                colDo_cao.Visible = false;
                colDo_day.Visible = false;
                colTrong_luong.Visible = false;
                colKhau_do.Visible = false;
            }
            if (LoaiVatTu != null)
            {
                string[] Ma_nhom = { "NAN", "PROFILE", "LTGC", "KINH" };
                if (Ma_nhom.Contains(LoaiVatTu.Ma_loai))
                {
                    pnl1.Visible = true;
                    pnl2.Visible = LoaiVatTu.Ma_loai == "NAN" ? true : false;
                    pnl3.Visible = LoaiVatTu.Ma_loai == "NAN" ? true : false;

                    colDo_cao.Visible = LoaiVatTu.Ma_loai == "NAN" ? true : false;
                    colDo_day.Visible = LoaiVatTu.Ma_loai == "NAN" ? true : false;

                    colTrong_luong.Visible = true;
                    colKhau_do.Visible = true;
                }
                else
                {
                    pnl1.Visible = false;
                    pnl2.Visible = false;
                    pnl3.Visible = false;

                    colDo_cao.Visible = false;
                    colDo_day.Visible = false;
                    colTrong_luong.Visible = false;
                    colKhau_do.Visible = false;
                }
            }
        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (IsAction) return;

            VatTu = gridView.GetFocusedRow() as viewSTOVatTu;
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
                txtMaVatTu.Enabled = txtVatTu.Enabled = ledDonVi.Enabled = sedKhauDo.Enabled = sedKhoiLuong.Enabled = false;

                pnl1.Visible = false;
                pnl2.Visible = false;

                if (pnl3.Visible == true)
                {
                    btnSinh.Enabled = false;
                    
                    pnl3.Visible = false;
                }

                lookUpEdit_LoaiVatTu_EditValueChanged(null, null);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            txtMaVatTu.Enabled = txtVatTu.Enabled = ledDonVi.Enabled = sedKhauDo.Enabled = sedKhoiLuong.Enabled = true;

            if (pnl3.Visible == true)
            {
                btnSinh.Enabled = true;
            }

            if (pnl2.Visible == true)
            {
                sedDoDay.Enabled = sedDoCao.Enabled = true;
            }

            this.IsAction = true;

            txtMaVatTu.Text = txtVatTu.Text = string.Empty;

            string[] Ma_nhom = { "NAN" };

            if (Ma_nhom.Contains(LoaiVatTu.Ma_loai))
            {
                txtMaVatTu.Text = ucLedLoaiVatTu.lookUpEdit.Text;
            }

            sedKhauDo.Value = sedKhoiLuong.Value = 0;
            sedDoDay.Value = 0;
            sedDoCao.Value = 0;
            ledDonVi.EditValue = 0;

            txtVatTu.SetFocus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtMaVatTu.Enabled = txtVatTu.Enabled = ledDonVi.Enabled = sedKhauDo.Enabled = sedKhoiLuong.Enabled = true;

            if (pnl2.Visible == true)
            {
                sedDoDay.Enabled = sedDoCao.Enabled = true;
            }

            this.IsAction = true;

            txtVatTu.SetFocus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridView.FocusedRowHandle < 0) return;

            if (INotify.ShowDeleteConfirm() == DialogResult.Yes)
            {
                try
                {
                    STO_VatTuCtrl.Delete(VatTu);

                    STO_VatTuCtrl.LoadBindingSource(viewSTOVatTuBindingSource, (int)ucLedLoaiVatTu.lookUpEdit.EditValue);
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
                    if (!STO_VatTuCtrl.Insert(VatTu)) throw new Exception();

                    STO_VatTuCtrl.LoadBindingSource(viewSTOVatTuBindingSource, (int)ucLedLoaiVatTu.lookUpEdit.EditValue);
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
                    if (!STO_VatTuCtrl.Update(VatTu)) throw new Exception();

                    STO_VatTuCtrl.LoadBindingSource(viewSTOVatTuBindingSource, (int)ucLedLoaiVatTu.lookUpEdit.EditValue);
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

            ledDonVi.Select();

            if (pnl1.Visible == true)
            {
                sedKhauDo.Select();
            }

            foreach (var control in controls)
            {
                control.Select();
            }

            return IsValid;
        }

        private void txtMaVatTu_Validating(object sender, CancelEventArgs e)
        {
            if (!IsAction) return;

            if (string.IsNullOrEmpty(txtMaVatTu.Text.Trim()))
                txtMaVatTu.SetError(dxErrorProvider, "Chưa nhập mã vật tư!", ref IsValid);
            else
                dxErrorProvider.ClearErrors();
        }

        private void txtVatTu_Validating(object sender, CancelEventArgs e)
        {
            if (!IsAction) return;

            if (string.IsNullOrEmpty(txtVatTu.Text.Trim()))
                txtVatTu.SetError(dxErrorProvider, "Chưa nhập tên vật tư!", ref IsValid);
            else
                dxErrorProvider.ClearErrors();
        }

        private void sedKhauDo_Validating(object sender, CancelEventArgs e)
        {
            if (!IsAction) return;

            if (sedKhauDo.Value == 0)
                sedKhauDo.SetError(dxErrorProvider, "Chưa nhập khẩu độ vật tư!", ref IsValid);
            else
                dxErrorProvider.ClearErrors();
        }

        private void ledDonVi_Validating(object sender, CancelEventArgs e)
        {
            if (!IsAction) return;

            if (ledDonVi.EditValue == null || (int)ledDonVi.EditValue == -1 || (int)ledDonVi.EditValue == 0)
                ledDonVi.SetError(dxErrorProvider, "Chưa nhập khối lượng vật tư!", ref IsValid);
            else
                dxErrorProvider.ClearErrors();
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            //IsValid = true;

            //ledDonVi.Select();
            //txtMaVatTu.Select();

            //if (!IsValid) return;

            //try
            //{
            //    var entity = new STO_VatTu
            //    {
            //        ID_loai = (int)ucLedLoaiVatTu.lookUpEdit.EditValue,
            //        Ma_vat_tu = txtMaVatTu.Text,
            //        Ten_vat_tu = txtVatTu.Text,
            //        ID_don_vi = (int)ledDonVi.EditValue,
            //        Khau_do = 0,
            //        Trong_luong = (decimal?)null,
            //        Mo_ta = null,
            //        Trang_thai = true,
            //    };

            //    var begin = sedBatDau.EditValue == null ? 0 : sedBatDau.Value;
            //    var end = sedKetThuc.EditValue == null ? 0 : sedKetThuc.Value;
            //    var add = sedKhoangCach.EditValue == null ? 0 : sedKhoangCach.Value;

            //    for (decimal i = begin; i <= end; i += add)
            //    {
            //        entity.Ma_vat_tu = String.Format("{0}-{1}", txtMaVatTu.Text.Trim(), i);
            //        entity.Khau_do = (decimal)i;
            //        STO_VatTuCtrl.Insert(entity);
            //    }

            //}
            //catch
            //{
            //    INotify.ShowInsertError();
            //}
            //finally
            //{
            //    ucAction.nAction = -1;
            //    btnExit_Click(null, null);
            //    ucAction.btnExit.PerformClick();
            //    STO_VatTuCtrl.LoadBindingSource(viewSTOVatTuBindingSource, (int)ucLedLoaiVatTu.lookUpEdit.EditValue);
            //    gridView.BestFitColumns();
            //}
        }

        private void sedKhauDo_EditValueChanged(object sender, EventArgs e)
        {
            if (!IsAction) return;

            string[] Ma_nhom = { "NAN" };

            if (Ma_nhom.Contains(LoaiVatTu.Ma_loai))
            {
                txtMaVatTu.Text = ucLedLoaiVatTu.lookUpEdit.Text + ((sedKhauDo.Value > 0) ? "-" + sedKhauDo.Value : string.Empty);
            }
        }

        private void sedKhauDo_MouseClick(object sender, MouseEventArgs e)
        {
            sedKhauDo.SelectionStart = 0;
            sedKhauDo.SelectionLength = sedKhauDo.Text.Length;
            sedKhauDo.Select();
        }
        
        private void sedKhoiLuong_MouseClick(object sender, MouseEventArgs e)
        {
            sedKhoiLuong.SelectionStart = 0;
            sedKhoiLuong.SelectionLength = sedKhauDo.Text.Length;
            sedKhoiLuong.Select();
        }
    }
}