using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.UI.Grid
{
    public static class IGridView
    {
        /// <summary>
        /// ConfigGridView
        /// </summary>
        /// <param name="gridView">GridView</param>
        /// <param name="readOnly">ReadOnly</param>
        /// <param name="allowCellMerge">AllowCellMerge</param>
        /// <param name="allowGroup">AllowGroup</param>
        /// <param name="allowFilter">AllowFilter</param>
        /// <param name="allowSort">AllowSort</param>
        /// <param name="allowColumnMoving">AllowColumnMoving</param>
        /// <param name="allowColumnResizing">AllowColumnResizing</param>
        /// <param name="allowQuickHideColumns">AllowQuickHideColumns</param>
        public static void Config
            (
                this DevExpress.XtraGrid.Views.Grid.GridView gridView,
                bool readOnly = false,
                bool allowCellMerge = false,
                bool allowGroup = false,
                bool allowFilter = false,
                bool allowSort = false,
                bool allowColumnMoving = false,
                bool allowColumnResizing = true,
                bool allowQuickHideColumns = false,
                bool showIndicator = false,
                bool showColumnHeaders = true,
                bool showDetailButtons = false,
                bool useEmbeddedNavigator = false,
                bool autoFocusNewRow = true
            )
        {
            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                gridView.Columns[i].AppearanceCell.Options.UseTextOptions = true;
                gridView.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                gridView.Columns[i].AppearanceHeader.Options.UseTextOptions = true;
                gridView.Columns[i].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }
            //BestFitColumns
            gridView.BestFitColumns();

            //Readonly
            gridView.OptionsBehavior.ReadOnly = readOnly;
            gridView.OptionsBehavior.Editable = !readOnly;

            //group column
            gridView.OptionsCustomization.AllowGroup = allowGroup;
            gridView.OptionsCustomization.AllowFilter = allowFilter;
            gridView.OptionsCustomization.AllowSort = allowSort;

            //merge column
            gridView.OptionsView.AllowCellMerge = allowCellMerge;
            //----------------------------------------------------------------------------
            gridView.OptionsMenu.EnableColumnMenu = false;
            gridView.OptionsCustomization.AllowColumnMoving = allowColumnMoving;
            gridView.OptionsCustomization.AllowColumnResizing = allowColumnResizing;
            gridView.OptionsCustomization.AllowQuickHideColumns = allowQuickHideColumns;
            //----------------------------------------------------------------------------
            gridView.OptionsView.ShowGroupPanel = gridView.OptionsCustomization.AllowGroup;
            gridView.OptionsView.ShowAutoFilterRow = gridView.OptionsCustomization.AllowFilter;
            gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;

            gridView.OptionsView.ShowIndicator = showIndicator;
            gridView.OptionsView.ShowColumnHeaders = showColumnHeaders;
            gridView.OptionsView.ShowDetailButtons = showDetailButtons;

            gridView.GridControl.UseEmbeddedNavigator = useEmbeddedNavigator;

            gridView.OptionsNavigation.AutoFocusNewRow = autoFocusNewRow;
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;

            gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
        }

        /// <summary>
        /// ReconfigGridView
        /// </summary>
        /// <param name="gridView">GridView</param>
        /// <param name="columnPanelRowHeight">ColumnPanelRowHeight</param>
        /// <param name="indicatorWidth">IndicatorWidth</param>
        /// <param name="select">GridMultiSelectMode</param>
        /// <param name="enableAppearanceFocusedCell">EnableAppearanceFocusedCell</param>
        /// <param name="enableAppearanceFocusedRow">EnableAppearanceFocusedRow</param>
        /// <param name="enableAppearanceHideSelection">EnableAppearanceHideSelection</param>
        public static void Config2
            (
                this DevExpress.XtraGrid.Views.Grid.GridView gridView,
                DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode select = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect,
                bool enableAppearanceFocusedCell = false,
                bool enableAppearanceFocusedRow = false,
                bool enableAppearanceHideSelection = false,
                int columnPanelRowHeight = 0,
                int indicatorWidth = 0
            )
        {
            if (columnPanelRowHeight != 0) gridView.ColumnPanelRowHeight = columnPanelRowHeight;
            if (indicatorWidth != 0) gridView.IndicatorWidth = indicatorWidth;

            //gridView.FocusRectStyle = DrawFocusRectStyle.None;
            gridView.OptionsSelection.MultiSelect = select == DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect ? true : false;
            gridView.OptionsSelection.MultiSelectMode = select;

            gridView.OptionsSelection.EnableAppearanceFocusedCell = enableAppearanceFocusedCell;
            gridView.OptionsSelection.EnableAppearanceFocusedRow = enableAppearanceFocusedRow;
            gridView.OptionsSelection.EnableAppearanceHideSelection = enableAppearanceHideSelection;
        }

        public static void DisplayFormatColumn
            (
                this DevExpress.XtraGrid.Views.Grid.GridView gridView,
                DevExpress.XtraGrid.Columns.GridColumn column,
                string formatString,
                DevExpress.Utils.FormatType formatType = DevExpress.Utils.FormatType.Custom
            )
        {
            gridView.Columns[column.FieldName].DisplayFormat.FormatType = formatType;
            gridView.Columns[column.FieldName].DisplayFormat.FormatString = formatString;
        }

        public static void MergeColumns
            (
                this DevExpress.XtraGrid.Views.Grid.GridView gridView, 
                DevExpress.XtraGrid.Columns.GridColumn[] columns
            )
        {
            gridView.OptionsView.AllowCellMerge = true;

            gridView.BeginUpdate();
            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                gridView.Columns[i].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            }

            foreach (var column in columns)
            {
                column.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            }
            gridView.EndUpdate();
        }

        public static void AppearanceColumns
            (
                this DevExpress.XtraGrid.Views.Grid.GridView gridView,
                DevExpress.XtraGrid.Columns.GridColumn[] columns = null,
                DevExpress.Utils.HorzAlignment hAlignment = DevExpress.Utils.HorzAlignment.Near
            )
        {
            if (columns == null) return;

            gridView.BeginUpdate();
            foreach (var column in columns)
            {
                column.AppearanceCell.Options.UseTextOptions = true;
                column.AppearanceCell.TextOptions.HAlignment = hAlignment;
            }
            gridView.EndUpdate();
        }

        public static void BestFitAllColumns(this DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            gridView.BestFitColumns();

            gridView.BeginUpdate();
            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                gridView.Columns[i].BestFit();
            }
            gridView.EndUpdate();
        }

        public static void GroupColumns
            (
                this DevExpress.XtraGrid.Views.Grid.GridView gridView,
                DevExpress.XtraGrid.Columns.GridColumn[] columns = null,
                bool autoExpandAllGroups = false,
                bool allowGroup = false
            )
        {
            if (columns != null)
            {
                gridView.OptionsBehavior.AutoExpandAllGroups = autoExpandAllGroups;
                gridView.OptionsCustomization.AllowGroup = allowGroup;

                gridView.BeginUpdate();
                gridView.ClearGrouping();
                int index = 0;
                foreach (var column in columns)
                {
                    column.GroupIndex = index++;
                }
                gridView.EndUpdate();
            }
        }

        public static void UnReadOnlyColumns
            (
                this DevExpress.XtraGrid.Views.Grid.GridView gridView, 
                DevExpress.XtraGrid.Columns.GridColumn[] columns
            )
        {
            gridView.OptionsBehavior.ReadOnly = false;
            gridView.OptionsBehavior.Editable = true;

            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                gridView.Columns[i].OptionsColumn.ReadOnly = true;
            }

            foreach (var column in columns)
            {
                column.OptionsColumn.ReadOnly = false;
            }
        }

        public static void AddNewItemRow
            (
                this DevExpress.XtraGrid.Views.Grid.GridView gridView, 
                DevExpress.XtraGrid.Views.Grid.NewItemRowPosition newItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            )
        {
            gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;

            if (gridView.OptionsBehavior.ReadOnly == true) gridView.OptionsBehavior.ReadOnly = false; 
            gridView.OptionsBehavior.Editable = true;

            gridView.OptionsNavigation.AutoFocusNewRow = true;

            gridView.OptionsView.ShowIndicator = true;
            gridView.OptionsView.NewItemRowPosition = newItemRowPosition;
        }
    }
}
