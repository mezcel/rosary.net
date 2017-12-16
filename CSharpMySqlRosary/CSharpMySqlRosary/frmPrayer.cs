using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient; //mysql library, doownload Utilities from the MySql Installer

namespace CSharpMySqlRosary
{
    public partial class frmPrayer : Form
    {
        //connect c# to mysql schema database
        // MySqlConnection mcon = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=sumano00");//localhost
        MySqlConnection mcon = new MySqlConnection(RosaryVarsBetweenForms.ConnStrRose); //localhost
        MySqlCommand mcd;
        MySqlDataAdapter mda;
        DataTable table;
        
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
        
        public frmPrayer()
        {
            InitializeComponent();
        }
        
        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMenu Menu = new frmMenu();
            Menu.StartPosition = FormStartPosition.Manual;
            Menu.Left = this.Left;
            Menu.Top = this.Top;
            Menu.Show();
            this.Close();
        }

        private void frmPrayer_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();
            loadPrayerNames();
        }

        // --- SQL --- --- ---
        public DataTable getData(string query)
        {
            mcd = new MySqlCommand(query, mcon);
            mda = new MySqlDataAdapter(mcd);
            table = new DataTable();
            mda.Fill(table);
            return table;
        }

        private void loadPrayerNames()
        {
            //name of the prayer
            string query = "SELECT prayerTypeID, prayerTypeName FROM lecciodivina.prayertype;";
            lbxPrayerName.DataSource = getData(query);
            lbxPrayerName.DisplayMember = "prayerTypeName";
            lbxPrayerName.ValueMember = "prayerTypeID";
        }

        private void loadPrayerText(int prayerType_FK, int lexicon_FK)
        {
            //the prayer itself
            // the listbox defaults its index to 0, so I had to "+1" the _FK ID, thats how the DB "hack" works
            string query = "SELECT prayertextString FROM lecciodivina.prayertext WHERE (prayerType_FK = " + prayerType_FK + ") AND (lexicon_FK = " + lexicon_FK + ");";

            txtPrayerText.Text = getData(query).Rows[0][0].ToString(); 
        }

        private void lbxPrayerName_SelectedValueChanged(object sender, EventArgs e)
        {

            if (rdoEnglish.Checked == true)
            { RosaryVarsBetweenForms.languageInt = 2; }
            else if (rdoSpanish.Checked == true)
            { RosaryVarsBetweenForms.languageInt = 3; }
            else if (rdoLatin.Checked == true)
            { RosaryVarsBetweenForms.languageInt = 4; }

            loadPrayerText(lbxPrayerName.SelectedIndex + 1 , RosaryVarsBetweenForms.languageInt);
        }

        private void rdoEnglish_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoEnglish.Checked == true)
            {
                RosaryVarsBetweenForms.languageInt = 2;
                loadPrayerText(lbxPrayerName.SelectedIndex + 1, RosaryVarsBetweenForms.languageInt);
            }
        }

        private void rdoSpanish_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSpanish.Checked == true)
            {
                RosaryVarsBetweenForms.languageInt = 3;
                loadPrayerText(lbxPrayerName.SelectedIndex + 1, RosaryVarsBetweenForms.languageInt);
            }
        }

        private void rdoLatin_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLatin.Checked == true)
            {
                RosaryVarsBetweenForms.languageInt = 4;
                loadPrayerText(lbxPrayerName.SelectedIndex + 1, RosaryVarsBetweenForms.languageInt);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();
        }    
    }
}
