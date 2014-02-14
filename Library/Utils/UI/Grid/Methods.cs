using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.UI.Grid
{
    public class Methods
    {
        //Returns the child data rows for the given group row 
        public static void GetChildRows(DevExpress.XtraGrid.Views.Grid.GridView view, int groupRowHandle, System.Collections.ArrayList childRows)
        {
            if (!view.IsGroupRow(groupRowHandle)) return;

            //Get the number of immediate children 
            int childCount = view.GetChildRowCount(groupRowHandle);

            for (int i = 0; i < childCount; i++)
            {
                //Get the handle of a child row with the required index 
                int childHandle = view.GetChildRowHandle(groupRowHandle, i);
                //If the child is a group row, then add its children to the list 
                if (view.IsGroupRow(childHandle))
                    GetChildRows(view, childHandle, childRows);
                else
                {
                    // The child is a data row.  
                    // Add it to the childRows as long as the row wasn't added before 

                    if (!childRows.Contains(childHandle))
                        childRows.Add(childHandle);
                }
            }
        }

        // Returns the child data rows for all selected group rows and selected data rows 
        public static void GetChildRows(DevExpress.XtraGrid.Views.Grid.GridView view, System.Collections.ArrayList childRows)
        {
            int[] rowIDs = view.GetSelectedRows();

            foreach (int rowID in rowIDs)
            {
                //Get related data rows 
                if (view.IsGroupRow(rowID))
                    GetChildRows(view, rowID, childRows);
                else
                    childRows.Add(rowID);
            }
        }

        public static void SetSelectedRowsCellValue(DevExpress.XtraGrid.Views.Grid.GridView view, string fieldName, object value)
        {
            System.Collections.ArrayList rows = new System.Collections.ArrayList();
            GetChildRows(view, rows);
            // Update state
            view.BeginUpdate();

            foreach (var row in rows)
            {
                view.SetRowCellValue((int)row, fieldName, value);
            }

            view.EndUpdate();
        }

        public static void SetAllRowsCellValue(DevExpress.XtraGrid.Views.Grid.GridView view, string fieldName, object value)
        {
            // Update state
            view.BeginUpdate();

            for (int i = 0; i < view.DataRowCount; i++)
            {
                view.SetRowCellValue(i, view.Columns[fieldName], value);
            }

            view.EndUpdate();
        }

        public static int GetCheckedCount(DevExpress.XtraGrid.Views.Grid.GridView view, string fieldName)
        {
            int count = 0;
            for (int i = 0; i < view.DataRowCount; i++)
            {
                if ((bool)view.GetRowCellValue(i, view.Columns[fieldName]) == true)
                    count++;
            }
            return count;
        }
    }
}
