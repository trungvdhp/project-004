namespace Project._008.UserControls
{
    partial class ucLookUpEdit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lookUpEdit
            // 
            this.lookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpEdit.Location = new System.Drawing.Point(3, 6);
            this.lookUpEdit.Name = "lookUpEdit";
            this.lookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit.Size = new System.Drawing.Size(298, 20);
            this.lookUpEdit.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Image = global::Project._008.Properties.Resources.Button_Insert_16;
            this.btnAdd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAdd.Location = new System.Drawing.Point(307, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(37, 22);
            this.btnAdd.TabIndex = 1;
            // 
            // ucLookUpEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lookUpEdit);
            this.Name = "ucLookUpEdit";
            this.Size = new System.Drawing.Size(347, 30);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.LookUpEdit lookUpEdit;
        public DevExpress.XtraEditors.SimpleButton btnAdd;
    }
}
