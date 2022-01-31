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
using System.Windows.Media.Animation;
namespace VPN
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const double TimeAnimationPanel = 0.3;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Anim(double to, double from)
        {
            DoubleAnimation animation = new DoubleAnimation();

            animation.From = from;
            animation.To = to;
            animation.Duration = TimeSpan.FromSeconds(TimeAnimationPanel);

            PanelMainMenu.BeginAnimation(HeightProperty, animation);
        }

        private void AnimationMenu(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(ButtonCloseMainMenu))
            {
                Anim(0, 470);
            }
            else
            {
                Anim(470, 0);
            }
        }

        private void ChooseParagraph(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(ButtonProfile))
            {
                ToDefault();
                ButtonProfile.Background = Brushes.LightSkyBlue;
                PanelProfile.Visibility = Visibility.Visible;
            }
            else if(sender.Equals(ButtonOptions))
            {
                ToDefault();
                ButtonOptions.Background = Brushes.LightSkyBlue;
                PanelOptions.Visibility = Visibility.Visible;
            }
            else if(sender.Equals(ButtonInfo))
            {
                ToDefault();
                ButtonInfo.Background= Brushes.LightSkyBlue;
                PanelInfo.Visibility = Visibility.Visible;
            }
            else
            {
                ToDefault();
                ButtonSupport.Background = Brushes.LightSkyBlue;
                PanelSupport.Visibility = Visibility.Visible;
            }
        }

        private void ToDefault()
        {
            ButtonProfile.Background = Brushes.AliceBlue;
            ButtonOptions.Background = Brushes.AliceBlue;
            ButtonInfo.Background = Brushes.AliceBlue;
            ButtonSupport.Background = Brushes.AliceBlue;
            PanelProfile.Visibility = Visibility.Hidden;
            PanelOptions.Visibility = Visibility.Hidden;
            PanelInfo.Visibility = Visibility.Hidden;
            PanelSupport.Visibility = Visibility.Hidden;
        }
    }
}
