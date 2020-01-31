using Occupational_Safety_and_Health.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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

        internal void Check(object selectedItem, string password, MainWindow mainWindow)
        {
            var selectedUser = (UsersView)selectedItem;
            if (selectedUser.Password.Equals((object)ComputeSha256Hash(password).ToUpper()))
            {
                Window window = new Work.MainWorkWindow(selectedUser);
                window.Show();
                mainWindow.Close();
            }
            else
            {
                MessageBox.Show("Не верный пароль!!!");
            }
        }

        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }


    }
}
