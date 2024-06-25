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

namespace View.Screens
{
    /// <summary>
    /// Interaction logic for SettingScreen.xaml
    /// </summary>
    public partial class SettingScreen : UserControl
    {
        public SettingScreen()
        {
            InitializeComponent();
        }

        private void LightMode(object sender, RoutedEventArgs e)
        {
            SetTheme("LightMode");
        }
        private void DarkMode(object sender, RoutedEventArgs e)
        {
            SetTheme("DarkMode");
        }

        private void SetTheme(string name)
        {
            var app = (App) Application.Current;
            app.SetTheme(name);
        }
    }
}
