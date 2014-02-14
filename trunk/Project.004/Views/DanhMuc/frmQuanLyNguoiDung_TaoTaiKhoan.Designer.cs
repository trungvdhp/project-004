namespace Project._004.Views.DanhMuc
{
    partial class frmQuanLyNguoiDung_TaoTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTaoTaiKhoan = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ledVaiTro = new DevExpress.XtraEditors.LookUpEdit();
            this.tedThoiGianCho = new DevExpress.XtraEditors.TimeEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtMatKhauXacNhan = new DevExpress.XtraEditors.TextEdit();
            this.chkKichHoatTaiKhoan = new DevExpress.XtraEditors.CheckEdit();
            this.ledNhanVien = new DevExpress.XtraEditors.LookUpEdit();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenDayDu = new DevExpress.XtraEditors.TextEdit();
            this.txtTenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledVaiTro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedThoiGianCho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauXacNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkKichHoatTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDayDu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Location = new System.Drawing.Point(187, 12);
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.Size = new System.Drawing.Size(85, 23);
            this.btnTaoTaiKhoan.TabIndex = 9;
            this.btnTaoTaiKhoan.Text = "Tạo tài khoản";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.ledVaiTro);
            this.panelControl1.Controls.Add(this.tedThoiGianCho);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.txtMatKhauXacNhan);
            this.panelControl1.Controls.Add(this.chkKichHoatTaiKhoan);
            this.panelControl1.Controls.Add(this.ledNhanVien);
            this.panelControl1.Controls.Add(this.txtMatKhau);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.txtTenDayDu);
            this.panelControl1.Controls.Add(this.txtTenDangNhap);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(375, 218);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 69);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Nhân viên:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 43);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Vai trò:";
            // 
            // ledVaiTro
            // 
            this.ledVaiTro.Location = new System.Drawing.Point(110, 40);
            this.ledVaiTro.Name = "ledVaiTro";
            this.ledVaiTro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledVaiTro.Size = new System.Drawing.Size(254, 20);
            this.ledVaiTro.TabIndex = 10;
            this.ledVaiTro.EditValueChanged += new System.EventHandler(this.ledVaiTro_EditValueChanged);
            // 
            // tedThoiGianCho
            // 
            this.tedThoiGianCho.EditValue = new System.DateTime(2013, 6, 28, 8, 0, 0, 0);
            this.tedThoiGianCho.Location = new System.Drawing.Point(110, 188);
            this.tedThoiGianCho.Name = "tedThoiGianCho";
            this.tedThoiGianCho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tedThoiGianCho.Properties.Mask.EditMask = "HH:mm";
            this.tedThoiGianCho.Size = new System.Drawing.Size(133, 20);
            this.tedThoiGianCho.TabIndex = 6;
            this.tedThoiGianCho.ToolTip = "Sau giờ:phút thì tài khoản đang đăng nhập sẽ tự động đăng xuất";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 191);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(67, 13);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Thời gian chờ:";
            // 
            // txtMatKhauXacNhan
            // 
            this.txtMatKhauXacNhan.EditValue = "";
            this.txtMatKhauXacNhan.Location = new System.Drawing.Point(110, 157);
            this.txtMatKhauXacNhan.Name = "txtMatKhauXacNhan";
            this.txtMatKhauXacNhan.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtMatKhauXacNhan.Properties.Mask.EditMask = "[a-zA-Z0-9!#$%&\'()*+,-.:;<=>?@[\\\\\\]{}^_`|~]+";
            this.txtMatKhauXacNhan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtMatKhauXacNhan.Properties.MaxLength = 30;
            this.txtMatKhauXacNhan.Properties.NullValuePrompt = "Nhập lại mật khẩu";
            this.txtMatKhauXacNhan.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtMatKhauXacNhan.Properties.PasswordChar = '*';
            this.txtMatKhauXacNhan.Size = new System.Drawing.Size(254, 20);
            this.txtMatKhauXacNhan.TabIndex = 5;
            // 
            // chkKichHoatTaiKhoan
            // 
            this.chkKichHoatTaiKhoan.EditValue = true;
            this.chkKichHoatTaiKhoan.Location = new System.Drawing.Point(249, 189);
            this.chkKichHoatTaiKhoan.Name = "chkKichHoatTaiKhoan";
            this.chkKichHoatTaiKhoan.Properties.Caption = "Kích hoạt tài khoản";
            this.chkKichHoatTaiKhoan.Size = new System.Drawing.Size(115, 19);
            this.chkKichHoatTaiKhoan.TabIndex = 7;
            // 
            // ledNhanVien
            // 
            this.ledNhanVien.Location = new System.Drawing.Point(110, 66);
            this.ledNhanVien.Name = "ledNhanVien";
            this.ledNhanVien.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.ledNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledNhanVien.Properties.NullText = "";
            this.ledNhanVien.Size = new System.Drawing.Size(254, 20);
            this.ledNhanVien.TabIndex = 2;
            this.ledNhanVien.EditValueChanged += new System.EventHandler(this.ledNhanVien_EditValueChanged);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.EditValue = "";
            this.txtMatKhau.Location = new System.Drawing.Point(110, 131);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtMatKhau.Properties.Mask.EditMask = "[a-zA-Z0-9!#$%&\'()*+,-.:;<=>?@[\\\\\\]{}^_`|~]+";
            this.txtMatKhau.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtMatKhau.Properties.MaxLength = 30;
            this.txtMatKhau.Properties.NullValuePrompt = "Nhập mật khẩu ít nhất là 6 ký tự";
            this.txtMatKhau.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtMatKhau.Properties.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(254, 20);
            this.txtMatKhau.TabIndex = 4;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 134);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 13);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "Mật khẩu:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 160);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(89, 13);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "Nhập lại mật khẩu:";
            // 
            // txtTenDayDu
            // 
            this.txtTenDayDu.Location = new System.Drawing.Point(110, 92);
            this.txtTenDayDu.Name = "txtTenDayDu";
            this.txtTenDayDu.Properties.MaxLength = 50;
            this.txtTenDayDu.Properties.NullValuePrompt = "Nhập tên đầy đủ";
            this.txtTenDayDu.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtTenDayDu.Size = new System.Drawing.Size(254, 20);
            this.txtTenDayDu.TabIndex = 3;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.txtTenDangNhap.Location = new System.Drawing.Point(110, 14);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtTenDangNhap.Properties.Mask.EditMask = "[a-zA-Z0-9_\\-\\.]+";
            this.txtTenDangNhap.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtTenDangNhap.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTenDangNhap.Properties.MaxLength = 30;
            this.txtTenDangNhap.Properties.NullValuePrompt = "Nhập tên đăng nhập ít nhất 3 ký tự";
            this.txtTenDangNhap.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtTenDangNhap.Size = new System.Drawing.Size(254, 20);
            this.txtTenDangNhap.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 95);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tên đầy đủ:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Tên đăng nhập:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnThoat);
            this.panelControl2.Controls.Add(this.btnTaoTaiKhoan);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 218);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(375, 40);
            this.panelControl2.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(278, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 23);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelControl2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(375, 258);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // frmQuanLyNguoiDung_TaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 258);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmQuanLyNguoiDung_TaoTaiKhoan";
            this.Load += new System.EventHandler(this.frmQuanLyNguoiDung_TaoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledVaiTro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedThoiGianCho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauXacNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkKichHoatTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDayDu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnTaoTaiKhoan;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit ledVaiTro;
        private DevExpress.XtraEditors.TimeEdit tedThoiGianCho;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtMatKhauXacNhan;
        private DevExpress.XtraEditors.CheckEdit chkKichHoatTaiKhoan;
        private DevExpress.XtraEditors.LookUpEdit ledNhanVien;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtTenDayDu;
        private DevExpress.XtraEditors.TextEdit txtTenDangNhap;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    }
}