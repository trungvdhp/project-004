using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project._008.Controllers
{
    public class SYS_PhongBanCtrl
    {
        public static void LoadDataSource(DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpEdit, Context db = null)
        {
            if (db == null) db = new Context();

            lookUpEdit.Columns.Clear();
            lookUpEdit.DataSource = db.CAT_PhongBans.ToList();
            lookUpEdit.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_phong", "Phòng"));
            lookUpEdit.DisplayMember = "Ten_phong";
            lookUpEdit.ValueMember = "ID_phong";
            lookUpEdit.NullText = string.Empty;
            lookUpEdit.NullValuePrompt = string.Empty;
            lookUpEdit.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
        }
    }
}
