using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using Project._008.Models;

namespace Project._008.Controllers
{

    public class STO_KhoVatTuCtrl
    {
        public static void LoadBindingSource(BindingSource bindingSource, Context db = null)
        {
            if (db == null) db = new Context();

            bindingSource.DataSource = db.STO_KhoVatTus.Where(w => w.Trang_thai == true).ToList();
        }

        public static List<STO_KhoVatTu> LoadDataSource(Context db = null)
        {
            if (db == null) db = new Context();

            return db.STO_KhoVatTus.Where(w => w.Trang_thai == true).ToList();
        }

        public static STO_KhoVatTu GetItem(int id, Context db = null)
        {
            if (db == null) db = new Context();

            return db.STO_KhoVatTus.SingleOrDefault(w => w.ID_kho == id && w.Trang_thai == true);
        }

        public static bool Insert(STO_KhoVatTu KhoVatTu, Context db = null)
        {
            if (db == null) db = new Context();

            var insertItem = db.STO_KhoVatTus.SingleOrDefault(w => w.Ten_kho == KhoVatTu.Ten_kho && w.Dia_diem == KhoVatTu.Dia_diem);

            if (insertItem != null) return false;

            insertItem = new STO_KhoVatTu
            {
                Ten_kho = KhoVatTu.Ten_kho,
                Dia_diem = KhoVatTu.Dia_diem,
                Trang_thai = true
            };

            db.STO_KhoVatTus.InsertOnSubmit(insertItem);

            db.SubmitChanges();

            return true;
        }

        public static bool Update(STO_KhoVatTu KhoVatTu, Context db = null)
        {
            if (db == null) db = new Context();

            var updateItem = db.STO_KhoVatTus.SingleOrDefault(w => w.ID_kho == KhoVatTu.ID_kho);

            if (updateItem == null) return false;

            updateItem.Ten_kho = KhoVatTu.Ten_kho;
            updateItem.Dia_diem = KhoVatTu.Dia_diem;

            db.SubmitChanges();

            return true;
        }

        public static void LoadDataSource(LookUpEdit lookUpEdit, Context db = null)
        {
            if (db == null) db = new Context();

            lookUpEdit.Properties.Columns.Clear();
            lookUpEdit.Properties.DataSource = db.STO_KhoVatTus.Where(w => w.Trang_thai == true).ToList();
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_kho", "Tên kho"));
            lookUpEdit.Properties.DisplayMember = "Ten_kho";
            lookUpEdit.Properties.ValueMember = "ID_kho";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn kho vật tư";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
            
            lookUpEdit.ItemIndex = 0;
        }

        public static void LoadDataSource(RepositoryItemLookUpEdit lookUpEdit, Context db = null)
        {
            if (db == null) db = new Context();

            lookUpEdit.Columns.Clear();
            lookUpEdit.DataSource = db.STO_KhoVatTus.Where(w => w.Trang_thai == true).ToList();
            lookUpEdit.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_kho", "Tên kho"));
            lookUpEdit.DisplayMember = "Ten_kho";
            lookUpEdit.ValueMember = "ID_kho";
            lookUpEdit.NullText = string.Empty;
            lookUpEdit.NullValuePrompt = string.Empty;
            lookUpEdit.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
        }

    }
}
