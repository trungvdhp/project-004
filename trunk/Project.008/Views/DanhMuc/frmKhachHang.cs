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
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private CAT_KhachHang _KhachHang;
        public CAT_KhachHang KhachHang
        {
            get
            {
                if (_KhachHang == null) _KhachHang = new CAT_KhachHang();
                var hoTen = txtHoTen.Text.Trim();
                var index = hoTen.LastIndexOf(" ");
                _KhachHang.Ho_dem = index == -1 ? hoTen : hoTen.Substring(0, index - 1);
                _KhachHang.Ten = index == -1 ? string.Empty : hoTen.Substring(index + 1);
                _KhachHang.Dien_thoai = txtDienThoai.Text.Trim();
                _KhachHang.Dia_chi = txtDiaChi.Text.Trim();
                return _KhachHang;
            }
            set
            {
                _KhachHang = value;

                if (value != null)
                {
                    txtHoTen.Text = String.Format("{0} {1}", _KhachHang.Ho_dem, _KhachHang.Ten);
                    txtDienThoai.Text = _KhachHang.Dien_thoai;
                    txtDiaChi.Text = _KhachHang.Dia_chi;
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

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            gridView.Config(true, false, false, true);
            gridView.AppearanceColumns(new[] { colHo_dem, colTen, colDia_chi, colDien_thoai });
            //----------------------------------------------------------------------
            CAT_KhachHangCtrl.LoadBindingSource(cATKhachHangBindingSource);
            gridView.BestFitColumns();
            //----------------------------------------------------------------------
            ucAction.btnInsert.Click += btnInsert_Click;
            ucAction.btnUpdate.Click += btnUpdate_Click;
            ucAction.btnDelete.Click += btnDelete_Click;
            ucAction.btnCommit.Click += btnCommit_Click;
            ucAction.btnExit.Click += btnExit_Click;

            ArrayControls = new Control[] { txtDiaChi, txtDienThoai, txtHoTen };
        }

        private Control[] ArrayControls; 

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (IsAction) return;

            KhachHang = gridView.GetFocusedRow() as CAT_KhachHang;
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
                txtHoTen.Enabled =txtDienThoai.Enabled = txtDiaChi.Enabled = false;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            txtHoTen.Enabled = txtDienThoai.Enabled = txtDiaChi.Enabled = true;

            this.IsAction = true;

            txtHoTen.Text = txtDienThoai.Text = txtDiaChi.Text = string.Empty;

            txtHoTen.SetFocus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtHoTen.Enabled = txtDienThoai.Enabled = txtDiaChi.Enabled = true;

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
                    CAT_KhachHangCtrl.Delete(KhachHang);

                    CAT_KhachHangCtrl.LoadBindingSource(cATKhachHangBindingSource);
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
                    if (!CAT_KhachHangCtrl.Insert(KhachHang)) throw new Exception();
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
                    if (!CAT_KhachHangCtrl.Update(KhachHang)) throw new Exception();
                }
                catch (Exception)
                {
                    INotify.ShowUpdateError();
                }
            }

            CAT_KhachHangCtrl.LoadBindingSource(cATKhachHangBindingSource);
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
                txtHoTen.SetError(dxErrorProvider, "Chưa nhập họ và tên khách hàng!", ref IsValid);
            else
                dxErrorProvider.ClearErrors();
        }

        private void txtDienThoai_Validating(object sender, CancelEventArgs e)
        {
            if (!IsAction) return;

            if (string.IsNullOrEmpty(txtDienThoai.Text.Trim()))
                txtDienThoai.SetError(dxErrorProvider, "Chưa nhập số điện thoại khách hàng!", ref IsValid);
            else
                dxErrorProvider.ClearErrors();
        }

        private void txtDiaChi_Validating(object sender, CancelEventArgs e)
        {
            if (!IsAction) return;

            if (string.IsNullOrEmpty(txtDiaChi.Text.Trim()))
                txtDiaChi.SetError(dxErrorProvider, "Chưa nhập địa chỉ khách hàng!", ref IsValid);
            else
                dxErrorProvider.ClearErrors();
        }
    }
}