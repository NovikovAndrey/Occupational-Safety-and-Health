using Occupational_Safety_and_Health.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Occupational_Safety_and_Health.Autantification
{
    class AtantificationClass
    {
        OTEntities entities;
        List<UsersView> t;
        private List<UsersView> UsersAsync(Progress<List<UsersView>> progress)
        {
            entities = new OTEntities();
            t = entities.UsersViews.ToList();
            return t;
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
