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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Page
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonCloseMenu_MouseEnter(object sender, MouseEventArgs e)
        {
            //if (ButtonCloseMenu.Visibility == Visibility.Visible)
            //{
            //    ButtonCloseMenu.Effect = new DropShadowEffect
            //    {
            //        ShadowDepth = 5,
            //        BlurRadius = 5,
            //        Direction = 5,
            //        Opacity = 100,
            //        Color = Colors.Black
            //    };
            //}
        }

        private void ButtonCloseMenu_MouseLeave(object sender, MouseEventArgs e)
        {
            //if(ButtonCloseMenu.Visibility == Visibility.Visible)
            //    ButtonCloseMenu.Effect = null;
        }

        private void ButtonOpenMenu_MouseEnter(object sender, MouseEventArgs e)
        {
            //if (ButtonOpenMenu.Visibility == Visibility.Visible)
            //{
            //    ButtonOpenMenu.Effect = new DropShadowEffect
            //    {
            //        ShadowDepth = 0,
            //        BlurRadius = 20,
            //        Opacity = 100,
            //        Color = Colors.Black
            //    };
            //}
        }

        private void ButtonOpenMenu_MouseLeave(object sender, MouseEventArgs e)
        {
            //if (ButtonOpenMenu.Visibility == Visibility.Visible)
            //    ButtonOpenMenu.Effect = null;
        }
    }
}
