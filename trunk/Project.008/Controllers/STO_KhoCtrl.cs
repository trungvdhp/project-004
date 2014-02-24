using Project._008.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project._008.Controllers
{
    public class STO_KhoCtrl
    {
        public static void LoadBindingSource(BindingSource bindingSource, Context db = null)
        {
            if (db == null) db = new Context();

            bindingSource.DataSource = db.STO_Khos.OrderBy(o => o.Dia_diem).ToList();
        }

        public static void Insert(STO_Kho dvt, Context db = null)
        {
            if (db == null) db = new Context();

            var exist = db.STO_Khos.Where(w => w.Dia_diem == dvt.Dia_diem).ToList();

            if (exist.Any()) return;

            var insertItem = new STO_Kho { Dia_diem = dvt.Dia_diem };

            db.STO_Khos.InsertOnSubmit(insertItem);

            db.SubmitChanges();
        }

        public static void Update(STO_Kho dvt, Context db = null)
        {
            if (db == null) db = new Context();

            var insertItem = db.STO_Khos.SingleOrDefault(w => w.ID_kho_tt == dvt.ID_kho_tt);

            if (insertItem == null) return;

            insertItem.Dia_diem = dvt.Dia_diem;

            db.SubmitChanges();
        }

        public static void Delete(STO_Kho dvt, Context db = null)
        {
            if (db == null) db = new Context();

            var deleteItem = db.STO_Khos.SingleOrDefault(w => w.ID_kho_tt == dvt.ID_kho_tt);

            if (deleteItem == null) return;

            db.STO_Khos.DeleteOnSubmit(deleteItem);

            db.SubmitChanges();
        }
    }
}
