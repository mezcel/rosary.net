using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace RosaryClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //https://msdn.microsoft.com/en-us/library/system.windows.application.mainwindow(v=vs.110).aspx
        /*
        void Application_Startup(object sender, StartupEventArgs e)
        {
            //add some bootstrap or startup logic 
            //RosaryVarsBetweenForms.OpenWindowFlag = true;

            var identity = RosaryVarsBetweenForms.OpenWindowFlag;
            if (identity == 1)
            {
                LoginWindow login = new LoginWindow();
                login.Show();
            }
            else if (identity == 2)
            {
                MainRosaryWindow mainView = new MainRosaryWindow();
                mainView.Show();
            }
        }
        */
    }
}
