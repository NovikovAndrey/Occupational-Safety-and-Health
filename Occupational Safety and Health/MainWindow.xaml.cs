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

namespace Occupational_Safety_and_Health
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OTEntitiesTest entitiesTest;
        List<UsersView> t;
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //ReadAsync();
            t = await Task.Run(() => UsersAsync());

            dgogrenci.ItemsSource = t;
        }
        //private async void ReadAsync()
        //{
        //      // выполняется асинхронно
        //    dgogrenci.ItemsSource = t;
        //}
        static List<UsersView> UsersAsync()
        {
            OTEntitiesTest entitiesTest;
            List<UsersView> t;
            entitiesTest = new OTEntitiesTest();
            t = entitiesTest.UsersViews.ToList();
            return t;
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            //ReadAsync();
        }
    }
}
