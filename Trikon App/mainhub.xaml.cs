using GameSparks.NET.Services;
using GameSparks.NET.Services.Player.Requests;
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

namespace Trikon_App
{
    /// <summary>
    /// Interaction logic for mainhub.xaml
    /// </summary>
    public partial class mainhub : Window
    {
        public mainhub()
        {
            InitializeComponent();
            GetPlayerInfo();
        }

        public void GetPlayerInfo()
        {
            string userID = Properties.Settings.Default.UserID;
            var playerService = new GameSparksPlayerService();
            var response = playerService.AccountDetailsRequest(new AccountDetailsRequest(userID));
            usernametxt.Text = response.DisplayName;
            Console.WriteLine("User = " + userID);
        }
    }
}
