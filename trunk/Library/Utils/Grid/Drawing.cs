using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.UI.Grid
{
    public class Drawing
    {
        /// <summary>
        /// SetStyleFormat
        /// </summary>
        /// <param name="gridView">DevExpress.XtraGrid.Views.Grid.GridView</param>
        /// <param name="values">new List<int> { -8388652, -1, -16744448, -16711936, -16776961, -256, -65536 }</param>
        public static void SetStyleFormat(DevExpress.XtraGrid.Views.Grid.GridView gridView, List<int> values = null)
        {
            if (values == null || values.Count == 0)
                values = new List<int> { -8388652, -1, -16744448, -16711936, -16776961, -256, -65536 };

            for (int i = -1; i < values.Count - 1; i++)
            {
                DevExpress.XtraGrid.StyleFormatCondition style = new DevExpress.XtraGrid.StyleFormatCondition();
                style.Appearance.BackColor = System.Drawing.Color.FromArgb(values[i + 1]);
                style.Appearance.ForeColor = System.Drawing.Color.FromArgb(values[i + 1]);
                style.Appearance.Options.UseBackColor = true;
                style.Appearance.Options.UseForeColor = true;
                style.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
                style.Value1 = i;
                gridView.FormatConditions.Add(style);
            }
        }

        /// <summary>
        /// SetStyleFormat
        /// </summary>
        /// <param name="gridView">DevExpress.XtraGrid.Views.Grid.GridView</param>
        /// <param name="values">new int[] { -8388652, -1, -16744448, -16711936, -16776961, -256, -65536 }</param>
        public static void SetStyleFormat(DevExpress.XtraGrid.Views.Grid.GridView gridView, int[] values = null)
        {
            if (values == null || values.Length == 0)
                values = new int[] { -8388652, -1, -16744448, -16711936, -16776961, -256, -65536 };

            for (int i = -1; i < values.Length - 1; i++)
            {
                DevExpress.XtraGrid.StyleFormatCondition style = new DevExpress.XtraGrid.StyleFormatCondition();
                style.Appearance.BackColor = System.Drawing.Color.FromArgb(values[i + 1]);
                style.Appearance.ForeColor = System.Drawing.Color.FromArgb(values[i + 1]);
                style.Appearance.Options.UseBackColor = true;
                style.Appearance.Options.UseForeColor = true;
                style.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
                style.Value1 = i;
                gridView.FormatConditions.Add(style);
            }
        }

        /// <summary>
        /// DrawCheckBox in GridView
        /// </summary>
        /// <param name="checkEdit">DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit</param>
        /// <param name="g">System.Drawing.Graphics in </param>
        /// <param name="r">System.Drawing.Rectangle</param>
        /// <param name="Checked">state: true or false</param>
        public static void DrawCheckBox(DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit checkEdit, System.Drawing.Graphics g, System.Drawing.Rectangle r, bool Checked)
        {
            DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo info;
            DevExpress.XtraEditors.Drawing.CheckEditPainter painter;
            DevExpress.XtraEditors.Drawing.ControlGraphicsInfoArgs args;
            info = checkEdit.CreateViewInfo() as DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo;
            painter = checkEdit.CreatePainter() as DevExpress.XtraEditors.Drawing.CheckEditPainter;
            info.EditValue = Checked;

            info.Bounds = r;
            info.PaintAppearance.ForeColor = System.Drawing.Color.Black;
            info.CalcViewInfo(g);
            args = new DevExpress.XtraEditors.Drawing.ControlGraphicsInfoArgs(info, new DevExpress.Utils.Drawing.GraphicsCache(g), r);
            painter.Draw(args);
            args.Cache.Dispose();
        }
    }
}
