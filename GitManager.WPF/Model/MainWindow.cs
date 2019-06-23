using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GitManager.WPF.Model
{
    public class MainWindow : INotifyPropertyChanged
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

        public MainWindow()
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
