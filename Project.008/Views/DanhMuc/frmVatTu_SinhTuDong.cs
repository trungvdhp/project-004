using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Project._008.Views.DanhMuc
{
    public partial class frmVatTu_SinhTuDong : DevExpress.XtraEditors.XtraForm
    {
        public frmVatTu_SinhTuDong()
        {
            InitializeComponent();
        }

        private void frmVatTu_SinhTuDong_Load(object sender, EventArgs e)
        {
            sedBatDau.Value = (decimal)3.2;
            sedKetThuc.Value = (decimal)6.5;
            sedKhoangCach.Value = (decimal)0.1;
        }
    }
}