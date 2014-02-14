using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project._004.Models;

namespace Project._004.Controllers
{
    public class CAT_NhanVienCtrl
    {
        public static void LoadDataSource(LookUpEdit lookUpEdit, Context db = null)
        {
            if (db == null) db = new Context();

            lookUpEdit.Properties.Columns.Clear();

            var nhanViens = (from p in db.CAT_NhanViens.Where(w => w.Trang_thai == true)
                            select new 
                            {
                                p.ID_nhan_vien,
                                Ho_ten = string.Format("{0} {1}", p.Ho_dem, p.Ten),
                            }).ToList();

            lookUpEdit.Properties.DataSource = nhanViens;
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ho_ten", "Nhân viên"));
            lookUpEdit.Properties.DisplayMember = "Ho_ten";
            lookUpEdit.Properties.ValueMember = "ID_nhan_vien";
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

            var nhanViens = (from p in db.CAT_NhanViens.Where(w => w.Trang_thai == true)
                             select new
                             {
                                 p.ID_nhan_vien,
                                 Ho_ten = string.Format("{0} {1}", p.Ho_dem, p.Ten),
                             }).ToList();

            lookUpEdit.DataSource = nhanViens;
            lookUpEdit.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ho_ten", "Nhân viên"));
            lookUpEdit.DisplayMember = "Ho_ten";
            lookUpEdit.ValueMember = "ID_nhan_vien";
            lookUpEdit.NullText = string.Empty;
            lookUpEdit.NullValuePrompt = string.Empty;
            lookUpEdit.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
        }
    }
}
