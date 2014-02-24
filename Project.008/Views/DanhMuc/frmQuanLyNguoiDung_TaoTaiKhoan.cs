using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library;
using Library.UI;
using Library.UI.Grid;
using Library.UI.Form;
using Project._008.Models;
using Project._008.Controllers;

namespace Project._008.Views.DanhMuc
{
    public partial class frmQuanLyNguoiDung_TaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public frmQuanLyNguoiDung_TaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Abort;
        }

        private void frmQuanLyNguoiDung_TaoTaiKhoan_Load(object sender, EventArgs e)
        {
            SYS_VaiTroCtrl.LoadDataSource(ledVaiTro);
            CAT_NhanVienCtrl.LoadDataSource(ledNhanVien);
            //-------------------------------------------------------------
            ledNhanVien.EditValue = null;
            txtTenDangNhap.SetFocus();

        }

        private void ledVaiTro_EditValueChanged(object sender, EventArgs e)
        {
            if (ledVaiTro.EditValue != null && (int)ledVaiTro.EditValue == 0)
            {
                ledNhanVien.Enabled = false;
                ledNhanVien.EditValue = null;
            }
            else
            {
                ledNhanVien.Enabled = true;
                ledNhanVien.ItemIndex = 0;
            }
        }

        private void ledNhanVien_EditValueChanged(object sender, EventArgs e)
        {
            txtTenDayDu.Enabled = ledNhanVien.EditValue == null ? false : true;

            if (ledNhanVien.EditValue == null)
            {
                txtTenDayDu.Enabled = true;
                txtTenDayDu.Text = string.Empty;
                txtTenDayDu.SetFocus();
            }
            else
            {
                txtTenDayDu.Enabled = false;
                var nv = CAT_NhanVienCtrl.GetItem((int)ledNhanVien.EditValue);
                txtTenDayDu.Text = string.Format("{0} {1}", nv.Ho_dem, nv.Ten);
            }
        }

        bool IsValid;
        private bool Validator(Control[] controls = null)
        {
            if (controls == null) return false;

            IsValid = true;

            foreach (var control in controls)
            {
                control.Select();
            }

            return IsValid;
        }

        private void txtTenDangNhap_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDangNhap.Text.Trim()) && txtTenDangNhap.Text.Trim().Length >= 3)
                txtTenDangNhap.SetError(dxErrorProvider, "Chưa nhập tên đăng nhập hoặc tên đăng nhập phải ít nhất là 3 ký tự!", ref IsValid);
            else
                dxErrorProvider.ClearErrors();
        }

        private void txtMatKhau_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatKhau.Text.Trim()) && txtMatKhau.Text.Trim().Length >= 6)
                txtMatKhau.SetError(dxErrorProvider, "Chưa nhập mật khẩu hoặc mật khẩu phải ít nhất là 6 ký tự!", ref IsValid);
            else
                dxErrorProvider.ClearErrors();
        }

        private void txtMatKhauXacNhan_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatKhauXacNhan.Text.Trim()) && txtMatKhauXacNhan.Text.Trim() == txtMatKhau.Text.Trim())
                txtMatKhauXacNhan.SetError(dxErrorProvider, "Chưa nhập mật khẩu xác nhận hoặc mật khẩu xác nhận và mật khẩu chưa giống nhau!", ref IsValid);
            else
                dxErrorProvider.ClearErrors();
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            if (!Validator(new [] { txtMatKhauXacNhan, txtMatKhau, txtTenDangNhap })) return;

            try
            {
                TimeSpan time;
                var nguoiDung = new SYS_NguoiDung
                {
                    Tai_khoan = txtTenDangNhap.Text.Trim(),
                    Mat_khau = txtMatKhau.Text.Trim(),
                    Ten_day_du = txtTenDayDu.Text.Trim(),
                    ID_trang_thai = 0,
                    ID_nhan_vien = ledNhanVien.EditValue == null ? (int?)null : (int)ledNhanVien.EditValue,
                    Thoi_gian_cho = tedThoiGianCho.EditValue == null ? (TimeSpan?)null : (TimeSpan.TryParse(tedThoiGianCho.Text, out time) ? time : (new TimeSpan(8,0,0))),
                };

                int rs = SYS_NguoiDungCtrl.Insert(nguoiDung);

                if (rs == -1)
                {
                    INotify.ShowWarning("Tài khoản này đã tồn tại.\nVui lòng chọn một tên đăng nhập khác!", "Tạo tài khoản người dùng");
                }
                else
                {
                    if (ledVaiTro.EditValue != null && (int)ledVaiTro.EditValue != 0)
                    {
                        SYS_NguoiDungCtrl.Insert(nguoiDung, (int?)ledVaiTro.EditValue);
                    }
                    INotify.ShowInsertSuccess("Tạo tài khoản người dùng mới thành công.");
                    
                    btnThoat.PerformClick();
                }
            }
            catch
            {
                INotify.ShowInsertError("Tạo tài khoản người dùng mới thất bại.");
            }
        }
    }
}
