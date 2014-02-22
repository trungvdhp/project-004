using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Library;
using DevExpress.XtraBars.Ribbon;
using System.Transactions;
using System.Reflection;
using Project._008.Models;

namespace Project._008.Controllers
{
    public class SYS_QuyenCtrl
    {
        public static List<SYS_Quyen> LoadDataSource(Context db = null)
        {
            if (db == null) db = new Context();

            return db.SYS_Quyens.OrderBy(t => t.Loai_dieu_khien).ToList();
        }

        public static List<SYS_Quyen> LoadSourceControls()
        {
            var forms = SYS_AssemblyCtrl.GetFormList();
            return SYS_AssemblyCtrl.GetControls(forms).OrderBy(t => t.Loai_dieu_khien).ToList();
        }

        public static List<SYS_LoaiDieuKhien> LoadCollectionControls()
        {
            var forms = SYS_AssemblyCtrl.GetFormList();

            List<SYS_Quyen> lst = SYS_AssemblyCtrl.GetControls(forms).OrderBy(t => t.Loai_dieu_khien).ToList();

            var collection = lst.Where(w => !w.Loai_dieu_khien.Contains("Base") && !w.Loai_dieu_khien.Contains("Form")).Select(w => w.Loai_dieu_khien).Distinct().ToList();

            List<SYS_LoaiDieuKhien> controls = new List<SYS_LoaiDieuKhien>();

            collection.ForEach(item => { controls.Add(new SYS_LoaiDieuKhien { Ten_loai = item, Ky_hieu = item }); });

            return controls;
        }
        
        public static List<SYS_ThuocTinh> LoadCollectionProperties(string controlType = null)
        {
            var forms = SYS_AssemblyCtrl.GetFormList();
            List<SYS_ThuocTinh> properties = new List<SYS_ThuocTinh>();

            List<KeyValuePair<string, string>> collection = SYS_AssemblyCtrl.GetProperties(SYS_AssemblyCtrl.FindControlByType(forms, controlType)).ToList();

            collection.ForEach(f => { properties.Add(new SYS_ThuocTinh { Ky_hieu = f.Key, Ten_thuoc_tinh = f.Key, Loai_gia_tri = f.Value }); });

            return properties;
        }
        
        public static void Insert(List<SYS_Quyen> list, Context db = null)
        {
            if (db == null) db = new Context();

            list = list.OrderBy(o => o.ID_goc).ThenBy(o => o.ID_cha).ThenBy(o => o.ID_quyen).ToList();
            
            using (TransactionScope scope = new TransactionScope())
            {
                db.SYS_Quyens.DeleteAllOnSubmit(db.SYS_Quyens.ToList());
                db.SYS_Quyens.InsertAllOnSubmit(list);

                db.SubmitChanges();
                scope.Complete();
            }
        }
    }
}
