namespace CSharpMySqlRosary
{
    partial class frmLogin
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCon = new System.Windows.Forms.Button();
            this.lblUserAcct = new System.Windows.Forms.Label();
            this.lblPW = new System.Windows.Forms.Label();
            this.lblNetworkAdr = new System.Windows.Forms.Label();
            this.lbltcpip = new System.Windows.Forms.Label();
            this.txtUserAcct = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtNetAddress = new System.Windows.Forms.TextBox();
            this.txtTCPIP = new System.Windows.Forms.TextBox();
            this.lblDefaultLabel = new System.Windows.Forms.Label();
            this.btnDefault = new System.Windows.Forms.Button();
            this.rdoHide = new System.Windows.Forms.RadioButton();
            this.rdoShow = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(170, 185);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 55);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Terminate";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCon
            // 
            this.btnCon.BackColor = System.Drawing.Color.Turquoise;
            this.btnCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCon.Location = new System.Drawing.Point(12, 186);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(133, 55);
            this.btnCon.TabIndex = 13;
            this.btnCon.Text = "Continue";
            this.btnCon.UseVisualStyleBackColor = false;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // lblUserAcct
            // 
            this.lblUserAcct.AutoSize = true;
            this.lblUserAcct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserAcct.Location = new System.Drawing.Point(23, 80);
            this.lblUserAcct.Name = "lblUserAcct";
            this.lblUserAcct.Size = new System.Drawing.Size(97, 17);
            this.lblUserAcct.TabIndex = 3;
            this.lblUserAcct.Text = "User Account:";
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPW.Location = new System.Drawing.Point(47, 106);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(73, 17);
            this.lblPW.TabIndex = 0;
            this.lblPW.Text = "Password:";
            // 
            // lblNetworkAdr
            // 
            this.lblNetworkAdr.AutoSize = true;
            this.lblNetworkAdr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetworkAdr.Location = new System.Drawing.Point(3, 125);
            this.lblNetworkAdr.Name = "lblNetworkAdr";
            this.lblNetworkAdr.Size = new System.Drawing.Size(102, 15);
            this.lblNetworkAdr.TabIndex = 2;
            this.lblNetworkAdr.Text = "Network Address:";
            // 
            // lbltcpip
            // 
            this.lbltcpip.AutoSize = true;
            this.lbltcpip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltcpip.Location = new System.Drawing.Point(33, 151);
            this.lbltcpip.Name = "lbltcpip";
            this.lbltcpip.Size = new System.Drawing.Size(72, 15);
            this.lbltcpip.TabIndex = 3;
            this.lbltcpip.Text = "TCP/IP Port:";
            // 
            // txtUserAcct
            // 
            this.txtUserAcct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserAcct.Location = new System.Drawing.Point(128, 77);
            this.txtUserAcct.Name = "txtUserAcct";
            this.txtUserAcct.Size = new System.Drawing.Size(150, 23);
            this.txtUserAcct.TabIndex = 2;
            this.txtUserAcct.Text = "root";
            // 
            // txtPW
            // 
            this.txtPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPW.Location = new System.Drawing.Point(128, 106);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(150, 23);
            this.txtPW.TabIndex = 0;
            // 
            // txtNetAddress
            // 
            this.txtNetAddress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNetAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetAddress.ForeColor = System.Drawing.Color.Black;
            this.txtNetAddress.Location = new System.Drawing.Point(111, 122);
            this.txtNetAddress.Name = "txtNetAddress";
            this.txtNetAddress.Size = new System.Drawing.Size(100, 23);
            this.txtNetAddress.TabIndex = 4;
            this.txtNetAddress.Text = "127.0.0.1";
            this.txtNetAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTCPIP
            // 
            this.txtTCPIP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTCPIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTCPIP.ForeColor = System.Drawing.Color.Black;
            this.txtTCPIP.Location = new System.Drawing.Point(111, 148);
            this.txtTCPIP.Name = "txtTCPIP";
            this.txtTCPIP.Size = new System.Drawing.Size(100, 23);
            this.txtTCPIP.TabIndex = 3;
            this.txtTCPIP.Text = "3306";
            this.txtTCPIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDefaultLabel
            // 
            this.lblDefaultLabel.AutoSize = true;
            this.lblDefaultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaultLabel.Location = new System.Drawing.Point(20, 97);
            this.lblDefaultLabel.Name = "lblDefaultLabel";
            this.lblDefaultLabel.Size = new System.Drawing.Size(193, 13);
            this.lblDefaultLabel.TabIndex = 5;
            this.lblDefaultLabel.Text = "Default Service: Mysql@localhost:3306";
            // 
            // btnDefault
            // 
            this.btnDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefault.Location = new System.Drawing.Point(6, 54);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(205, 40);
            this.btnDefault.TabIndex = 6;
            this.btnDefault.Text = "Reset to Default Connection";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // rdoHide
            // 
            this.rdoHide.AutoSize = true;
            this.rdoHide.Checked = true;
            this.rdoHide.Location = new System.Drawing.Point(128, 132);
            this.rdoHide.Name = "rdoHide";
            this.rdoHide.Size = new System.Drawing.Size(45, 17);
            this.rdoHide.TabIndex = 12;
            this.rdoHide.TabStop = true;
            this.rdoHide.Text = "hide";
            this.rdoHide.UseVisualStyleBackColor = true;
            this.rdoHide.CheckedChanged += new System.EventHandler(this.rdoHide_CheckedChanged);
            // 
            // rdoShow
            // 
            this.rdoShow.AutoSize = true;
            this.rdoShow.Location = new System.Drawing.Point(179, 132);
            this.rdoShow.Name = "rdoShow";
            this.rdoShow.Size = new System.Drawing.Size(50, 17);
            this.rdoShow.TabIndex = 1;
            this.rdoShow.Text = "show";
            this.rdoShow.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnTest);
            this.panel1.Controls.Add(this.lblNetworkAdr);
            this.panel1.Controls.Add(this.lbltcpip);
            this.panel1.Controls.Add(this.txtNetAddress);
            this.panel1.Controls.Add(this.txtTCPIP);
            this.panel1.Controls.Add(this.lblDefaultLabel);
            this.panel1.Controls.Add(this.btnDefault);
            this.panel1.Location = new System.Drawing.Point(348, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 179);
            this.panel1.TabIndex = 5;
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.SystemColors.Control;
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(6, 4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(205, 44);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Test Connection !!!";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 58);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnCon;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(579, 247);
            this.ControlBox = false;
            this.Controls.Add(this.lblPW);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.rdoShow);
            this.Controls.Add(this.txtUserAcct);
            this.Controls.Add(this.lblUserAcct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rdoHide);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.Label lblUserAcct;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.Label lblNetworkAdr;
        private System.Windows.Forms.Label lbltcpip;
        private System.Windows.Forms.TextBox txtUserAcct;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.TextBox txtNetAddress;
        private System.Windows.Forms.TextBox txtTCPIP;
        private System.Windows.Forms.Label lblDefaultLabel;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.RadioButton rdoHide;
        private System.Windows.Forms.RadioButton rdoShow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTest;
    }
}