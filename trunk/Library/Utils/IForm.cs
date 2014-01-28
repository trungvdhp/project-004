using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;

namespace Library.UI
{
    public static class IForm
    {
        /// <summary>
        /// Show the form as a model dialog box.
        /// </summary>
        /// <param name="frm">XtraForm</param>
        /// <param name="state">FormWindowState</param>
        /// <param name="style">FormBorderStyle</param>
        /// <returns>DialogResult</returns>
        public static DialogResult ShowDialogForm(XtraForm frm, FormWindowState state = FormWindowState.Normal, FormBorderStyle style = FormBorderStyle.None)
        {
            frm.WindowState = state;
            frm.FormBorderStyle = style;
            frm.StartPosition = FormStartPosition.CenterScreen;

            return frm.ShowDialog();
        }

        #region TabControl
        /// <summary>
        /// Xóa XtraTabPage hiện thời trong XtraTabControl
        /// </summary>
        /// <param name="parent">Example: this.Parent</param>
        public static void CloseCurrentTabPage(this System.Windows.Forms.Control parent)
        {
            if (parent == null) return;
            DevExpress.XtraTab.XtraTabPage tabPage = parent as DevExpress.XtraTab.XtraTabPage;
            DevExpress.XtraTab.XtraTabControl tabControl = tabPage.Parent as DevExpress.XtraTab.XtraTabControl;
            tabControl.TabPages.Remove(tabPage);
        }

        /// <summary>
        /// Xóa toàn bộ XtraTabPage trong XtraTabControl
        /// </summary>
        /// <param name="tabControl">Example: xtraTabControl</param>
        public static void CloseAllTabPage(this DevExpress.XtraTab.XtraTabControl tabControl)
        {
            List<DevExpress.XtraTab.XtraTabPage> tabPages = new List<DevExpress.XtraTab.XtraTabPage>();

            tabPages.AddRange(tabControl.TabPages);

            foreach (DevExpress.XtraTab.XtraTabPage tabPage in tabPages)
            {
                tabControl.TabPages.Remove(tabPage);
            }
        }

        /// <summary>
        /// Thêm một XtraTabPage vào trong XtraTabControl
        /// </summary>
        /// <param name="frm">Example: new frmConfig()</param>
        /// <param name="tabControl">Example: xtraTabControl</param>
        public static void OpenTabPage(this DevExpress.XtraTab.XtraTabControl tabControl, DevExpress.XtraEditors.XtraForm frm)
        {
            foreach (DevExpress.XtraTab.XtraTabPage tab in tabControl.TabPages)
            {
                if (tab.Text == frm.Text)
                {
                    tabControl.SelectedTabPage = tab;
                    return;
                }
            }

            DevExpress.XtraTab.XtraTabPage tabPage = new DevExpress.XtraTab.XtraTabPage { Text = frm.Text };
            tabControl.TabPages.Add(tabPage);
            tabControl.SelectedTabPage = tabPage;
            frm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Parent = tabPage;
            frm.Show();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
        }
        #endregion

        /// <summary>
        /// Sets an error for a control.
        /// </summary>
        /// <param name="control">Control</param>
        /// <param name="dxErrorProvider">DXErrorProvider</param>
        /// <param name="errorText">string</param>
        /// <param name="isValid">bool</param>
        /// <param name="errorType">ErrorType</param>
        public static void SetError(this Control control, DXErrorProvider dxErrorProvider, string errorText, ref bool isValid, ErrorType errorType = ErrorType.User1)
        {
            isValid = false;
            dxErrorProvider.SetError(control, errorText, errorType);
            control.Focus();
        }

        /// <summary>
        /// Sets an error for a control.
        /// </summary>
        /// <param name="control">Control</param>
        /// <param name="dxErrorProvider">DXErrorProvider</param>
        /// <param name="errorText">string</param>
        /// <param name="isValid">bool</param>
        /// <param name="errorType">ErrorType</param>
        public static void SetError(this Control control, DXErrorProvider dxErrorProvider, string errorText, ErrorType errorType = ErrorType.User1)
        {
            dxErrorProvider.SetError(control, errorText, errorType);
            control.Focus();
        }
    }
}
