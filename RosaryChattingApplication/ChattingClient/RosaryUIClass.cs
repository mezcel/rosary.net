using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosaryClient
{
    class RosaryVarsBetweenForms
    {
        /* Global Variables Used in Version 1 and migrated into Version 2 */

        private static string rosarystring;
        public static string RosarySting
        {
            get { return rosarystring; }
            set { rosarystring = value; }
        }

        // i just want to flag which window is open to determine which window to write to
        // used in WinForm

        #region client_winFormform

        private static int openwindowflag = 1;
        public static int OpenWindowFlag
        {
            get { return openwindowflag; }
            set { openwindowflag = value; }
        }

        // a flag just to ensure the original Form1 stays unaffected
        private static bool originalmainform1 = true;
        public static bool OriginalMainForm1
        {
            get { return originalmainform1; }
            set { originalmainform1 = value; }
        }

        #endregion client_winFormform

        #region client_connectionstring

        private static string serverendpointaddress = "localhost";
        public static string ServerEndpointAddress
        {
            get { return serverendpointaddress; }
            set { serverendpointaddress = value; }
        }

        private static string connstrRose;
        public static string ConnStrRose
        {
            get { return connstrRose; }
            set { connstrRose = value; }
        }

        /* mysql connection flag */
        private static bool mysqlconnectedbool = false;
        public static bool isMySqlConnectedBool
        {
            get { return mysqlconnectedbool; }
            set { mysqlconnectedbool = value; }
        }

        #endregion client_connectionstring

        #region client_beadcounter

        private static int rosarybeadint;
        public static int RosaryBeadInt
        {
            get { return rosarybeadint; }
            set { rosarybeadint = value; }
        }

        #endregion

        #region client_radiobuttons

        private static bool joyfulbool;
        public static bool JoyfulBool
        {
            get { return joyfulbool; }
            set { joyfulbool = value; }
        }

        private static bool sorrowfulbool;
        public static bool SorrowfulBool
        {
            get { return sorrowfulbool; }
            set { sorrowfulbool = value; }
        }

        private static bool luminousbool;
        public static bool LuminousBool
        {
            get { return luminousbool; }
            set { luminousbool = value; }
        }

        private static bool gloriousbool;
        public static bool GloriousBool
        {
            get { return gloriousbool; }
            set { gloriousbool = value; }
        }

        private static int languageint; //default to english
        public static int languageInt
        {
            get { return languageint; }
            set { languageint = value; }
        }

        #endregion client_radiobuttons

        #region clientsystemclock

        private static string clocktime; //default to english
        public static string ClockTime
        {
            get { return clocktime; }
            set { clocktime = value; }
        }

        #endregion clientsystemclock
    }

}
