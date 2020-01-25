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
        //OTEntitiesTest entitiesTest;
        //List<UsersView> t;
        readonly Autantification.AtantificationClass tt = new Autantification.AtantificationClass();
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private async void Window_Initialized(object sender, EventArgs e)
        {
            tt.GetUsers(LoginsComboBox);
        }
    }
}
