using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Project._008.Models;
using Project._008.Controllers;
using Library;
using Library.UI;
using Library.UI.Form;
using Library.UI.Grid;

namespace Project._008.Views.HeThong
{

    public partial class frmVaiTro : DevExpress.XtraEditors.XtraForm
    {
        public frmVaiTro()
        {
            InitializeComponent();
        }

        private SYS_VaiTro _Entity;
        public SYS_VaiTro Entity
        {
            get 
            {
                _Entity.Ten_vai_tro = txtVaiTro.Text;
                _Entity.ID_cha = ledQuanLy.EditValue == null ? 0 : (int)ledQuanLy.EditValue;
                _Entity.Mo_ta = txtMoTa.Text;
                return _Entity;
            }
            set 
            { 
                _Entity = value;
                if (value != null)
                {
                    txtVaiTro.Text = value.Ten_vai_tro;
                    ledQuanLy.EditValue = value.ID_cha;
                    txtMoTa.Text = value.Mo_ta;
                }
            }
        }

        private void frmVaiTro_Load(object sender, EventArgs e)
        {
            txtVaiTro.Enabled = txtMoTa.Enabled = ledQuanLy.Enabled = false;

            gridView.Config(true, false, false, false, true);
            gridView.AppearanceColumns(new[] { colTen_vai_tro, colMo_Ta });

            Context db = new Context();

            SYS_VaiTroCtrl.LoadDataSource(ledQuanLy, db);
            SYS_VaiTroCtrl.LoadDataSource(repID_cha, db);

            gridControl.BeginUpdate();
            gridControl.DataSource = SYS_VaiTroCtrl.LoadDataSource(db);
            gridControl.RefreshDataSource();
            gridControl.EndUpdate();

            gridView.BestFitAllColumns();
            //------------------------------------------------------------
            ucAction.btnExit.Click += btnExit_Click;
            ucAction.btnInsert.Click += btnInsert_Click;
            ucAction.btnUpdate.Click += btnUpdate_Click;
            ucAction.btnDelete.Click += btnDelete_Click;
            ucAction.btnCommit.Click += btnCommit_Click;
        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Entity = gridView.GetFocusedRow() as SYS_VaiTro;
        }

        #region Config UserControl        
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (ucAction.nAction == 0)
            {
                this.Close();
            }
            else if (ucAction.nAction == -1)
            {
                gridView_FocusedRowChanged(gridView, new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs(-1, gridView.FocusedRowHandle));
                ledQuanLy.EditValue = 0;
                txtVaiTro.Enabled = txtMoTa.Enabled = ledQuanLy.Enabled = false;
            }
        }

        private void ResetGUI()
        {
            txtVaiTro.Text = txtMoTa.Text = string.Empty;
            ledQuanLy.EditValue = 0;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            txtVaiTro.Enabled = txtMoTa.Enabled = ledQuanLy.Enabled = true;

            ResetGUI();
            txtVaiTro.SetFocus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtVaiTro.Enabled = txtMoTa.Enabled = ledQuanLy.Enabled = true;

            txtVaiTro.SetFocus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridView.FocusedRowHandle < 0) return;

            if (INotify.ShowDeleteConfirm() == DialogResult.Yes)
            {
                try
                {
                    SYS_VaiTroCtrl.Delete(Entity);
                }
                catch
                {
                    INotify.ShowDeleteError();
                }
                finally
                {
                    gridControl.BeginUpdate();
                    gridControl.DataSource = SYS_VaiTroCtrl.LoadDataSource();
                    gridControl.RefreshDataSource();
                    gridControl.EndUpdate();
                }
            }
        }


        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (!Validator(new [] { txtVaiTro })) return;

            if (ucAction.nAction == 1)
            {
                try
                {
                    SYS_VaiTroCtrl.Insert(Entity);
                }
                catch (Exception) 
                {
                    INotify.ShowInsertError();
                }
            }
            else if (ucAction.nAction == 2)
            {
                try
                {
                    SYS_VaiTroCtrl.Update(Entity);
                }
                catch (Exception) 
                {
                    INotify.ShowUpdateError();
                }
            }
            ucAction.btnExit.PerformClick();

            gridControl.BeginUpdate();
            gridControl.DataSource = SYS_VaiTroCtrl.LoadDataSource();
            gridControl.RefreshDataSource();
            gridControl.EndUpdate();
            gridView.BestFitAllColumns();
        }

        #endregion

        bool IsValid;
        private bool Validator(Control[] controls = null)
        {
            IsValid = true;

            if (controls == null) return false;

            foreach (var control in controls)
            {
                control.Select();
            }

            return IsValid;
        }

        private void txtVaiTro_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtVaiTro.Text.Trim()))
                txtVaiTro.SetError(dxErrorProvider, "Chưa nhập mật khẩu!", ref IsValid);
            else
                dxErrorProvider.ClearErrors();
        }
    }
}