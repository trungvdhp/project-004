using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.UI
{
    public static class IPopupMenu
    {
        public static DXPopupMenu dxPopupMenu { get; set; }

        public static void BUpdate(this DropDownButton dropDownButton)
        {
            dxPopupMenu = new DXPopupMenu();
        }

        public static void AddItem(this DropDownButton dropDownButton, string caption, EventHandler click)
        {
            dxPopupMenu.Items.Add(new DXMenuItem(caption, new EventHandler(click)));
        }

        public static void AddNewGroup(this DropDownButton dropDownButton, string caption, EventHandler click)
        {
            DXMenuItem newDXMenuItem = new DXMenuItem(caption, new EventHandler(click));
            newDXMenuItem.BeginGroup = true;
            dxPopupMenu.Items.Add(newDXMenuItem);
        }

        public static void EUpdate(this DropDownButton dropDownButton)
        {
            dropDownButton.DropDownControl = dxPopupMenu;
            dxPopupMenu = null;
        }
    }
}
