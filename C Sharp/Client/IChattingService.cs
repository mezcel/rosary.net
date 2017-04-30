using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ChattingInterfaces
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IChattingService" in both code and config file together.
    [ServiceContract(CallbackContract=typeof(IClient))]
    public interface IChattingService
    {
        [OperationContract]
        int Login(string userName);

        [OperationContract]
        void Logout();

        [OperationContract]
        void SendMessageToALL(string message, string userName); //sent to all except to myself

        [OperationContract]
        List<string> GetCurrentUsers();

        #region Bead

        [OperationContract]
        void SendBeadMessageToALL(string message, string userName); //sent to all except to myself

        [OperationContract]
        void SendBeadNumberToALL(int messageInt, string userName); //universal bead counter

        [OperationContract]
        void SendBeadListMessageToALL(List<string> listofbeads, string userName);

        #endregion Bead
    }
}

