using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChattingClient
{
    class RosaryVarsBetweenForms
    {
        /*
            * The accessor of a property contains the executable statements associated with getting (reading or computing) or setting (writing) the property.
            *
            * The get Accessor:
            * The body of the get accessor is similar to that of a method. It must return a value of the property type. 
            * The execution of the get accessor is equivalent to reading the value of the field.
            * 
            * The set Accessor:
            * The set accessor is similar to a method that returns void. It uses an implicit parameter called value, whose type is the type of the property.
         */

        // i just want to flag which window is open to determine which window to write to
        private static int openwindowflag = 1;
        public static int OpenWindowFlag
        {
            get { return openwindowflag; }
            set { openwindowflag = value; }
        }


        /* mysql connection string */
        private static string serverendpointaddress = "localhost";
        //private static string serverendpointaddress = "192.168.1.101";
        //192.168.1.101
        //private static string serverendpointaddress = "localhost";
        public static string ServerEndpointAddress
        {
            get { return serverendpointaddress; }
            set { serverendpointaddress = value; }
        }

        /* mysql connection string */
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

        // a flag just to ensure the original Form1 stays unaffected
        private static bool originalmainform1 = true;
        public static bool OriginalMainForm1
        {
            get { return originalmainform1; }
            set { originalmainform1 = value; }
        }

        private static string rosarystring;
        public static string RosarySting
        {
            get { return rosarystring; }
            set { rosarystring = value; }
        }

        //--- bead counter --- vvv --------
        private static int rosarybeadint;
        public static int RosaryBeadInt
        {
            get { return rosarybeadint; }
            set { rosarybeadint = value; }
        }
        //--- bead counter --- ^^^ --------

        //--- radio buttons --- vvv --------
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
        //--- radio buttons --- ^^^ --------

        //system clock display string
        private static string clocktime; //default to english
        public static string ClockTime
        {
            get { return clocktime; }
            set { clocktime = value; }
        }

    }

}
