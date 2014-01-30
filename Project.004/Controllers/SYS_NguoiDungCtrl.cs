using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;

namespace Project._004.Controllers
{
    using Library;
    using Library.Data;
    using Project._004.Models;

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

                var user = db.SYS_NguoiDungs.SingleOrDefault(w => w.Tai_khoan == Tai_khoan && w.Mat_khau == password);

                if (user == null) return USERSTATE.WRONGPASSWORD; //Sai mật khẩu

                if (user.ID_trang_thai == 1 || user.ID_trang_thai == 0)
                {
                    user.ID_trang_thai = 2;
                    user.Lan_dang_nhap_cuoi = DbHelper.GetDatabaseDate();
                    user.May_tram = MachineInfo.GetMachineInfo();

                    db.SubmitChanges();
                    Program.CurrentUser = user;

                    return USERSTATE.AUTHORIZE; //Đăng nhập thành công
                }
                else if (user.ID_trang_thai == 2)
                {
                    user.Lan_dang_nhap_cuoi = DbHelper.GetDatabaseDate();
                    user.May_tram = MachineInfo.GetMachineInfo();

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

        //public static SYS_NguoiDung GetNguoiDung(int ID_nguoi_dung, Context db = null)
        //{
        //    try
        //    {
        //        if (db == null) db = new Context();

        //        return db.SYS_NguoiDungs.SingleOrDefault(t => t.ID_nguoi_dung == ID_nguoi_dung);
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }
        //}

        //public static void Update(SYS_VaiTro vaiTro, EXT_NguoiDung nguoiDung, Context db = null)
        //{
        //    if (vaiTro == null || nguoiDung == null) return;

        //    if (db == null) db = new Context();

        //    if (nguoiDung.Trang_thai == true) //insert
        //    {
        //        var deleteItem = db.SYS_NguoiDungVaiTros.SingleOrDefault(w => w.ID_nguoi_dung == nguoiDung.View.ID_nguoi_dung);

        //        if (deleteItem != null) db.SYS_NguoiDungVaiTros.DeleteOnSubmit(deleteItem);

        //        var insertItem = new SYS_NguoiDungVaiTro
        //        {
        //            ID_nguoi_dung = nguoiDung.View.ID_nguoi_dung,
        //            ID_vai_tro = vaiTro.ID_vai_tro,
        //        };
        //        db.SYS_NguoiDungVaiTros.InsertOnSubmit(insertItem);
        //    }
        //    else //delete
        //    {
        //        var deleteItem = db.SYS_NguoiDungVaiTros.SingleOrDefault(w => w.ID_nguoi_dung == nguoiDung.View.ID_nguoi_dung);

        //        if (deleteItem != null) db.SYS_NguoiDungVaiTros.DeleteOnSubmit(deleteItem);
        //    }
        //    db.SubmitChanges();
        //}

        //public static void LoadDataSource(LookUpEdit lookUpEdit, Context db = null)
        //{
        //    if (db == null) db = new Context();

        //    lookUpEdit.Properties.DataSource = db.SYS_NguoiDungs.ToList();
        //    lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_day_du", 100, "Người dùng"));
        //    lookUpEdit.Properties.DisplayMember = "Ten_day_du";
        //    lookUpEdit.Properties.ValueMember = "ID_nguoi_dung";
        //    lookUpEdit.Properties.NullText = "";
        //    lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn người dùng";
        //    lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
        //    lookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;

        //    lookUpEdit.ItemIndex = 0;
        //}

        //public static void LoadDataSource(RepositoryItemLookUpEdit lookUpEdit, Context db = null)
        //{
        //    if (db == null) db = new Context();
        //    lookUpEdit.DataSource = db.SYS_NguoiDungs.ToList();
        //    lookUpEdit.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_day_du", 100, "Người dùng"));
        //    lookUpEdit.DisplayMember = "Ten_day_du";
        //    lookUpEdit.ValueMember = "ID_nguoi_dung";
        //    lookUpEdit.NullText = string.Empty;
        //    lookUpEdit.NullValuePrompt = string.Empty;
        //    lookUpEdit.NullValuePromptShowForEmptyValue = true;
        //    lookUpEdit.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
        //}
    }
}
