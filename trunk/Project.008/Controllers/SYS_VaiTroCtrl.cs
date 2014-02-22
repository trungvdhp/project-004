using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using Project._008.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project._008.Controllers
{
    public class SYS_VaiTroCtrl
    {
        public static void LoadDataSource(LookUpEdit lookUpEdit, Context db = null)
        {
            if (db == null) db = new Context();

            lookUpEdit.Properties.Columns.Clear();

            var vaiTros = new List<SYS_VaiTro>();
            
            if (Program.CurrentUser != null && Program.CurrentUser.ID_nhan_vien == null) 
                vaiTros.Add(new SYS_VaiTro { ID_vai_tro = 0, Ten_vai_tro = "Admin" });

            vaiTros.AddRange(db.SYS_VaiTros.ToList());

            lookUpEdit.Properties.DataSource = vaiTros;
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_vai_tro", "Vai trò"));
            lookUpEdit.Properties.DisplayMember = "Ten_vai_tro";
            lookUpEdit.Properties.ValueMember = "ID_vai_tro";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn vai trò";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;

            lookUpEdit.ItemIndex = 0;
        }
        public static List<SYS_VaiTro> LoadDataSource(Context db = null)
        {
            if (db == null) db = new Context();

            return db.SYS_VaiTros.ToList();
        }

        public static void LoadDataSource(RepositoryItemLookUpEdit lookUpEdit, Context db = null)
        {
            if (db == null) db = new Context();

            lookUpEdit.Columns.Clear();
            lookUpEdit.DataSource = db.SYS_VaiTros.ToList();
            lookUpEdit.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_vai_tro", "Vai trò"));
            lookUpEdit.DisplayMember = "Ten_vai_tro";
            lookUpEdit.ValueMember = "ID_vai_tro";
            lookUpEdit.NullText = string.Empty;
            lookUpEdit.NullValuePrompt = string.Empty;
            lookUpEdit.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
        }

        public static void Insert(SYS_VaiTro entity, Context db = null)
        {
            if (entity == null) return;

            if (db == null) db = new Context();

            var insertItem = new SYS_VaiTro
            {
                Ten_vai_tro = entity.Ten_vai_tro,
                ID_cha = entity.ID_cha,
                Mo_ta = entity.Mo_ta,
            };

            db.SYS_VaiTros.InsertOnSubmit(insertItem);

            db.SubmitChanges();
        }

        public static void Update(SYS_VaiTro entity, Context db = null)
        {
            if (entity == null) return;

            if (db == null) db = new Context();

            var updateItem = db.SYS_VaiTros.SingleOrDefault(w => w.ID_vai_tro == entity.ID_vai_tro);

            if (updateItem == null) return;

            updateItem.Ten_vai_tro = entity.Ten_vai_tro;
            updateItem.ID_cha = entity.ID_cha;
            updateItem.Mo_ta = entity.Mo_ta;

            db.SubmitChanges();
        }

        public static void Delete(SYS_VaiTro entity, Context db = null)
        {
            if (entity == null) return;

            if (db == null) db = new Context();

            var deleteItem = db.SYS_VaiTros.SingleOrDefault(w => w.ID_vai_tro == entity.ID_vai_tro);

            if (deleteItem == null) return;

            db.SYS_VaiTros.DeleteOnSubmit(deleteItem);

            db.SubmitChanges();
        }
    }
}
