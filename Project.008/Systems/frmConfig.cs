using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Project._008.Systems
{
    using Library;
    using Library.UI;
    using Library.UI.Form;

    public partial class frmConfig : DevExpress.XtraEditors.XtraForm
    {
        public frmConfig()
        {
            InitializeComponent();
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            txtServer.Text = Properties.Settings.Default.DS;
            txtUsername.Text = Properties.Settings.Default.UID;

            txtServer.SetFocus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            var databases = DbHelper.GetDatabaseList(txtServer.Text.Trim(), txtUsername.Text, txtPassword.Text);

            if (databases == null)
            {
                INotify.ShowError("Không thể kết nối, vui lòng kiểm tra lại!", "Lỗi kết nối");
                return;
            }

            cmbDatabase.DataSource = databases;
            cmbDatabase.SelectedIndex = databases.Count != 0 ? 0 : -1;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (cmbDatabase.Text == string.Empty)
                cmbDatabase.SetError(dxErrorProvider, "Chưa chọn cơ sở dữ liệu!");
            else
                dxErrorProvider.ClearErrors();

            Properties.Settings.Default.DS = txtServer.Text.Trim();
            Properties.Settings.Default.DB = cmbDatabase.Text;
            Properties.Settings.Default.UID = txtUsername.Text;
            Properties.Settings.Default.SSAP = DbHelper.EnCryptPass(txtPassword.Text);
            Properties.Settings.Default.Save();

            Program.ConnectionString = DbHelper.GetConnectionString(txtServer.Text, cmbDatabase.Text, txtUsername.Text, txtPassword.Text);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}