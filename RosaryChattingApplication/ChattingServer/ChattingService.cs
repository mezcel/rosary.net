using ClientServerInterfaces;

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ChattingServer
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.Single)] 
        // single = 1 instance of service
        // multiple = multi-threaded service // must look into thread safety on real launch builds

    public class ChattingService : IChattingService
    {
        //my custom data structure
        public ConcurrentDictionary<string, ConnectedClient> _connectedClients = new ConcurrentDictionary<string,ConnectedClient>();


        public int Login(string userName)
        {

            // is anyone logged in with this same name
            foreach (var client in _connectedClients)
            {
                if (client.Key.ToLower() == userName.ToLower())
                {
                    //if yes
                    return 1;
                }
            }

            var establishedUserConnection = OperationContext.Current.GetCallbackChannel<IClient>();

            ConnectedClient newClient = new ConnectedClient();
            newClient.connection = establishedUserConnection;
            newClient.UserName = userName;

            _connectedClients.TryAdd(userName, newClient);

            updateHelper(0, userName);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Client login: {0} at {1}", newClient.UserName, System.DateTime.Now);
            Console.ResetColor();

            return 0;
        }

        public void SendMessageToALL(string message, string userName)
        {
            //determin whether to display You as the User or THEM as the message sender

            foreach (var client in _connectedClients)
            {
                if (client.Key.ToLower() != userName.ToLower())
                {
                    client.Value.connection.GetMessage(message, userName);
                }
            }

        }

        public void Logout()
        {
            ConnectedClient client = GetMyClient();

            if (client != null)
            {
                ConnectedClient removedClient;
                _connectedClients.TryRemove(client.UserName, out removedClient);

                updateHelper(1, removedClient.UserName);

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Client logoff: {0} at {1}", removedClient.UserName, System.DateTime.Now);
                Console.ResetColor();
            }
        }

        public ConnectedClient GetMyClient()
        {
            var establishedUserConnection = OperationContext.Current.GetCallbackChannel<IClient>();
            
            foreach (var client in _connectedClients)
            {
                if (client.Value.connection == establishedUserConnection)
                {
                    return client.Value;
                }

            }

            return null; //just in case we get to this point
        }

        private void updateHelper(int value, string userName)
        {

            foreach (var client in _connectedClients)
            {
                if (client.Value.UserName.ToLower() != userName.ToLower())
                {
                    client.Value.connection.GetUpdate(value, userName);
                }
                else
                {
                    return;
                }
            }
        }

        public List<string> GetCurrentUsers()
        {
            List<string> listOfUsers = new List<string>();

            foreach (var client in _connectedClients)
            {
                listOfUsers.Add(client.Value.UserName);
            }

            return listOfUsers;
        }

        #region Bead
        



        public void SendBeadMessageToALL(string message, string userName)
        {
            foreach (var client in _connectedClients)
            {
                if (client.Key.ToLower() != userName.ToLower())
                {
                    client.Value.connection.GetBeadMessage(message, userName);
                }
            }
        }

        public void SendBeadNumberToALL(int messageInt, string userName)
        {
            foreach (var client in _connectedClients)
            {
                if (client.Key.ToLower() != userName.ToLower())
                {
                    client.Value.connection.GetBeadNumberMessage(messageInt, userName);
                }
            }
        }

        public void SendBeadListMessageToALL(List<string> listofbeadusers, string userName)
        {
            foreach (var client in _connectedClients)
            {
                if (client.Key.ToLower() != userName.ToLower())
                {
                    client.Value.connection.GetBeadListMessage(listofbeadusers, userName);
                }
            }
        }

        #endregion Bead
    }

}
