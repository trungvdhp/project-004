using Project._008.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project._008.Controllers
{
    public class STO_DonViTinhCtrl
    {
        public static void LoadBindingSource(BindingSource bindingSource, Context db = null)
        {
            if (db == null) db = new Context();

            bindingSource.DataSource = db.STO_DonViTinhs.OrderBy(o => o.Ten_don_vi).ToList();
        }

        public static void Insert(STO_DonViTinh dvt, Context db = null)
        {
            if (db == null) db = new Context();

            var exist = db.STO_DonViTinhs.Where(w => w.Ten_don_vi == dvt.Ten_don_vi).ToList();

            if (exist.Any()) return;

            var insertItem = new STO_DonViTinh { Ten_don_vi = dvt.Ten_don_vi };

            db.STO_DonViTinhs.InsertOnSubmit(insertItem);

            db.SubmitChanges();
        }

        public static void Update(STO_DonViTinh dvt, Context db = null)
        {
            if (db == null) db = new Context();

            var insertItem = db.STO_DonViTinhs.SingleOrDefault(w => w.ID_don_vi == dvt.ID_don_vi);

            if (insertItem == null) return;

            insertItem.Ten_don_vi = dvt.Ten_don_vi;

            db.SubmitChanges();
        }

        public static void Delete(STO_DonViTinh dvt, Context db = null)
        {
            if (db == null) db = new Context();

            var deleteItem = db.STO_DonViTinhs.SingleOrDefault(w => w.ID_don_vi == dvt.ID_don_vi);

            if (deleteItem == null) return;

            db.STO_DonViTinhs.DeleteOnSubmit(deleteItem);

            db.SubmitChanges();
        }
    }
}
