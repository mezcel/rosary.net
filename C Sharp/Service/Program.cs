using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

//ip socket specific
using System.Net;
using System.Net.Sockets;

//find ports in use
using System.Net.NetworkInformation;

//used in usedport array
using System.Collections;

//Listing All Connection Strings
using System.Configuration; //had to install dll

//ip socket specific
using System.Net.NetworkInformation;
using System.Net;
using System.Net.Sockets;

//used for obtaining all ips
using System.Diagnostics;
using System.IO;

//used in parsing
using System.Text.RegularExpressions;

namespace ChattingServer
{
    class Program
    {
        public static ChattingService _server; //1 instance of the service; 
        static void Main(string[] args)
        {
            //hostrelated(); //initialize hosting activation of local app server

            _server = new ChattingService();

            using (ServiceHost host = new ServiceHost(_server))
            {
                host.Open();
                DisplayAbout(); // disclamer info
                Console.ReadLine(); // pause

            }// end using
        } //end main funct   

        private static string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            //No Network Setup, default to localhost: 127.0.0.1
            return "127.0.0.1:7777"; //localhost default
        }

        private static void DisplayAbout()
        {
            string cmdlinetext = "";
            cmdlinetext = cmdlinetext + " Your Chat Server is running ...\n";
            cmdlinetext = cmdlinetext + " --------------------------------------------\n\n";
            cmdlinetext = cmdlinetext + " This Server IP is within your current localhost... " + GetLocalIP() + "\n";
            cmdlinetext = cmdlinetext + " Your FULL IPv4 Endpoint address is: " + GetLocalIP() + ":7777\n";
            cmdlinetext = cmdlinetext + " --------------------------------------------\n\n";
            cmdlinetext = cmdlinetext + "  Now you may Run the ChattingClient App to exectute the Chating interaction. \n";
            cmdlinetext = cmdlinetext + "  Note: You alone are 'The Server Host' for this chat. \n";
            cmdlinetext = cmdlinetext + "        Closing 'this black terminal box' will 'close this server channel'. \n\n";
            cmdlinetext = cmdlinetext + "        !!! < CLOSE THIS BOX LAST UPON EXIT > !!!\n";
            cmdlinetext = cmdlinetext + "        !!! < NO CHAT ACTIVITY for 10:00 min will EXIT the server > !!!\n\n";
            cmdlinetext = cmdlinetext + " ============================================\n";
            cmdlinetext = cmdlinetext + " Active Users Enrolled in this chat: \n";
            cmdlinetext = cmdlinetext + " ============================================\n";
			
            Console.WriteLine(cmdlinetext);
        }
	} //end class
}
