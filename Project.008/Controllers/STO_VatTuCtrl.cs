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
    public class STO_VatTuCtrl
    {
        public static void LoadBindingSource(BindingSource bindingSource, int id, Context db = null)
        {
            if (db == null) db = new Context();

            bindingSource.DataSource = db.viewSTOVatTus.Where(w => w.ID_loai == id && w.Trang_thai == true).ToList();
        }

        public static bool Insert(viewSTOVatTu view, Context db = null)
        {
            if (db == null) db = new Context();

            //var insertItem = db.STO_VatTus.SingleOrDefault(w => w.Ten_vat_tu == view.Ten_vat_tu && w.ID_loai == view.ID_loai);

            //if (insertItem != null) return false;

            var insertItem = new STO_VatTu
            {
                ID_loai = view.ID_loai,
                Ma_vat_tu = view.Ma_vat_tu,
                Ten_vat_tu = view.Ten_vat_tu,
                ID_don_vi = view.ID_don_vi,
                Khau_do = view.Khau_do,
                Trong_luong = view.Trong_luong,
                Do_cao = view.Do_cao,
                Do_day = view.Do_day,
                Do_rong = view.Do_rong,
                Trang_thai = true
            };

            db.STO_VatTus.InsertOnSubmit(insertItem);

            db.SubmitChanges();

            return true;
        }

        public static bool Update(viewSTOVatTu view, Context db = null)
        {
            if (db == null) db = new Context();

            var updateItem = db.STO_VatTus.SingleOrDefault(w => w.ID_vat_tu == view.ID_vat_tu);

            if (updateItem == null) return false;

            updateItem.ID_loai = view.ID_loai;
            updateItem.Ma_vat_tu = view.Ma_vat_tu;
            updateItem.Ten_vat_tu = view.Ten_vat_tu;
            updateItem.ID_don_vi = view.ID_don_vi;
            updateItem.Khau_do = view.Khau_do;
            updateItem.Trong_luong = view.Trong_luong;
            updateItem.Do_cao = view.Do_cao;
            updateItem.Do_day = view.Do_day;
            updateItem.Do_rong = view.Do_rong;
            updateItem.Trang_thai = true;

            db.SubmitChanges();

            return true;
        }

        public static bool Delete(viewSTOVatTu view, Context db = null)
        {
            if (db == null) db = new Context();

            var deleteItem = db.STO_VatTus.SingleOrDefault(w => w.ID_vat_tu == view.ID_vat_tu);

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
            lookUpEdit.Properties.DataSource = db.STO_VatTus.Where(w => w.ID_loai == id && w.Trang_thai == true).ToList();
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_vat_tu", 300, "Vật tư"));
            lookUpEdit.Properties.DisplayMember = "Ten_vat_tu";
            lookUpEdit.Properties.ValueMember = "ID_vat_tu";
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
            lookUpEdit.DataSource = db.STO_VatTus.Where(w => w.Trang_thai == true).ToList();
            lookUpEdit.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_vat_tu", 300, "Vật tư"));
            lookUpEdit.DisplayMember = "Ten_vat_tu";
            lookUpEdit.ValueMember = "ID_vat_tu";
            lookUpEdit.NullText = string.Empty;
            lookUpEdit.NullValuePrompt = string.Empty;
            lookUpEdit.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
        }

        public static STO_VatTu GetItem(int id, Context db = null)
        {
            if (db == null) db = new Context();

            return db.STO_VatTus.SingleOrDefault(w => w.ID_vat_tu == id && w.Trang_thai == true);
        }

        public static void Insert(STO_VatTu entity, Context db = null)
        {
            if (db == null) db = new Context();

            //var insertItem = new STO_VatTu
            //{
            //    ID_loai = entity.ID_loai,
            //    Ma_vat_tu = entity.Ma_vat_tu,
            //    Ten_vat_tu = entity.Ten_vat_tu,
            //    ID_don_vi = entity.ID_don_vi,
            //    Khau_do = entity.Khau_do,
            //    Trong_luong = entity.Trong_luong,
            //    Mo_ta = null,
            //    Trang_thai = true
            //};

            //db.STO_VatTus.InsertOnSubmit(insertItem);

            db.SubmitChanges();
        }

        public static decimal GetDonGia(int ID_kho_tt, int Id_vat_tu, Context db = null)
        {
            if (db == null) db = new Context();

            var items = db.STO_KhoVatTuCTs.Where(w => w.ID_kho_tt == ID_kho_tt && w.ID_vat_tu == Id_vat_tu).ToList();

            if (items.Any())
            {
                var item = items.OrderBy(o => o.ID_phieu_nhap).ToList().Last();

                return item.Don_gia_xuat == null ? 0 : item.Don_gia_xuat.Value;
            }
            else
            {
                return 0;
            }
            return 0;
        }

        public static decimal GetSoLuong(int ID_kho_tt, int Id_vat_tu, Context db = null)
        {
            if (db == null) db = new Context();

            var items = db.STO_KhoVatTuCTs.Where(w => w.ID_kho_tt == ID_kho_tt && w.ID_vat_tu == Id_vat_tu).ToList();

            if (items.Any())
            {
                var item = items.OrderBy(o => o.ID_phieu_nhap).ToList().Last();

                return item.So_luong == 0 ? 0 : item.So_luong;
            }
            else
            {
                return 0;
            }
            return 0;
        }
    }
}
