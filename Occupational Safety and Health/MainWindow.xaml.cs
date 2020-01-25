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
        OTEntitiesTest entitiesTest;
        List<UsersView> t;
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Вызов в асинхроне и заполнение коллекции
            t = await Task.Run(() => UsersAsync());
            dgogrenci.ItemsSource = t;
        }

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
        }
    }
}
