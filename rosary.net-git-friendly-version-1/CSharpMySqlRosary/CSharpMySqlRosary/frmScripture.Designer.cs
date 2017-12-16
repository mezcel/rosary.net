namespace CSharpMySqlRosary
{
    partial class frmScripture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScripture));
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lbxBook = new System.Windows.Forms.ListBox();
            this.lbxChapter = new System.Windows.Forms.ListBox();
            this.lbxVerse = new System.Windows.Forms.ListBox();
            this.btnScripturePack = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblLabel = new System.Windows.Forms.Label();
            this.lbxQuote = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.RoyalBlue;
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
            this.lblTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTime.Location = new System.Drawing.Point(203, 60);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 13);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "10:30 AM";
            // 
            // lbxBook
            // 
            this.lbxBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbxBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxBook.FormattingEnabled = true;
            this.lbxBook.ItemHeight = 18;
            this.lbxBook.Location = new System.Drawing.Point(56, 242);
            this.lbxBook.Name = "lbxBook";
            this.lbxBook.ScrollAlwaysVisible = true;
            this.lbxBook.Size = new System.Drawing.Size(97, 108);
            this.lbxBook.TabIndex = 13;
            this.lbxBook.SelectedValueChanged += new System.EventHandler(this.lbxBook__SelectedValueChanged);
            // 
            // lbxChapter
            // 
            this.lbxChapter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxChapter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbxChapter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxChapter.FormattingEnabled = true;
            this.lbxChapter.ItemHeight = 18;
            this.lbxChapter.Location = new System.Drawing.Point(159, 242);
            this.lbxChapter.Name = "lbxChapter";
            this.lbxChapter.ScrollAlwaysVisible = true;
            this.lbxChapter.Size = new System.Drawing.Size(158, 108);
            this.lbxChapter.TabIndex = 14;
            this.lbxChapter.SelectedValueChanged += new System.EventHandler(this.lbxChapter__SelectedValueChanged);
            // 
            // lbxVerse
            // 
            this.lbxVerse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxVerse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbxVerse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxVerse.FormattingEnabled = true;
            this.lbxVerse.ItemHeight = 18;
            this.lbxVerse.Location = new System.Drawing.Point(323, 242);
            this.lbxVerse.Name = "lbxVerse";
            this.lbxVerse.ScrollAlwaysVisible = true;
            this.lbxVerse.Size = new System.Drawing.Size(71, 108);
            this.lbxVerse.TabIndex = 15;
            this.lbxVerse.Click += new System.EventHandler(this.lbxVerse__Click);
            // 
            // btnScripturePack
            // 
            this.btnScripturePack.BackColor = System.Drawing.SystemColors.Control;
            this.btnScripturePack.BackgroundImage = global::CSharpMySqlRosary.Properties.Resources.MarbleBlock;
            this.btnScripturePack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScripturePack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScripturePack.Location = new System.Drawing.Point(262, 140);
            this.btnScripturePack.Name = "btnScripturePack";
            this.btnScripturePack.Size = new System.Drawing.Size(132, 45);
            this.btnScripturePack.TabIndex = 16;
            this.btnScripturePack.Text = "Add Scripture Pack";
            this.btnScripturePack.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackgroundImage = global::CSharpMySqlRosary.Properties.Resources.MarbleBlock;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(262, 191);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(132, 45);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Remove Scripture Pack";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.BackColor = System.Drawing.Color.Black;
            this.lblLabel.Font = new System.Drawing.Font("Palatino Linotype", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel.ForeColor = System.Drawing.Color.White;
            this.lblLabel.Location = new System.Drawing.Point(55, 182);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(201, 54);
            this.lblLabel.TabIndex = 18;
            this.lblLabel.Text = "Scriptures";
            // 
            // lbxQuote
            // 
            this.lbxQuote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbxQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxQuote.FormattingEnabled = true;
            this.lbxQuote.HorizontalScrollbar = true;
            this.lbxQuote.ItemHeight = 15;
            this.lbxQuote.Location = new System.Drawing.Point(56, 360);
            this.lbxQuote.Name = "lbxQuote";
            this.lbxQuote.ScrollAlwaysVisible = true;
            this.lbxQuote.Size = new System.Drawing.Size(338, 259);
            this.lbxQuote.TabIndex = 19;
            this.lbxQuote.Click += new System.EventHandler(this.lbxQuote__Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // frmScripture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSharpMySqlRosary.Properties.Resources.KindleFire;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(453, 714);
            this.ControlBox = false;
            this.Controls.Add(this.lbxQuote);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnScripturePack);
            this.Controls.Add(this.lbxVerse);
            this.Controls.Add(this.lbxChapter);
            this.Controls.Add(this.lbxBook);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(453, 714);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(453, 714);
            this.Name = "frmScripture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmScripture";
            this.Load += new System.EventHandler(this.frmScripture_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ListBox lbxBook;
        private System.Windows.Forms.ListBox lbxChapter;
        private System.Windows.Forms.ListBox lbxVerse;
        private System.Windows.Forms.Button btnScripturePack;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.ListBox lbxQuote;
        private System.Windows.Forms.Timer timer1;


    }
}