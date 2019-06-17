using System;
using System.Collections.Generic;
using System.Linq;
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

namespace GitManager.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

        }

        private async void CloseGridMenu_Click(object sender, RoutedEventArgs e)
        {
            await Task.Delay(500);
            GridMenu.Visibility = Visibility.Collapsed;
            ViewSplitter.Visibility = Visibility.Visible;
        }

        private void OpenGridMenu_Click(object sender, RoutedEventArgs e)
        {
            GridMenu.Visibility = Visibility.Visible;
            ViewSplitter.Visibility = Visibility.Collapsed;
        }
    }
}
