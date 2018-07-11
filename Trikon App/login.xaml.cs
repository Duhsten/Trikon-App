using GameSparks.NET.Infrastructure.Settings;
using GameSparks.NET.Services;
using GameSparks.NET.Services.Authentication.Requests;
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

namespace Trikon_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            GameSparksSettings.SetApiKey("xxx");
            GameSparksSettings.SetCredentials("xxxxx");
            GameSparksSettings.SetSecret("xxxxxx");
            GameSparksSettings.SetIsLive(false);
            var authService = new GameSparksAuthenticationService();
            string user = username.Text;
            string pass = password.Password;
            //Auth Login
            var authRequest = new AuthenticationRequest(user, pass);
            var response = authService.AuthenticationRequest(authRequest);
            Console.WriteLine(response.DisplayName);
            if (response.DisplayName == null)
            {
                Console.WriteLine("Incorrect Login Information");
                ErrorMessage.Text = "Incorrect Login Information";
            }
            else
            {
                ErrorMessage.Text = "";
                Console.WriteLine("Auth token: " + response.AuthToken);
                Console.WriteLine("User ID: " + response.UserId);
                // Load Hub
                mainhub hub = new mainhub();
                hub.Show();
                this.Close();
            }
           
         
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
