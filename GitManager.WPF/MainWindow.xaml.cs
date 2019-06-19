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
        public ViewModel TestViewModel { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            TestViewModel = new ViewModel();
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
            TestViewModel.Content_GridSplitter_Visibility = Visibility.Collapsed;
            TestViewModel.Sidebar_Grid_Visibility = Visibility.Visible;
        }
    }

    public class ViewModel : INotifyPropertyChanged
    {
        private Visibility _Content_GridSplitter_Visibility { get; set; }
        public Visibility Content_GridSplitter_Visibility
        {
            get
            {
                return _Content_GridSplitter_Visibility;
            }
            set
            {
                _Content_GridSplitter_Visibility = value;
                NotifyPropertyChanged("Content_GridSplitter_Visibility");
            }
        }

        private Visibility _Sidebar_Grid_Visibility { get; set; }
        public Visibility Sidebar_Grid_Visibility
        {
            get
            {
                return _Sidebar_Grid_Visibility;
            }
            set
            {
                _Sidebar_Grid_Visibility = value;
                NotifyPropertyChanged("Sidebar_Grid_Visibility");
            }
        }

        public string WindowTitle
        {
            get
            {
                return "Local Git Manager";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ViewModel()
        {
            _Sidebar_Grid_Visibility = Visibility.Collapsed;
            _Content_GridSplitter_Visibility = Visibility.Visible;
        }

        public void NotifyPropertyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
