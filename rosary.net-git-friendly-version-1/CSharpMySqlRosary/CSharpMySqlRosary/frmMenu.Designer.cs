namespace CSharpMySqlRosary
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnTitle = new System.Windows.Forms.Button();
            this.btnRosary = new System.Windows.Forms.Button();
            this.btnMeditation = new System.Windows.Forms.Button();
            this.btnScripture = new System.Windows.Forms.Button();
            this.btnPrayer = new System.Windows.Forms.Button();
            this.lblMystery = new System.Windows.Forms.Label();
            this.rdoGlorious = new System.Windows.Forms.RadioButton();
            this.rdoLuminous = new System.Windows.Forms.RadioButton();
            this.rdoSorrowful = new System.Windows.Forms.RadioButton();
            this.rdoJoyful = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblToday = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnTitle
            // 
            this.btnTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitle.Location = new System.Drawing.Point(141, 542);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(174, 34);
            this.btnTitle.TabIndex = 0;
            this.btnTitle.Text = "Title Screen";
            this.btnTitle.UseVisualStyleBackColor = true;
            this.btnTitle.Click += new System.EventHandler(this.btnTitle_Click);
            // 
            // btnRosary
            // 
            this.btnRosary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRosary.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnRosary.FlatAppearance.BorderSize = 4;
            this.btnRosary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRosary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRosary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRosary.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRosary.ForeColor = System.Drawing.Color.Maroon;
            this.btnRosary.Location = new System.Drawing.Point(62, 121);
            this.btnRosary.Name = "btnRosary";
            this.btnRosary.Size = new System.Drawing.Size(102, 50);
            this.btnRosary.TabIndex = 2;
            this.btnRosary.Text = "Rosary";
            this.btnRosary.UseVisualStyleBackColor = true;
            this.btnRosary.Click += new System.EventHandler(this.btnRosary_Click);
            this.btnRosary.MouseEnter += new System.EventHandler(this.btnRosary_MouseEnter);
            this.btnRosary.MouseLeave += new System.EventHandler(this.btnRosary_MouseLeave);
            // 
            // btnMeditation
            // 
            this.btnMeditation.BackColor = System.Drawing.Color.White;
            this.btnMeditation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMeditation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMeditation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeditation.Location = new System.Drawing.Point(62, 177);
            this.btnMeditation.Name = "btnMeditation";
            this.btnMeditation.Size = new System.Drawing.Size(102, 50);
            this.btnMeditation.TabIndex = 3;
            this.btnMeditation.Text = "Meditations";
            this.btnMeditation.UseVisualStyleBackColor = false;
            this.btnMeditation.Click += new System.EventHandler(this.btnMeditation_Click);
            this.btnMeditation.MouseEnter += new System.EventHandler(this.btnMeditation_MouseEnter);
            this.btnMeditation.MouseLeave += new System.EventHandler(this.btnMeditation_MouseLeave);
            // 
            // btnScripture
            // 
            this.btnScripture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScripture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScripture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScripture.Location = new System.Drawing.Point(62, 289);
            this.btnScripture.Name = "btnScripture";
            this.btnScripture.Size = new System.Drawing.Size(102, 50);
            this.btnScripture.TabIndex = 4;
            this.btnScripture.Text = "Scriptures";
            this.btnScripture.UseVisualStyleBackColor = true;
            this.btnScripture.Click += new System.EventHandler(this.btnScripture_Click);
            this.btnScripture.MouseEnter += new System.EventHandler(this.btnScripture_MouseEnter);
            this.btnScripture.MouseLeave += new System.EventHandler(this.btnScripture_MouseLeave);
            // 
            // btnPrayer
            // 
            this.btnPrayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrayer.Location = new System.Drawing.Point(62, 233);
            this.btnPrayer.Name = "btnPrayer";
            this.btnPrayer.Size = new System.Drawing.Size(102, 50);
            this.btnPrayer.TabIndex = 5;
            this.btnPrayer.Text = "Prayers / Language";
            this.btnPrayer.UseVisualStyleBackColor = true;
            this.btnPrayer.Click += new System.EventHandler(this.btnPrayer_Click);
            this.btnPrayer.MouseEnter += new System.EventHandler(this.btnPrayer_MouseEnter);
            this.btnPrayer.MouseLeave += new System.EventHandler(this.btnPrayer_MouseLeave);
            // 
            // lblMystery
            // 
            this.lblMystery.BackColor = System.Drawing.Color.Transparent;
            this.lblMystery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMystery.ForeColor = System.Drawing.Color.Black;
            this.lblMystery.Location = new System.Drawing.Point(214, 121);
            this.lblMystery.Name = "lblMystery";
            this.lblMystery.Size = new System.Drawing.Size(175, 20);
            this.lblMystery.TabIndex = 10;
            this.lblMystery.Text = "Select Mystery";
            this.lblMystery.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rdoGlorious
            // 
            this.rdoGlorious.BackColor = System.Drawing.Color.Transparent;
            this.rdoGlorious.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdoGlorious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoGlorious.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rdoGlorious.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGlorious.ForeColor = System.Drawing.Color.Maroon;
            this.rdoGlorious.Location = new System.Drawing.Point(214, 198);
            this.rdoGlorious.Name = "rdoGlorious";
            this.rdoGlorious.Size = new System.Drawing.Size(175, 21);
            this.rdoGlorious.TabIndex = 3;
            this.rdoGlorious.Text = "Glorious (wed. + sun.)";
            this.rdoGlorious.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoGlorious.UseVisualStyleBackColor = false;
            // 
            // rdoLuminous
            // 
            this.rdoLuminous.BackColor = System.Drawing.Color.Transparent;
            this.rdoLuminous.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdoLuminous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoLuminous.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rdoLuminous.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLuminous.ForeColor = System.Drawing.Color.Maroon;
            this.rdoLuminous.Location = new System.Drawing.Point(214, 225);
            this.rdoLuminous.Name = "rdoLuminous";
            this.rdoLuminous.Size = new System.Drawing.Size(175, 21);
            this.rdoLuminous.TabIndex = 2;
            this.rdoLuminous.Text = "Luminous (thursday)";
            this.rdoLuminous.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoLuminous.UseVisualStyleBackColor = false;
            // 
            // rdoSorrowful
            // 
            this.rdoSorrowful.BackColor = System.Drawing.Color.Transparent;
            this.rdoSorrowful.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdoSorrowful.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoSorrowful.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rdoSorrowful.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSorrowful.ForeColor = System.Drawing.Color.Maroon;
            this.rdoSorrowful.Location = new System.Drawing.Point(214, 171);
            this.rdoSorrowful.Name = "rdoSorrowful";
            this.rdoSorrowful.Size = new System.Drawing.Size(175, 21);
            this.rdoSorrowful.TabIndex = 1;
            this.rdoSorrowful.Text = "Sorrowful (tues. + fri.)";
            this.rdoSorrowful.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoSorrowful.UseVisualStyleBackColor = false;
            // 
            // rdoJoyful
            // 
            this.rdoJoyful.BackColor = System.Drawing.Color.Transparent;
            this.rdoJoyful.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdoJoyful.Checked = true;
            this.rdoJoyful.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoJoyful.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rdoJoyful.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoJoyful.ForeColor = System.Drawing.Color.Maroon;
            this.rdoJoyful.Location = new System.Drawing.Point(214, 144);
            this.rdoJoyful.Name = "rdoJoyful";
            this.rdoJoyful.Size = new System.Drawing.Size(175, 21);
            this.rdoJoyful.TabIndex = 0;
            this.rdoJoyful.TabStop = true;
            this.rdoJoyful.Text = "Joyful (mon. + sat.)";
            this.rdoJoyful.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoJoyful.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.RosyBrown;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnExit.FlatAppearance.BorderSize = 4;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(141, 582);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(174, 36);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "( Close Application )";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "10:30 AM";
            // 
            // lblToday
            // 
            this.lblToday.BackColor = System.Drawing.Color.Transparent;
            this.lblToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToday.Location = new System.Drawing.Point(62, 88);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(327, 21);
            this.lblToday.TabIndex = 12;
            this.lblToday.Text = "lblToday";
            this.lblToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CSharpMySqlRosary.Properties.Resources.MenuView;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(453, 714);
            this.ControlBox = false;
            this.Controls.Add(this.lblToday);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblMystery);
            this.Controls.Add(this.rdoGlorious);
            this.Controls.Add(this.rdoLuminous);
            this.Controls.Add(this.btnPrayer);
            this.Controls.Add(this.rdoSorrowful);
            this.Controls.Add(this.btnScripture);
            this.Controls.Add(this.rdoJoyful);
            this.Controls.Add(this.btnMeditation);
            this.Controls.Add(this.btnRosary);
            this.Controls.Add(this.btnTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.Button btnRosary;
        private System.Windows.Forms.Button btnMeditation;
        private System.Windows.Forms.Button btnScripture;
        private System.Windows.Forms.Button btnPrayer;
        private System.Windows.Forms.RadioButton rdoGlorious;
        private System.Windows.Forms.RadioButton rdoLuminous;
        private System.Windows.Forms.RadioButton rdoSorrowful;
        private System.Windows.Forms.RadioButton rdoJoyful;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMystery;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Timer timer1;
    }
}