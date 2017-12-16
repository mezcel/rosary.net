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
    public partial class frmRosary : Form
    {
        int beadtotal;
        int beadpos = 0;
        int repeatbead_temp = 0; //used to count sequential beads with the same number

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

        public frmRosary()
        {
            InitializeComponent();
            //designer add-on for animated buttons
            btnBack.MouseDown += new MouseEventHandler(btnBack_MouseDown);
            btnBack.MouseUp += new MouseEventHandler(btnBack_MouseUp);
            btnFwd.MouseDown += new MouseEventHandler(btnFwd_MouseDown);
            btnFwd.MouseUp += new MouseEventHandler(btnFwd_MouseUp);
            btnBeadButton.MouseDown += new MouseEventHandler(btnBeadButton_MouseDown);
            btnBeadButton.MouseUp += new MouseEventHandler(btnBeadButton_MouseUp);
        }
        private void frmRosary_Load(object sender, EventArgs e)
        {
            string query = "SELECT  COUNT(*) FROM (SELECT beadnumber FROM lecciodivina.bead GROUP BY beadnumber) groups;";
            beadtotal = Convert.ToInt32(getData(query).Rows[0][0]);

            lblTime.Text = DateTime.Now.ToShortTimeString();

            prayerString(0, 0); //initial display

            lblBeadCount.Text = "";
            lblButton.Text = "";
            lblMystery.Text = "";
            lblScripture.Text = "";
            mcon.Close();
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

        //--- button animation vvv ----------------------------------------
        private void btnBack_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            btnBack.Image = CSharpMySqlRosary.Properties.Resources.thumbButton;
            btnBeadButton.Image = CSharpMySqlRosary.Properties.Resources.bluethumbdark;
        }
        private void btnBack_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            btnBack.Image = CSharpMySqlRosary.Properties.Resources.MarbleBlock;
            btnBeadButton.Image = CSharpMySqlRosary.Properties.Resources.purplethumb;
        }
        private void btnFwd_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            btnFwd.Image = CSharpMySqlRosary.Properties.Resources.thumbButton;
            btnBeadButton.Image = CSharpMySqlRosary.Properties.Resources.bluethumbdark;
        }
        private void btnFwd_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            btnFwd.Image = CSharpMySqlRosary.Properties.Resources.MarbleBlock;
            btnBeadButton.Image = CSharpMySqlRosary.Properties.Resources.purplethumb;
        }
        private void btnBeadButton_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            btnBeadButton.Image = CSharpMySqlRosary.Properties.Resources.bluethumbdark;
        }
        private void btnBeadButton_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            btnBeadButton.Image = CSharpMySqlRosary.Properties.Resources.purplethumb;
        }
        
        //--- button animation ^^^ ----------------------------------------

        //--- bead navigate vvv ----------------------------------------
        private void btnBack_Click(object sender, EventArgs e)
        {
            repeatbead_temp = 0;

            if ((beadpos - 1) > 0)
            {
                string query;
                int repeatbeadNo;

                beadpos = beadpos - 1;

                query = "SELECT COUNT(beadNumber) FROM lecciodivina.bead WHERE beadNumber = " + beadpos + ";";
                repeatbeadNo = Convert.ToInt32(getData(query).Rows[0][0]);

                prayerTypeString(beadpos);
                verseString(beadpos, repeatbeadNo);
                meditationName(beadpos); //display a meditation instead of a verse
                prayerString(beadpos, repeatbeadNo);
                decadeCounter(beadpos, repeatbeadNo);
            }

            mcon.Close();
        }
        private void btnFwd_Click(object sender, EventArgs e)
        {
            repeatbead_temp = 0;

            if ((beadpos + 1) < (beadtotal))
            {
                string query;
                int repeatbeadNo;

                beadpos = beadpos + 1;

                query = "SELECT COUNT(beadNumber) FROM lecciodivina.bead WHERE beadNumber = " + beadpos + ";";
                repeatbeadNo = Convert.ToInt32(getData(query).Rows[0][0]);

                prayerTypeString(beadpos);
                verseString(beadpos, repeatbeadNo);
                meditationName(beadpos); //display a meditation instead of a verse
                prayerString(beadpos, repeatbeadNo);
                decadeCounter(beadpos, repeatbeadNo);
            }

            mcon.Close();
        }
        private void btnBeadButton_Click(object sender, EventArgs e)
        {
            repeatbead_temp = 0;

            if ((beadpos + 1) < (beadtotal))
            {
                string query;
                int repeatbeadNo;

                beadpos = beadpos + 1;

                query = "SELECT COUNT(beadNumber) FROM lecciodivina.bead WHERE beadNumber = " + beadpos + ";";
                repeatbeadNo = Convert.ToInt32(getData(query).Rows[0][0]);

                prayerTypeString(beadpos);
                verseString(beadpos, repeatbeadNo);
                meditationName(beadpos); //display a meditation instead of a verse
                prayerString(beadpos, repeatbeadNo);
                decadeCounter(beadpos, repeatbeadNo);
            }

            mcon.Close();
        }
        //--- bead navigate ^^^ ----------------------------------------
        
        //--- messages vvv ----------------------------------------
        private void btnPevText_Click(object sender, EventArgs e)
        { 
            //back verse
            string query;
            int repeatbeadNo;

            query = "SELECT COUNT(beadNumber) FROM lecciodivina.bead WHERE beadNumber = " + beadpos + ";";
            repeatbeadNo = Convert.ToInt32(getData(query).Rows[0][0]);

            if ((repeatbead_temp - 1) >= 0)
            {
                repeatbead_temp = repeatbead_temp - 1;
                verseString(beadpos, repeatbeadNo);
            }
            

            mcon.Close();
        }
        private void btnNextText_Click(object sender, EventArgs e)
        {
            //fwd verse
            string query;
            int repeatbeadNo;

            query = "SELECT COUNT(beadNumber) FROM lecciodivina.bead WHERE beadNumber = " + beadpos + ";";
            repeatbeadNo = Convert.ToInt32(getData(query).Rows[0][0]);

            if ((repeatbead_temp + 1) < repeatbeadNo)
            {
                repeatbead_temp = repeatbead_temp + 1;
                verseString(beadpos, repeatbeadNo);
            }
            else if (repeatbead_temp == 1)
            {
                verseString(beadpos, repeatbeadNo);
            }
            mcon.Close();
        }
        //--- messages ^^^ ----------------------------------------

        // --- SQL --- functions --- ---
        public DataTable getData(string query)
        {
            mcd = new MySqlCommand(query, mcon);
            mda = new MySqlDataAdapter(mcd);
            table = new DataTable();
            mda.Fill(table);
            return table;
        }
        private void beadNumber(int beadpos)
        {
            string query;
            query = "SELECT bead.beadNumber FROM lecciodivina.bead WHERE bead.beadNumber = " + beadpos + ";";
            lblBeadCount.Text = getData(query).Rows[0][0].ToString();
            //mcon.Close();
        }
        private void meditationName(int beadpos)
        {
            string query;
            int beadtype_watch;

            query = "SELECT beadtype_FK FROM lecciodivina.bead where beadNumber = " + beadpos + ";";
            beadtype_watch = Int32.Parse(getData(query).Rows[0][0].ToString()); // return the beadtype FK

            if (beadtype_watch == 10)
            {
                query = "SELECT meditationDescription FROM lecciodivina.meditation WHERE meditationID = (SELECT meditation_FK FROM lecciodivina.bead WHERE beadNumber = 7);";
                lblScripture.Text = getData(query).Rows[0][0].ToString();
            }
            
        }
        private void verseString(int beadpos, int repeatbeadNo)
        {
            string query;
            string book, chapter, verseNo, versequote;


            //disp scripture quote
            if (repeatbeadNo == 1)
            {
                repeatbead_temp = 0;
                query = "SELECT verseString FROM lecciodivina.verse, lecciodivina.bead WHERE verse.verseID = bead.verse_FK AND bead.beadNumber = " + beadpos + ";";
                //disp scripture quote
                versequote = getData(query).Rows[0][0].ToString();
                
                //disp book name
                query = "SELECT bookName FROM lecciodivina.book WHERE bookID = (SELECT book_FK FROM lecciodivina.verse, lecciodivina.bead WHERE verse.verseID = bead.verse_FK AND bead.beadNumber = " + beadpos + ");";
                book = getData(query).Rows[0][0].ToString();

                //disp chapter number
                query = "SELECT chapterNumber FROM lecciodivina.chapter WHERE chapterID = (SELECT chapter_FK FROM lecciodivina.verse, lecciodivina.bead WHERE verse.verseID = bead.verse_FK AND bead.beadNumber = " + beadpos + ");";
                chapter = getData(query).Rows[0][0].ToString();

                //disp verse number
                query = "SELECT verseNumber FROM lecciodivina.verse, lecciodivina.bead WHERE verse.verseID = bead.verse_FK AND bead.beadNumber = " + beadpos + ";";
                verseNo = getData(query).Rows[0][0].ToString();
            }
            else
            {
                query = "SELECT verseString FROM lecciodivina.verse, lecciodivina.bead WHERE verse.verseID = bead.verse_FK AND bead.beadNumber = " + beadpos + " LIMIT " + repeatbead_temp + " , 1;";
                //disp scripture quote
                versequote = getData(query).Rows[0][0].ToString();
                
                //disp book name
                query = "SELECT bookName FROM lecciodivina.book WHERE bookID = (SELECT book_FK FROM lecciodivina.verse, lecciodivina.bead WHERE verse.verseID = bead.verse_FK AND bead.beadNumber = " + beadpos + " LIMIT " + repeatbead_temp + " , 1);";
                book = getData(query).Rows[0][0].ToString();

                //disp chapter number
                query = "SELECT chapterNumber FROM lecciodivina.chapter WHERE chapterID = (SELECT chapter_FK FROM lecciodivina.verse, lecciodivina.bead WHERE verse.verseID = bead.verse_FK AND bead.beadNumber = " + beadpos + " limit 0,1);";
                chapter = getData(query).Rows[0][0].ToString();

                //disp verse number
                query = "SELECT verseNumber FROM lecciodivina.verse, lecciodivina.bead WHERE verse.verseID = bead.verse_FK AND bead.beadNumber = " + beadpos + " LIMIT " + repeatbead_temp + " , 1;";
                verseNo = getData(query).Rows[0][0].ToString();
            }

            lblButton.Text = book + " " + chapter + ":" + verseNo;
            lblScripture.Text = versequote;
            mcon.Close();
        }
        private void prayerString(int beadpos, int repeatbeadNo)
        {
            string query;

            if (repeatbeadNo < 2)
            {
                query = "SELECT prayertext.prayertextstring FROM lecciodivina.prayertext, lecciodivina.prayertype WHERE prayertext.prayertype_FK = prayertype.prayertypeID AND lexicon_FK = " + RosaryVarsBetweenForms.languageInt + " AND prayertype.prayertypeID = (SELECT beadtype.prayertype_FK FROM lecciodivina.prayertype, lecciodivina.beadtype WHERE prayertype.prayertypeID = beadtype.prayertype_FK AND beadtype.beadtypeID = (SELECT bead.beadtype_FK FROM lecciodivina.bead WHERE beadNumber = " + beadpos + "));";
                repeatbead_temp = 0;
            }
            else
            {
                query = "SELECT prayertext.prayertextstring FROM lecciodivina.prayertext, lecciodivina.prayertype WHERE prayertext.prayertype_FK = prayertype.prayertypeID AND lexicon_FK = " +RosaryVarsBetweenForms.languageInt +" AND prayertype.prayertypeID = (SELECT beadtype.prayertype_FK FROM lecciodivina.prayertype, lecciodivina.beadtype WHERE prayertype.prayertypeID = beadtype.prayertype_FK AND beadtype.beadtypeID = (SELECT bead.beadtype_FK FROM lecciodivina.bead WHERE beadNumber = " + beadpos + " LIMIT 0 , 1 ));";
                if ((repeatbead_temp + 1) < repeatbeadNo)
                {
                    repeatbead_temp = repeatbead_temp + 1;
                }

            }

            btnBeadButton.Text = getData(query).Rows[0][0].ToString();
            

        }
        private void prayerTypeString(int beadpos)
        {
            string query;
            query = "SELECT beadTypeName FROM lecciodivina.beadtype WHERE beadtypeID = (SELECT bead.beadtype_FK FROM lecciodivina.bead WHERE beadNumber = " + beadpos + " LIMIT 0 , 1);";
            lblMystery.Text = getData(query).Rows[0][0].ToString();
            mcon.Close();
        }
        private void decadeCounter(int beadpos, int repeatbeadNo)
        {
            string query;
            int beadtype_watch, dec;
            int repeat = repeatbeadNo;

            query = "SELECT beadtype_FK FROM lecciodivina.bead where beadNumber = " + beadpos + ";";
            beadtype_watch = Int32.Parse(getData(query).Rows[0][0].ToString()); // return the beadtype FK
            
            if (beadtype_watch == 14)
            {
                //i used 7 because that was the math need to display 1-10
                query = "SELECT bead.beadNumber FROM lecciodivina.bead WHERE bead.beadNumber = " + beadpos + " limit 0,1;";
                dec = Int32.Parse(getData(query).Rows[0][0].ToString()) - 7; //do some math to match the bead counter

                lblBeadCount.Text = dec.ToString() + " of 10";
            }
            else
            {
                query = "SELECT beadTypeName FROM lecciodivina.beadtype where beadTypeID = (SELECT beadtype_FK FROM lecciodivina.bead where beadNumber = " + beadpos + " limit 0,1);";
                lblBeadCount.Text = getData(query).Rows[0][0].ToString();
            }

            mcon.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
