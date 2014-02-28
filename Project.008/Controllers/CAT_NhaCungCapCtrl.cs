using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using Project._008.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project._008.Controllers
{
    public class CAT_NhaCungCapCtrl
    {                                                                                   
        public static void LoadBindingSource(BindingSource bindingSource, Context db = null)
        {
            if (db == null) db = new Context();

            bindingSource.DataSource = db.CAT_NhaCungCaps.Where(w => w.Trang_thai == true).ToList();
        }

        public static List<CAT_NhaCungCap> LoadDataSource(Context db = null)
        {
            if (db == null) db = new Context();

            return db.CAT_NhaCungCaps.Where(w => w.Trang_thai == true).ToList();
        }

        public static bool Insert(CAT_NhaCungCap ncc, Context db = null)
        {
            if (db == null) db = new Context();

            //var insertItem = db.CAT_KhachHangs.SingleOrDefault(w => w.Ho_dem == khachHang.Ho_dem && w.Ten == khachHang.Ten && w.Dia_chi == khachHang.Dia_chi);

            //if (insertItem != null) return false;

            var insertItem = new CAT_NhaCungCap
            {
                Ten_nha_cung_cap = ncc.Ten_nha_cung_cap,
                Nguoi_dai_dien = ncc.Nguoi_dai_dien,
                Dien_thoai = ncc.Dien_thoai,
                Dia_chi = ncc.Dia_chi,
                Email = ncc.Email,
                So_tai_khoan = ncc.So_tai_khoan,
                Ngan_hang = ncc.Ngan_hang,
                Trang_thai = true
            };

            db.CAT_NhaCungCaps.InsertOnSubmit(insertItem);

            db.SubmitChanges();

            return true;
        }

        public static bool Update(CAT_NhaCungCap ncc, Context db = null)
        {
            if (db == null) db = new Context();

            var updateItem = db.CAT_NhaCungCaps.SingleOrDefault(w => w.ID_nha_cung_Cap == ncc.ID_nha_cung_Cap);

            if (updateItem == null) return false;

            updateItem.Ten_nha_cung_cap = ncc.Ten_nha_cung_cap;
            updateItem.Nguoi_dai_dien = ncc.Nguoi_dai_dien;
            updateItem.Dien_thoai = ncc.Dien_thoai;
            updateItem.Dia_chi = ncc.Dia_chi;
            updateItem.Email = ncc.Email;
            updateItem.So_tai_khoan = ncc.So_tai_khoan;
            updateItem.Ngan_hang = ncc.Ngan_hang;

            db.SubmitChanges();

            return true;
        }

        public static bool Delete(CAT_NhaCungCap ncc, Context db = null)
        {
            if (db == null) db = new Context();

            var deleteItem = db.CAT_NhaCungCaps.SingleOrDefault(w => w.ID_nha_cung_Cap == ncc.ID_nha_cung_Cap);

            if (deleteItem == null) return false;

            deleteItem.Trang_thai = false;

            db.SubmitChanges();

            return true;
        }

        public static void LoadDataSource(LookUpEdit lookUpEdit, Context db = null)
        {
            if (db == null) db = new Context();

            lookUpEdit.Properties.Columns.Clear();
            lookUpEdit.Properties.DataSource = db.CAT_NhaCungCaps.Where(w => w.Trang_thai == true).ToList();
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_nha_cung_cap", "Nhà cung cấp"));
            lookUpEdit.Properties.DisplayMember = "Ten_nha_cung_cap";
            lookUpEdit.Properties.ValueMember = "ID_nha_cung_Cap";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn nhà cung cấp";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;

            lookUpEdit.ItemIndex = 0;
        }

        public static void LoadDataSource(RepositoryItemLookUpEdit lookUpEdit, Context db = null)
        {
            if (db == null) db = new Context();

            lookUpEdit.Columns.Clear();
            lookUpEdit.DataSource = db.CAT_NhaCungCaps.ToList();
            lookUpEdit.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_nha_cung_cap", "Nhà cung cấp"));
            lookUpEdit.DisplayMember = "Ten_nha_cung_cap";
            lookUpEdit.ValueMember = "ID_nha_cung_Cap";
            lookUpEdit.NullText = string.Empty;
            lookUpEdit.NullValuePrompt = string.Empty;
            lookUpEdit.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
        }
    }
}
