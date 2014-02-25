using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Library;
using Library.UI;
using Library.UI.Grid;
using Library.UI.Form;
using Project._008.Models;
using Project._008.Controllers;

namespace Project._008.Views.DanhMuc
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        // Fields...
        private CAT_NhanVien _NhanVien;
        public CAT_NhanVien NhanVien
        {
            get
            {
                if (_NhanVien == null) _NhanVien = new CAT_NhanVien();
                var hoTen = txtHoTen.Text.Trim();
                var index = hoTen.LastIndexOf(" ");
                _NhanVien.Ho_dem = index == -1 ? hoTen : hoTen.Substring(0, index - 1);
                _NhanVien.Ten = index == -1 ? string.Empty : hoTen.Substring(index + 1);
                _NhanVien.Ngay_sinh = (DateTime)dteNgaySinh.EditValue;
                _NhanVien.Gioi_tinh = cmbGioiTinh.Text == "Nam" ? 1 : 0;
                _NhanVien.Dien_thoai = txtDienThoai.Text.Trim();
                _NhanVien.CMND = txtCMND.Text.Trim() == string.Empty ? null : txtCMND.Text.Trim();
                _NhanVien.Ngay_cap = txtCMND.Text.Trim() == string.Empty || dteNgayCap.EditValue == null ? (DateTime?)null : (DateTime)dteNgayCap.EditValue;
                _NhanVien.Noi_cap = txtCMND.Text.Trim() == string.Empty || txtNoiCap.Text.Trim() == string.Empty ? null : txtNoiCap.Text.Trim();
                _NhanVien.Email = txtEmail.Text.Trim(); 
                _NhanVien.Dia_chi = txtDiaChi.Text.Trim();
                _NhanVien.ID_phong = ledPhongBan.EditValue == null ? (int?)null : (int)ledPhongBan.EditValue;
                return _NhanVien;
            }
            set
            {
                _NhanVien = value;

                if (value != null)
                {
                    txtHoTen.Text = String.Format("{0} {1}", _NhanVien.Ho_dem, _NhanVien.Ten);
                    dteNgaySinh.EditValue = _NhanVien.Ngay_sinh;
                    cmbGioiTinh.SelectedText = _NhanVien.Gioi_tinh == 1 ? "Nam" : "Nữ";
                    txtDienThoai.Text = _NhanVien.Dien_thoai;

                    txtCMND.Text = _NhanVien.CMND == null ? string.Empty : _NhanVien.CMND;
                    dteNgayCap.EditValue = _NhanVien.Ngay_cap == null ? null : _NhanVien.Ngay_cap;
                    txtNoiCap.Text = _NhanVien.Noi_cap == null ? string.Empty : _NhanVien.Noi_cap;
                    
                    txtEmail.Text = _NhanVien.Email;
                    txtDiaChi.Text = _NhanVien.Dia_chi;

                    ledPhongBan.EditValue = _NhanVien.ID_phong;
                }
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

        private void frmMemberShip_Load(object sender, EventArgs e)
        {
            //----------------------------------------------------------------------
            dteNgaySinh.Config("dd/MM/yyyy");
            dteNgayCap.Config("dd/MM/yyyy");
            txtCMND.Config(12);
            txtCMND.SetMask("[0-9]*");
            txtDienThoai.Config(15);
            txtDienThoai.SetMask("[ -.0-9]*");
            txtEmail.SetMask("[A-Za-z0-9._%-]+@[A-Za-z0-9.-]*");
            //----------------------------------------------------------------------
            gridView.Config(true, false, false, true);
            gridView.AppearanceColumns(new[] { colHo_dem, colTen, colNoi_cap, colDia_chi, colDien_thoai, colID_phong });
            gridView.AppearanceColumns(new[] { colDien_thoai }, DevExpress.Utils.HorzAlignment.Far);

            gridView.DisplayFormatColumn(colNgay_sinh, "dd/MM/yyyy", DevExpress.Utils.FormatType.DateTime);
            gridView.DisplayFormatColumn(colNoi_cap, "dd/MM/yyyy", DevExpress.Utils.FormatType.DateTime);
            //----------------------------------------------------------------------
            CAT_PhongBanCtrl.LoadDataSource(ledPhongBan);
            CAT_PhongBanCtrl.LoadDataSource(repID_Phong);

            CAT_NhanVienCtrl.LoadBindingSource(cATNhanVienBindingSource);
            gridView.BestFitColumns();
            //----------------------------------------------------------------------
            ucAction.btnInsert.Click += btnInsert_Click;
            ucAction.btnUpdate.Click += btnUpdate_Click;
            ucAction.btnDelete.Click += btnDelete_Click;
            ucAction.btnCommit.Click += btnCommit_Click;
            ucAction.btnExit.Click += btnExit_Click;

            ArrayControls = new Control[] { dteNgaySinh, txtHoTen };
        }

        private Control[] ArrayControls;

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (IsAction) return;

            NhanVien = gridView.GetFocusedRow() as CAT_NhanVien;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.IsAction = false;

            if (ucAction.nAction == 0)
            {
                IForm.CloseCurrentTabPage(this.Parent);
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
            }
            else if (ucAction.nAction == -1)
            {
                dxErrorProvider.ClearErrors();
                gridView_FocusedRowChanged(gridView, new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs(-1, gridView.FocusedRowHandle));
                txtHoTen.Enabled = dteNgaySinh.Enabled = cmbGioiTinh.Enabled = txtDienThoai.Enabled = false;
                txtCMND.Enabled = dteNgayCap.Enabled = txtNoiCap.Enabled = false;
                txtEmail.Enabled = txtDiaChi.Enabled = ledPhongBan.Enabled = false;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            txtHoTen.Enabled = dteNgaySinh.Enabled = cmbGioiTinh.Enabled = txtDienThoai.Enabled = true;
            txtCMND.Enabled = true;
            dteNgayCap.Enabled = txtNoiCap.Enabled = false;
            txtEmail.Enabled = txtDiaChi.Enabled = ledPhongBan.Enabled = true;

            this.IsAction = true;

            txtHoTen.Text = txtDienThoai.Text = string.Empty;
            cmbGioiTinh.SelectedIndex = 0;
            dteNgaySinh.EditValue = null;
            txtCMND.Text = txtNoiCap.Text = string.Empty;
            dteNgayCap.EditValue = null;
            txtEmail.Text = txtDiaChi.Text = string.Empty;
                
            ledPhongBan.ItemIndex = 0;

            txtHoTen.SetFocus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtHoTen.Enabled = dteNgaySinh.Enabled = cmbGioiTinh.Enabled = txtDienThoai.Enabled = true;
            txtCMND.Enabled = true;
            if (txtCMND.Text != string.Empty && gridView.GetFocusedRowCellValue(colCMND) != null)
            {
                dteNgayCap.Enabled = txtNoiCap.Enabled = true;
            }
            else
            {
                dteNgayCap.Enabled = txtNoiCap.Enabled = false;
            }

            txtEmail.Enabled = txtDiaChi.Enabled = ledPhongBan.Enabled = true;

            this.IsAction = true;

            txtHoTen.SetFocus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridView.FocusedRowHandle < 0) return;

            if (INotify.ShowDeleteConfirm() == DialogResult.Yes)
            {
                try
                {
                    CAT_NhanVienCtrl.Delete(NhanVien);

                    CAT_NhanVienCtrl.LoadBindingSource(cATNhanVienBindingSource);
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
                    if (!CAT_NhanVienCtrl.Insert(NhanVien)) throw new Exception();
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
                    if (!CAT_NhanVienCtrl.Update(NhanVien)) throw new Exception();
                }
                catch (Exception)
                {
                    INotify.ShowUpdateError();
                }
            }

            CAT_NhanVienCtrl.LoadBindingSource(cATNhanVienBindingSource);
            gridView.BestFitColumns();

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

        private void txtHoTen_Validating(object sender, CancelEventArgs e)
        {
            if (!IsAction) return;

            if (string.IsNullOrEmpty(txtHoTen.Text.Trim()))
                txtHoTen.SetError(dxErrorProvider, "Chưa nhập họ tên nhân viên!", ref IsValid);
            else
                dxErrorProvider.ClearErrors();
        }

        private void dteNgaySinh_Validating(object sender, CancelEventArgs e)
        {
            if (!IsAction) return;

            if (dteNgaySinh.EditValue == null)
                dteNgaySinh.SetError(dxErrorProvider, "Chưa nhập ngày sinh!", ref IsValid);
            else
                dxErrorProvider.ClearErrors();
        }

        private void txtCMND_Validating(object sender, CancelEventArgs e)
        {
            if (!IsAction) return;

            if (string.IsNullOrEmpty(txtCMND.Text.Trim()))
            {
                dteNgayCap.Enabled = txtNoiCap.Enabled = false;
            }
            else
            {
                dteNgayCap.Enabled = txtNoiCap.Enabled = true;
            }
        }

        private void ucAction_Load(object sender, EventArgs e)
        {

        }
    }
}