using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Project._008.Systems
{
    using Library;
    using Library.UI;
    using Library.UI.Form;
    using Library.Data;
    using Project._008.Controllers;

    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.SetMask("[a-zA-Z0-9_\\-\\.]+"); 
            txtTenDangNhap.SetNullValue("Nhập tên đăng nhập ít nhất 3 ký tự");
            
            txtMatKhau.SetMask("[a-zA-Z0-9!#$%&'()*+,-.:;<=>?@[\\]{}^_`|~]+");
            txtMatKhau.SetNullValue("Nhập mật khẩu ít nhất là 6 ký tự");

            txtTenDangNhap.SetFocus();

            txtTenDangNhap.Validating += (sender1, e1) =>
                {
                    if (string.IsNullOrEmpty(txtTenDangNhap.Text.Trim()))
                        txtTenDangNhap.SetError(dxErrorProvider, "Chưa nhập tên đăng nhập!", ref IsValid);
                    else if (txtTenDangNhap.Text.Length < 3)
                        txtTenDangNhap.SetError(dxErrorProvider, "Nhập tên đăng nhập ít nhất 3 ký tự", ref IsValid);
                    else
                        dxErrorProvider.ClearErrors();
                };
            txtMatKhau.Validating += (sender2, e2) =>
                {
                    if (string.IsNullOrEmpty(txtMatKhau.Text.Trim()))
                        txtMatKhau.SetError(dxErrorProvider, "Chưa nhập mật khẩu!", ref IsValid);
                    else
                        dxErrorProvider.ClearErrors();
                };
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

        private void btnCauHinhKetNoi_Click(object sender, EventArgs e)
        {
            IForm.ShowDialogForm(new frmConfig(), FormWindowState.Normal, System.Windows.Forms.FormBorderStyle.None);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!Validator(new [] { txtMatKhau, txtTenDangNhap})) return;

            USERSTATE state = SYS_NguoiDungCtrl.Login(txtTenDangNhap.Text, txtMatKhau.Text);

            switch (state)
            {
                case USERSTATE.ERROR:
                    INotify.ShowError("1. Kết nối đến máy chủ không thành công.\n2. Hoặc cơ sở dữ liệu không phù hợp.\n\n* Vui lòng kiểm tra lại thông tin đăng nhập hoặc kết nối cơ sở dữ liệu*", "Đăng nhập thất bại");
                    break;
                case USERSTATE.NOTEXIST:
                    INotify.ShowError("Tài khoản không tồn tại!", "Đăng nhập thất bại");
                    txtTenDangNhap.SetFocus();
                    break;
                case USERSTATE.WRONGPASSWORD:
                    INotify.ShowError("Mật khẩu không đúng!", "Đăng nhập thất bại");
                    txtMatKhau.SetFocus();
                    break;
                case USERSTATE.BEINGUSED:
                case USERSTATE.AUTHORIZE:
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    break;
                case USERSTATE.LOCK:
                    INotify.ShowError("Tài khoản hiện đang bị khóa!", "Đăng nhập thất bại");
                    break;
            }
        }
    }
}