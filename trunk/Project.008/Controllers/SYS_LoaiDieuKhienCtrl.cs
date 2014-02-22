using Project._008.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project._008.Controllers
{
    public class SYS_LoaiDieuKhienCtrl
    {
        public static void LoadBindingSource(BindingSource bindingSource, Context db = null)
        {
            if (db == null) db = new Context();

            bindingSource.DataSource = db.SYS_LoaiDieuKhiens.ToList();
        }

        public static void Insert(SYS_LoaiDieuKhien entity, Context db = null)
        {
            if (db == null) db = new Context();

            db.SYS_LoaiDieuKhiens.InsertOnSubmit(entity);

            db.SubmitChanges();
        }

        public static void Insert(List<SYS_LoaiDieuKhien> entities, Context db = null)
        {
            if (entities == null || entities.Count == 0) return;

            if (db == null) db = new Context();

            var Ky_hieus = db.SYS_LoaiDieuKhiens.Select(w => w.Ky_hieu).Distinct().ToList();

            entities = (from p in entities where !Ky_hieus.Contains(p.Ky_hieu) select p).ToList();

            db.SYS_LoaiDieuKhiens.InsertAllOnSubmit(entities);

            db.SubmitChanges();
        }

        public static void Update(SYS_LoaiDieuKhien loaiDieuKhien, Context db = null)
        {
            if (db == null) db = new Context();

            var entity = db.SYS_LoaiDieuKhiens.SingleOrDefault(w => w.ID_loai == loaiDieuKhien.ID_loai);

            entity.Ky_hieu = loaiDieuKhien.Ky_hieu;
            entity.Ten_loai = loaiDieuKhien.Ten_loai;

            db.SubmitChanges();
        }
    }
}
