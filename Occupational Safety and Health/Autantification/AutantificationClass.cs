using Occupational_Safety_and_Health.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Occupational_Safety_and_Health.Autantification
{
    class AutantificationClass
    {
        private OTEntities entities;
        private List<UsersView> usersViews;
        private List<UsersView> UsersAsync(Progress<List<UsersView>> progress)
        {
            entities = new OTEntities();
            usersViews = entities.UsersViews.ToList();
            return usersViews;
        }
        public async void GetUsers(System.Windows.Controls.ComboBox loginsComboBox)
        {
            var progress = new Progress<List<UsersView>>(s => loginsComboBox.ItemsSource = s);
            loginsComboBox.ItemsSource = await Task.Factory.StartNew<List<UsersView>>(
                                                         () => UsersAsync(progress),
                                                         TaskCreationOptions.LongRunning);
            loginsComboBox.DisplayMemberPath = "Login";
        }
    }
}
