using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using Project._008.Models;

namespace Project._008.Controllers
{
    public class CAT_NhanVienCtrl
    {
        public static string GetPhongBan(int ID_nhan_vien, Context db = null)
        {
            if (db == null) db = new Context();

            var phongBan = (from p in db.CAT_NhanViens.Where(w => w.ID_nhan_vien == ID_nhan_vien)
                           join p1 in db.CAT_PhongBans on p.ID_phong equals p1.ID_phong
                           select p1).Single();

            return phongBan.Ten_phong;
        }

        public static void LoadBindingSource(BindingSource bindingSource, Context db = null)
        {
            if (db == null) db = new Context();

            bindingSource.DataSource = db.CAT_NhanViens.Where(w => w.Trang_thai == true).ToList();
        }

        public static void LoadBindingSource(BindingSource bindingSource, SYS_VaiTro vaiTro, Context db = null)
        {
            if (db == null) db = new Context();

            var result = new List<EXT_NguoiDung>();

            if (vaiTro != null)
            {
                result = (from p1 in db.viewNguoiDungs.Where(w => w.ID_nhan_vien != null && w.Trang_thai == true)
                          join p2 in db.SYS_NguoiDungVaiTros on p1.ID_nguoi_dung equals p2.ID_nguoi_dung into joined2
                          from j2 in joined2.DefaultIfEmpty()
                          select new EXT_NguoiDung
                          {
                              Trang_thai = j2 == null ? false : j2.ID_vai_tro == vaiTro.ID_vai_tro ? true : false,
                              View = p1,
                          }).ToList();
            }

            bindingSource.DataSource = result;
        }

        public static void LoadDataSource(LookUpEdit lookUpEdit, Context db = null)
        {
            if (db == null) db = new Context();

            lookUpEdit.Properties.Columns.Clear();
            var result = from p in db.CAT_NhanViens.Where(w => w.Trang_thai == true)
                         join p1 in db.CAT_PhongBans on p.ID_phong equals p1.ID_phong
                         select new
                         {
                             p.ID_nhan_vien,
                             Ho_ten = String.Format("{0} {1}", p.Ho_dem, p.Ten),
                             p.Ngay_sinh,
                             p1.Ten_phong,
                         };
            lookUpEdit.Properties.DataSource = result.ToList();
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ho_ten", 200, "Họ tên"));
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ngay_sinh", "Ngày sinh", 100, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", true, DevExpress.Utils.HorzAlignment.Center));
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_phong", 150, "Phòng - chức vụ"));
            lookUpEdit.Properties.DisplayMember = "Ho_ten";
            lookUpEdit.Properties.ValueMember = "ID_nhan_vien";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn nhân viên";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;

            lookUpEdit.ItemIndex = 0;
        }

        public static void LoadDataSource(RepositoryItemLookUpEdit lookUpEdit, Context db = null)
        {
            if (db == null) db = new Context();

            lookUpEdit.Columns.Clear();
            var result = from p in db.CAT_NhanViens.Where(w => w.Trang_thai == true)
                         join p1 in db.CAT_PhongBans on p.ID_phong equals p1.ID_phong
                         select new
                         {
                             p.ID_nhan_vien,
                             Ho_ten = String.Format("{0} {1}", p.Ho_dem, p.Ten),
                             p.Ngay_sinh,
                             p1.Ten_phong,
                         };
            lookUpEdit.DataSource = result.ToList();
            lookUpEdit.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ho_ten", 100, "Họ tên"));
            lookUpEdit.DisplayMember = "Ho_ten";
            lookUpEdit.ValueMember = "ID_nhan_vien";
            lookUpEdit.NullText = string.Empty;
            lookUpEdit.NullValuePrompt = string.Empty;
            lookUpEdit.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
        }

        public static bool Insert(CAT_NhanVien nhanVien, Context db = null)
        {
            if (db == null) db = new Context();

            var insertItem = new CAT_NhanVien
            {
                Ho_dem = nhanVien.Ho_dem,
                Ten = nhanVien.Ho_dem,
                Ngay_sinh = nhanVien.Ngay_sinh,
                Gioi_tinh = nhanVien.Gioi_tinh,
                Dien_thoai = nhanVien.Dien_thoai,
                CMND = nhanVien.CMND,
                Ngay_cap = nhanVien.Ngay_cap,
                Noi_cap = nhanVien.Noi_cap,
                Email = nhanVien.Email,
                Dia_chi = nhanVien.Dia_chi,
                ID_phong = nhanVien.ID_phong,
                Trang_thai = true
            };

            db.CAT_NhanViens.InsertOnSubmit(insertItem);

            db.SubmitChanges();

            return true;
        }

        public static bool Update(CAT_NhanVien nhanVien, Context db = null)
        {
            if (db == null) db = new Context();

            var updateItem = db.CAT_NhanViens.SingleOrDefault(w => w.ID_nhan_vien == nhanVien.ID_nhan_vien);

            if (updateItem == null) return false;

            updateItem.Ho_dem = nhanVien.Ho_dem;
            updateItem.Ten = nhanVien.Ho_dem;
            updateItem.Ngay_sinh = nhanVien.Ngay_sinh;
            updateItem.Gioi_tinh = nhanVien.Gioi_tinh;
            updateItem.Dien_thoai = nhanVien.Dien_thoai;
            updateItem.CMND = nhanVien.CMND;
            updateItem.Ngay_cap = nhanVien.Ngay_cap;
            updateItem.Noi_cap = nhanVien.Noi_cap;
            updateItem.Email = nhanVien.Email;
            updateItem.Dia_chi = nhanVien.Dia_chi;
            updateItem.ID_phong = nhanVien.ID_phong;

            db.SubmitChanges();

            return true;
        }

        public static bool Delete(CAT_NhanVien nhanVien, Context db = null)
        {
            if (db == null) db = new Context();

            var deleteItem = db.CAT_NhanViens.SingleOrDefault(w => w.ID_nhan_vien == nhanVien.ID_nhan_vien);

            if (deleteItem == null) return false;

            deleteItem.Trang_thai = false;

            db.SubmitChanges();

            return true;
        }
        
        public static CAT_NhanVien GetItem(int ID_nhan_vien, Context db = null)
        {
            if (db == null) db = new Context();

            return db.CAT_NhanViens.SingleOrDefault(w => w.ID_nhan_vien == ID_nhan_vien);
        }
    }
}
