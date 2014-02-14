using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using Project._004.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project._004.Controllers
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
    }
}
