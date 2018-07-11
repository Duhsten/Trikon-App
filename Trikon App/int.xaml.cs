using GameSparks.NET.Infrastructure.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for @int.xaml
    /// </summary>
    public partial class @int : Window
    {
        public @int()
        {
            InitializeComponent();

            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

    }
}
