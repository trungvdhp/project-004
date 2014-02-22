using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Library.Data;

namespace Library.UI.Form
{
    public static class ITreeList
    {
        #region Config
        public static void Config(this DevExpress.XtraTreeList.TreeList treeList, string keyFieldName, string parentFildName)
        {
            treeList.OptionsBehavior.AllowIncrementalSearch = true;
            treeList.OptionsBehavior.AllowIndeterminateCheckState = true;
            treeList.OptionsBehavior.AllowRecursiveNodeChecking = true;
            treeList.OptionsBehavior.AutoMoveRowFocus = true;
            treeList.OptionsBehavior.EnableFiltering = true;
            treeList.OptionsBehavior.EnterMovesNextColumn = true;
            treeList.OptionsBehavior.ExpandNodesOnIncrementalSearch = true;
            treeList.OptionsBehavior.Editable = false;

            treeList.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Smart;
            treeList.OptionsFilter.ShowAllValuesInFilterPopup = true;

            treeList.OptionsSelection.MultiSelect = true;

            treeList.OptionsView.ShowAutoFilterRow = true;
            treeList.OptionsView.ShowFilterPanelMode = DevExpress.XtraTreeList.ShowFilterPanelMode.ShowAlways;
            treeList.OptionsView.ShowPreview = true;

            treeList.OptionsView.ShowCheckBoxes = false;
            treeList.OptionsView.ShowIndicator = true;
            treeList.OptionsView.ShowRoot = true;

            treeList.Appearance.OddRow.BackColor = Color.White;
            treeList.Appearance.OddRow.BackColor2 = Color.WhiteSmoke;

            /*---------------------------------------------------------------*/
            treeList.KeyFieldName = keyFieldName;
            treeList.ParentFieldName = parentFildName;
        }

        public static void AddColumns(this DevExpress.XtraTreeList.TreeList treeList, List<TreeListColumn> columns)
        {
            treeList.BeginUpdate();

            for (int i = 0; i < columns.Count; i++)
            {
                treeList.Columns.Add();
                treeList.Columns[i].Name = columns[i].Name;
                treeList.Columns[i].Caption = columns[i].Caption;
                treeList.Columns[i].FieldName = columns[i].FieldName;

                treeList.Columns[i].Visible = true;
                treeList.Columns[i].VisibleIndex = i;
            }

            treeList.BestFitColumns();
            treeList.EndUpdate();
            treeList.Update();
        }

        public static void AddColumn(this DevExpress.XtraTreeList.TreeList treeList, string name, string caption, string fieldName)
        {
            treeList.BeginUpdate();
            treeList.Columns.Add();
            int index = treeList.Columns.Count - 1;
            treeList.Columns[index].Name = name;
            treeList.Columns[index].Caption = caption;
            treeList.Columns[index].FieldName = fieldName;

            treeList.Columns[index].Visible = true;
            treeList.Columns[index].VisibleIndex = index;
            treeList.EndUpdate();
        }
        #endregion

        public static Hashtable GetNodesForDeleting(this DevExpress.XtraTreeList.TreeList treeList)
        {
            Hashtable nodesForDeleting = new Hashtable();
            IEnumerator sel = treeList.Selection.GetEnumerator();
            sel.Reset();

            while (sel.MoveNext())
            {
                nodesForDeleting.AddSelectedNode((DevExpress.XtraTreeList.Nodes.TreeListNode)sel.Current);
                //AddSelectedNode((DevExpress.XtraTreeList.Nodes.TreeListNode)sel.Current);
            }

            return nodesForDeleting;
        }

        private static void AddSelectedNode(this Hashtable nodesForDeleting, DevExpress.XtraTreeList.Nodes.TreeListNode node)
        {
            DevExpress.XtraTreeList.Nodes.TreeListNode pnode = GetSelectedParent(node);
            nodesForDeleting[pnode] = pnode;
        }

        private static DevExpress.XtraTreeList.Nodes.TreeListNode GetSelectedParent(DevExpress.XtraTreeList.Nodes.TreeListNode node)
        {
            DevExpress.XtraTreeList.Nodes.TreeListNode pnode = node;

            while (pnode.ParentNode != null && pnode.ParentNode.Selected)
            {
                pnode = pnode.ParentNode;
            }
            return pnode;
        }
    }
}
