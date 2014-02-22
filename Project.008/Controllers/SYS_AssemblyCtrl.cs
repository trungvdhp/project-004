using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project._008.Controllers
{
    using DevExpress.XtraBars;
    using DevExpress.XtraGrid;
    using DevExpress.XtraGrid.Columns;
    using DevExpress.XtraGrid.Views.Grid;
    using System.ComponentModel;
    using System.Reflection;
    using Library;
    using Project._008.Models;

    public class SYS_AssemblyCtrl
    {
        private static List<Type> IncludeList = new List<Type>(new Type[] { typeof(DevExpress.XtraBars.BarButtonItem), typeof(SimpleButton), typeof(LookUpEdit), typeof(DateEdit), typeof(SpinEdit), typeof(MemoEdit), typeof(TextEdit), typeof(TimeEdit), typeof(DevExpress.XtraGrid.Columns.GridColumn), typeof(LabelControl), typeof(DevExpress.XtraPrinting.Control.PrintControl) });

        private static List<Type> ExcludeList = new List<Type>(new Type[] { typeof(Label), typeof(LabelControl), typeof(DevExpress.XtraTab.XtraTabControl), typeof(RibbonStatusBar) });

        private static List<string> FormList = new List<string>(new string[] { "frmSplashScreen", "frmDangNhap", "frmCauHinh", "frmTimer", "frmConfig", "frmLogin", "frmQuyen", "frmLoaiDieuKhien", "frmVaiTro", "frmPhanQuyen", "frmPhanVaiTro", "frmThongTinTaiKhoan" });

        private static List<Type> PropertyList = new List<Type>(new Type[] { typeof(System.Boolean), typeof(DevExpress.Utils.DefaultBoolean), typeof(DevExpress.XtraBars.BarItemVisibility) });

        #region Get controls
        /// <summary>
        /// Get sub classes
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private static List<Type> GetSubClasses<T>()
        {
            return AppDomain
                .CurrentDomain
                .GetAssemblies()
                .SelectMany(
                    a => a.GetTypes().Where(type => type.IsSubclassOf(typeof(T)))
                ).ToList();
        }

        /// <summary>
        /// Get form list with StartsWith Name is "frm"
        /// </summary>
        /// <returns></returns>
        public static List<Control> GetFormList()
        {
            List<Control> list = new List<Control>();
            var tmp = GetSubClasses<XtraForm>().Where(x => x.Name.StartsWith("frm")).ToList();

            foreach (var item in tmp)
            {
                list.Add((Control)(Activator.CreateInstance(item)));
            }

            return list;
        }

        public static bool HaveRelationShip(string formName, int ID_quyen, Context db = null)
        {
            if (db == null) db = new Context();

            var quyen = db.SYS_Quyens.FirstOrDefault(t => t.ID_quyen == ID_quyen);

            while (true)
            {
                if (quyen == null) return false;

                if (quyen.Ma_quyen == formName) return true;

                if (quyen.ID_quyen == quyen.ID_cha) return false;

                quyen = db.SYS_Quyens.FirstOrDefault(t => t.ID_quyen == quyen.ID_cha);
            }

            return false;
        }

        public static List<int> GetChildrenIDs(string formName, Context db = null)
        {
            if (db == null) db = new Context();

            var form = db.SYS_Quyens.FirstOrDefault(t => t.Ma_quyen == formName);
            List<int> list = new List<int>();

            Queue<SYS_Quyen> queue = new Queue<SYS_Quyen>();
            queue.Enqueue(form);

            while (queue.Count != 0)
            {
                SYS_Quyen node = queue.Dequeue();

                var children = db.SYS_Quyens.Where(t => t.ID_cha == node.ID_quyen && t.ID_quyen != node.ID_quyen);

                foreach (var child in children)
                {
                    list.Add(child.ID_quyen);
                    queue.Enqueue(child);
                }
            }

            return list;
        }

        /// <summary>
        /// Get list children controls
        /// </summary>
        /// <returns></returns>
        public static List<SYS_Quyen> GetControls(List<Control> forms)
        {
            List<SYS_Quyen> controls = new List<SYS_Quyen>();
            List<Type> types = IncludeList;

            List<Type> excludeList = ExcludeList;

            Queue<KeyValuePair<SYS_Quyen, object>> queue = new Queue<KeyValuePair<SYS_Quyen, object>>();
            int id = 0;
            //Tìm kiếm toàn bộ form đưa vào queue
            foreach (var form in forms)
            {
                if (!FormList.Contains(form.Name))
                {
                    id++;
                    queue.Enqueue(
                        new KeyValuePair<SYS_Quyen, object>(
                            new SYS_Quyen
                            {
                                ID_quyen = id,
                                ID_cha = id,
                                Ma_quyen = form.Name,
                                Ten_quyen = form.Text,
                                Loai_dieu_khien = form.GetType().BaseType.ToString().GetLastString(),
                                ID_goc = id
                            },
                            form)
                        );
                }
            }

            while (queue.Count != 0)
            {
                var node = queue.Dequeue();
                controls.Add(node.Key);

                if (node.Value.GetType() == typeof(DevExpress.XtraBars.Ribbon.RibbonControl))
                {
                    var children = (node.Value as DevExpress.XtraBars.Ribbon.RibbonControl).Items;

                    foreach (object child in children)
                    {
                        if (child.GetType() == typeof(DevExpress.XtraBars.BarButtonItem))
                        {
                            id++;
                            DevExpress.XtraBars.BarButtonItem btn = child as DevExpress.XtraBars.BarButtonItem;

                            queue.Enqueue(
                                new KeyValuePair<SYS_Quyen, object>(
                                    new SYS_Quyen
                                    {
                                        ID_quyen = id,
                                        ID_cha = node.Key.ID_quyen,
                                        Ma_quyen = btn.Name,
                                        Ten_quyen = btn.Caption,
                                        Loai_dieu_khien = child.GetType().ToString().GetLastString(),
                                        ID_goc = node.Key.ID_goc
                                    },
                                    child)
                                );
                        }
                    }
                }
                else if (types.Contains(node.Value.GetType()))
                {
                }
                else if (node.Value.GetType() == typeof(DevExpress.XtraGrid.GridControl))
                {
                    var children = (node.Value as DevExpress.XtraGrid.GridControl).Views;

                    foreach (DevExpress.XtraGrid.Views.Grid.GridView child in children)
                    {
                        id++;
                        queue.Enqueue(
                            new KeyValuePair<SYS_Quyen, object>(
                                new SYS_Quyen
                                {
                                    ID_quyen = id,
                                    ID_cha = node.Key.ID_quyen,
                                    Ma_quyen = child.Name,
                                    Ten_quyen = child.ViewCaption,
                                    Loai_dieu_khien = child.GetType().ToString().GetLastString(),
                                    ID_goc = node.Key.ID_goc
                                },
                                child)
                            );
                    }

                }
                else if (node.Value.GetType() == typeof(DevExpress.XtraGrid.Views.Grid.GridView))
                {
                    var children = (node.Value as DevExpress.XtraGrid.Views.Grid.GridView).Columns;

                    foreach (DevExpress.XtraGrid.Columns.GridColumn child in children)
                    {
                        id++;
                        queue.Enqueue(
                            new KeyValuePair<SYS_Quyen, object>(
                                new SYS_Quyen
                                {
                                    ID_quyen = id,
                                    ID_cha = node.Key.ID_quyen,
                                    Ma_quyen = child.Name,
                                    Ten_quyen = child.Caption,
                                    Loai_dieu_khien = child.GetType().ToString().GetLastString(),
                                    ID_goc = node.Key.ID_goc
                                },
                                child)
                            );
                    }
                }
                else
                {
                    //Nếu không phải thì là đối tượng đệ quy : Form
                    var children = (node.Value as Control).Controls;

                    foreach (object child in children)
                    {
                        if (!excludeList.Contains(child.GetType()))
                        {
                            id++;
                            Control ctrl = child as Control;
                            queue.Enqueue(
                                new KeyValuePair<SYS_Quyen, object>(
                                    new SYS_Quyen
                                    {
                                        ID_quyen = id,
                                        ID_cha = node.Key.ID_quyen,
                                        Ma_quyen = ctrl.Name,
                                        Ten_quyen = (child.GetType() == typeof(DevExpress.XtraGrid.Columns.GridColumn)) ? (child as DevExpress.XtraGrid.Columns.GridColumn).Caption : ctrl.Tag != null ? ctrl.Tag.ToString() : ctrl.Text != "" ? ctrl.Text : ctrl.Name,
                                        Loai_dieu_khien = child.GetType().ToString().GetLastString(),
                                        ID_goc = node.Key.ID_goc
                                    },
                                    child)
                                );
                        }
                    }
                }
            }

            return controls;
        }

        /// <summary>
        /// Find control in a parent control, find by type
        /// </summary>
        /// <param name="forms">Parent control</param>
        /// <param name="controlType">Control type</param>
        /// <returns></returns>
        public static object FindControlByType(List<Control> forms, string controlType)
        {
            List<Type> includeList = IncludeList;

            List<Type> excludeList = ExcludeList;

            Queue<object> queue = new Queue<object>();

            foreach (var form in forms)
            {
                if (!FormList.Contains(form.Name))
                {
                    queue.Enqueue(form);
                }
            }

            while (queue.Count != 0)
            {
                var node = queue.Dequeue();

                if (node.GetType() == typeof(RibbonControl))
                {
                    var children = (node as RibbonControl).Items;

                    foreach (object child in children)
                    {
                        if (child.GetType() == typeof(BarButtonItem))
                        {
                            if (child.GetType().ToString().GetLastString() == controlType) return child;
                            queue.Enqueue(child);
                        }
                    }
                }
                else if (includeList.Contains(node.GetType()))
                {
                    if (node.GetType().ToString().GetLastString() == controlType) return node;
                }
                else if (node.GetType() == typeof(GridControl))
                {
                    var children = (node as GridControl).Views;

                    foreach (GridView child in children)
                    {
                        if (child.GetType().ToString().GetLastString() == controlType) return child;
                        queue.Enqueue(child);
                    }

                }
                else if (node.GetType() == typeof(GridView))
                {
                    var children = (node as GridView).Columns;

                    foreach (GridColumn child in children)
                    {
                        if (child.GetType().ToString().GetLastString() == controlType) return child;

                        queue.Enqueue(child);
                    }
                }
                else
                {
                    var children = (node as Control).Controls;

                    foreach (object child in children)
                    {
                        if (!excludeList.Contains(child.GetType()))
                        {
                            Control ctrl = child as Control;
                            if (child.GetType().ToString().GetLastString() == controlType) return child;
                            queue.Enqueue(child);
                        }
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Find control in a parent control, find by name
        /// </summary>
        /// <param name="parent">Parent control</param>
        /// <param name="controlName">Control name</param>
        /// <returns></returns>
        public static object FindControlByName(object parent, string controlName)
        {
            List<Type> includeList = IncludeList;

            List<Type> excludeList = ExcludeList;

            Queue<object> queue = new Queue<object>();
            queue.Enqueue(parent);

            while (queue.Count != 0)
            {
                var node = queue.Dequeue();

                if (node.GetType() == typeof(RibbonControl))
                {
                    var children = (node as RibbonControl).Items;

                    foreach (var child in children)
                    {
                        if (child.GetType() == typeof(BarButtonItem))
                        {
                            BarButtonItem btn = child as BarButtonItem;

                            if (btn.Name == controlName)
                                return btn;

                            queue.Enqueue(child);
                        }
                    }
                }
                else if (includeList.Contains(node.GetType()))
                {

                }
                else if (node.GetType() == typeof(GridControl))
                {
                    var children = (node as GridControl).Views;

                    foreach (GridView child in children)
                    {
                        if (child.Name == controlName)
                            return child;

                        queue.Enqueue(child);
                    }
                }
                else if (node.GetType() == typeof(GridView))
                {
                    var children = (node as GridView).Columns;

                    foreach (GridColumn child in children)
                    {
                        if (child.Name == controlName)
                            return child;

                        queue.Enqueue(child);
                    }
                }
                else
                {
                    var children = (node as Control).Controls;

                    foreach (Control child in children)
                    {
                        if (!ExcludeList.Contains(child.GetType()))
                        {
                            if (child.Name == controlName)
                                return child;

                            queue.Enqueue(child);
                        }
                    }
                }
            }

            return null;
        }
        #endregion
        
        #region Get Properties
        public static List<KeyValuePair<string, string>> GetProperties(object control)
        {
            if (control == null) return null;
            List<KeyValuePair<string, string>> properties = new List<KeyValuePair<string, string>>();
            Type controlType;

            if (control.GetType() == typeof(DevExpress.XtraBars.Ribbon.RibbonControl)) controlType = (control as DevExpress.XtraBars.Ribbon.RibbonControl).GetType();
            else if (control.GetType() == typeof(DevExpress.XtraBars.BarButtonItem)) controlType = (control as DevExpress.XtraBars.BarButtonItem).GetType();
            else if (control.GetType() == typeof(DevExpress.XtraGrid.GridControl)) controlType = (control as DevExpress.XtraGrid.GridControl).GetType();
            else if (control.GetType() == typeof(DevExpress.XtraGrid.Views.Grid.GridView)) controlType = (control as DevExpress.XtraGrid.Views.Grid.GridView).GetType();
            else if (control.GetType() == typeof(DevExpress.XtraGrid.Columns.GridColumn)) controlType = (control as DevExpress.XtraGrid.Columns.GridColumn).GetType();
            else controlType = (control as Control).GetType();

            //Type controlType = control.GetType();
            PropertyInfo[] propertyInfos = controlType.GetProperties();
            foreach (PropertyInfo controlProperty in propertyInfos)
            {
                if (PropertyList.Contains(controlProperty.PropertyType) && (!controlProperty.Name.StartsWith("Is")) && (!controlProperty.Name.StartsWith("is")))
                {
                    properties.Add(new KeyValuePair<string, string>(controlProperty.Name, controlProperty.PropertyType.ToString()));
                }
            }

            return properties;
        }
        #endregion

        /// <summary>
        /// Set value for a property of specified component
        /// </summary>
        /// <param name="component">A specified component</param>
        /// <param name="propertyPath">Path of property</param>
        /// <param name="value">Value to set</param>
        public static void SetValue(object component, string propertyPath, object value)
        {
            try
            {
                object propValue = component;
                var props = propertyPath.Split('.');

                for (int i = 0; i < props.Length - 1; i++)
                {
                    propValue = TypeDescriptor.GetProperties(propValue)[props[i]].GetValue(propValue);
                }

                TypeDescriptor.GetProperties(propValue)[props[props.Length - 1]].SetValue(propValue, value);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Lỗi gán giá trị cho thuộc tính của thành phần :" + component.ToString());
            }
        }        

        ///// <summary>
        ///// Reset value of child controls in a specified parent controls to default values
        ///// </summary>
        ///// <param name="Parent">Parent control</param>
        //public static void ResetControls(Control Parent)
        //{
        //    foreach (var control in Parent.Controls)
        //    {
        //        if (control.GetType() == typeof(TextBox))
        //        {
        //            (control as TextBox).ResetText();
        //        }
        //        else if (control.GetType() == typeof(TextEdit))
        //        {
        //            (control as TextEdit).ResetText();
        //        }
        //        else if (control.GetType() == typeof(MemoEdit))
        //        {
        //            (control as MemoEdit).ResetText();
        //        }
        //        else if (control.GetType() == typeof(LookUpEdit))
        //        {
        //            (control as LookUpEdit).EditValue = null;
        //        }
        //        else if (control.GetType() == typeof(DateEdit))
        //        {
        //            //(control as DateEdit).EditValue = DatabaseHelper.GetDatabaseDate();
        //        }
        //        else if (control.GetType() == typeof(SpinEdit))
        //        {
        //            (control as SpinEdit).EditValue = (control as SpinEdit).Properties.MinValue;
        //        }
        //        else if (control.GetType() == typeof(GridControl))
        //        {
        //            (control as GridControl).Views[0].RefreshData();
        //        }
        //        else if (control.GetType() == typeof(TableLayoutPanel) || control.GetType() == typeof(Panel) || control.GetType() == typeof(PanelControl) || control.GetType() == typeof(GroupControl) || control.GetType() == typeof(SplitContainerControl) || control.GetType() == typeof(SplitContainerControl) || control.GetType() == typeof(SplitContainer))
        //        {
        //            ResetControls((Control)control);
        //        }
        //    }
        //}
    }
}
