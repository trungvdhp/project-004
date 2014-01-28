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
        public static void Config(this SpinEdit spinEdit, string mask, long maxValue = 5000, long minValue = 0, Decimal? value = null, bool readOnly = false)
        {
            if (value != null) spinEdit.EditValue = Decimal.Parse(value.ToString());
            spinEdit.Properties.DisplayFormat.FormatString = mask;
            spinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            spinEdit.Properties.EditFormat.FormatString = mask;
            spinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            spinEdit.Properties.EditMask = mask;
            spinEdit.Properties.ReadOnly = readOnly;

            spinEdit.Properties.MaxValue = maxValue;
            spinEdit.Properties.MinValue = minValue;
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
