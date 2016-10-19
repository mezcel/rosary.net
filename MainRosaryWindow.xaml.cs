
using ClientServerInterfaces;
//using ChattingServer;

using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using MySql.Data.MySqlClient; //use mysql
using System.Data; //use datasets

//ip socket specific
using System.Net.NetworkInformation;
using System.Net;
using System.Net.Sockets;

//used for obtaining all ips
using System.Diagnostics;
using System.IO;

//used in parsing
using System.Text.RegularExpressions;

namespace RosaryClient
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainRosaryWindow : Window
    {
        //chat server
        public static IChattingService Server;
        private static DuplexChannelFactory<IChattingService> _channelFactory;

        #region MySql DB Server


        int beadtotal;
        int beadpos = 0; //default forward
        int beadposRev = 0; //temporary reverse
        int beadposFwd = 0; //temporary forward
        int repeatbead_temp = 0; //used to count sequential beads with the same number (used in verse and prayer)
        int repeat_prayer_temp = 0; //this is directly related to the repeatbead_temp, but used to prevent confusion in 

        public static string ASUSconnectionstringmysql = "datasource=127.0.0.1;port=3306;username=root;password=sumano00;";
        //public static string ASUSconnectionstringmysql = "datasource=192.168.1.100;port=3306;username=root;password=sumano00;";
        //127.0.0.1
        //192.168.1.100
        //public static string DELLconnectionstringmysql = "datasource=127.0.0.1;port=3306;username=mezcel;password=;";
        //public static string DELLconnectionstringmysql = "datasource=192.168.1.102;port=3306;username=mezcel;password=;"; //toddnetwork
        public static string DELLconnectionstringmysql = "datasource=192.168.1.100;port=3306;username=mezcel;password=;";
        //198.105.254.20
        //198.105.244.20
        //192.168.1.100
        //127.0.0.1


        MySqlConnection mcon = new MySqlConnection(ASUSconnectionstringmysql); //localhost //DELLconnectionstringmysql //ASUSconnectionstringmysql
        //MySqlConnection mcon = new MySqlConnection(ASUSconnectionstringmysql);
        MySqlCommand mcd;
        MySqlDataAdapter mda;
        DataTable table;

        #endregion MySql DB Server

        public MainRosaryWindow()
        {
            InitializeComponent();
            RosaryVarsBetweenForms.ServerEndpointAddress = "localhost";
            //MyOwnNetworkingInitializations();
            coverArtCanvas.Visibility = Visibility.Visible;

        }

        public void MyOwnNetworkingInitializations()
        {

            #region chatserverStuff

            //_channelFactory = new DuplexChannelFactory<IChattingService>(new ClientCallback(), "ChattingServiceEndPoint"); //original working version
            string tcpendpointaddress; // = "net.tcp://192.168.0.100:7777/ChattingService";
            //tcpendpointaddress = "net.tcp://localhost:7777/ChattingService"; //test IP
            tcpendpointaddress = "net.tcp://" + RosaryVarsBetweenForms.ServerEndpointAddress + ":7777/ChattingService"; // actual ip
            
            _channelFactory = new DuplexChannelFactory<IChattingService>(new ClientCallback(), new NetTcpBinding(), new EndpointAddress(tcpendpointaddress));

            Server = _channelFactory.CreateChannel();

            #endregion chatserverStuff

            #region MySqlStuff

           // string LeccioDivinaIP = getIPv4("DELLMEZCEL");            
            //DELLconnectionstringmysql = "datasource=" + LeccioDivinaIP + ";port=3306;username=mezcel;password=;";
            string LeccioDivinaIP = getIPv4("ASUSLAPTOP");
            RosaryVarsBetweenForms.ConnStrRose = ASUSconnectionstringmysql; //localhost //DELLconnectionstringmysql //ASUSconnectionstringmysql
            //RosaryVarsBetweenForms.ConnStrRose = DELLconnectionstringmysql;
                RosaryVarsBetweenForms.languageInt = 2;
                string query = "SELECT  COUNT(*) FROM (SELECT beadnumber FROM lecciodivina.bead GROUP BY beadnumber) groups;";
                beadtotal = Convert.ToInt32(getData(query).Rows[0][0]);
                prayerString(0, 0); //initial display
                mcon.Close();

            #endregion MySqlStuff

        }

        #region InstantMessageServerGUI

        public void TakeMessage(string message, string userName) 
        {
            TextDisplayTextBox.Text += userName + ": " + message + "\n";
            TextDisplayTextBox.ScrollToEnd();
        }

        private void TextButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageTextBox.Text.Length == 0)
            {
                //this is just a catch if nothing, not even a space was entered
                //not will happen
                return;
            }

            Server.SendMessageToALL(MessageTextBox.Text, UserNameTextBox.Text);

            TakeMessage(MessageTextBox.Text, "You"); //i edited the SendMessageToALL function in ChattingService.cs
            MessageTextBox.Text = "";
            
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {   
            try
            {       
                if ((UserNameTextBox.Text != "") || (Server != null))
                {
                    int returnValue = Server.Login(UserNameTextBox.Text);

                    if (returnValue == 1)
                    {
                        MessageBox.Show("name is already used .... try being someone else");                
                    }
                    else if (returnValue == 0)
                    {
                        MessageBox.Show("you are now logged in");
                        WelcomeLabel.Content = "Welcome " + UserNameTextBox.Text + "!";
                        UserNameTextBox.IsEnabled = false;
                        LoginButton.IsEnabled = false;

                        LoadUserList(Server.GetCurrentUsers());                        
                    }

                    //the newest member in a group greater than 1 shall not initiate a bead, yet will be listed among the redy to proceede list
                    

                    if (UsersListBox.Items.Count > 1)
                    {
                        rdoBead.IsChecked = true;
                        BeadButton.IsEnabled = false;
                        BeadListBox.Items.Add(UserNameTextBox.Text);

                        // This is the waiting list Part
                        List<string> templist = new List<string>();
                        foreach (string item in BeadListBox.Items)
                        {
                            templist.Add(item);
                        }

                        Server.SendBeadListMessageToALL(templist, UserNameTextBox.Text);
                    }

                }
                else if (UserNameTextBox.Text == "")
                {
                    MessageBox.Show("Pick a user name visable and appropriate to others");
                    
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                MessageBox.Show("You are not Hosting or linked to an existing Chatting Server\n\nLink to a server Then Login");
                UserNameTextBox.Text = "";
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Server.Logout();

                SomeoneDropedTheirBead();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public void AddUserToList(string userName)
        {
            if (UsersListBox.Items.Contains(userName))
            {
                return;
            }

            UsersListBox.Items.Add(userName);
 
        }

        public void RemoveUserToList(string userName)
        {
            if (UsersListBox.Items.Contains(userName))
            {
                UsersListBox.Items.Remove(userName);
            }

        }

        private void LoadUserList(List<string> users)
        {
            foreach (var user in users)
            {
                AddUserToList(user);
            }
        }

        #endregion InstantMessageServerGUI

        #region BeadChat

        public void AddBeadUserToList(string userName)
        {
            if (BeadListBox.Items.Contains(userName))
            {
                return;
            }

            BeadListBox.Items.Add(userName);

        }

        public void TakeBeadMessage(string message, string userName)
        {
            TextDisplayTextBox.Text += userName + ": " + message + "\n";
            TextDisplayTextBox.ScrollToEnd();

            lblTest.Content = "Last Action: " + userName;
        }

        public void TakeBeadNumberMessage(int messageInt, string userName)
        {
            beadpos = messageInt; //update global var with group
        }

        public void TakeBeadListMessage(List<string> itemsinlist, string userName)
        {
            BeadListBox.Items.Clear();

            if (itemsinlist.Count < 1)
            {
                BeadButton.IsEnabled = true;
                rdoBead.IsChecked = false;
                return;
            }
            else
            {
                //BeadButton.IsEnabled = false;
                foreach (string item in itemsinlist)
                {
                    BeadListBox.Items.Add(item);
                }
            }

            //condition to re-activate button
            if (BeadListBox.Items.Count == UsersListBox.Items.Count)
            {
                //reactivate bead button
                BeadButton.IsEnabled = true;
                BeadListBox.Items.Clear();
            }
        }

        public void SomeoneDropedTheirBead()
        {   
            List<string> currentuserlistbox = new List<string>();
            foreach (string item in UsersListBox.Items)
            {
                currentuserlistbox.Add(item);
            }

            List<string> updatedBeadListBox = new List<string>();
            foreach (string item in BeadListBox.Items)
            {
                if(currentuserlistbox.Contains(item))
                {
                    updatedBeadListBox.Add(item);
                }
            }

            //condition to re-activate button and Reset
            if (BeadListBox.Items.Count == UsersListBox.Items.Count)
            {
                //reactivate bead button
                BeadButton.IsEnabled = true;
                BeadListBox.Items.Clear();
                //templist.Clear();
                //Server.SendBeadListMessageToALL(updatedBeadListBox, UserNameTextBox.Text);
            }
            else if (BeadListBox.Items.Count < UsersListBox.Items.Count)
            {
                Server.SendMessageToALL("Just Dropped their bead", UserNameTextBox.Text);
                Server.SendBeadListMessageToALL(updatedBeadListBox, UserNameTextBox.Text);
                //deactivate button
                BeadButton.IsEnabled = false;
            }

        }

        #endregion BeadChat

        #region RosaryMySql

        private void RosaryFunction()
        {
            if ((beadpos + 1) < (beadtotal))
            {
                string query;
                int repeatbeadNo;

                beadpos = beadpos + 1;

                beadposRev = beadpos; //update reverse location for future reverse
                beadposFwd = beadpos; //update reverse location for future reverse to fwd

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

        public DataTable getData(string query)
        {
            mcd = new MySqlCommand(query, mcon);
            mda = new MySqlDataAdapter(mcd);
            table = new DataTable();
            mda.Fill(table);
            return table;
        }

        private void prayerTypeString(int beadpos)
        {
            string query;

            query = "SELECT prayertext.prayertextname FROM lecciodivina.prayertext, lecciodivina.prayertype WHERE prayertext.prayertype_FK = prayertype.prayertypeID AND lexicon_FK = " + RosaryVarsBetweenForms.languageInt + " AND prayertype.prayertypeID = (SELECT beadtype.prayertype_FK FROM lecciodivina.prayertype, lecciodivina.beadtype WHERE prayertype.prayertypeID = beadtype.prayertype_FK AND beadtype.beadtypeID = (SELECT bead.beadtype_FK FROM lecciodivina.bead WHERE beadNumber = " + beadpos + " LIMIT 0 , 1 ));";

            mysteryBlock.Text = "Prayer: " + getData(query).Rows[0][0].ToString();
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

            bookchapterverse.Text = book + " " + chapter + ":" + verseNo;
            scriptureTextBlock.Text = versequote;

            int temp_verse_counter = repeatbead_temp + 1; //local temporary counter
            verseMonitor.Text = "Bead Scripture: " + temp_verse_counter + " of " + repeatbeadNo;

            mcon.Close();
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
                //lblScripture.Text = getData(query).Rows[0][0].ToString();
                scriptureTextBlock.Text = "Current Mystery: " + getData(query).Rows[0][0].ToString();
            }
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
                query = "SELECT prayertext.prayertextstring FROM lecciodivina.prayertext, lecciodivina.prayertype WHERE prayertext.prayertype_FK = prayertype.prayertypeID AND lexicon_FK = " + RosaryVarsBetweenForms.languageInt + " AND prayertype.prayertypeID = (SELECT beadtype.prayertype_FK FROM lecciodivina.prayertype, lecciodivina.beadtype WHERE prayertype.prayertypeID = beadtype.prayertype_FK AND beadtype.beadtypeID = (SELECT bead.beadtype_FK FROM lecciodivina.bead WHERE beadNumber = " + beadpos + " LIMIT 0 , 1 ));";
                if ((repeatbead_temp + 1) < repeatbeadNo)
                {
                    repeatbead_temp = repeatbead_temp + 1;
                }

            }

            prayerTextBlock.Text = getData(query).Rows[0][0].ToString();
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

                //this requres some calculation
                dec = Int32.Parse(getData(query).Rows[0][0].ToString()) - 7; //do some math to match the bead counter

                //lblBeadCount.Text = dec.ToString() + " of 10";
                decadeMonitor.Text = "Decade: " + dec.ToString() + " of 10";
            }
            else
            {
                query = "SELECT beadTypeName FROM lecciodivina.beadtype where beadTypeID = (SELECT beadtype_FK FROM lecciodivina.bead where beadNumber = " + beadpos + " limit 0,1);";
                //lblBeadCount.Text = getData(query).Rows[0][0].ToString();
                decadeMonitor.Text = "Bead : " + getData(query).Rows[0][0].ToString();
            }

            mcon.Close();
        }

        #endregion RosaryMySql

        private void btnExit_TouchDown(object sender, TouchEventArgs e)
        {
            try
            {
                Server.Logout();

                SomeoneDropedTheirBead();

                this.Close();
            }
            catch //(Exception ex)
            {
                this.Close();
            }
        }

        #region virtual_keyboard

        private void close_keyboard_Click(object sender, RoutedEventArgs e)
        {
            keyboardString.Text = "";
            keyboardCanvas.Visibility = Visibility.Hidden;
            
        }

        private void MessageTextBox_TouchEnter(object sender, TouchEventArgs e)
        {
            keyboardCanvas.Visibility = Visibility.Visible;
            keyboardDestinationLabel.Content = "Send a chat message ...";
            keyboardString.Text = "|";
        }

        private void UserNameTextBox_TouchEnter(object sender, TouchEventArgs e)
        {
            keyboardCanvas.Visibility = Visibility.Visible;
            keyboardDestinationLabel.Content = "User Name Input ...";
            keyboardString.Text = "|";
        }

        private void CapitalLetters()
        {
            letter_q.Content = "Q";
            letter_w.Content = "W";
            letter_e.Content = "E";
            letter_r.Content = "R";
            letter_t.Content = "T";
            letter_y.Content = "Y";
            letter_u.Content = "U";
            letter_i.Content = "I";
            letter_o.Content = "O";
            letter_p.Content = "P";

            letter_a.Content = "A";
            letter_s.Content = "S";
            letter_d.Content = "D";
            letter_f.Content = "F";
            letter_g.Content = "G";
            letter_h.Content = "H";
            letter_j.Content = "J";
            letter_k.Content = "K";
            letter_l.Content = "L";

            letter_z.Content = "Z";
            letter_x.Content = "X";
            letter_c.Content = "C";
            letter_v.Content = "V";
            letter_b.Content = "B";
            letter_n.Content = "N";
            letter_m.Content = "M"; 
        }

        private void LowerCaseLetters()
        {
            letter_q.Content = "q";
            letter_w.Content = "w";
            letter_e.Content = "e";
            letter_r.Content = "r";
            letter_t.Content = "t";
            letter_y.Content = "y";
            letter_u.Content = "u";
            letter_i.Content = "i";
            letter_o.Content = "o";
            letter_p.Content = "p";

            letter_a.Content = "a";
            letter_s.Content = "s";
            letter_d.Content = "d";
            letter_f.Content = "f";
            letter_g.Content = "g";
            letter_h.Content = "h";
            letter_j.Content = "j";
            letter_k.Content = "k";
            letter_l.Content = "l";

            letter_z.Content = "z";
            letter_x.Content = "x";
            letter_c.Content = "c";
            letter_v.Content = "v";
            letter_b.Content = "b";
            letter_n.Content = "n";
            letter_m.Content = "m";
        }

        private void shift_Click(object sender, RoutedEventArgs e)
        {

            if (shiftCheckBox.IsChecked == false)
            {
                shiftCheckBox.IsChecked = true;
                CapitalLetters();
            }
            else
            {
                shiftCheckBox.IsChecked = false;
                LowerCaseLetters();
            }
        }

        #endregion virtual_keyboard

        #region letters

        private void letter_q_Click(object sender, RoutedEventArgs e)
        {
            keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);
            if (shiftCheckBox.IsChecked == true)
            {
                keyboardString.Text = keyboardString.Text + "Q";
            }
            else
            {
                keyboardString.Text = keyboardString.Text + "q";
            }
            keyboardString.Text = keyboardString.Text + "|";
        }

        private void letter_w_Click(object sender, RoutedEventArgs e)
        {
            keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);
            if (shiftCheckBox.IsChecked == true)
            {
                keyboardString.Text = keyboardString.Text + "W";
            }
            else
            {
                keyboardString.Text = keyboardString.Text + "w";
            }
            keyboardString.Text = keyboardString.Text + "|";
        }

        private void letter_e_Click(object sender, RoutedEventArgs e)
        {
            keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);
            if (shiftCheckBox.IsChecked == true)
            {
                keyboardString.Text = keyboardString.Text + "E";
            }
            else
            {
                keyboardString.Text = keyboardString.Text + "e";
            }
            keyboardString.Text = keyboardString.Text + "|";
        }

        private void letter_r_Click(object sender, RoutedEventArgs e)
        {
            keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);
            if (shiftCheckBox.IsChecked == true)
            {
                keyboardString.Text = keyboardString.Text + "R";
            }
            else
            {
                keyboardString.Text = keyboardString.Text + "r";
            }
            keyboardString.Text = keyboardString.Text + "|";
        }

        private void letter_t_Click(object sender, RoutedEventArgs e)
        {
            keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);
            if (shiftCheckBox.IsChecked == true)
            {
                keyboardString.Text = keyboardString.Text + "T";
            }
            else
            {
                keyboardString.Text = keyboardString.Text + "t";
            }
            keyboardString.Text = keyboardString.Text + "|";
        }

        private void letter_y_Click(object sender, RoutedEventArgs e)
        {
            keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);
            if (shiftCheckBox.IsChecked == true)
            {
                keyboardString.Text = keyboardString.Text + "Y";
            }
            else
            {
                keyboardString.Text = keyboardString.Text + "y";
            }
            keyboardString.Text = keyboardString.Text + "|";
        }

        private void letter_u_Click(object sender, RoutedEventArgs e)
        {
            keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);
            if (shiftCheckBox.IsChecked == true)
            {
                keyboardString.Text = keyboardString.Text + "U";
            }
            else
            {
                keyboardString.Text = keyboardString.Text + "u";
            }
            keyboardString.Text = keyboardString.Text + "|";
        }

        private void letter_i_Click(object sender, RoutedEventArgs e)
        {
            keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);
            if (shiftCheckBox.IsChecked == true)
            {
                keyboardString.Text = keyboardString.Text + "I";
            }
            else
            {
                keyboardString.Text = keyboardString.Text + "i";
            }
            keyboardString.Text = keyboardString.Text + "|";
        }

        private void letter_o_Click(object sender, RoutedEventArgs e)
        {
            keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);
            if (shiftCheckBox.IsChecked == true)
            {
                keyboardString.Text = keyboardString.Text + "O";
            }
            else
            {
                keyboardString.Text = keyboardString.Text + "o";
            }
            keyboardString.Text = keyboardString.Text + "|";
        }

        private void letter_p_Click(object sender, RoutedEventArgs e)
        {
            keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);
            if (shiftCheckBox.IsChecked == true)
            {
                keyboardString.Text = keyboardString.Text + "P";
            }
            else
            {
                keyboardString.Text = keyboardString.Text + "p";
            }
            keyboardString.Text = keyboardString.Text + "|";
        }

        private void letter_a_Click(object sender, RoutedEventArgs e)
        {
            keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);
            if (shiftCheckBox.IsChecked == true)
            {
                keyboardString.Text = keyboardString.Text + "A";
            }
            else
            {
                keyboardString.Text = keyboardString.Text + "a";
            }
            keyboardString.Text = keyboardString.Text + "|";
        }

        private void letter_s_Click(object sender, RoutedEventArgs e)
        {
            keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);
            if (shiftCheckBox.IsChecked == true)
            {
                keyboardString.Text = keyboardString.Text + "S";
            }
            else
            {
                keyboardString.Text = keyboardString.Text + "s";
            }
            keyboardString.Text = keyboardString.Text + "|";
        }

        private void letter_d_Click(object sender, RoutedEventArgs e)
        {
            keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);
            if (shiftCheckBox.IsChecked == true)
            {
                keyboardString.Text = keyboardString.Text + "D";
            }
            else
            {
                keyboardString.Text = keyboardString.Text + "d";
            }
            keyboardString.Text = keyboardString.Text + "|";
        }

        private void letter_f_Click(object sender, RoutedEventArgs e)
        {
            keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);
            if (shiftCheckBox.IsChecked == true)
            {
                keyboardString.Text = keyboardString.Text + "F";
            }
            else
            {
                keyboardString.Text = keyboardString.Text + "f";
            }
            keyboardString.Text = keyboardString.Text + "|";
        }

        private void letter_g_Click(object sender, RoutedEventArgs e)
        {
            keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);
            if (shiftCheckBox.IsChecked == true)
            {
                keyboardString.Text = keyboardString.Text + "G";
            }
            else
            {
                keyboardString.Text = keyboardString.Text + "g";
            }
            keyboardString.Text = keyboardString.Text + "|";
        }

        private void letter_h_Click(object sender, RoutedEventArgs e)
        {
            keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);
            if (shiftCheckBox.IsChecked == true)
            {
                keyboardString.Text = keyboardString.Text + "H";
            }
            else
            {
                keyboardString.Text = keyboardString.Text + "h";
            }
            keyboardString.Text = keyboardString.Text + "|";
        }

        private void letter_j_Click(object sender, RoutedEventArgs e)
        {
            keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);
            if (shiftCheckBox.IsChecked == true)
            {
                keyboardString.Text = keyboardString.Text + "J";
            }
            else
            {
                keyboardString.Text = keyboardString.Text + "j";
            }
            keyboardString.Text = keyboardString.Text + "|";
        }

        private void letter_k_Click(object sender, RoutedEventArgs e)
        {
            keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);
            if (shiftCheckBox.IsChecked == true)
            {
                keyboardString.Text = keyboardString.Text + "K";
            }
            else
            {
                keyboardString.Text = keyboardString.Text + "k";
            }
            keyboardString.Text = keyboardString.Text + "|";
        }

        private void letter_l_Click(object sender, RoutedEventArgs e)
        {
            keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);
            if (shiftCheckBox.IsChecked == true)
            {
                keyboardString.Text = keyboardString.Text + "L";
            }
            else
            {
                keyboardString.Text = keyboardString.Text + "l";
            }
            keyboardString.Text = keyboardString.Text + "|";
        }

        private void letter_z_Click(object sender, RoutedEventArgs e)
        {
            keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);
            if (shiftCheckBox.IsChecked == true)
            {
                keyboardString.Text = keyboardString.Text + "Z";
            }
            else
            {
                keyboardString.Text = keyboardString.Text + "z";
            }
            keyboardString.Text = keyboardString.Text + "|";
        }

        private void letter_x_Click(object sender, RoutedEventArgs e)
        {
            keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);
            if (shiftCheckBox.IsChecked == true)
            {
                keyboardString.Text = keyboardString.Text + "X";
            }
            else
            {
                keyboardString.Text = keyboardString.Text + "x";
            }
            keyboardString.Text = keyboardString.Text + "|";
        }

        private void letter_c_Click(object sender, RoutedEventArgs e)
        {
            keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);
            if (shiftCheckBox.IsChecked == true)
            {
                keyboardString.Text = keyboardString.Text + "C";
            }
            else
            {
                keyboardString.Text = keyboardString.Text + "c";
            }
            keyboardString.Text = keyboardString.Text + "|";
        }

        private void letter_v_Click(object sender, RoutedEventArgs e)
        {
            keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);
            if (shiftCheckBox.IsChecked == true)
            {
                keyboardString.Text = keyboardString.Text + "V";
            }
            else
            {
                keyboardString.Text = keyboardString.Text + "v";
            }
            keyboardString.Text = keyboardString.Text + "|";
        }

        private void letter_b_Click(object sender, RoutedEventArgs e)
        {
            keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);
            if (shiftCheckBox.IsChecked == true)
            {
                keyboardString.Text = keyboardString.Text + "B";
            }
            else
            {
                keyboardString.Text = keyboardString.Text + "b";
            }
            keyboardString.Text = keyboardString.Text + "|";
        }

        private void letter_n_Click(object sender, RoutedEventArgs e)
        {
            keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);
            if (shiftCheckBox.IsChecked == true)
            {
                keyboardString.Text = keyboardString.Text + "N";
            }
            else
            {
                keyboardString.Text = keyboardString.Text + "n";
            }
            keyboardString.Text = keyboardString.Text + "|";
        }

        private void letter_m_Click(object sender, RoutedEventArgs e)
        {
            keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);
            if (shiftCheckBox.IsChecked == true)
            {
                keyboardString.Text = keyboardString.Text + "M";
            }
            else
            {
                keyboardString.Text = keyboardString.Text + "m";
            }
            keyboardString.Text = keyboardString.Text + "|";
        }

        private void colon_Click(object sender, RoutedEventArgs e)
        {
            keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);

            keyboardString.Text = keyboardString.Text + ": |";
        }

        private void backspace_Click(object sender, RoutedEventArgs e)
        {

            if (keyboardString.Text.Length >= 2)
            {
                keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);
                keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);
                keyboardString.Text = keyboardString.Text + "|";
            }
            else if (keyboardString.Text.Length == 1)
            {
                keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);
                keyboardString.Text = keyboardString.Text + "|";
            }
            else
            {
                return;
            }

        }

        private void period_Click(object sender, RoutedEventArgs e)
        {
            keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);

            keyboardString.Text = keyboardString.Text + ". |";
        }

        private void comma_Click(object sender, RoutedEventArgs e)
        {
            keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);

            keyboardString.Text = keyboardString.Text + ", |";
        }

        private void question_Click(object sender, RoutedEventArgs e)
        {
            keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);

            keyboardString.Text = keyboardString.Text + "? |";
        }

        private void quote_Click(object sender, RoutedEventArgs e)
        {
            keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);

            keyboardString.Text = keyboardString.Text + "' |";
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            string keyBrdstring;

            keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);
            keyBrdstring = keyboardString.Text;

            if (LoginButton.IsEnabled == false)
            {
                MessageTextBox.Text = keyBrdstring;
            }
            else 
            {
                UserNameTextBox.Text = keyBrdstring;
            }

            keyBrdstring = "";
            keyboardString.Text = "";
            keyboardCanvas.Visibility = Visibility.Hidden;

        }

        private void spcaebar_Click(object sender, RoutedEventArgs e)
        {
            keyboardString.Text = keyboardString.Text.Remove(keyboardString.Text.Length - 1, 1);
            keyboardString.Text = keyboardString.Text + ' ';
            keyboardString.Text = keyboardString.Text + "|";
        }

        #endregion letters
        
        #region RosaryGUI

        private void coverArtCanvas_TouchEnter(object sender, TouchEventArgs e)
        {
            coverArtCanvas.Visibility = Visibility.Hidden;
        }

        private void curtainShowbutton_Click(object sender, RoutedEventArgs e)
        {
            coverArtCanvas.Visibility = Visibility.Visible;
        }

        private void btnPevText_Click(object sender, RoutedEventArgs e)
        {
            //back verse
            string query;
            int repeatbeadNo;
            
            query = "SELECT COUNT(beadNumber) FROM lecciodivina.bead WHERE beadNumber = " + beadposRev + ";";
            repeatbeadNo = Convert.ToInt32(getData(query).Rows[0][0]);

            if ((repeatbead_temp - 1) >= 0)
            {
                repeatbead_temp = repeatbead_temp - 1;
                verseString(beadposRev, repeatbeadNo);
            }
            else if (repeatbead_temp == 1)
            {
                verseString(beadposRev, repeatbeadNo);
            }
            mcon.Close();
        }

        private void btnNextText_Click(object sender, RoutedEventArgs e)
        {
            //fwd verse
            string query;
            int repeatbeadNo;

            query = "SELECT COUNT(beadNumber) FROM lecciodivina.bead WHERE beadNumber = " + beadposFwd + ";";
            repeatbeadNo = Convert.ToInt32(getData(query).Rows[0][0]);

            int temp_verse_inc = repeatbead_temp + 1;

            if (temp_verse_inc < repeatbeadNo)
            {
                repeatbead_temp = temp_verse_inc; 
                verseString(beadposFwd, repeatbeadNo);
            }
            else if (repeatbead_temp == 1)
            {
                verseString(beadposFwd, repeatbeadNo);
            }
            mcon.Close();
        }

        private void coverArtCanvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            coverArtCanvas.Visibility = Visibility.Hidden;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Server.Logout();

                SomeoneDropedTheirBead();

                this.Close();
            }
            catch //(Exception ex)
            {
                this.Close();
            }
        }

        private void BeadButtonMessageSubroutine()
        {

            #region BeadNumber

            int totalcurrentusers = Server.GetCurrentUsers().Count();
            if (beadpos > 0)
            {
                //avoid updating cout bassed on the new person
                Server.SendBeadNumberToALL(beadpos, UserNameTextBox.Text);
            }

            #endregion

            #region BeadMessage

            //Text Confirmation
            int tempBeadNumMsg = beadpos + 1;

            Server.SendBeadMessageToALL("<awaiting bead>", UserNameTextBox.Text);
            TakeBeadMessage("<commencing bead " + tempBeadNumMsg.ToString() + ">", "YOU");
            rdoBead.IsChecked = true;

            #endregion BeadMessage

            #region BeadList 
            //Update a list of people who have pressed the bead button on the current bead

            AddBeadUserToList(UserNameTextBox.Text); //add to BeadListBox

            // This is the waiting list Part
            List<string> templist = new List<string>();
            foreach (string item in BeadListBox.Items)
            {
                templist.Add(item);
            }

            //condition to re-activate button and Reset
            if (BeadListBox.Items.Count == UsersListBox.Items.Count)
            {
                //reactivate bead button
                BeadButton.IsEnabled = true;
                BeadListBox.Items.Clear();
                templist.Clear();
                Server.SendBeadListMessageToALL(templist, UserNameTextBox.Text);

                rdoBead.Content = "Bead Forward When You Are Ready";
                rdoBead.IsChecked = false;
            }
            else if (BeadListBox.Items.Count < UsersListBox.Items.Count)
            {
                Server.SendBeadListMessageToALL(templist, UserNameTextBox.Text);
                //deactivate button
                BeadButton.IsEnabled = false;
                BeadButton.IsEnabled = false;

            }

            #endregion BeadList

        }

        private void BeadButton_Click(object sender, RoutedEventArgs e)
        {
            rdoBead.IsEnabled = true;

            if (UserNameTextBox.IsEnabled == false)
            {
                BeadButtonMessageSubroutine();
            }
            rdoBead.IsEnabled = false;

            repeatbead_temp = 0;

            RosaryFunction();

            beadposRev = beadpos; //resets the reverse counter
        }

        private void BeadButtonBack_Click(object sender, RoutedEventArgs e)
        {
            if ((beadpos - 1) > 0)
            {
                string query;
                int repeatbeadNo;                

                if (beadposRev > 0)
                {
                    beadposRev = beadposRev - 1; //decrement fwd/rev
                    beadposFwd = beadposRev; //update the last rev position for forwarding

                    query = "SELECT COUNT(beadNumber) FROM lecciodivina.bead WHERE beadNumber = " + beadposRev + ";";
                    repeatbeadNo = Convert.ToInt32(getData(query).Rows[0][0]);

                    prayerTypeString(beadposRev);
                    prayerString(beadposRev, repeatbeadNo); //repeatbead_temp gets +1 if (repeatbeadNo < 2) 
                    //repeatbead_temp = 0; //reset verse counter
                    if (repeatbeadNo > 1)
                    {
                        //repeatbead_temp = repeatbead_temp - 1;
                        repeatbead_temp = 0;
                    }
                    verseString(beadposRev, repeatbeadNo);
                    meditationName(beadposRev); //display a meditation instead of a verse                    
                    
                    decadeCounter(beadposRev, repeatbeadNo);
                }                
            }

            mcon.Close();
        }

        private void BeadButtonForward_Click(object sender, RoutedEventArgs e)
        {
            if ((beadpos + 1) < (beadtotal))
            {
                string query;
                int repeatbeadNo;                

                if (beadposFwd < beadpos)
                {
                    beadposFwd = beadposFwd + 1; //increment from last tmp decrement
                    beadposRev = beadposFwd; //update the last rev position for forwarding

                    query = "SELECT COUNT(beadNumber) FROM lecciodivina.bead WHERE beadNumber = " + beadposFwd + ";";
                    repeatbeadNo = Convert.ToInt32(getData(query).Rows[0][0]);
                    
                    /*
                    prayerTypeString(beadposFwd);
                    
                    repeatbead_temp = 0; //reset verse counter
                    verseString(beadposFwd, repeatbeadNo);
                    meditationName(beadposFwd); //display a meditation instead of a verse
                    prayerString(beadposFwd, repeatbeadNo);
                    
                    decadeCounter(beadposFwd, repeatbeadNo);
                    */

                    prayerTypeString(beadposFwd);
                    prayerString(beadposFwd, repeatbeadNo); //repeatbead_temp gets +1 if (repeatbeadNo < 2) 
                    //repeatbead_temp = 0; //reset verse counter
                    if (repeatbeadNo > 1)
                    {
                        //repeatbead_temp = repeatbead_temp - 1;
                        repeatbead_temp = 0;
                    }
                    verseString(beadposFwd, repeatbeadNo);
                    meditationName(beadposFwd); //display a meditation instead of a verse
                    
                    decadeCounter(beadposFwd, repeatbeadNo);
                }
            }

            mcon.Close();
        }

        #endregion RosaryGUI

        #region ServerScanRelated

        public void FindServerAndUsersMAIN()
        {

            FindPCs();
            FindPCsWithChatServer();
        }
        
        public void FindPCs()
        {
            //---- save output to string ------
            string cmdOutputString = ExecuteCMDCommand("net view", 1); //wait 5000
            //------  strip line function ---------
            string[] lines = cmdOutputString.Split(new char[] { '\n' });

            List<string> ListBoxPCnames = new List<string>();

            string[] strippedLines = StripComments(lines);

            //string tempName;
            foreach (string line in strippedLines)
            {
                ListBoxPCnames.Add(line);
            }

            // fill the GUI opbjects
            foreach (string PCname in ListBoxPCnames)
            {
                listOfPCsOnNetwork.Items.Add(PCname);
            }
        }
        
        public void FindPCsWithChatServer()
        {
            foreach (string line in listOfPCsOnNetwork.Items)
            {
                if (ReturnServers(line, 7777) != "")
                {
                    cbxServerSelectLAN.Items.Add(line);
                }
            }
        }

        public static string ReturnServers(string _HostURI, int _PortNumber)
        {
            try
            {
                TcpClient client = new TcpClient(_HostURI, _PortNumber);

                if (client.Connected)
                {
                    return _HostURI;
                }
                else
                {
                    return "";
                }
            }
            catch //(Exception ex)
            {
                return "";
            }
        }

        #region PCFinderFunctions

        public static string ExecuteCMDCommand(string Command, int Timeout)
        {
            int ExitCode;
            string output;

            ProcessStartInfo ProcessInfo;
            Process Process = new Process();

            ProcessInfo = new ProcessStartInfo("cmd.exe", "/C " + Command);
            ProcessInfo.RedirectStandardOutput = true;
            ProcessInfo.CreateNoWindow = true;
            ProcessInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            ProcessInfo.UseShellExecute = false;
            Process = Process.Start(ProcessInfo);

            output = Process.StandardOutput.ReadToEnd();

            Process.WaitForExit(Timeout);
            ExitCode = Process.ExitCode;
            Process.Close();

            return output;
        }

        public static string[] StripComments(string[] lines)
        {
            List<string> lineList = new List<string>();
            string noWhite;

            foreach (string line in lines)
            {
                if (line.TrimStart(' ').StartsWith(@"\"))
                {
                    line.Replace(@"\\", @"");

                    noWhite = RemoveWhitespace(line.Replace("\"", ""));
                    noWhite = RemoveWhitespace(noWhite.Replace("\"", ""));

                    noWhite = RemoveWhitespace(line.Replace(@"\\", @""));

                    lineList.Add(noWhite);
                }
            }
            return lineList.ToArray();
        }
        public static string RemoveWhitespace(string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }
        public static string[] getPCname(string Ipv4address)
        {
            IPAddress[] ips;
            string PCnameString;

            ips = Dns.GetHostAddresses(Ipv4address);

            List<string> listOfpcNames = new List<string>();

            foreach (IPAddress ip in ips)
            {
                PCnameString = ip.ToString();
                listOfpcNames.Add(PCnameString);
            }

            return listOfpcNames.ToArray();
        }
        public static string getIPv4(string ipquery)
        {
            string ipstring;
            IPAddress ip = Dns.GetHostEntry(ipquery).AddressList.Where(o => o.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).First();
            //Console.WriteLine(ip);
            //string name = Dns.GetHostEntry(ip).HostName.ToString();
            //Console.WriteLine(name);
            ipstring = ip.ToString();

            //string ipstring2 = Dns.GetHostAddresses("mezceltran");

            return ipstring;
        }
        public static string getIPRouter(string ipquery)
        {
            IPAddress ip = Dns.GetHostEntry(ipquery).AddressList.Where(o => o.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).First();
            //Console.WriteLine(ip);
            string name = Dns.GetHostEntry(ip).HostName.ToString();
            //Console.WriteLine(name);
            return name;
        }

        #endregion PCFinderFunctions

        private void btnRescanServer_MouseEnter(object sender, MouseEventArgs e)
        {
            scanbtntextbox.Text = "Be Patient\nscans takes a moment...";
        }

        #endregion ServerScanRelated

        private void btnRescanServer_Click(object sender, RoutedEventArgs e)
        {
            FindServerAndUsersMAIN();
            scanbtntextbox.Text = "Scan is complete,\nScan again?";
            ipconfirmTextBlock.Text = "Select A PC Name from the Dropbox and Continue";
        }

        private void cbxServerSelectLAN_DropDownClosed(object sender, EventArgs e)
        {
            if (cbxServerSelectLAN.SelectedItem != null)
            {
                string networkingEndpoint = getIPv4(cbxServerSelectLAN.SelectedItem.ToString());
                RosaryVarsBetweenForms.ServerEndpointAddress = networkingEndpoint;

                ipconfirmTextBlock.Text = "You will be linked with: " + RosaryVarsBetweenForms.ServerEndpointAddress + ":7777" + "\n\n" + cbxServerSelectLAN.Text + " is the Prayer Leader";

                MyOwnNetworkingInitializations();
            }
            else
            {
                RosaryVarsBetweenForms.ServerEndpointAddress = "localhost";
                ipconfirmTextBlock.Text = "You are in Sola Scriptura mode\nScan your LAN Network for available Rosary Circles\n\nThen\nSelect from the Dropbox";
            }
        }

        private void btnCancelServerSelect_Click(object sender, RoutedEventArgs e)
        {
            RosaryVarsBetweenForms.ServerEndpointAddress = "localhost";
            MyOwnNetworkingInitializations();
            ServerLoginCanvas.Visibility = Visibility.Hidden;
        }

        private void btnConfirmServerSelect_Click(object sender, RoutedEventArgs e)
        {
            if (cbxServerSelectLAN.Text != "")
            {
                string networkingEndpoint = getIPv4(cbxServerSelectLAN.SelectedItem.ToString());

                RosaryVarsBetweenForms.ServerEndpointAddress = networkingEndpoint;

                MyOwnNetworkingInitializations();
                ServerLoginCanvas.Visibility = Visibility.Hidden;
            }
            else 
            {
                ipconfirmTextBlock.Text = "Select a name from the 'dropdown box', or press 'Cancel'\n\n You are defaulted to a localhost chat server";
            }
            
        }

        private void MessageTextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            keyboardCanvas.Visibility = Visibility.Visible;
            keyboardDestinationLabel.Content = "Send a chat message ...";
            keyboardString.Text = "|";
        }
              
        private void UserNameTextBox_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            keyboardCanvas.Visibility = Visibility.Visible;
            keyboardDestinationLabel.Content = "User Name Input ...";
            keyboardString.Text = "|";
        }

    }//end WPF form

}//end namespace
