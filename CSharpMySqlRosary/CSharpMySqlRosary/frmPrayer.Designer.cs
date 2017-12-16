namespace CSharpMySqlRosary
{
    partial class frmPrayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrayer));
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPrayer = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPrayerPack = new System.Windows.Forms.Button();
            this.lbxPrayerName = new System.Windows.Forms.ListBox();
            this.rdoEnglish = new System.Windows.Forms.RadioButton();
            this.rdoSpanish = new System.Windows.Forms.RadioButton();
            this.rdoLatin = new System.Windows.Forms.RadioButton();
            this.txtPrayerText = new System.Windows.Forms.TextBox();
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
            this.btnMenu.TabIndex = 9;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
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
            // lblPrayer
            // 
            this.lblPrayer.AutoSize = true;
            this.lblPrayer.BackColor = System.Drawing.Color.Black;
            this.lblPrayer.Font = new System.Drawing.Font("Palatino Linotype", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrayer.ForeColor = System.Drawing.Color.White;
            this.lblPrayer.Location = new System.Drawing.Point(55, 182);
            this.lblPrayer.Name = "lblPrayer";
            this.lblPrayer.Size = new System.Drawing.Size(155, 54);
            this.lblPrayer.TabIndex = 19;
            this.lblPrayer.Text = "Prayers";
            // 
            // btnRemove
            // 
            this.btnRemove.BackgroundImage = global::CSharpMySqlRosary.Properties.Resources.MarbleBlock;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(262, 191);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(132, 45);
            this.btnRemove.TabIndex = 21;
            this.btnRemove.Text = "Remove Prayer Pack";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnPrayerPack
            // 
            this.btnPrayerPack.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrayerPack.BackgroundImage = global::CSharpMySqlRosary.Properties.Resources.MarbleBlock;
            this.btnPrayerPack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrayerPack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrayerPack.Location = new System.Drawing.Point(262, 140);
            this.btnPrayerPack.Name = "btnPrayerPack";
            this.btnPrayerPack.Size = new System.Drawing.Size(132, 45);
            this.btnPrayerPack.TabIndex = 20;
            this.btnPrayerPack.Text = "Add Prayer Pack";
            this.btnPrayerPack.UseVisualStyleBackColor = false;
            // 
            // lbxPrayerName
            // 
            this.lbxPrayerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxPrayerName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbxPrayerName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxPrayerName.FormattingEnabled = true;
            this.lbxPrayerName.ItemHeight = 16;
            this.lbxPrayerName.Location = new System.Drawing.Point(56, 242);
            this.lbxPrayerName.Name = "lbxPrayerName";
            this.lbxPrayerName.ScrollAlwaysVisible = true;
            this.lbxPrayerName.Size = new System.Drawing.Size(200, 80);
            this.lbxPrayerName.TabIndex = 22;
            this.lbxPrayerName.SelectedValueChanged += new System.EventHandler(this.lbxPrayerName_SelectedValueChanged);
            // 
            // rdoEnglish
            // 
            this.rdoEnglish.BackColor = System.Drawing.Color.Transparent;
            this.rdoEnglish.Checked = true;
            this.rdoEnglish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoEnglish.ForeColor = System.Drawing.Color.White;
            this.rdoEnglish.Location = new System.Drawing.Point(286, 254);
            this.rdoEnglish.Name = "rdoEnglish";
            this.rdoEnglish.Size = new System.Drawing.Size(81, 24);
            this.rdoEnglish.TabIndex = 24;
            this.rdoEnglish.TabStop = true;
            this.rdoEnglish.Text = "English";
            this.rdoEnglish.UseVisualStyleBackColor = false;
            this.rdoEnglish.CheckedChanged += new System.EventHandler(this.rdoEnglish_CheckedChanged);
            // 
            // rdoSpanish
            // 
            this.rdoSpanish.BackColor = System.Drawing.Color.Transparent;
            this.rdoSpanish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoSpanish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSpanish.ForeColor = System.Drawing.Color.White;
            this.rdoSpanish.Location = new System.Drawing.Point(286, 284);
            this.rdoSpanish.Name = "rdoSpanish";
            this.rdoSpanish.Size = new System.Drawing.Size(81, 24);
            this.rdoSpanish.TabIndex = 25;
            this.rdoSpanish.Text = "Spanish";
            this.rdoSpanish.UseVisualStyleBackColor = false;
            this.rdoSpanish.CheckedChanged += new System.EventHandler(this.rdoSpanish_CheckedChanged);
            // 
            // rdoLatin
            // 
            this.rdoLatin.BackColor = System.Drawing.Color.Transparent;
            this.rdoLatin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoLatin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLatin.ForeColor = System.Drawing.Color.White;
            this.rdoLatin.Location = new System.Drawing.Point(286, 314);
            this.rdoLatin.Name = "rdoLatin";
            this.rdoLatin.Size = new System.Drawing.Size(81, 24);
            this.rdoLatin.TabIndex = 26;
            this.rdoLatin.Text = "Latin";
            this.rdoLatin.UseVisualStyleBackColor = false;
            this.rdoLatin.CheckedChanged += new System.EventHandler(this.rdoLatin_CheckedChanged);
            // 
            // txtPrayerText
            // 
            this.txtPrayerText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrayerText.Location = new System.Drawing.Point(56, 347);
            this.txtPrayerText.Multiline = true;
            this.txtPrayerText.Name = "txtPrayerText";
            this.txtPrayerText.Size = new System.Drawing.Size(338, 280);
            this.txtPrayerText.TabIndex = 27;
            this.txtPrayerText.Text = "txtPrayerText";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // frmPrayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CSharpMySqlRosary.Properties.Resources.KindleFire;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(453, 714);
            this.ControlBox = false;
            this.Controls.Add(this.txtPrayerText);
            this.Controls.Add(this.rdoLatin);
            this.Controls.Add(this.rdoSpanish);
            this.Controls.Add(this.rdoEnglish);
            this.Controls.Add(this.lbxPrayerName);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnPrayerPack);
            this.Controls.Add(this.lblPrayer);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmPrayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblPrayer;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnPrayerPack;
        private System.Windows.Forms.ListBox lbxPrayerName;
        private System.Windows.Forms.RadioButton rdoEnglish;
        private System.Windows.Forms.RadioButton rdoSpanish;
        private System.Windows.Forms.RadioButton rdoLatin;
        private System.Windows.Forms.TextBox txtPrayerText;
        private System.Windows.Forms.Timer timer1;
    }
}