using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//mysql library, doownload Utilities from the MySql Installer
using MySql.Data.MySqlClient;

namespace CSharpMySqlRosary
{
    public partial class frmLogin : Form
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

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPW.Select(); //PW is the intial textbox
            this.AcceptButton = btnCon; //activates button when enter is pressed

            txtPW.UseSystemPasswordChar = true;
        }
    

        private void btnCon_Click(object sender, EventArgs e)
        {
            RosaryVarsBetweenForms.ConnStrRose = "datasource=" + txtNetAddress.Text + ";port=" + txtTCPIP.Text + ";username=" + txtUserAcct.Text + ";password=" + txtPW.Text;

            if (checkDB_Conn() == true)
            {
               
                RosaryVarsBetweenForms.isMySqlConnectedBool = true;
                // nothing to display since the login works
                this.Close();
            }
            else
            {
                RosaryVarsBetweenForms.isMySqlConnectedBool = false;
                label1.ForeColor = Color.Red;
                label1.Text = "!! Login Failed !!";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            txtUserAcct.Text = "root";
            txtPW.Text = "";
            txtNetAddress.Text = "127.0.0.1";
            txtTCPIP.Text = "3306";
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            RosaryVarsBetweenForms.ConnStrRose = "datasource=" + txtNetAddress.Text + ";port=" + txtTCPIP.Text + ";username=" + txtUserAcct.Text + ";password=" + txtPW.Text;

            if (checkDB_Conn() == true)
            {
                RosaryVarsBetweenForms.isMySqlConnectedBool = true;
                label1.ForeColor = Color.Green;
                label1.Text = "*** Login Passed ***";
            }
            else
            {
                RosaryVarsBetweenForms.isMySqlConnectedBool = false;
                label1.ForeColor = Color.Red;
                label1.Text = "!! Login Failed !!";
            }
        }

        public static bool checkDB_Conn()
        {
            // this functure is used to Flag if there is a successful MySql connection present

            var conn_info = RosaryVarsBetweenForms.ConnStrRose;
            bool isConn = false;
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(conn_info);
                conn.Open();
                isConn = true;
            }
            catch (MySqlException ex)
            {
                isConn = false;
                switch (ex.Number)
                {
                    /* this technique was aquired from: http://dev.mysql.com/doc/refman/5.0/en/error-messages-server.html */
                    case 1042: // Unable to connect to any of the specified MySQL hosts (Check Server,Port)
                        break;
                    case 0: // Access denied (Check DB name,username,password)
                        break;
                    default:
                        break;
                }
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return isConn;
        }

        private void rdoHide_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHide.Checked == false)
            {
                txtPW.UseSystemPasswordChar = false;
            }
            else
            {
                txtPW.UseSystemPasswordChar = true;
            }
        }


    }
}
