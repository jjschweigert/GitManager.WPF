using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Views;

namespace GitManager.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Window MainWindow = new Window
            {
                Height = 600,
                MinHeight = 600,
                MaxHeight = 600,
                Width = 1024,
                MinWidth = 1024,
                MaxWidth = 1024,
                WindowStyle = WindowStyle.None,
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };

            MainWindow.Content = new MainView();
            MainWindow.Show();

        }
    }
}
