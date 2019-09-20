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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void CloseMenu_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation opacityChange = new DoubleAnimation();
            opacityChange.From = 1;
            opacityChange.To = 0.35;
            opacityChange.Duration = new Duration(TimeSpan.FromSeconds(1));
            opacityChange.AutoReverse = true;

            MainGrid.BeginAnimation(OpacityProperty, opacityChange);
        }

        private void Grid_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(NotificationIcon.Visibility == Visibility.Collapsed)
            {
                NotificationIcon.Visibility = Visibility.Visible;
            }
            else
            {
                NotificationIcon.Visibility = Visibility.Collapsed;
            }
        }
    }
}
