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
    public partial class frmScripture : Form
    {
        //connect c# to mysql schema database
        // MySqlConnection mcon = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=yourpw");//localhost
        MySqlConnection mcon = new MySqlConnection(RosaryVarsBetweenForms.ConnStrRose); //localhost
        MySqlCommand mcd;
        MySqlDataAdapter mda;
        //MySqlDataReader reader;
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

        public frmScripture()
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

        private void frmScripture_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();
            loadBooks();
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

        private void loadBooks()
        {
            //book
            string query = "SELECT * FROM lecciodivina.book;";
            lbxBook.DataSource = getData(query);
            lbxBook.DisplayMember = "bookName";
            lbxBook.ValueMember = "bookID";
        }

        private void loadChapters(int book_FK)
        {
            //chapters
            string query = "SELECT * FROM lecciodivina.chapter WHERE book_FK = " + book_FK + ";";
            lbxChapter.DataSource = getData(query);
            lbxChapter.DisplayMember = "chapterName";
            lbxChapter.ValueMember = "chapterID";
        }

        private void loadVerses(int chapter_FK, int book_FK)
        {
            //verses
            string query = "SELECT * FROM lecciodivina.verse where chapter_FK = " + chapter_FK + " AND book_FK = " + book_FK + ";";
            lbxVerse.DataSource = getData(query);
            lbxVerse.DisplayMember = "verseNumber";
            lbxVerse.ValueMember = "verseID";
        }

        private void loadQuotes(int chapter_FK, int book_FK)
        {
            //verses
            string query = "SELECT * FROM lecciodivina.verse where chapter_FK = " + chapter_FK + " AND book_FK = " + book_FK + ";";
            lbxQuote.DataSource = getData(query);
            lbxQuote.DisplayMember = "verseString";
            lbxQuote.ValueMember = "verseID";
        }

        private void lbxBook__SelectedValueChanged(object sender, EventArgs e)
        {
            lbxChapter.SelectedIndex = -1;
            loadChapters(lbxBook.SelectedIndex + 1);
            loadVerses(lbxChapter.SelectedIndex + 1, lbxBook.SelectedIndex + 1);
            loadQuotes(lbxChapter.SelectedIndex + 1, lbxBook.SelectedIndex + 1);
        }

        private void lbxChapter__SelectedValueChanged(object sender, EventArgs e)
        {
            lbxVerse.SelectedIndex = -1;
            loadVerses(lbxChapter.SelectedIndex + 1, lbxBook.SelectedIndex + 1);
            loadQuotes(lbxChapter.SelectedIndex + 1, lbxBook.SelectedIndex + 1);
        }

        private void lbxVerse__Click(object sender, EventArgs e)
        {
            loadQuotes(lbxChapter.SelectedIndex + 1, lbxBook.SelectedIndex + 1);
            lbxQuote.SelectedIndex = lbxVerse.SelectedIndex;
        }

        private void lbxQuote__Click(object sender, EventArgs e)
        {
            lbxVerse.SelectedIndex = lbxQuote.SelectedIndex;
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
