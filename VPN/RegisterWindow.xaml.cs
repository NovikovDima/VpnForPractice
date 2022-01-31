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
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace VPN
{
    /// <summary>
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        private const double TimeAnimationPanel = 0.2;

        private const int MinSizeText = 40;
        private const int MaxSizeText = 90;

        private const double MinHeightPanel = 0;
        private const double MaxHeightPanel = 500;

        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void AnimOpen(Panel panel)
        {
            AnimationPanel(panel, MinHeightPanel, MaxHeightPanel);
            AnimationText(MaxSizeText, MinSizeText);
        }
        private void AnimClose(Panel panel)
        {
            AnimationPanel(panel, MaxHeightPanel, MinHeightPanel);
            AnimationText(MinSizeText, MaxSizeText);
        }

        private void AnimationPanel(Panel panel, double from, double to)
        {
            DoubleAnimation animation = new DoubleAnimation();

            animation.From = from;
            animation.To = to;
            animation.Duration = TimeSpan.FromSeconds(TimeAnimationPanel);

            panel.BeginAnimation(HeightProperty, animation);
        }
        private void AnimationText(double from, double to)
        {
            DoubleAnimation animationText = new DoubleAnimation();

            animationText.From = from;
            animationText.To = to;
            animationText.Duration = TimeSpan.FromSeconds(TimeAnimationPanel);

            TextVPNLogo.BeginAnimation(FontSizeProperty, animationText);
        }

        private void ChangeEnabledButtons(bool flag)
        {
            ButtonSignIn.IsEnabled = flag;
            ButtonSignUp.IsEnabled = flag;
            ButtonHide.IsEnabled = flag;
            ButtonQuit.IsEnabled = flag;
        }

        /* MAIN */
        private void SignInClick(object sender, RoutedEventArgs e)
        {
            ChangeEnabledButtons(false);
            AnimOpen(PanelSignIn);
        }
        private void SignUpClick(object sender, RoutedEventArgs e)
        {
            ChangeEnabledButtons(false);
            AnimOpen(PanelSignUp);
        }
        private void QuitProgramClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void HideWindowClick(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        /* PANEL SIGN IN */
        private void BackSignInClick(object sender, RoutedEventArgs e)
        {
            ChangeEnabledButtons(true);
            AnimClose(PanelSignIn);
        }
        private void OkSignInClick(object sender, RoutedEventArgs e)
        {
            ChangeEnabledButtons(true);
            AnimClose(PanelSignIn);
            this.Hide();
            
            MainWindow window = new MainWindow();
            window.Show();
        }

        /* PANEL SIGN UP */
        private void BackSignUpClick(object sender, RoutedEventArgs e)
        {
            ChangeEnabledButtons(true);
            AnimClose(PanelSignUp);
        }
        private void OkSignUpClick(object sender, RoutedEventArgs e)
        {
            ChangeEnabledButtons(true);
            AnimClose(PanelSignUp);
        }
    }
}