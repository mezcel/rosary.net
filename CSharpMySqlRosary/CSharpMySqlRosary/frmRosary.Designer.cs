namespace CSharpMySqlRosary
{
    partial class frmRosary
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRosary));
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBeadButton = new System.Windows.Forms.Button();
            this.btnFwd = new System.Windows.Forms.Button();
            this.lblScripture = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblBeadCount = new System.Windows.Forms.Label();
            this.lblMystery = new System.Windows.Forms.Label();
            this.lblButton = new System.Windows.Forms.Label();
            this.btnPevText = new System.Windows.Forms.Button();
            this.btnNextText = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMenu.Image = global::CSharpMySqlRosary.Properties.Resources.Menu;
            this.btnMenu.Location = new System.Drawing.Point(56, 82);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(338, 52);
            this.btnMenu.TabIndex = 8;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::CSharpMySqlRosary.Properties.Resources.MarbleBlock;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Lucida Console", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(56, 567);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(169, 60);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "<~ ";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBeadButton
            // 
            this.btnBeadButton.BackColor = System.Drawing.Color.White;
            this.btnBeadButton.BackgroundImage = global::CSharpMySqlRosary.Properties.Resources.purplethumb;
            this.btnBeadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBeadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBeadButton.FlatAppearance.BorderSize = 0;
            this.btnBeadButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBeadButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBeadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeadButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeadButton.Location = new System.Drawing.Point(56, 260);
            this.btnBeadButton.Name = "btnBeadButton";
            this.btnBeadButton.Size = new System.Drawing.Size(338, 302);
            this.btnBeadButton.TabIndex = 6;
            this.btnBeadButton.Text = "Hail mary";
            this.btnBeadButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBeadButton.UseVisualStyleBackColor = false;
            this.btnBeadButton.Click += new System.EventHandler(this.btnBeadButton_Click);
            // 
            // btnFwd
            // 
            this.btnFwd.BackgroundImage = global::CSharpMySqlRosary.Properties.Resources.MarbleBlock;
            this.btnFwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFwd.FlatAppearance.BorderSize = 0;
            this.btnFwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFwd.Font = new System.Drawing.Font("Lucida Console", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFwd.Location = new System.Drawing.Point(225, 567);
            this.btnFwd.Name = "btnFwd";
            this.btnFwd.Size = new System.Drawing.Size(169, 60);
            this.btnFwd.TabIndex = 9;
            this.btnFwd.Text = " ~>";
            this.btnFwd.UseVisualStyleBackColor = true;
            this.btnFwd.Click += new System.EventHandler(this.btnFwd_Click);
            // 
            // lblScripture
            // 
            this.lblScripture.BackColor = System.Drawing.Color.Lavender;
            this.lblScripture.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScripture.Location = new System.Drawing.Point(56, 136);
            this.lblScripture.MaximumSize = new System.Drawing.Size(338, 74);
            this.lblScripture.MinimumSize = new System.Drawing.Size(338, 74);
            this.lblScripture.Name = "lblScripture";
            this.lblScripture.Size = new System.Drawing.Size(338, 74);
            this.lblScripture.TabIndex = 11;
            this.lblScripture.Text = "scripture reading / meditation";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTime.Location = new System.Drawing.Point(203, 60);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 13);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "10:30 AM";
            // 
            // lblBeadCount
            // 
            this.lblBeadCount.BackColor = System.Drawing.Color.LightCyan;
            this.lblBeadCount.Location = new System.Drawing.Point(56, 239);
            this.lblBeadCount.Name = "lblBeadCount";
            this.lblBeadCount.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.lblBeadCount.Size = new System.Drawing.Size(105, 16);
            this.lblBeadCount.TabIndex = 13;
            this.lblBeadCount.Text = "bead 1 decade 1";
            this.lblBeadCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMystery
            // 
            this.lblMystery.BackColor = System.Drawing.Color.LightCyan;
            this.lblMystery.Location = new System.Drawing.Point(294, 239);
            this.lblMystery.Name = "lblMystery";
            this.lblMystery.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.lblMystery.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMystery.Size = new System.Drawing.Size(100, 16);
            this.lblMystery.TabIndex = 14;
            this.lblMystery.Text = "mystery 1";
            this.lblMystery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblButton
            // 
            this.lblButton.BackColor = System.Drawing.Color.LightCyan;
            this.lblButton.Location = new System.Drawing.Point(162, 239);
            this.lblButton.Name = "lblButton";
            this.lblButton.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.lblButton.Size = new System.Drawing.Size(131, 16);
            this.lblButton.TabIndex = 15;
            this.lblButton.Text = "button description";
            this.lblButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPevText
            // 
            this.btnPevText.Location = new System.Drawing.Point(56, 213);
            this.btnPevText.Name = "btnPevText";
            this.btnPevText.Size = new System.Drawing.Size(169, 23);
            this.btnPevText.TabIndex = 16;
            this.btnPevText.Text = "<< previous";
            this.btnPevText.UseVisualStyleBackColor = true;
            this.btnPevText.Click += new System.EventHandler(this.btnPevText_Click);
            // 
            // btnNextText
            // 
            this.btnNextText.Location = new System.Drawing.Point(225, 213);
            this.btnNextText.Name = "btnNextText";
            this.btnNextText.Size = new System.Drawing.Size(169, 23);
            this.btnNextText.TabIndex = 17;
            this.btnNextText.Text = "next >>";
            this.btnNextText.UseVisualStyleBackColor = true;
            this.btnNextText.Click += new System.EventHandler(this.btnNextText_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmRosary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CSharpMySqlRosary.Properties.Resources.KindleFire;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(453, 714);
            this.ControlBox = false;
            this.Controls.Add(this.btnNextText);
            this.Controls.Add(this.btnPevText);
            this.Controls.Add(this.lblButton);
            this.Controls.Add(this.lblMystery);
            this.Controls.Add(this.lblBeadCount);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblScripture);
            this.Controls.Add(this.btnFwd);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnBeadButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(453, 714);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(453, 714);
            this.Name = "frmRosary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmRosary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnBeadButton;
        private System.Windows.Forms.Button btnFwd;
        private System.Windows.Forms.Label lblScripture;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblBeadCount;
        private System.Windows.Forms.Label lblMystery;
        private System.Windows.Forms.Label lblButton;
        private System.Windows.Forms.Button btnPevText;
        private System.Windows.Forms.Button btnNextText;
        private System.Windows.Forms.Timer timer1;
    }
}