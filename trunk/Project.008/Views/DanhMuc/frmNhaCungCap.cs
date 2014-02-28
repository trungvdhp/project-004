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
    public partial class frmNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        // Fields...
        private CAT_NhaCungCap _NhaCungCap;
        public CAT_NhaCungCap NhaCungCap
        {
            get
            {
                _NhaCungCap.Ten_nha_cung_cap = txtNhaCungCap.Text.Trim();
                _NhaCungCap.Nguoi_dai_dien = txtNguoiDaiDien.Text.Trim();
                _NhaCungCap.Dien_thoai = txtDienThoai.Text.Trim();
                _NhaCungCap.Dia_chi = txtDiaChi.Text.Trim();
                _NhaCungCap.Email = txtEmail.Text.Trim();
                _NhaCungCap.Ngan_hang = txtNganHang.Text.Trim();
                _NhaCungCap.So_tai_khoan = txtSoTaiKhoan.Text.Trim();
                return _NhaCungCap;
            }
            set
            {
                _NhaCungCap = value;

                if (value != null)
                {
                    txtNhaCungCap.Text = _NhaCungCap.Ten_nha_cung_cap;
                    txtNguoiDaiDien.Text = _NhaCungCap.Nguoi_dai_dien;
                    txtDienThoai.Text = _NhaCungCap.Dien_thoai;
                    txtDiaChi.Text = _NhaCungCap.Dia_chi;
                    txtEmail.Text = _NhaCungCap.Email;
                    txtNganHang.Text = _NhaCungCap.Ngan_hang;
                    txtSoTaiKhoan.Text = _NhaCungCap.So_tai_khoan;
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

        private void frmProvider_Load(object sender, EventArgs e)
        {
            gridView.Config(true, false, false, true);
            gridView.AppearanceColumns(new[] { colTen_nha_cung_cap, colNguoi_dai_dien, colDia_chi, colEmail, colNgan_hang });
            gridView.AppearanceColumns(new[] { colDien_thoai, colSo_tai_khoan  }, DevExpress.Utils.HorzAlignment.Far);
            //----------------------------------------------------------------------
            CAT_NhaCungCapCtrl.LoadBindingSource(cATNhaCungCapBindingSource);
            gridView.BestFitColumns();

            //----------------------------------------------------------------------
            ucAction.btnInsert.Click += btnInsert_Click;
            ucAction.btnUpdate.Click += btnUpdate_Click;
            ucAction.btnDelete.Click += btnDelete_Click;
            ucAction.btnCommit.Click += btnCommit_Click;
            ucAction.btnExit.Click += btnExit_Click;

            //ArrayControls = new Control[] { txtSoTaiKhoan, txtNganHang, txtEmail, txtDiaChi, txtDienThoai, txtNguoiDaiDien, txtNhaCungCap };
            ArrayControls = new Control[] { txtNhaCungCap };
        }

        private Control[] ArrayControls; 

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (IsAction) return;

            NhaCungCap = gridView.GetFocusedRow() as CAT_NhaCungCap;
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
                txtNhaCungCap.Enabled = txtNguoiDaiDien.Enabled = txtDienThoai.Enabled = txtDiaChi.Enabled = false;
                txtNganHang.Enabled = txtEmail.Enabled = txtSoTaiKhoan.Enabled = false;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            txtNhaCungCap.Enabled = txtNguoiDaiDien.Enabled = txtDienThoai.Enabled = txtDiaChi.Enabled = true;
            txtNganHang.Enabled = txtEmail.Enabled = txtSoTaiKhoan.Enabled = true;

            this.IsAction = true;

            txtNhaCungCap.Text = txtNguoiDaiDien.Text = txtDienThoai.Text = txtDiaChi.Text = string.Empty;
            txtNganHang.Text = txtEmail.Text = txtSoTaiKhoan.Text = string.Empty;

            txtNhaCungCap.SetFocus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtNhaCungCap.Enabled = txtNguoiDaiDien.Enabled = txtDienThoai.Enabled = txtDiaChi.Enabled = true;
            txtNganHang.Enabled = txtEmail.Enabled = txtSoTaiKhoan.Enabled = true;

            this.IsAction = true;

            txtNhaCungCap.SetFocus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridView.FocusedRowHandle < 0) return;

            if (INotify.ShowDeleteConfirm() == DialogResult.Yes)
            {
                try
                {
                    CAT_NhaCungCapCtrl.Delete(NhaCungCap);

                    CAT_NhaCungCapCtrl.LoadBindingSource(cATNhaCungCapBindingSource);
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
                    if (!CAT_NhaCungCapCtrl.Insert(NhaCungCap)) throw new Exception();
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
                    if (!CAT_NhaCungCapCtrl.Update(NhaCungCap)) throw new Exception();
                }
                catch (Exception)
                {
                    INotify.ShowUpdateError();
                }
            }

            CAT_NhaCungCapCtrl.LoadBindingSource(cATNhaCungCapBindingSource);
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

        private void txtNhaCungCap_Validating(object sender, CancelEventArgs e)
        {
            if (!IsAction) return;

            if (string.IsNullOrEmpty(txtNhaCungCap.Text.Trim()))
                txtNhaCungCap.SetError(dxErrorProvider, "Chưa nhập tên nhà cung cấp!", ref IsValid);
            else
                dxErrorProvider.ClearErrors();
        }
    }
}