using DevExpress.XtraEditors;
using Project._008.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project._008.Controllers
{
    public class SYS_VaiTroQuyenCtrl
    {
        public static List<SYS_VaiTroQuyen> LoadDataSource(object ID_vai_tro, SYS_Quyen entity, Context db = null)
        {
            if (db == null) db = new Context();

            var thuocTinhs = (from p in db.SYS_Quyens.Where(w => w.ID_quyen == entity.ID_quyen)
                              join p1 in db.SYS_LoaiDieuKhiens on p.Loai_dieu_khien equals p1.Ky_hieu
                              join p2 in db.SYS_LoaiDieuKhienThuocTinhs on p1.ID_loai equals p2.ID_loai
                              join p3 in db.SYS_ThuocTinhs on p2.ID_thuoc_tinh equals p3.ID_thuoc_tinh
                              select p3).ToList();

            var vaitroQuyen = db.SYS_VaiTroQuyens.Where(w => w.ID_quyen == entity.ID_quyen && w.ID_vai_tro == (int)ID_vai_tro).ToList();

            var result = from p in thuocTinhs
                         join p1 in vaitroQuyen on p.ID_thuoc_tinh equals p1.ID_thuoc_tinh into joined
                         from j in joined.DefaultIfEmpty()
                         select new SYS_VaiTroQuyen
                         {
                             ID_quyen = entity.ID_quyen,
                             ID_thuoc_tinh = p.ID_thuoc_tinh,
                             Gia_tri = j == null ? (bool?)null : j.Gia_tri,
                         };

            return result.ToList();
        }

        public static void Insert(List<SYS_VaiTroQuyen> entities, object ID_vai_tro, SYS_Quyen quyen, Context db = null)
        {
            if (db == null) db = new Context();

            var deleteItems = db.SYS_VaiTroQuyens.Where(w => w.ID_vai_tro == (int)ID_vai_tro && w.ID_quyen == quyen.ID_quyen).ToList();

            db.SYS_VaiTroQuyens.DeleteAllOnSubmit(deleteItems);

            entities = entities.Where(w => w.Gia_tri != null).ToList();

            var insertItems = (from p in entities
                               select new SYS_VaiTroQuyen
                               {
                                   ID_vai_tro = (int)ID_vai_tro,
                                   ID_quyen = p.ID_quyen,
                                   ID_thuoc_tinh = p.ID_thuoc_tinh,
                                   Gia_tri = p.Gia_tri,
                               }).ToList();

            db.SYS_VaiTroQuyens.InsertAllOnSubmit(insertItems);

            db.SubmitChanges();
        }

        public static void Inheritance(object ID_vai_tro1, object ID_vai_tro2, Context db = null)
        {
            if (db == null) db = new Context();

            var deleteItems = db.SYS_VaiTroQuyens.Where(w => w.ID_vai_tro == (int)ID_vai_tro2).ToList();

            db.SYS_VaiTroQuyens.DeleteAllOnSubmit(deleteItems);

            var entities = db.SYS_VaiTroQuyens.Where(w => w.ID_vai_tro == (int)ID_vai_tro1).ToList();

            var insertItems = (from p in entities
                               select new SYS_VaiTroQuyen
                               {
                                   ID_vai_tro = (int)ID_vai_tro2,
                                   ID_quyen = p.ID_quyen,
                                   ID_thuoc_tinh = p.ID_thuoc_tinh,
                                   Gia_tri = p.Gia_tri,
                               }).ToList();

            db.SYS_VaiTroQuyens.InsertAllOnSubmit(insertItems);

            db.SubmitChanges();
        }

        public static void ReconfigFormControls(XtraForm form, Context db = null)
        {
            if (db == null) db = new Context();

            var quyen = db.SYS_Quyens.FirstOrDefault(w => w.Ma_quyen == form.Name);

            if (quyen == null) return;

            var nguoiDungVaiTro = db.SYS_NguoiDungVaiTros.SingleOrDefault(w => w.ID_nguoi_dung == Program.CurrentUser.ID_nguoi_dung);

            var vaiTroQuyen = new List<SYS_VaiTroQuyen>();

            if (nguoiDungVaiTro != null)
            {
                vaiTroQuyen = db.SYS_VaiTroQuyens.Where(w => w.ID_vai_tro == nguoiDungVaiTro.ID_vai_tro && w.SYS_Quyen.ID_goc == quyen.ID_quyen).ToList();
            }
            else
            {
                var vaiTro = db.SYS_VaiTros.OrderBy(o => o.ID_cha).ThenBy(o => o.ID_vai_tro).ToList().Last();

                if (vaiTro == null) return;
                
                vaiTroQuyen = db.SYS_VaiTroQuyens.Where(w => w.ID_vai_tro == vaiTro.ID_vai_tro && w.SYS_Quyen.ID_goc == quyen.ID_quyen).ToList();
            }

            if (vaiTroQuyen == null || Program.CurrentUser.ID_nhan_vien == null) return;

            int current = 0;
            object obj = form;

            foreach (var item in vaiTroQuyen)
            {
                if (item.ID_quyen != current)
                {
                    obj = SYS_AssemblyCtrl.FindControlByName(form, item.SYS_Quyen.Ma_quyen);
                    current = item.ID_quyen;
                }

                if (obj == null) continue;

                object value = true;

                switch (item.SYS_ThuocTinh.Loai_gia_tri)
                {
                    case "System.Boolean":
                        if (item.Gia_tri.Value == true)
                        {
                            value = true;
                        }
                        else if (item.Gia_tri.Value == false)
                        {
                            value = false;
                        }
                        break;
                    case "DevExpress.XtraBars.BarItemVisibility":
                        if (item.Gia_tri.Value == true)
                        {
                            value = DevExpress.XtraBars.BarItemVisibility.Always;
                        }
                        else if (item.Gia_tri.Value == false)
                        {
                            value = DevExpress.XtraBars.BarItemVisibility.Never;
                        }
                        break;
                    case "DevExpress.Utils.DefaultBoolean":
                        if (item.Gia_tri.Value == true)
                        {
                            value = DevExpress.Utils.DefaultBoolean.True;
                        }
                        else if (item.Gia_tri.Value == false)
                        {
                            value = DevExpress.Utils.DefaultBoolean.False;
                        }
                        break;
                }

                SYS_AssemblyCtrl.SetValue(obj, item.SYS_ThuocTinh.Ky_hieu, value);
            }
        }
    }
}
