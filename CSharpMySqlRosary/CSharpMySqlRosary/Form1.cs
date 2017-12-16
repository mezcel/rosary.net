//--- default visual studio libraries ---
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//---
//mysql library, doownload Utilities from the MySql Installer
using MySql.Data.MySqlClient;

namespace CSharpMySqlRosary
{
    public partial class Form1 : Form
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
        
        public Form1()
        {
            // Size: 453, 714
            InitializeComponent(); 
            
            //designer add-on for animated buttons
            pbxButtonBox.MouseDown += new MouseEventHandler(pbxButtonBox_MouseDown);
            pbxButtonBox.MouseUp += new MouseEventHandler(pbxButtonBox_MouseUp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();
            RosaryVarsBetweenForms.isMySqlConnectedBool = false;
            RosaryVarsBetweenForms.languageInt = 2;
        }
                
        //--- button animation vvv ---------------------------------
        private void pbxButtonBox_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            pbxButtonBox.Image = CSharpMySqlRosary.Properties.Resources.MarbleBlock_Pressed;
        }

        private void pbxButtonBox_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            pbxButtonBox.Image = CSharpMySqlRosary.Properties.Resources.MarbleBlock_UnPressed;
        }
        //--- button animation ^^^ ---------------------------------

        private void pbxButtonBox_Click(object sender, EventArgs e)
        {
            if (RosaryVarsBetweenForms.isMySqlConnectedBool == true)
            {
                frmRosary Rosary = new frmRosary();
                Rosary.StartPosition = FormStartPosition.Manual;
                Rosary.Left = this.Left;
                Rosary.Top = this.Top;
                Rosary.Show();

                // check to ensure the orifinal Form1 does not get closed by this button
                if (RosaryVarsBetweenForms.OriginalMainForm1 == false)
                {
                    //close clone forms
                    this.Close();
                }
                else
                {
                    //hide original form
                    RosaryVarsBetweenForms.OriginalMainForm1 = false;
                    //initialize myster based on the day of the week
                    AquireTodaysRosaryMystery();
                    this.Hide();
                }
            }
            else if (RosaryVarsBetweenForms.isMySqlConnectedBool == false)
            {
                frmLogin loginform = new frmLogin();
                loginform.Show();
            }
        }

        private void AquireTodaysRosaryMystery()
        {
            DateTime pcClock = DateTime.Now;
            int dayInt;
            dayInt = (int)pcClock.DayOfWeek;

            if ((dayInt == 1) || (dayInt == 6))
            {
                RosaryVarsBetweenForms.JoyfulBool = true; //initialize default rdo to Joyful Mystery
            }
            else if ((dayInt == 2) || (dayInt == 5))
            {
                RosaryVarsBetweenForms.SorrowfulBool = true;
            }
            else if ((dayInt == 3) || (dayInt == 7))
            {
                RosaryVarsBetweenForms.GloriousBool = true;
            }
            else
            {
                RosaryVarsBetweenForms.LuminousBool = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
