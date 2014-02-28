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
    public class STO_KhoCtrl
    {
        public static void LoadBindingSource(BindingSource bindingSource, Context db = null)
        {
            if (db == null) db = new Context();

            bindingSource.DataSource = db.STO_Khos.OrderBy(o => o.Dia_diem).ToList();
        }

        public static void Insert(STO_Kho dvt, Context db = null)
        {
            if (db == null) db = new Context();

            var exist = db.STO_Khos.Where(w => w.Dia_diem == dvt.Dia_diem).ToList();

            if (exist.Any()) return;

            var insertItem = new STO_Kho { Dia_diem = dvt.Dia_diem };

            db.STO_Khos.InsertOnSubmit(insertItem);

            db.SubmitChanges();
        }

        public static void Update(STO_Kho dvt, Context db = null)
        {
            if (db == null) db = new Context();

            var insertItem = db.STO_Khos.SingleOrDefault(w => w.ID_kho_tt == dvt.ID_kho_tt);

            if (insertItem == null) return;

            insertItem.Dia_diem = dvt.Dia_diem;

            db.SubmitChanges();
        }

        public static void Delete(STO_Kho dvt, Context db = null)
        {
            if (db == null) db = new Context();

            var deleteItem = db.STO_Khos.SingleOrDefault(w => w.ID_kho_tt == dvt.ID_kho_tt);

            if (deleteItem == null) return;

            db.STO_Khos.DeleteOnSubmit(deleteItem);

            db.SubmitChanges();
        }

        public static void LoadDataSource(LookUpEdit lookUpEdit, Context db = null)
        {
            if (db == null) db = new Context();

            lookUpEdit.Properties.Columns.Clear();
            lookUpEdit.Properties.DataSource = db.STO_Khos.ToList();
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Dia_diem", "Địa điểm"));
            lookUpEdit.Properties.DisplayMember = "Dia_diem";
            lookUpEdit.Properties.ValueMember = "ID_kho_tt";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn địa điểm";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;

            lookUpEdit.ItemIndex = 0;
        }

        public static void LoadDataSource(RepositoryItemLookUpEdit lookUpEdit, Context db = null)
        {
            if (db == null) db = new Context();

            lookUpEdit.Columns.Clear();
            lookUpEdit.DataSource = db.STO_Khos.ToList();
            lookUpEdit.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Dia_diem", "Địa điểm"));
            lookUpEdit.DisplayMember = "Dia_diem";
            lookUpEdit.ValueMember = "ID_kho_tt";
            lookUpEdit.NullText = string.Empty;
            lookUpEdit.NullValuePrompt = string.Empty;
            lookUpEdit.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
        }
    }
}
