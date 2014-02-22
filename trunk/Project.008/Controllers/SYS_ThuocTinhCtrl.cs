using Project._008.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project._008.Controllers
{
    public class SYS_ThuocTinhCtrl
    {
        public static void LoadBindingSource(BindingSource bindingSource, Context db = null)
        {
            if (db == null) db = new Context();

            bindingSource.DataSource = db.SYS_ThuocTinhs.ToList();
        }

        public static void LoadDataSource(DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpEdit, Context db = null)
        {
            if (db == null) db = new Context();

            lookUpEdit.Columns.Clear();
            lookUpEdit.DataSource = db.SYS_ThuocTinhs.ToList();
            lookUpEdit.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_thuoc_tinh", "Thuộc tính"));
            lookUpEdit.DisplayMember = "Ten_thuoc_tinh";
            lookUpEdit.ValueMember = "ID_thuoc_tinh";
            lookUpEdit.NullText = string.Empty;
            lookUpEdit.NullValuePrompt = string.Empty;
            lookUpEdit.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
        }

        public static void Insert(SYS_ThuocTinh entity, Context db = null)
        {
            if (db == null) db = new Context();

            var exist = db.SYS_ThuocTinhs.SingleOrDefault(w => w.Ky_hieu == entity.Ky_hieu && w.Ten_thuoc_tinh == entity.Ten_thuoc_tinh && w.Loai_gia_tri == entity.Loai_gia_tri);

            if (exist != null) return;

            db.SYS_ThuocTinhs.InsertOnSubmit(entity);

            db.SubmitChanges();
        }

        public static void Update(SYS_ThuocTinh thuocTinh, Context db = null)
        {
            if (db == null) db = new Context();

            var entity = db.SYS_ThuocTinhs.SingleOrDefault(w => w.ID_thuoc_tinh == thuocTinh.ID_thuoc_tinh);

            entity.Ky_hieu = thuocTinh.Ky_hieu;
            entity.Ten_thuoc_tinh = thuocTinh.Ten_thuoc_tinh;
            entity.Loai_gia_tri = thuocTinh.Loai_gia_tri;

            db.SubmitChanges();
        }

        public static void Insert(List<SYS_ThuocTinh> entities, Context db = null)
        {
            if (entities == null || entities.Count == 0) return;

            if (db == null) db = new Context();

            var thuocTinhs = db.SYS_ThuocTinhs.Select(w => new { w.Ky_hieu, w.Loai_gia_tri }).Distinct().ToList();

            entities = (from p in entities where !thuocTinhs.Contains(new { p.Ky_hieu, p.Loai_gia_tri }) select p).ToList();

            db.SYS_ThuocTinhs.InsertAllOnSubmit(entities);

            db.SubmitChanges();
        }

        public static List<SYS_ThuocTinh> LoadCollectionProperties(List<SYS_ThuocTinh> thuocTinhOlds, List<SYS_ThuocTinh> thuocTinhNews)
        {
            if (thuocTinhOlds == null || thuocTinhNews == null || thuocTinhNews.Count == 0) new List<SYS_ThuocTinh>();

            var thuocTinhs = thuocTinhNews.Select(w => new { w.Ky_hieu, w.Loai_gia_tri }).Distinct().ToList();

            return (from p in thuocTinhOlds where thuocTinhs.Contains(new { p.Ky_hieu, p.Loai_gia_tri }) select p).ToList();
        }
    }
}
