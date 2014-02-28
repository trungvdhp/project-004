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
    public class CAT_KhachHangCtrl
    {
        public static void LoadBindingSource(BindingSource bindingSource, Context db = null)
        {
            if (db == null) db = new Context();

            bindingSource.DataSource = db.CAT_KhachHangs.Where(w => w.Trang_thai == true).ToList();
        }

        public static List<CAT_KhachHang> LoadDataSource(Context db = null)
        {
            if (db == null) db = new Context();

            return db.CAT_KhachHangs.Where(w => w.Trang_thai == true).ToList();
        }

        public static CAT_KhachHang GetItem(int id, Context db = null)
        {
            if (db == null) db = new Context();

            return db.CAT_KhachHangs.SingleOrDefault(w => w.ID_khach_hang == id && w.Trang_thai == true);
        }

        public static bool Insert(CAT_KhachHang khachHang, Context db = null)
        {
            if (db == null) db = new Context();

            //var insertItem = db.CAT_KhachHangs.SingleOrDefault(w => w.Ho_dem == khachHang.Ho_dem && w.Ten == khachHang.Ten && w.Dia_chi == khachHang.Dia_chi);

            //if (insertItem != null) return false;

            var insertItem = new CAT_KhachHang
            {
                Ho_dem = khachHang.Ho_dem,
                Ten = khachHang.Ten,
                Dia_chi = khachHang.Dia_chi,
                Dien_thoai = khachHang.Dien_thoai,
                Trang_thai = true
            };

            db.CAT_KhachHangs.InsertOnSubmit(insertItem);

            db.SubmitChanges();

            return true;
        }

        public static bool Update(CAT_KhachHang khachHang, Context db = null)
        {
            if (db == null) db = new Context();

            var updateItem = db.CAT_KhachHangs.SingleOrDefault(w => w.ID_khach_hang == khachHang.ID_khach_hang);

            if (updateItem == null) return false;

            updateItem.Ho_dem = khachHang.Ho_dem;
            updateItem.Ten = khachHang.Ten;
            updateItem.Dia_chi = khachHang.Dia_chi;
            updateItem.Dien_thoai = khachHang.Dien_thoai;

            db.SubmitChanges();

            return true;
        }

        public static bool Delete(CAT_KhachHang khachHang, Context db = null)
        {
            if (db == null) db = new Context();

            var deleteItem = db.CAT_KhachHangs.SingleOrDefault(w => w.ID_khach_hang == khachHang.ID_khach_hang);

            if (deleteItem == null) return false;

            deleteItem.Trang_thai = false;
            //db.STO_LoaiVatTus.DeleteOnSubmit(deleteItem);

            db.SubmitChanges();

            return true;
        }

        public static void LoadDataSource(LookUpEdit lookUpEdit, Context db = null)
        {
            if (db == null) db = new Context();

            lookUpEdit.Properties.Columns.Clear();
            lookUpEdit.Properties.DataSource = db.CAT_KhachHangs.Where(w => w.Trang_thai == true).Select(s => new { s.ID_khach_hang, Ho_ten = String.Format("{0} {1}", s.Ho_dem, s.Ten), s.Dien_thoai, s.Dia_chi }).ToList();
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ho_ten", 100, "Tên khách hàng"));
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Dia_chi", 200, "Địa chỉ"));
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Dien_thoai", 50,"Điện thoại"));
            lookUpEdit.Properties.DisplayMember = "Ho_ten";
            lookUpEdit.Properties.ValueMember = "ID_khach_hang";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn khách hàng";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;

            lookUpEdit.ItemIndex = 0;
        }

        public static void LoadDataSource(RepositoryItemLookUpEdit lookUpEdit, Context db = null)
        {
            if (db == null) db = new Context();

            lookUpEdit.Columns.Clear();
            lookUpEdit.DataSource = db.CAT_KhachHangs.Where(w => w.Trang_thai == true).Select(s => new { s.ID_khach_hang, Ho_ten = String.Format("{0} {1}", s.Ho_dem, s.Ten), s.Dien_thoai, s.Dia_chi }).ToList();
            lookUpEdit.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ho_ten", 100, "Tên khách hàng"));
            lookUpEdit.DisplayMember = "Ho_ten";
            lookUpEdit.ValueMember = "ID_khach_hang";
            lookUpEdit.NullText = string.Empty;
            lookUpEdit.NullValuePrompt = string.Empty;
            lookUpEdit.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
        }
    }
}
