using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using Library;
using Library.Data;
using Project._008.Models;
using System.Windows.Forms;

namespace Project._008.Controllers
{

    public class SYS_NguoiDungCtrl
    {
        public static USERSTATE Login(string Tai_khoan, string Mat_khau, Context db = null)
        {
            if (db == null) db = new Context();

            try
            {
                string password = ISecurity.CreateSHAHash(Mat_khau);

                var users = db.SYS_NguoiDungs.Where(w => w.Tai_khoan == Tai_khoan).ToList();

                if (!users.Any()) return USERSTATE.NOTEXIST; //Người dùng không tồn tại

                var user = db.SYS_NguoiDungs.FirstOrDefault(w => w.Tai_khoan == Tai_khoan && w.Mat_khau == password);

                if (user == null) return USERSTATE.WRONGPASSWORD; //Sai mật khẩu

                if (user.ID_trang_thai == 1 || user.ID_trang_thai == 0)
                {
                    user.ID_trang_thai = 2;
                    user.Lan_dang_nhap_cuoi = DbHelper.GetDatabaseDate();
                    user.May_tram = MachineInfo.SystemInformation;

                    db.SubmitChanges();
                    Program.CurrentUser = user;

                    return USERSTATE.AUTHORIZE; //Đăng nhập thành công
                }
                else if (user.ID_trang_thai == 2)
                {
                    user.Lan_dang_nhap_cuoi = DbHelper.GetDatabaseDate();
                    user.May_tram = MachineInfo.SystemInformation;

                    db.SubmitChanges();
                    Program.CurrentUser = user;

                    return USERSTATE.BEINGUSED; //Tài khoản đang được sử dụng
                }
                else if (user.ID_trang_thai == 3)
                {
                    return USERSTATE.LOCK; //Tài khoản bị khóa
                }
            }
            catch (Exception)
            {
            }

            return USERSTATE.ERROR;
        }

        public static void LogOut(Context db = null)
        {
            if (Program.CurrentUser == null) return;

            if (db == null) db = new Context();

            var user = db.SYS_NguoiDungs.SingleOrDefault(t => t.ID_nguoi_dung == Program.CurrentUser.ID_nguoi_dung);

            user.ID_trang_thai = 1;

            db.SubmitChanges();
        }

        public static void LoadBindingSource(BindingSource bindingSource, Context db = null)
        {
            if (db == null) db = new Context();

            bindingSource.DataSource = db.SYS_NguoiDungs.OrderBy(o => o.Lan_dang_nhap_cuoi).ToList();
        }

        public static SYS_NguoiDung GetItem(int ID_nguoi_dung, Context db = null)
        {
            if (db == null) db = new Context();

            return db.SYS_NguoiDungs.SingleOrDefault(t => t.ID_nguoi_dung == ID_nguoi_dung);
        }

        public static int Insert(SYS_NguoiDung nguoiDung, Context db = null)
        {
            if (db == null) db = new Context();

            var items = db.SYS_NguoiDungs.Where(w => w.Tai_khoan == nguoiDung.Tai_khoan).ToList();

            if (items.Any()) return -1;

            db.SYS_NguoiDungs.InsertOnSubmit(nguoiDung);

            db.SubmitChanges();

            return 0;
        }

        public static void Update(SYS_NguoiDung nguoiDung, Context db = null)
        {
            if (nguoiDung == null) return;

            if (db == null) db = new Context();

            var updateItem = db.SYS_NguoiDungs.SingleOrDefault(w => w.ID_nguoi_dung == nguoiDung.ID_nguoi_dung);

            if (updateItem == null) return;

            updateItem.Tai_khoan = nguoiDung.Tai_khoan;
            updateItem.Mat_khau = ISecurity.CreateSHAHash(nguoiDung.Mat_khau);
            updateItem.Ten_day_du = nguoiDung.Ten_day_du;
            updateItem.ID_trang_thai = nguoiDung.ID_trang_thai;
            updateItem.ID_nhan_vien = nguoiDung.ID_nhan_vien;
            updateItem.Thoi_gian_cho = nguoiDung.Thoi_gian_cho;

            db.SubmitChanges();
        }

        public static void Update(SYS_VaiTro vaiTro, EXT_NguoiDung nguoiDung, Context db = null)
        {
            if (vaiTro == null || nguoiDung == null) return;

            if (db == null) db = new Context();

            if (nguoiDung.Trang_thai == true) //insert
            {
                var deleteItem = db.SYS_NguoiDungVaiTros.SingleOrDefault(w => w.ID_nguoi_dung == nguoiDung.View.ID_nguoi_dung);

                if (deleteItem != null) db.SYS_NguoiDungVaiTros.DeleteOnSubmit(deleteItem);

                var insertItem = new SYS_NguoiDungVaiTro
                {
                    ID_nguoi_dung = nguoiDung.View.ID_nguoi_dung,
                    ID_vai_tro = vaiTro.ID_vai_tro,
                };
                db.SYS_NguoiDungVaiTros.InsertOnSubmit(insertItem);
            }
            else //delete
            {
                var deleteItem = db.SYS_NguoiDungVaiTros.SingleOrDefault(w => w.ID_nguoi_dung == nguoiDung.View.ID_nguoi_dung);

                if (deleteItem != null) db.SYS_NguoiDungVaiTros.DeleteOnSubmit(deleteItem);
            }
            db.SubmitChanges();
        }

        /*
        public static void Update(SYS_VaiTro vaiTro, EXT_NguoiDung nguoiDung, Context db = null)
        {
            if (vaiTro == null || nguoiDung == null) return;

            if (db == null) db = new Context();

            if (nguoiDung.Trang_thai == true) //insert
            {
                var deleteItem = db.SYS_NguoiDungVaiTros.SingleOrDefault(w => w.ID_nguoi_dung == nguoiDung.View.ID_nguoi_dung);

                if (deleteItem != null) db.SYS_NguoiDungVaiTros.DeleteOnSubmit(deleteItem);

                var insertItem = new SYS_NguoiDungVaiTro
                {
                    ID_nguoi_dung = nguoiDung.View.ID_nguoi_dung,
                    ID_vai_tro = vaiTro.ID_vai_tro,
                };
                db.SYS_NguoiDungVaiTros.InsertOnSubmit(insertItem);
            }
            else //delete
            {
                var deleteItem = db.SYS_NguoiDungVaiTros.SingleOrDefault(w => w.ID_nguoi_dung == nguoiDung.View.ID_nguoi_dung);

                if (deleteItem != null) db.SYS_NguoiDungVaiTros.DeleteOnSubmit(deleteItem);
            }
            db.SubmitChanges();
        }

        public static void LoadDataSource(LookUpEdit lookUpEdit, Context db = null)
        {
            if (db == null) db = new Context();

            lookUpEdit.Properties.DataSource = db.SYS_NguoiDungs.ToList();
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_day_du", 100, "Người dùng"));
            lookUpEdit.Properties.DisplayMember = "Ten_day_du";
            lookUpEdit.Properties.ValueMember = "ID_nguoi_dung";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn người dùng";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;

            lookUpEdit.ItemIndex = 0;
        }

        public static void LoadDataSource(RepositoryItemLookUpEdit lookUpEdit, Context db = null)
        {
            if (db == null) db = new Context();
            lookUpEdit.DataSource = db.SYS_NguoiDungs.ToList();
            lookUpEdit.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_day_du", 100, "Người dùng"));
            lookUpEdit.DisplayMember = "Ten_day_du";
            lookUpEdit.ValueMember = "ID_nguoi_dung";
            lookUpEdit.NullText = string.Empty;
            lookUpEdit.NullValuePrompt = string.Empty;
            lookUpEdit.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
        }

        public static void LoadBindingSource(BindingSource bindingSource, Context db = null)
        {
            if (db == null) db = new Context();

            bindingSource.DataSource = db.SYS_NguoiDungs.OrderBy(o => o.Lan_dang_nhap_cuoi).ToList();
        }

        public static SYS_NguoiDung GetItem(int ID_nguoi_dung, Context db = null)
        {
            if (db == null) db = new Context();

            return db.SYS_NguoiDungs.SingleOrDefault(t => t.ID_nguoi_dung == ID_nguoi_dung);
        }

        public static int Insert(SYS_NguoiDung nguoiDung, Context db = null)
        {
            if (db == null) db = new Context();

            var items = db.SYS_NguoiDungs.Where(w => w.Tai_khoan == nguoiDung.Tai_khoan).ToList();

            if (items.Any()) return -1;

            db.SYS_NguoiDungs.InsertOnSubmit(nguoiDung);

            db.SubmitChanges();

            return 0;
        }
         * */
    }
}
