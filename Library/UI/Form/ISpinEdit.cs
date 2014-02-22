using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.UI.Form
{
    public static class ISpinEdit
    {
        public static void Config(this SpinEdit spinEdit, long maxValue = 5000, long minValue = 0, bool readOnly = false)
        {
            spinEdit.Properties.ReadOnly = readOnly;

            spinEdit.Properties.MaxValue = maxValue;
            spinEdit.Properties.MinValue = minValue;
        }

        public static void SetMask(this SpinEdit spinEdit, string editMask, DevExpress.XtraEditors.Mask.MaskType maskType = DevExpress.XtraEditors.Mask.MaskType.Numeric)
        {
            spinEdit.Properties.DisplayFormat.FormatString = editMask;
            spinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            spinEdit.Properties.EditFormat.FormatString = editMask;
            spinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            spinEdit.Properties.EditMask = editMask;
        }

        public static void SetValue(this SpinEdit spinEdit, object value = null, string stringFormat = null)
        {
            if (value != null)
                spinEdit.EditValue = Decimal.Parse(value.ToString());
        }

        public static void Config(this RepositoryItemSpinEdit spinEdit, string mask, long maxValue = 5000, long minValue = 0, Decimal? value = null, bool readOnly = false)
        {
            spinEdit.DisplayFormat.FormatString = mask;
            spinEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            spinEdit.EditFormat.FormatString = mask;
            spinEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            spinEdit.EditMask = mask;
            spinEdit.ReadOnly = readOnly;
        }
    }
}
