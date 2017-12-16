namespace CSharpMySqlRosary
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbxButtonBox = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxButtonBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxButtonBox
            // 
            this.pbxButtonBox.BackColor = System.Drawing.Color.Black;
            this.pbxButtonBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxButtonBox.Image = global::CSharpMySqlRosary.Properties.Resources.MarbleBlock_UnPressed;
            this.pbxButtonBox.InitialImage = null;
            this.pbxButtonBox.Location = new System.Drawing.Point(57, 541);
            this.pbxButtonBox.Name = "pbxButtonBox";
            this.pbxButtonBox.Size = new System.Drawing.Size(337, 91);
            this.pbxButtonBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxButtonBox.TabIndex = 6;
            this.pbxButtonBox.TabStop = false;
            this.pbxButtonBox.Click += new System.EventHandler(this.pbxButtonBox_Click);
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CSharpMySqlRosary.Properties.Resources.KindleFire;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(453, 714);
            this.ControlBox = false;
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pbxButtonBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(453, 714);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(453, 714);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxButtonBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxButtonBox;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
    }
}

