using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Occupational_Safety_and_Health.Model;

namespace Occupational_Safety_and_Health
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly Autantification.AutantificationClass autantificationUsers = new Autantification.AutantificationClass();
        public MainWindow()
        {
            InitializeComponent();
            autantificationUsers.GetUsers(LoginsComboBox);
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private async void Window_Initialized(object sender, EventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            Window window = new Work.MainWorkWindow();
            window.Show();
            this.Close();
        }
    }
}