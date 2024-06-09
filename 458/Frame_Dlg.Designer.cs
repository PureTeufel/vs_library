namespace PLinView
{
    partial class FrameDlg
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbIDs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eData1 = new System.Windows.Forms.TextBox();
            this.eData2 = new System.Windows.Forms.TextBox();
            this.eData3 = new System.Windows.Forms.TextBox();
            this.eData4 = new System.Windows.Forms.TextBox();
            this.eData5 = new System.Windows.Forms.TextBox();
            this.eData6 = new System.Windows.Forms.TextBox();
            this.eData7 = new System.Windows.Forms.TextBox();
            this.eData8 = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.eLength = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCheck = new System.Windows.Forms.Label();
            this.lbPID = new System.Windows.Forms.Label();
            this.lbLen = new System.Windows.Forms.Label();
            this.lbDirect = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&ID (Hex):";
            // 
            // cbIDs
            // 
            this.cbIDs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIDs.FormattingEnabled = true;
            this.cbIDs.Location = new System.Drawing.Point(12, 25);
            this.cbIDs.Name = "cbIDs";
            this.cbIDs.Size = new System.Drawing.Size(121, 21);
            this.cbIDs.TabIndex = 1;
            this.cbIDs.SelectedIndexChanged += new System.EventHandler(this.cbIDs_SelectedIndexChanged);
            this.cbIDs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Length:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data (1..8):";
            // 
            // eData1
            // 
            this.eData1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.eData1.Location = new System.Drawing.Point(12, 73);
            this.eData1.MaxLength = 2;
            this.eData1.Name = "eData1";
            this.eData1.Size = new System.Drawing.Size(24, 22);
            this.eData1.TabIndex = 5;
            this.eData1.Text = "00";
            this.eData1.TextChanged += new System.EventHandler(this.Data_Changed);
            this.eData1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // eData2
            // 
            this.eData2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.eData2.Location = new System.Drawing.Point(42, 73);
            this.eData2.MaxLength = 2;
            this.eData2.Name = "eData2";
            this.eData2.Size = new System.Drawing.Size(24, 22);
            this.eData2.TabIndex = 6;
            this.eData2.Text = "00";
            this.eData2.TextChanged += new System.EventHandler(this.Data_Changed);
            this.eData2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // eData3
            // 
            this.eData3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.eData3.Location = new System.Drawing.Point(72, 73);
            this.eData3.MaxLength = 2;
            this.eData3.Name = "eData3";
            this.eData3.Size = new System.Drawing.Size(24, 22);
            this.eData3.TabIndex = 7;
            this.eData3.Text = "00";
            this.eData3.TextChanged += new System.EventHandler(this.Data_Changed);
            this.eData3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // eData4
            // 
            this.eData4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.eData4.Location = new System.Drawing.Point(102, 73);
            this.eData4.MaxLength = 2;
            this.eData4.Name = "eData4";
            this.eData4.Size = new System.Drawing.Size(24, 22);
            this.eData4.TabIndex = 8;
            this.eData4.Text = "00";
            this.eData4.TextChanged += new System.EventHandler(this.Data_Changed);
            this.eData4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // eData5
            // 
            this.eData5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.eData5.Location = new System.Drawing.Point(132, 73);
            this.eData5.MaxLength = 2;
            this.eData5.Name = "eData5";
            this.eData5.Size = new System.Drawing.Size(24, 22);
            this.eData5.TabIndex = 9;
            this.eData5.Text = "00";
            this.eData5.TextChanged += new System.EventHandler(this.Data_Changed);
            this.eData5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // eData6
            // 
            this.eData6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.eData6.Location = new System.Drawing.Point(162, 73);
            this.eData6.MaxLength = 2;
            this.eData6.Name = "eData6";
            this.eData6.Size = new System.Drawing.Size(24, 22);
            this.eData6.TabIndex = 10;
            this.eData6.Text = "00";
            this.eData6.TextChanged += new System.EventHandler(this.Data_Changed);
            this.eData6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // eData7
            // 
            this.eData7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.eData7.Location = new System.Drawing.Point(192, 73);
            this.eData7.MaxLength = 2;
            this.eData7.Name = "eData7";
            this.eData7.Size = new System.Drawing.Size(24, 22);
            this.eData7.TabIndex = 11;
            this.eData7.Text = "00";
            this.eData7.TextChanged += new System.EventHandler(this.Data_Changed);
            this.eData7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // eData8
            // 
            this.eData8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.eData8.Location = new System.Drawing.Point(222, 73);
            this.eData8.MaxLength = 2;
            this.eData8.Name = "eData8";
            this.eData8.Size = new System.Drawing.Size(24, 22);
            this.eData8.TabIndex = 12;
            this.eData8.Text = "00";
            this.eData8.TextChanged += new System.EventHandler(this.Data_Changed);
            this.eData8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(91, 236);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 15;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(172, 236);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // eLength
            // 
            this.eLength.Enabled = false;
            this.eLength.Location = new System.Drawing.Point(141, 25);
            this.eLength.Name = "eLength";
            this.eLength.Size = new System.Drawing.Size(45, 22);
            this.eLength.TabIndex = 17;
            this.eLength.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCheck);
            this.groupBox1.Controls.Add(this.lbPID);
            this.groupBox1.Controls.Add(this.lbLen);
            this.groupBox1.Controls.Add(this.lbDirect);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 113);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // lbCheck
            // 
            this.lbCheck.AutoSize = true;
            this.lbCheck.Location = new System.Drawing.Point(94, 82);
            this.lbCheck.Name = "lbCheck";
            this.lbCheck.Size = new System.Drawing.Size(88, 13);
            this.lbCheck.TabIndex = 10;
            this.lbCheck.Text = "Checksum Type:";
            // 
            // lbPID
            // 
            this.lbPID.AutoSize = true;
            this.lbPID.Location = new System.Drawing.Point(94, 25);
            this.lbPID.Name = "lbPID";
            this.lbPID.Size = new System.Drawing.Size(27, 13);
            this.lbPID.TabIndex = 9;
            this.lbPID.Text = "PID:";
            // 
            // lbLen
            // 
            this.lbLen.AutoSize = true;
            this.lbLen.Location = new System.Drawing.Point(94, 63);
            this.lbLen.Name = "lbLen";
            this.lbLen.Size = new System.Drawing.Size(46, 13);
            this.lbLen.TabIndex = 8;
            this.lbLen.Text = "Length:";
            // 
            // lbDirect
            // 
            this.lbDirect.AutoSize = true;
            this.lbDirect.Location = new System.Drawing.Point(94, 44);
            this.lbDirect.Name = "lbDirect";
            this.lbDirect.Size = new System.Drawing.Size(57, 13);
            this.lbDirect.TabIndex = 7;
            this.lbDirect.Text = "Direction:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Checksum Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "PID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Length:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Direction:";
            // 
            // FrameDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 271);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.eLength);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.eData8);
            this.Controls.Add(this.eData7);
            this.Controls.Add(this.eData6);
            this.Controls.Add(this.eData5);
            this.Controls.Add(this.eData4);
            this.Controls.Add(this.eData3);
            this.Controls.Add(this.eData2);
            this.Controls.Add(this.eData1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbIDs);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrameDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New transmit frame";
            this.Shown += new System.EventHandler(this.FrameDlg_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrameDlg_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbIDs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox eData1;
        private System.Windows.Forms.TextBox eData2;
        private System.Windows.Forms.TextBox eData3;
        private System.Windows.Forms.TextBox eData4;
        private System.Windows.Forms.TextBox eData5;
        private System.Windows.Forms.TextBox eData6;
        private System.Windows.Forms.TextBox eData7;
        private System.Windows.Forms.TextBox eData8;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox eLength;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCheck;
        private System.Windows.Forms.Label lbPID;
        private System.Windows.Forms.Label lbLen;
        private System.Windows.Forms.Label lbDirect;
    }
}