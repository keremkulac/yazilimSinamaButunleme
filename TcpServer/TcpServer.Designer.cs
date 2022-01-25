namespace yazilimSinamaButunleme
{
    partial class TcpServer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lstClientIP = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbSHA256 = new System.Windows.Forms.RadioButton();
            this.rbSPN = new System.Windows.Forms.RadioButton();
            this.rbAES = new System.Windows.Forms.RadioButton();
            this.rbDES = new System.Windows.Forms.RadioButton();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtEncryptMessage = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEncryptedMessage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFindMessage = new System.Windows.Forms.TextBox();
            this.dgvFindMessage = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(71, 21);
            this.txtIP.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(92, 26);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "127.0.0.1";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(11, 53);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInfo.Size = new System.Drawing.Size(419, 137);
            this.txtInfo.TabIndex = 2;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(4, 32);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(606, 91);
            this.txtMessage.TabIndex = 5;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(552, 129);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(58, 27);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(287, 20);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(58, 26);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lstClientIP
            // 
            this.lstClientIP.FormattingEnabled = true;
            this.lstClientIP.ItemHeight = 19;
            this.lstClientIP.Location = new System.Drawing.Point(438, 53);
            this.lstClientIP.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lstClientIP.Name = "lstClientIP";
            this.lstClientIP.Size = new System.Drawing.Size(193, 137);
            this.lstClientIP.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Client IP:";
            // 
            // rbSHA256
            // 
            this.rbSHA256.AutoSize = true;
            this.rbSHA256.Checked = true;
            this.rbSHA256.Location = new System.Drawing.Point(8, 86);
            this.rbSHA256.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbSHA256.Name = "rbSHA256";
            this.rbSHA256.Size = new System.Drawing.Size(82, 23);
            this.rbSHA256.TabIndex = 10;
            this.rbSHA256.TabStop = true;
            this.rbSHA256.Text = "SHA256";
            this.rbSHA256.UseVisualStyleBackColor = true;
            // 
            // rbSPN
            // 
            this.rbSPN.AutoSize = true;
            this.rbSPN.Location = new System.Drawing.Point(95, 86);
            this.rbSPN.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbSPN.Name = "rbSPN";
            this.rbSPN.Size = new System.Drawing.Size(57, 23);
            this.rbSPN.TabIndex = 11;
            this.rbSPN.Text = "SPN";
            this.rbSPN.UseVisualStyleBackColor = true;
            // 
            // rbAES
            // 
            this.rbAES.AutoSize = true;
            this.rbAES.Location = new System.Drawing.Point(155, 86);
            this.rbAES.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbAES.Name = "rbAES";
            this.rbAES.Size = new System.Drawing.Size(56, 23);
            this.rbAES.TabIndex = 12;
            this.rbAES.Text = "AES";
            this.rbAES.UseVisualStyleBackColor = true;
            // 
            // rbDES
            // 
            this.rbDES.AutoSize = true;
            this.rbDES.Location = new System.Drawing.Point(216, 86);
            this.rbDES.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbDES.Name = "rbDES";
            this.rbDES.Size = new System.Drawing.Size(56, 23);
            this.rbDES.TabIndex = 13;
            this.rbDES.Text = "DES";
            this.rbDES.UseVisualStyleBackColor = true;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(276, 81);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(69, 28);
            this.btnEncrypt.TabIndex = 14;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtEncryptMessage
            // 
            this.txtEncryptMessage.Location = new System.Drawing.Point(4, 32);
            this.txtEncryptMessage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEncryptMessage.Name = "txtEncryptMessage";
            this.txtEncryptMessage.Size = new System.Drawing.Size(324, 26);
            this.txtEncryptMessage.TabIndex = 15;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(11, 195);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(624, 215);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtMessage);
            this.tabPage1.Controls.Add(this.btnSend);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage1.Size = new System.Drawing.Size(616, 183);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Send Message";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(4, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(380, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Please enter the message to be send and select IP from above";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDecrypt);
            this.tabPage2.Controls.Add(this.btnClear);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtEncryptedMessage);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtEncryptMessage);
            this.tabPage2.Controls.Add(this.rbDES);
            this.tabPage2.Controls.Add(this.rbAES);
            this.tabPage2.Controls.Add(this.btnEncrypt);
            this.tabPage2.Controls.Add(this.rbSPN);
            this.tabPage2.Controls.Add(this.rbSHA256);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage2.Size = new System.Drawing.Size(616, 183);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Encrypt Message";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(350, 81);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(69, 28);
            this.btnDecrypt.TabIndex = 21;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(423, 81);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(53, 28);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(4, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Encrypted Message";
            // 
            // txtEncryptedMessage
            // 
            this.txtEncryptedMessage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEncryptedMessage.Location = new System.Drawing.Point(4, 147);
            this.txtEncryptedMessage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEncryptedMessage.Name = "txtEncryptedMessage";
            this.txtEncryptedMessage.Size = new System.Drawing.Size(606, 26);
            this.txtEncryptedMessage.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(4, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Choose an encryption type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Please enter the message to be encrypted";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(616, 183);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Send File";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.txtFindMessage);
            this.tabPage4.Controls.Add(this.dgvFindMessage);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(616, 183);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Find Message";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(294, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "Enter the message or sent date you want to find";
            // 
            // txtFindMessage
            // 
            this.txtFindMessage.Location = new System.Drawing.Point(3, 35);
            this.txtFindMessage.Name = "txtFindMessage";
            this.txtFindMessage.Size = new System.Drawing.Size(459, 26);
            this.txtFindMessage.TabIndex = 2;
            this.txtFindMessage.TextChanged += new System.EventHandler(this.txtFindMessage_TextChanged);
            // 
            // dgvFindMessage
            // 
            this.dgvFindMessage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvFindMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFindMessage.Location = new System.Drawing.Point(0, 67);
            this.dgvFindMessage.Name = "dgvFindMessage";
            this.dgvFindMessage.RowTemplate.Height = 25;
            this.dgvFindMessage.Size = new System.Drawing.Size(462, 113);
            this.dgvFindMessage.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(215, 20);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(50, 26);
            this.txtPort.TabIndex = 20;
            this.txtPort.Text = "9000";
            // 
            // TcpServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 447);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstClientIP);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TcpServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " ";
            this.Load += new System.EventHandler(this.TcpServer_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstClientIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbSHA256;
        private System.Windows.Forms.RadioButton rbSPN;
        private System.Windows.Forms.RadioButton rbAES;
        private System.Windows.Forms.RadioButton rbDES;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtEncryptMessage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEncryptedMessage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFindMessage;
        private System.Windows.Forms.DataGridView dgvFindMessage;
    }
}
