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
    public partial class frmVatTu : DevExpress.XtraEditors.XtraForm
    {
        public frmVatTu()
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

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            gridView.Config(true, false, false, true);
            gridView.AppearanceColumns(new[] { colID_kho, colID_nhom, colID_loai, colMa_vat_tu, colTen_vat_tu });
            gridView.AppearanceColumns(new[] { colKhau_do, colTrong_luong }, DevExpress.Utils.HorzAlignment.Far);
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
        }
        private void ledKhoVatTu_EditValueChanged(object sender, EventArgs e)
        {
            if (ledKhoVatTu.EditValue == null)
            {
                ucLedNhomVatTu.lookUpEdit.Properties.DataSource = new List<STO_NhomVatTu>();
                ucLedNhomVatTu.lookUpEdit.EditValue = null;

                viewSTOVatTuBindingSource.DataSource = new List<viewSTOVatTu>();
                return;
            }

            STO_NhomVatTuCtrl.LoadDataSource(ucLedNhomVatTu.lookUpEdit, (int)ledKhoVatTu.EditValue);
        }

        private void lookUpEdit_NhomVatTu_EditValueChanged(object sender, EventArgs e)
        {
            pnlKhauDo.Visible = pnlKhoiLuong.Visible = false;
            pnlDoDay.Visible = pnlDoCao.Visible = pnlDoRong.Visible = false;
            pnlSinhTuDong.Visible = false;

            colKhau_do.Visible = colTrong_luong.Visible = false;
            colDo_day.Visible = colDo_cao.Visible = colDo_rong.Visible = false;

            txtMaVatTu.Text = string.Empty;
            txtVatTu.Text = string.Empty;

            ledDonVi.EditValue = 0;

            sedKhauDo.Value = decimal.Parse("0");
            sedKhoiLuong.Value = decimal.Parse("0");

            sedDoDay.Value = decimal.Parse("0");
            sedDoCao.Value = decimal.Parse("0");
            sedDoRong.Value = decimal.Parse("0");

            viewSTOVatTuBindingSource.DataSource = new List<viewSTOVatTu>();

            if (ucLedNhomVatTu.lookUpEdit.EditValue == null || (int)ucLedNhomVatTu.lookUpEdit.EditValue == 0)
            {
                ucLedLoaiVatTu.lookUpEdit.Properties.DataSource = new List<STO_LoaiVatTu>();
                ucLedLoaiVatTu.lookUpEdit.EditValue = null;
                
                return;
            }

            STO_LoaiVatTuCtrl.LoadDataSource(ucLedLoaiVatTu.lookUpEdit, (int)ucLedNhomVatTu.lookUpEdit.EditValue);

            ucLedLoaiVatTu.lookUpEdit.ItemIndex = 0;
        }

        STO_LoaiVatTu LoaiVatTu = new STO_LoaiVatTu();
        private void lookUpEdit_LoaiVatTu_EditValueChanged(object sender, EventArgs e)
        {
            if (IsAction) return;

            pnlKhauDo.Visible = pnlKhoiLuong.Visible = false;
            pnlDoDay.Visible = pnlDoCao.Visible = pnlDoRong.Visible = false;
            pnlSinhTuDong.Visible = false;

            colKhau_do.Visible = colTrong_luong.Visible = false;
            colDo_day.Visible = colDo_cao.Visible = colDo_rong.Visible = false;

            if (ucLedLoaiVatTu.lookUpEdit.EditValue == null || (int)ucLedLoaiVatTu.lookUpEdit.EditValue == 0)
            {                
                viewSTOVatTuBindingSource.DataSource = new List<viewSTOVatTu>();
                return;
            }

            STO_VatTuCtrl.LoadBindingSource(viewSTOVatTuBindingSource, (int)ucLedLoaiVatTu.lookUpEdit.EditValue);
            gridView.BestFitColumns();

            LoaiVatTu = STO_LoaiVatTuCtrl.GetItem((int)ucLedLoaiVatTu.lookUpEdit.EditValue);

            if (LoaiVatTu != null)
            {
                string[] Ma_nhom = { "NAN", "PROFILE", "LTGC", "KINH" };

                switch (LoaiVatTu.Ma_loai)
                {
                    case "NAN":
                        pnlKhauDo.Visible = pnlKhoiLuong.Visible = true;
                        pnlDoDay.Visible = true;
                        pnlDoCao.Visible = true;

                        pnlSinhTuDong.Visible = true;

                        colKhau_do.Visible = colTrong_luong.Visible = false;
                        colDo_day.Visible = colDo_cao.Visible = false;

                        colKhau_do.VisibleIndex = 6;
                        colTrong_luong.VisibleIndex = 7;
                        colDo_day.VisibleIndex = 8;
                        colDo_cao.VisibleIndex = 9;
                        break;
                    case "PROFILE":
                    case "LTGC":
                        pnlKhauDo.Visible = pnlKhoiLuong.Visible = true;

                        colKhau_do.Visible = colTrong_luong.Visible = false;

                        colKhau_do.VisibleIndex = 6;
                        colTrong_luong.VisibleIndex = 7;
                        break;
                    case "KINH":
                        pnlDoCao.Visible = pnlDoRong.Visible = true;

                        colDo_cao.Visible = colDo_rong.Visible = false;

                        colDo_cao.VisibleIndex = 6;
                        colDo_rong.VisibleIndex = 7;
                        break;
                }
            }
        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (IsAction) return;

            VatTu = gridView.GetFocusedRow() as viewSTOVatTu;
        }

        private void ucAction_Load(object sender, EventArgs e)
        {
            ucAction.btnInsert.Click += btnInsert_Click;
            ucAction.btnUpdate.Click += btnUpdate_Click;
            ucAction.btnDelete.Click += btnDelete_Click;
            ucAction.btnCommit.Click += btnCommit_Click;
            ucAction.btnExit.Click += btnExit_Click;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            txtMaVatTu.Enabled = txtVatTu.Enabled = ledDonVi.Enabled = true;

            switch (LoaiVatTu.Ma_loai)
            {
                case "NAN":
                    sedKhauDo.Enabled = sedKhoiLuong.Enabled = true;
                    sedDoDay.Enabled = true;
                    sedDoCao.Enabled = true;

                    btnSinh.Enabled = true;
                    break;
                case "PROFILE":
                case "LTGC":
                    sedKhauDo.Enabled = sedKhoiLuong.Enabled = true;
                    break;
                case "KINH":
                    sedDoCao.Enabled = sedDoRong.Enabled = true;
                    break;
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
            sedDoRong.Value = 0;
            ledDonVi.EditValue = 0;

            txtVatTu.SetFocus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtMaVatTu.Enabled = txtVatTu.Enabled = ledDonVi.Enabled = true;

            switch (LoaiVatTu.Ma_loai)
            {
                case "NAN":
                    sedKhauDo.Enabled = sedKhoiLuong.Enabled = true;
                    sedDoDay.Enabled = true;
                    sedDoCao.Enabled = true;

                    btnSinh.Enabled = true;
                    break;
                case "PROFILE":
                case "LTGC":
                    sedKhauDo.Enabled = sedKhoiLuong.Enabled = true;
                    break;
                case "KINH":
                    sedDoCao.Enabled = sedDoRong.Enabled = true;
                    break;
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
            if (!Validator(new[] { ledDonVi, txtMaVatTu, txtVatTu })) return;

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
                txtMaVatTu.Enabled = txtVatTu.Enabled = ledDonVi.Enabled = false; 
                sedKhauDo.Enabled = sedKhoiLuong.Enabled = false;
                sedDoDay.Enabled = sedDoCao.Enabled = false;
                sedDoRong.Enabled =  false;                

                lookUpEdit_LoaiVatTu_EditValueChanged(null, null);
            }
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

        private void ledDonVi_Validating(object sender, CancelEventArgs e)
        {
            if (!IsAction) return;

            if (ledDonVi.EditValue == null || (int)ledDonVi.EditValue == -1 || (int)ledDonVi.EditValue == 0)
                ledDonVi.SetError(dxErrorProvider, "Chưa nhập khối lượng vật tư!", ref IsValid);
            else
                dxErrorProvider.ClearErrors();
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
            if (e.Button == System.Windows.Forms.MouseButtons.Left && e.Clicks == 1)
            {
                sedKhauDo.SelectionStart = 0;
                sedKhauDo.SelectionLength = sedKhauDo.Text.Length;
                sedKhauDo.Select();
            }
        }

        private void sedKhoiLuong_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && e.Clicks == 1)
            {
                sedKhauDo.SelectionStart = 0;
                sedKhauDo.SelectionLength = sedKhauDo.Text.Length;
                sedKhauDo.Select();
            }
        }

        private void sedDoDay_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && e.Clicks == 1)
            {
                sedDoDay.SelectionStart = 0;
                sedDoDay.SelectionLength = sedDoDay.Text.Length;
                sedDoDay.Select();
            }
        }

        private void sedDoRong_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && e.Clicks == 1)
            {
                sedDoRong.SelectionStart = 0;
                sedDoRong.SelectionLength = sedDoRong.Text.Length;
                sedDoRong.Select();
            }
        }

        private void sedDoCao_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && e.Clicks == 1)
            {
                sedDoCao.SelectionStart = 0;
                sedDoCao.SelectionLength = sedDoCao.Text.Length;
                sedDoCao.Select();
            }
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            IForm.ShowDialogForm(new frmVatTu_SinhTuDong(), FormWindowState.Normal, System.Windows.Forms.FormBorderStyle.None);

            STO_VatTuCtrl.LoadBindingSource(viewSTOVatTuBindingSource, (int)ucLedLoaiVatTu.lookUpEdit.EditValue);
            gridView.BestFitColumns();
        }
    }
}