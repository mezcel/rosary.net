using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpMySqlRosary
{
    public partial class frmMenu : Form
    {
        //--- form drag vvv ----------------------------------------
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }
        //--- form drag ^^^ ----------------------------------------
        
        public frmMenu()
        {
            InitializeComponent();

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();
            lblToday.Text = DateTime.Today.ToString("D");
            RadioBtnStateInput();
        }

        private void btnTitle_Click(object sender, EventArgs e)
        {
            Form1 cover = new Form1();
            cover.StartPosition = FormStartPosition.Manual;
            cover.Left = this.Left;
            cover.Top = this.Top;
            cover.Show();
            this.Close();
        }

        private void btnRosary_Click(object sender, EventArgs e)
        {
            frmRosary Rosary = new frmRosary();
            Rosary.StartPosition = FormStartPosition.Manual;
            Rosary.Left = this.Left;
            Rosary.Top = this.Top;

            RadioBtnStateOutput(); //inspect radio button state

            Rosary.Show();
            this.Close();
        }
		
		private void btnMeditation_Click(object sender, EventArgs e)
		{
            frmMeditation meditation = new frmMeditation();
            meditation.StartPosition = FormStartPosition.Manual;
            meditation.Left = this.Left;
            meditation.Top = this.Top;

            RadioBtnStateOutput(); //inspect radio button state

            meditation.Show();
            this.Close();
		}
		private void btnScripture_Click(object sender, EventArgs e)
		{
            frmScripture scriptures = new frmScripture();
            scriptures.StartPosition = FormStartPosition.Manual;
            scriptures.Left = this.Left;
            scriptures.Top = this.Top;

            RadioBtnStateOutput(); //inspect radio button state

            scriptures.Show();
            this.Close();
		}
		private void btnPrayer_Click(object sender, EventArgs e)
		{
            frmPrayer prayer = new frmPrayer();
            prayer.StartPosition = FormStartPosition.Manual;
            prayer.Left = this.Left;
            prayer.Top = this.Top;

            RadioBtnStateOutput(); //inspect radio button state

            prayer.Show();
            this.Close();
		}

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // --- void functions --- vvv ----
        private void RadioBtnStateOutput()
        { 
            //this will allow the rosary form to point to the rdo selected mystery
            if(rdoJoyful.Checked == true) 
            {
                RosaryVarsBetweenForms.JoyfulBool = true;
                RosaryVarsBetweenForms.SorrowfulBool = false;
                RosaryVarsBetweenForms.LuminousBool = false;
                RosaryVarsBetweenForms.GloriousBool = false;
            }
            else if (rdoSorrowful.Checked == true)
            {
                RosaryVarsBetweenForms.JoyfulBool = false;
                RosaryVarsBetweenForms.SorrowfulBool = true;
                RosaryVarsBetweenForms.LuminousBool = false;
                RosaryVarsBetweenForms.GloriousBool = false;
            }
            else if (rdoLuminous.Checked == true)
            {
                RosaryVarsBetweenForms.JoyfulBool = false;
                RosaryVarsBetweenForms.SorrowfulBool = false;
                RosaryVarsBetweenForms.LuminousBool = true;
                RosaryVarsBetweenForms.GloriousBool = false;
            }
            else if (rdoGlorious.Checked == true)
            {
                RosaryVarsBetweenForms.JoyfulBool = false;
                RosaryVarsBetweenForms.SorrowfulBool = false;
                RosaryVarsBetweenForms.LuminousBool = false;
                RosaryVarsBetweenForms.GloriousBool = true;
            }
        }

        private void RadioBtnStateInput()
        {
            //match the present rdo with the mystery in the rosary form
            if (RosaryVarsBetweenForms.JoyfulBool == true)
            {
                rdoJoyful.Checked = true;
            }
            else if (RosaryVarsBetweenForms.SorrowfulBool == true)
            {
                rdoSorrowful.Checked = true;
            }
            else if (RosaryVarsBetweenForms.LuminousBool == true)
            {
                rdoLuminous.Checked = true;
            }
            else if (RosaryVarsBetweenForms.GloriousBool == true)
            {
                rdoGlorious.Checked = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnMeditation_MouseEnter(object sender, EventArgs e)
        {
            btnMeditation.BackColor = Color.LightCyan;
        }

        private void btnMeditation_MouseLeave(object sender, EventArgs e)
        {
            btnMeditation.BackColor = Color.White;
        }

        private void btnPrayer_MouseEnter(object sender, EventArgs e)
        {
            btnPrayer.BackColor = Color.LightCyan;
        }

        private void btnPrayer_MouseLeave(object sender, EventArgs e)
        {
            btnPrayer.BackColor = Color.White;
        }

        private void btnScripture_MouseEnter(object sender, EventArgs e)
        {
            btnScripture.BackColor = Color.LightCyan;
        }

        private void btnScripture_MouseLeave(object sender, EventArgs e)
        {
            btnScripture.BackColor = Color.White;
        }

        private void btnRosary_MouseEnter(object sender, EventArgs e)
        {
            btnRosary.BackColor = Color.LightCyan;
        }

        private void btnRosary_MouseLeave(object sender, EventArgs e)
        {
            btnRosary.BackColor = Color.White;
        }


    }
}
