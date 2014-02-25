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
    public class STO_NhomVatTuCtrl
    {
        public static void LoadBindingSource(BindingSource bindingSource, Context db = null)
        {
            if (db == null) db = new Context();

            bindingSource.DataSource = db.STO_NhomVatTus.Where(w => w.Trang_thai == true).ToList();
        }

        public static void LoadBindingSource(BindingSource bindingSource, int id, Context db = null)
        {
            if (db == null) db = new Context();

            bindingSource.DataSource = db.STO_NhomVatTus.Where(w => w.ID_kho == id && w.Trang_thai == true).ToList();
        }

        public static List<STO_NhomVatTu> LoadDataSource(Context db = null)
        {
            if (db == null) db = new Context();

            return db.STO_NhomVatTus.Where(w => w.Trang_thai == true).ToList();
        }

        public static List<STO_NhomVatTu> LoadDataSource(int id, Context db = null)
        {
            if (db == null) db = new Context();

            return db.STO_NhomVatTus.Where(w => w.ID_kho == id && w.Trang_thai == true).ToList();
        }

        public static bool Insert(STO_NhomVatTu NhomVatTu, Context db = null)
        {
            if (db == null) db = new Context();

            //var insertItem = db.STO_NhomVatTus.SingleOrDefault(w => w.Ten_nhom == NhomVatTu.Ten_nhom && w.ID_kho == NhomVatTu.ID_kho);

            //if (insertItem != null) return false;

            var insertItem = new STO_NhomVatTu
            {
                ID_kho = NhomVatTu.ID_kho,
                Ten_nhom = NhomVatTu.Ten_nhom,
                Ma_nhom = NhomVatTu.Ma_nhom,
                Ghi_chu = NhomVatTu.Ghi_chu,
                Trang_thai = true
            };

            db.STO_NhomVatTus.InsertOnSubmit(insertItem);

            db.SubmitChanges();

            return true;
        }

        public static bool Update(STO_NhomVatTu NhomVatTu, Context db = null)
        {
            if (db == null) db = new Context();

            var updateItem = db.STO_NhomVatTus.SingleOrDefault(w => w.ID_nhom == NhomVatTu.ID_nhom);

            if (updateItem == null) return false;

            updateItem.ID_kho = NhomVatTu.ID_kho;
            updateItem.Ten_nhom = NhomVatTu.Ten_nhom;
            updateItem.Ma_nhom = NhomVatTu.Ma_nhom;
            updateItem.Ghi_chu = NhomVatTu.Ghi_chu;

            db.SubmitChanges();

            return true;
        }

        public static bool Delete(STO_NhomVatTu NhomVatTu, Context db = null)
        {
            if (db == null) db = new Context();

            var deleteItem = db.STO_NhomVatTus.SingleOrDefault(w => w.ID_nhom == NhomVatTu.ID_nhom);

            if (deleteItem == null) return false;

            deleteItem.Trang_thai = false;
            //db.STO_NhomVatTus.DeleteOnSubmit(deleteItem);

            db.SubmitChanges();

            return true;
        }

        public static void LoadDataSource(LookUpEdit lookUpEdit, int id, Context db = null)
        {
            if (db == null) db = new Context();

            lookUpEdit.Properties.Columns.Clear();
            lookUpEdit.Properties.DataSource = db.STO_NhomVatTus.Where(w => w.ID_kho == id && w.Trang_thai == true).ToList();
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_nhom", 300,"Tên nhóm"));
            lookUpEdit.Properties.DisplayMember = "Ten_nhom";
            lookUpEdit.Properties.ValueMember = "ID_nhom";
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
            lookUpEdit.DataSource = db.STO_NhomVatTus.Where(w => w.Trang_thai == true).ToList();
            lookUpEdit.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_nhom", 300, "Tên nhóm"));
            lookUpEdit.DisplayMember = "Ten_nhom";
            lookUpEdit.ValueMember = "ID_nhom";
            lookUpEdit.NullText = string.Empty;
            lookUpEdit.NullValuePrompt = string.Empty;
            lookUpEdit.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
        }

        public static STO_NhomVatTu GetItem(int id, Context db = null)
        {
            if (db == null) db = new Context();

            return db.STO_NhomVatTus.SingleOrDefault(w => w.ID_nhom == id && w.Trang_thai == true);
        }
    }
}
