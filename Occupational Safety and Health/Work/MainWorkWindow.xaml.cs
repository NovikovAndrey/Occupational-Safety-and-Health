using Occupational_Safety_and_Health.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace Occupational_Safety_and_Health.Work
{
    /// <summary>
    /// Interaction logic for MainWorkWindow.xaml
    /// </summary>
    public partial class MainWorkWindow : Window
    {
        
        public MainWorkWindow()
        {
            InitializeComponent();
        }

        private class MyPerson : T2Vvod
        {
            public UserAccess userAccesses{ get; set; }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Grid grid = new Grid();
            
            var tt = new MyPerson();
            
            //tt.KodPred
            var t2Vvods = UsersAsync();
            TestLB.ItemsSource = t2Vvods;
            ////T2Vvod t2Vvod = new T2Vvod();
            ////var t = t2Vvod.lo;
        }
        private OTEntities entities;
        private List<T2Vvod> usersViews;

        //private List<UsersView> usersViews;
        private List<T2Vvod> UsersAsync()
        {
            entities = new OTEntities();
            usersViews = entities.tt.ToList();
            var t = entities.tt.Sql.ToString(); 
            return usersViews;
        }
    }
}
