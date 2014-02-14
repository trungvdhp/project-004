using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.UI.Form
{
    public static class IDateTime
    {
        public static void Config(this DateEdit dateEdit, string mask, DateTime? value = null, bool readOnly = false, DateTime? minValue = null, DateTime? maxValue = null)
        {
            if (value != null) dateEdit.EditValue = DateTime.Parse(value.ToString());
            dateEdit.Properties.DisplayFormat.FormatString = mask;
            dateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dateEdit.Properties.EditFormat.FormatString = mask;
            dateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dateEdit.Properties.EditMask = mask;
            dateEdit.Properties.ReadOnly = readOnly;

            if (minValue != null && maxValue != null)
            {
                dateEdit.Properties.MaxValue = maxValue.Value;
                dateEdit.Properties.MinValue = minValue.Value;
            }
        }
    }
}
