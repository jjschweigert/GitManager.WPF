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
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private Visibility _GridSplitter { get; set; }
        public Visibility GridSplitter
        {
            get
            {
                return _GridSplitter;
            }
            set
            {
                _GridSplitter = value;
                NotifyPropertyChanged("GridSplitter");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        public MainWindow()
        {
            GridSplitter = Visibility.Collapsed;
            DataContext = this;
        }

        private async void CloseGridMenu_Click(object sender, RoutedEventArgs e)
        {
            await Task.Delay(500);
            GridMenu.Visibility = Visibility.Collapsed;
            GridSplitter = Visibility.Visible;

        }

        private void OpenGridMenu_Click(object sender, RoutedEventArgs e)
        {
            GridMenu.Visibility = Visibility.Visible;
            GridSplitter = Visibility.Collapsed;
        }
    }
}
