namespace CSharpMySqlRosary
{
    partial class frmMeditation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMeditation));
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMeditation = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnMeditationPack = new System.Windows.Forms.Button();
            this.lbxMeditationText = new System.Windows.Forms.ListBox();
            this.lbxMeditationPack = new System.Windows.Forms.ListBox();
            this.lbxMeditationMystery = new System.Windows.Forms.ListBox();
            this.lbxMeditationBead = new System.Windows.Forms.ListBox();
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
            // lblMeditation
            // 
            this.lblMeditation.AutoSize = true;
            this.lblMeditation.BackColor = System.Drawing.Color.Black;
            this.lblMeditation.Font = new System.Drawing.Font("Palatino Linotype", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeditation.ForeColor = System.Drawing.Color.White;
            this.lblMeditation.Location = new System.Drawing.Point(55, 182);
            this.lblMeditation.Name = "lblMeditation";
            this.lblMeditation.Size = new System.Drawing.Size(218, 54);
            this.lblMeditation.TabIndex = 20;
            this.lblMeditation.Text = "Meditation";
            // 
            // btnRemove
            // 
            this.btnRemove.BackgroundImage = global::CSharpMySqlRosary.Properties.Resources.MarbleBlock;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(262, 191);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(132, 45);
            this.btnRemove.TabIndex = 23;
            this.btnRemove.Text = "Remove Remove Pack";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnMeditationPack
            // 
            this.btnMeditationPack.BackColor = System.Drawing.SystemColors.Control;
            this.btnMeditationPack.BackgroundImage = global::CSharpMySqlRosary.Properties.Resources.MarbleBlock;
            this.btnMeditationPack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeditationPack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeditationPack.Location = new System.Drawing.Point(262, 140);
            this.btnMeditationPack.Name = "btnMeditationPack";
            this.btnMeditationPack.Size = new System.Drawing.Size(132, 45);
            this.btnMeditationPack.TabIndex = 22;
            this.btnMeditationPack.Text = "Add Meditation Pack";
            this.btnMeditationPack.UseVisualStyleBackColor = false;
            // 
            // lbxMeditationText
            // 
            this.lbxMeditationText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxMeditationText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbxMeditationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxMeditationText.FormattingEnabled = true;
            this.lbxMeditationText.ItemHeight = 18;
            this.lbxMeditationText.Location = new System.Drawing.Point(56, 360);
            this.lbxMeditationText.Name = "lbxMeditationText";
            this.lbxMeditationText.ScrollAlwaysVisible = true;
            this.lbxMeditationText.Size = new System.Drawing.Size(338, 270);
            this.lbxMeditationText.TabIndex = 25;
            this.lbxMeditationText.SelectedIndexChanged += new System.EventHandler(this.lbxPrayerText_SelectedIndexChanged);
            // 
            // lbxMeditationPack
            // 
            this.lbxMeditationPack.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxMeditationPack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbxMeditationPack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxMeditationPack.FormattingEnabled = true;
            this.lbxMeditationPack.ItemHeight = 18;
            this.lbxMeditationPack.Location = new System.Drawing.Point(56, 242);
            this.lbxMeditationPack.Name = "lbxMeditationPack";
            this.lbxMeditationPack.ScrollAlwaysVisible = true;
            this.lbxMeditationPack.Size = new System.Drawing.Size(125, 108);
            this.lbxMeditationPack.TabIndex = 24;
            this.lbxMeditationPack.SelectedIndexChanged += new System.EventHandler(this.lbxPrayerName_SelectedIndexChanged);
            // 
            // lbxMeditationMystery
            // 
            this.lbxMeditationMystery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxMeditationMystery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbxMeditationMystery.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxMeditationMystery.FormattingEnabled = true;
            this.lbxMeditationMystery.ItemHeight = 18;
            this.lbxMeditationMystery.Location = new System.Drawing.Point(187, 242);
            this.lbxMeditationMystery.Name = "lbxMeditationMystery";
            this.lbxMeditationMystery.ScrollAlwaysVisible = true;
            this.lbxMeditationMystery.Size = new System.Drawing.Size(130, 108);
            this.lbxMeditationMystery.TabIndex = 26;
            this.lbxMeditationMystery.SelectedIndexChanged += new System.EventHandler(this.lbxChapter_SelectedIndexChanged);
            // 
            // lbxMeditationBead
            // 
            this.lbxMeditationBead.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxMeditationBead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbxMeditationBead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxMeditationBead.FormattingEnabled = true;
            this.lbxMeditationBead.ItemHeight = 18;
            this.lbxMeditationBead.Location = new System.Drawing.Point(323, 242);
            this.lbxMeditationBead.Name = "lbxMeditationBead";
            this.lbxMeditationBead.ScrollAlwaysVisible = true;
            this.lbxMeditationBead.Size = new System.Drawing.Size(71, 108);
            this.lbxMeditationBead.TabIndex = 27;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMeditation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CSharpMySqlRosary.Properties.Resources.KindleFire;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(453, 714);
            this.ControlBox = false;
            this.Controls.Add(this.lbxMeditationBead);
            this.Controls.Add(this.lbxMeditationMystery);
            this.Controls.Add(this.lbxMeditationText);
            this.Controls.Add(this.lbxMeditationPack);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnMeditationPack);
            this.Controls.Add(this.lblMeditation);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMeditation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmMeditation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblMeditation;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnMeditationPack;
        private System.Windows.Forms.ListBox lbxMeditationText;
        private System.Windows.Forms.ListBox lbxMeditationPack;
        private System.Windows.Forms.ListBox lbxMeditationMystery;
        private System.Windows.Forms.ListBox lbxMeditationBead;
        private System.Windows.Forms.Timer timer1;


    }
}