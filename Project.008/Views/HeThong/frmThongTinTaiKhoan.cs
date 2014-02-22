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
using Library.UI;
using Library.UI.Form;
using Library;

namespace Project._008.Views.HeThong
{
    public partial class frmThongTinTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public frmThongTinTaiKhoan()
        {
            InitializeComponent();
        }
        SYS_NguoiDung NguoiDung { get; set; }
        public frmThongTinTaiKhoan(SYS_NguoiDung nguoiDung)
        {
            InitializeComponent();
            this.NguoiDung = nguoiDung;
        }

        private void frmThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            //-------------------------------------------------------------
            txtTenDangNhap.Text = NguoiDung.Tai_khoan;

            Context db = new Context();
            var nhanVien = NguoiDung.ID_nhan_vien == null ? null : CAT_NhanVienCtrl.GetItem((int)NguoiDung.ID_nhan_vien, db);
            
            txtTenDayDu.Text = NguoiDung.Ten_day_du;
            //-------------------------------------------------------------
            txtTenDayDu.SetFocus();

            txtTenDayDu.Enabled = nhanVien == null ? true : false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatKhauXacNhan.Text.Trim()) || txtMatKhauXacNhan.Text.Trim() != txtMatKhau.Text.Trim())
            {
                INotify.ShowWarning("Chưa nhập mật khẩu xác nhận hoặc mật khẩu xác nhận và mật khẩu chưa giống nhau.!", "Mật khẩu");
                txtMatKhau.SetFocus();
                return;
            }

            try
            {
                NguoiDung.Mat_khau = txtMatKhau.Text;
                NguoiDung.Ten_day_du = txtTenDayDu.Text;

                SYS_NguoiDungCtrl.Update(NguoiDung);

                btnThoat.PerformClick();
            }
            catch
            {
                INotify.ShowUpdateError("Cập nhật thông tin cá nhân thất bại.");
            }

        }
    }
}