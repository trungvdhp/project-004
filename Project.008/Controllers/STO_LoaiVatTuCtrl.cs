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
    public class STO_LoaiVatTuCtrl
    {
        public static void LoadBindingSource(BindingSource bindingSource, Context db = null)
        {
            if (db == null) db = new Context();

            bindingSource.DataSource = db.STO_LoaiVatTus.Where(w => w.Trang_thai == true).ToList();
        }

        public static void LoadBindingSource(BindingSource bindingSource, int id, Context db = null)
        {
            if (db == null) db = new Context();

            bindingSource.DataSource = db.STO_LoaiVatTus.Where(w => w.ID_nhom == id && w.Trang_thai == true).ToList();
        }

        public static List<STO_LoaiVatTu> LoadDataSource(Context db = null)
        {
            if (db == null) db = new Context();

            return db.STO_LoaiVatTus.Where(w => w.Trang_thai == true).ToList();
        }

        public static List<STO_LoaiVatTu> LoadDataSource(int id, Context db = null)
        {
            if (db == null) db = new Context();

            return db.STO_LoaiVatTus.Where(w => w.ID_nhom == id && w.Trang_thai == true).ToList();
        }

        public static bool Insert(STO_LoaiVatTu LoaiVatTu, Context db = null)
        {
            if (db == null) db = new Context();

            //var insertItem = db.STO_LoaiVatTus.SingleOrDefault(w => w.Ten_loai == LoaiVatTu.Ten_loai && w.ID_nhom == LoaiVatTu.ID_nhom);

            //if (insertItem != null) return false;

            var nhomVatTu = db.STO_NhomVatTus.Single(w => w.ID_nhom == LoaiVatTu.ID_nhom);

            var insertItem = new STO_LoaiVatTu
            {
                ID_nhom = LoaiVatTu.ID_nhom,
                Ten_loai = LoaiVatTu.Ten_loai,
                Ma_loai = nhomVatTu.Ma_nhom,
                Ghi_chu = string.Empty,
                Trang_thai = true
            };

            db.STO_LoaiVatTus.InsertOnSubmit(insertItem);

            db.SubmitChanges();

            return true;
        }

        public static bool Update(STO_LoaiVatTu LoaiVatTu, Context db = null)
        {
            if (db == null) db = new Context();

            var updateItem = db.STO_LoaiVatTus.SingleOrDefault(w => w.ID_loai == LoaiVatTu.ID_loai);

            if (updateItem == null) return false;

            updateItem.ID_nhom = LoaiVatTu.ID_nhom;
            updateItem.Ten_loai = LoaiVatTu.Ten_loai;
            updateItem.Ma_loai = LoaiVatTu.Ma_loai;
            updateItem.Ghi_chu = LoaiVatTu.Ghi_chu;

            db.SubmitChanges();

            return true;
        }

        public static bool Delete(STO_LoaiVatTu LoaiVatTu, Context db = null)
        {
            if (db == null) db = new Context();

            var deleteItem = db.STO_LoaiVatTus.SingleOrDefault(w => w.ID_loai == LoaiVatTu.ID_loai);

            if (deleteItem == null) return false;

            deleteItem.Trang_thai = false;
            //db.STO_LoaiVatTus.DeleteOnSubmit(deleteItem);

            db.SubmitChanges();

            return true;
        }

        public static void LoadDataSource(LookUpEdit lookUpEdit, int id, Context db = null)
        {
            if (db == null) db = new Context();

            lookUpEdit.Properties.Columns.Clear();
            lookUpEdit.Properties.DataSource = db.STO_LoaiVatTus.Where(w => w.ID_nhom == id && w.Trang_thai == true).ToList();
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_loai", 300, "Tên loại"));
            lookUpEdit.Properties.DisplayMember = "Ten_loai";
            lookUpEdit.Properties.ValueMember = "ID_loai";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn nhóm vật tư";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;

            lookUpEdit.ItemIndex = 0;
        }

        public static void LoadDataSource(RepositoryItemLookUpEdit lookUpEdit, Context db = null)
        {
            if (db == null) db = new Context();

            lookUpEdit.Columns.Clear();
            lookUpEdit.DataSource = db.STO_LoaiVatTus.Where(w => w.Trang_thai == true).ToList();
            lookUpEdit.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_loai", 300, "Tên loại"));
            lookUpEdit.DisplayMember = "Ten_loai";
            lookUpEdit.ValueMember = "ID_loai";
            lookUpEdit.NullText = string.Empty;
            lookUpEdit.NullValuePrompt = string.Empty;
            lookUpEdit.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
        }

        public static STO_LoaiVatTu GetItem(int id, Context db = null)
        {
            if (db == null) db = new Context();

            return db.STO_LoaiVatTus.SingleOrDefault(w => w.ID_loai == id && w.Trang_thai == true);
        }
    }
}
