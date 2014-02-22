using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Project._008.UserControls
{
    public partial class ucAction : DevExpress.XtraEditors.XtraUserControl
    {
        public int nAction { get; set; } //-1: Hủy, 0: Thoát, 1: Thêm, 2: Sửa

        public ucAction()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            btnInsert.Enabled = btnUpdate.Enabled = btnDelete.Enabled = false;
            btnCommit.Enabled = true;

            btnCommit.Text = "Lưu";
            btnCommit.ImageIndex = 3;
            btnExit.Text = "Hủy";
            btnExit.ImageIndex = 4;

            nAction = 1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnInsert.Enabled = btnUpdate.Enabled = btnDelete.Enabled = false;
            btnCommit.Enabled = true;

            btnCommit.Text = "Cập nhật";
            btnCommit.ImageIndex = 3;
            btnExit.Text = "Hủy";
            btnExit.ImageIndex = 4;

            nAction = 2;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (btnExit.Text == "Hủy")
            {
                btnInsert.Enabled = btnUpdate.Enabled = btnDelete.Enabled = true;
                btnCommit.Enabled = false;

                btnCommit.Text = "";
                btnCommit.ImageIndex = -1;
                btnExit.Text = "Thoát";
                btnExit.ImageIndex = 5;

                nAction = -1;
            }
            else
            {
                nAction = 0;
            }
        }
    }
}
