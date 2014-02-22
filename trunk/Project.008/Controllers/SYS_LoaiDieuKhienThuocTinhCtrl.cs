using Project._008.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project._008.Controllers
{
    public class SYS_LoaiDieuKhienThuocTinhCtrl
    {
        public static void LoadBindingSourceView(BindingSource bindingSource, Context db = null)
        {
            if (db == null) db = new Context();

            bindingSource.DataSource = db.viewLoaiDieuKhien_ThuocTinhs.ToList();
        }

        public static void Delete(viewLoaiDieuKhien_ThuocTinh view, Context db = null)
        {
            if (db == null) db = new Context();

            var deleteItem = db.SYS_LoaiDieuKhienThuocTinhs.SingleOrDefault(w => w.ID_thuoc_tinh == view.ID_thuoc_tinh && w.ID_loai == view.ID_loai);

            if (deleteItem == null) return;

            db.SYS_LoaiDieuKhienThuocTinhs.DeleteOnSubmit(deleteItem);

            db.SubmitChanges();
        }

        public static void Insert(SYS_LoaiDieuKhien loaiDieuKhien, List<SYS_ThuocTinh> thuocTinh, Context db = null)
        {
            if (loaiDieuKhien == null || thuocTinh == null || thuocTinh.Count == 0) return;

            if (db == null) db = new Context();

            var ID_thuoc_tinhs = db.SYS_LoaiDieuKhienThuocTinhs.Where(w => w.ID_loai == loaiDieuKhien.ID_loai).Select(s => s.ID_thuoc_tinh).Distinct().ToList();

            if (ID_thuoc_tinhs.Any()) thuocTinh = (from p in thuocTinh where !ID_thuoc_tinhs.Contains(p.ID_thuoc_tinh) select p).ToList();

            List<SYS_LoaiDieuKhienThuocTinh> insertItems = new List<SYS_LoaiDieuKhienThuocTinh>();

            thuocTinh.ForEach(f => { insertItems.Add(new SYS_LoaiDieuKhienThuocTinh { ID_loai = loaiDieuKhien.ID_loai, ID_thuoc_tinh = f.ID_thuoc_tinh }); });

            db.SYS_LoaiDieuKhienThuocTinhs.InsertAllOnSubmit(insertItems);

            db.SubmitChanges();
        }

        public static void Insert(SYS_LoaiDieuKhien loaiDieuKhien, SYS_ThuocTinh thuocTinh, Context db = null)
        {
            if (loaiDieuKhien == null || thuocTinh == null) return;

            if (db == null) db = new Context();

            var exist = db.SYS_LoaiDieuKhienThuocTinhs.SingleOrDefault(w => w.ID_thuoc_tinh == thuocTinh.ID_thuoc_tinh && w.ID_loai == loaiDieuKhien.ID_loai);

            if (exist != null) return;

            SYS_LoaiDieuKhienThuocTinh insertItem = new SYS_LoaiDieuKhienThuocTinh { ID_loai = loaiDieuKhien.ID_loai, ID_thuoc_tinh = thuocTinh.ID_thuoc_tinh };

            db.SYS_LoaiDieuKhienThuocTinhs.InsertOnSubmit(insertItem);

            db.SubmitChanges();
        }
    }
}
