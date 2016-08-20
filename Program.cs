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

                //Console.ReadLine();
            
                // Evaluate current system tcp connections. This is the same information provided
                // by the netstat command line application, just in .Net strongly-typed object
                // form.  We will look through the list, and if our port we would like to use
                // in our TcpClient is occupied, we will set isAvailable to false.
                #region testbenchDisplays
                /*
                Console.WriteLine("\n--------------------- TcpConnectionInformation --------------------");

                IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
                TcpConnectionInformation[] tcpConnInfoArray = ipGlobalProperties.GetActiveTcpConnections();

                foreach (TcpConnectionInformation tcpi in tcpConnInfoArray)
                {
                    Console.WriteLine(tcpi.LocalEndPoint.Port);

                    if (tcpi.LocalEndPoint.Port == port)
                    {
                        isAvailable = port + " is free and not used.";
                        break;
                    }
                    else
                    {
                        isAvailable = port + " is not reserved and available for use.";
                    }
                }
                Console.WriteLine("\n--------------------");
                Console.WriteLine(isAvailable);
                Console.WriteLine("\nBetween 7770 to 7780 series, Port:" + GetOpenPort() + " is the next open free port in the same IP.");
                Console.WriteLine("\nComputer name: " + ipGlobalProperties.HostName);
                Console.WriteLine("\nDomain  name:" + ipGlobalProperties.DhcpScopeName);

                Console.WriteLine("\n--------------------- GetTcpConnections() --------------------");
                GetTcpConnections(); //demo existing endpoints
                ShowActiveTcpConnections();

                Console.WriteLine("\n--------------------- GetTcpConnections2() --------------------");
                GetTcpConnections2();

                //ArrayList usedPorts = new ArrayList();
                Console.WriteLine("\n--------------------- ListAvailableTCPPort() --------------------");
                ListAvailableTCPPort();


                Console.WriteLine("\n--------------------- GetConnectionStrings() --------------------");

                GetConnectionStrings();


                Console.WriteLine("\n--------------------- ShowInboundIPStatistics() --------------------");

                ShowInboundIPStatistics();

                Console.WriteLine("\n--------------------- ShowActiveTcpListeners() --------------------");

                ShowActiveTcpListeners();

                Console.WriteLine("\n--------------------- GetLocalIP() --------------------");

                Console.WriteLine(GetLocalIP());
                */
                #endregion testbenchDisplays
                
                //Console.WriteLine("\n--------------------- FindServerAndUsersMAIN() --------------------");
                
                //FindServerAndUsersMAIN();

                Console.ReadLine(); // pause

            }// end using
        } //end main funct   



        private static void hostrelated()
        {
            _server = new ChattingService();

            using (ServiceHost host = new ServiceHost(_server))
            {
                host.Open();
                DisplayAbout(); // disclamer info

                Console.ReadLine();
            }
        }

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

        //test function

        //test function
        public void DisplayLocalHostName()
        {
            try
            {
                // Get the local computer host name.
                String hostName = Dns.GetHostName();
                Console.WriteLine("Computer name :" + hostName);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException caught!!!");
                Console.WriteLine("Source : " + e.Source);
                Console.WriteLine("Message : " + e.Message);
            }
        }

        private static string GetOpenPort()
        {
            int PortStartIndex = 7777;
            int PortEndIndex = 7780;
            IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] tcpEndPoints = properties.GetActiveTcpListeners();

            List<int> usedPorts = tcpEndPoints.Select(p => p.Port).ToList<int>();
            int unusedPort = 0;

            for (int port = PortStartIndex; port < PortEndIndex; port++)
            {
                if (!usedPorts.Contains(port))
                {
                    unusedPort = port;
                    break;
                }
            }
            return unusedPort.ToString();
        }

        public static void GetTcpConnections()
        {
            IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
            //            TcpConnectionInformation connections = properties.GetActiveTcpConnections();
            TcpConnectionInformation[] connections = properties.GetActiveTcpConnections();

            foreach (TcpConnectionInformation t in connections)
            {
                Console.Write("Local endpoint: {0} ", t.LocalEndPoint.Address);
                Console.Write("Remote endpoint: {0} ", t.RemoteEndPoint.Address);
                Console.WriteLine("{0}", t.State);
            }
            Console.WriteLine();
        }

        public static void GetTcpConnections2()
        {
            IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
            //            TcpConnectionInformation connections = properties.GetActiveTcpConnections();
            TcpConnectionInformation[] connections = properties.GetActiveTcpConnections();

            foreach (TcpConnectionInformation t in connections)
            {
                Console.Write("Local endpoint: {0} ", t.LocalEndPoint.Address);
                Console.Write("Remote endpoint: {0} ", t.RemoteEndPoint.Address);
                Console.WriteLine("{0}", t.State);
            }
            Console.WriteLine();
        }
        
        public static void ShowActiveTcpConnections()
        {
            Console.WriteLine("Active TCP Connections");
            IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
            TcpConnectionInformation[] connections = properties.GetActiveTcpConnections();
            foreach (TcpConnectionInformation c in connections)
            {
                Console.WriteLine("{0} <==> {1}",
                    c.LocalEndPoint.ToString(),
                    c.RemoteEndPoint.ToString());
            }
        }

        static void ListAvailableTCPPort()
        {
            

            IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
            TcpConnectionInformation[] tcpConnInfoArray = ipGlobalProperties.GetActiveTcpConnections();
            IEnumerator myEnum = tcpConnInfoArray.GetEnumerator();

            while (myEnum.MoveNext())
            {
                TcpConnectionInformation TCPInfo = (TcpConnectionInformation)myEnum.Current;
                Console.WriteLine("Port {0} {1} {2} ", TCPInfo.LocalEndPoint, TCPInfo.RemoteEndPoint, TCPInfo.State);
                //usedPort.Add(TCPInfo.LocalEndPoint.Port);
            }
        }

        static void GetConnectionStrings()
        {
            //https://msdn.microsoft.com/en-us/library/ms254494(v=vs.110).aspx
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;

            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    Console.WriteLine(cs.Name);
                    Console.WriteLine(cs.ProviderName);
                    Console.WriteLine(cs.ConnectionString);
                }
            }
        }

        public static void ShowInboundIPStatistics()
        {
            IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
            IPGlobalStatistics ipstat = properties.GetIPv4GlobalStatistics();
            Console.WriteLine("  Inbound Packet Data:");
            Console.WriteLine("      Received ............................ : {0}",
            ipstat.ReceivedPackets);
            Console.WriteLine("      Forwarded ........................... : {0}",
            ipstat.ReceivedPacketsForwarded);
            Console.WriteLine("      Delivered ........................... : {0}",
            ipstat.ReceivedPacketsDelivered);
            Console.WriteLine("      Discarded ........................... : {0}",
            ipstat.ReceivedPacketsDiscarded);
        }

        public static void ShowActiveTcpListeners()
        {
            //https://msdn.microsoft.com/en-us/library/system.net.networkinformation.ipglobalproperties.getactivetcplisteners(v=vs.110).aspx

            Console.WriteLine("Active TCP Listeners");
            IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] endPoints = properties.GetActiveTcpListeners();
            foreach (IPEndPoint e in endPoints)
            {
                Console.WriteLine(e.ToString());
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

        #region PCFinderMain

        public static void FindServerAndUsersMAIN()
        {
            //---- save output to string ------
            string cmdOutputString = ExecuteCMDCommand("net view", 3000); //wait 5000
            //------  strip line function ---------
            string[] lines = cmdOutputString.Split(new char[] { '\n' });

            List<string> combBoxPCnames = new List<string>();

            //List<string> combBoxPCIPv4 = new List<string>();
            //List<string> combBoxPCRouter = new List<string>();

            string[] strippedLines = StripComments(lines);
            foreach (string line in strippedLines)
            {
                combBoxPCnames.Add(line + " belongs to " + getIPv4(line));               //available People on same network
                //combBoxPCIPv4.Add(getIPv4(line));       //available IPvr addresses on same network
                //combBoxPCRouter.Add(getIPRouter(line)); //available Router hub on same network
                //PingHost(getIPv4(line), 7777);
                if (ReturnServers(getIPv4(line), 7777) != "")
                {
                    //Console.WriteLine(getIPv4(line).ToString() + ":" + 7777 + " is an active Rosary Circle Server");
                    //ips = Dns.GetHostAddresses(getIPv4(line));
                    Console.WriteLine(line + " is an active Rosary Circle Server");
                }
            }

            foreach (string PCname in combBoxPCnames)
            {
                Console.WriteLine("\n" + PCname);
            }
        }

        #endregion PCFinderMain

        public static void PingHost(string _HostURI, int _PortNumber)
        {
            try
            {
                TcpClient client = new TcpClient(_HostURI, _PortNumber);
                Console.WriteLine(_HostURI + ":" + _PortNumber + " is an active Rosary Circle Server");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error pinging host:'" + _HostURI + ":" + _PortNumber.ToString() + "'");
            }
        }

        public static string ReturnServers(string _HostURI, int _PortNumber)
        {

            try
            {
                TcpClient client = new TcpClient(_HostURI, _PortNumber);
                return _HostURI;
            }
            catch (Exception ex)
            {
                return "";
            }
 
        }
    } //end class
}
