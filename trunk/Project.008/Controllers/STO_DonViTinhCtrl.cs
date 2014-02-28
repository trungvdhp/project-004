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
    public class STO_DonViTinhCtrl
    {
        public static void LoadDataSource(LookUpEdit lookUpEdit, Context db = null)
        {
            if (db == null) db = new Context();

            lookUpEdit.Properties.Columns.Clear();
            lookUpEdit.Properties.DataSource = db.STO_DonViTinhs.ToList();
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_don_vi", 300, "Đơn vị"));
            lookUpEdit.Properties.DisplayMember = "Ten_don_vi";
            lookUpEdit.Properties.ValueMember = "ID_don_vi";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn đơn vị tính";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;

            lookUpEdit.ItemIndex = -1;
        }

        public static void LoadDataSource(RepositoryItemLookUpEdit lookUpEdit, Context db = null)
        {
            if (db == null) db = new Context();

            lookUpEdit.Columns.Clear();
            lookUpEdit.DataSource = db.STO_DonViTinhs.ToList();
            lookUpEdit.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_don_vi", 300, "Đơn vị"));
            lookUpEdit.DisplayMember = "Ten_don_vi";
            lookUpEdit.ValueMember = "ID_don_vi";
            lookUpEdit.NullText = string.Empty;
            lookUpEdit.NullValuePrompt = string.Empty;
            lookUpEdit.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
        }

        public static void LoadBindingSource(BindingSource bindingSource, Context db = null)
        {
            if (db == null) db = new Context();

            bindingSource.DataSource = db.STO_DonViTinhs.OrderBy(o => o.Ten_don_vi).ToList();
        }

        public static void Insert(STO_DonViTinh dvt, Context db = null)
        {
            if (db == null) db = new Context();

            var exist = db.STO_DonViTinhs.Where(w => w.Ten_don_vi == dvt.Ten_don_vi).ToList();

            if (exist.Any()) return;

            var insertItem = new STO_DonViTinh { Ten_don_vi = dvt.Ten_don_vi };

            db.STO_DonViTinhs.InsertOnSubmit(insertItem);

            db.SubmitChanges();
        }

        public static void Update(STO_DonViTinh dvt, Context db = null)
        {
            if (db == null) db = new Context();

            var insertItem = db.STO_DonViTinhs.SingleOrDefault(w => w.ID_don_vi == dvt.ID_don_vi);

            if (insertItem == null) return;

            insertItem.Ten_don_vi = dvt.Ten_don_vi;

            db.SubmitChanges();
        }

        public static void Delete(STO_DonViTinh dvt, Context db = null)
        {
            if (db == null) db = new Context();

            var deleteItem = db.STO_DonViTinhs.SingleOrDefault(w => w.ID_don_vi == dvt.ID_don_vi);

            if (deleteItem == null) return;

            db.STO_DonViTinhs.DeleteOnSubmit(deleteItem);

            db.SubmitChanges();
        }
    }
}
