using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TradingPlatform.UI.Windows;

namespace TradingPlatform.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : MetroWindow
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void RadHyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://google.com");
        }

        private void Connect_Click(object sender, RoutedEventArgs e)
        {
            Window mainScreen = new MainScreen();
            if (loginBox.Text == "" || passwordBox.Text == "")
            {
                errorMsg.Visibility = Visibility.Visible;
                return;
            }
            errorMsg.Visibility = Visibility.Hidden;
            mainScreen.Show();
            this.Close();
        }
    }
}
