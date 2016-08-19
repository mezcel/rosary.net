using ChattingInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ChattingClient
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
    
    class ClientCallback : IClient
    {

        public void GetMessage(string message, string userName)
        {
            ((MainRosaryWindow)Application.Current.MainWindow).TakeMessage(message, userName); 
            //i dont have acces to window at this point, it holds refference to main window
        }

        public void GetUpdate(int value, string userName)
        {
            switch (value)
            {
                case 0:
                    {
                        //((MainWindow)Application.Current.MainWindow).AddUserToList(userName);
                        ((MainRosaryWindow)Application.Current.MainWindow).AddUserToList(userName);
                        break;
                    }
                case 1:
                    {
                        ((MainRosaryWindow)Application.Current.MainWindow).RemoveUserToList(userName);
                        break;
                    }
            }
        }

        #region Bead

        public void GetBeadMessage(string message, string userName)
        {
            ((MainRosaryWindow)Application.Current.MainWindow).TakeBeadMessage(message, userName);
            //i dont have acces to window at this point, it holds refference to main window
        }


        public void GetBeadNumberMessage(int messageInt, string userName)
        {
            ((MainRosaryWindow)Application.Current.MainWindow).TakeBeadNumberMessage(messageInt, userName);
            //i dont have acces to window at this point, it holds refference to main window
        }


        public void GetBeadListMessage(List<string> listofbeads, string userName)
        {
            ((MainRosaryWindow)Application.Current.MainWindow).TakeBeadListMessage(listofbeads, userName);
            //i dont have acces to window at this point, it holds refference to main window
        }
        
        #endregion Bead



    }//end class
}//end namespace
