using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.UI.Form
{
    public static class ITextEdit
    {
        #region TextEdit
        /// <summary>
        /// Activates the control.
        /// </summary>
        /// <param name="txt">TextEdit</param>
        public static void SetFocus(this TextEdit txt)
        {
            txt.SelectionStart = 0;
            txt.SelectionLength = txt.Text.Length;
            txt.Select();
        }

        public static void Config(this TextEdit textEdit, int maxLength = 30, bool rightToLeft = false)
        {
            textEdit.Properties.MaxLength = maxLength;

            textEdit.RightToLeft = rightToLeft == true ? System.Windows.Forms.RightToLeft.Yes : System.Windows.Forms.RightToLeft.No;
        }

        public static void SetMask(this TextEdit textEdit, string editMask = null, DevExpress.XtraEditors.Mask.MaskType maskType = DevExpress.XtraEditors.Mask.MaskType.RegEx)
        {
            textEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            textEdit.Properties.Mask.EditMask = editMask;
            textEdit.Properties.Mask.MaskType = maskType;
        }

        public static void SetValue(this TextEdit textEdit, object value = null, string stringFormat = null)
        {
            if (value != null)
                textEdit.Text = stringFormat != null ? string.Format(stringFormat, value) : value.ToString();
        }

        public static void SetNullValue(this TextEdit textEdit, string value = null)
        {
            textEdit.Properties.NullValuePrompt = value;
            textEdit.Properties.NullValuePromptShowForEmptyValue = true;
        }
        #endregion

        public static void SetMask(this RepositoryItemTextEdit textEdit, string editMask = null, DevExpress.XtraEditors.Mask.MaskType maskType = DevExpress.XtraEditors.Mask.MaskType.RegEx)
        {
            textEdit.Mask.UseMaskAsDisplayFormat = true;
            textEdit.Mask.EditMask = editMask;
            textEdit.Mask.MaskType = maskType;
        }
    }
}
