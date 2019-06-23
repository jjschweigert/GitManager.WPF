using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public Model.MainWindow TestViewModel { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            TestViewModel = new Model.MainWindow();
            DataContext = TestViewModel;
        }

        private async void Close_Sidebar_Button_Click(object sender, RoutedEventArgs e)
        {
            await Task.Delay(500);
            TestViewModel.Content_GridSplitter_Visibility = Visibility.Visible;
            TestViewModel.Sidebar_Grid_Visibility = Visibility.Collapsed;
        }

        private void Open_Sidebar_Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 newWin = new Window1();
            newWin.DataContext = TestViewModel;
            newWin.ShowDialog();
            //TestViewModel.Content_GridSplitter_Visibility = Visibility.Collapsed;
            //TestViewModel.Sidebar_Grid_Visibility = Visibility.Visible;
        }
    }
}
