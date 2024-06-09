namespace PLinView
{
    partial class AboutDlg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.okButton = new System.Windows.Forms.Button();
            this.lbProductDescript = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.lbCopyright = new System.Windows.Forms.Label();
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(307, 305);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "&OK";
            // 
            // lbProductDescript
            // 
            this.lbProductDescript.AutoSize = true;
            this.lbProductDescript.BackColor = System.Drawing.Color.Transparent;
            this.lbProductDescript.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductDescript.Location = new System.Drawing.Point(22, 149);
            this.lbProductDescript.Name = "lbProductDescript";
            this.lbProductDescript.Size = new System.Drawing.Size(119, 17);
            this.lbProductDescript.TabIndex = 29;
            this.lbProductDescript.Text = "lbProductDescript";
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.BackColor = System.Drawing.Color.Transparent;
            this.lbVersion.Location = new System.Drawing.Point(22, 183);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(56, 13);
            this.lbVersion.TabIndex = 30;
            this.lbVersion.Text = "lbVersion";
            // 
            // lbCopyright
            // 
            this.lbCopyright.AutoSize = true;
            this.lbCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lbCopyright.Location = new System.Drawing.Point(22, 206);
            this.lbCopyright.Name = "lbCopyright";
            this.lbCopyright.Size = new System.Drawing.Size(68, 13);
            this.lbCopyright.TabIndex = 31;
            this.lbCopyright.Text = "lbCopyright";
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.lbCompanyName.Location = new System.Drawing.Point(22, 230);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(94, 13);
            this.lbCompanyName.TabIndex = 32;
            this.lbCompanyName.Text = "lbCompanyName";
            // 
            // AboutDlg
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PLinView.Properties.Resources.About;
            this.ClientSize = new System.Drawing.Size(394, 340);
            this.Controls.Add(this.lbCompanyName);
            this.Controls.Add(this.lbCopyright);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.lbProductDescript);
            this.Controls.Add(this.okButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDlg";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label lbProductDescript;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label lbCopyright;
        private System.Windows.Forms.Label lbCompanyName;
    }
}
