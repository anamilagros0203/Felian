using Felian.Models;
using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using AppFirebaseUser.Services;

namespace Felian.ViewModels
{
    public class UsersVM : BaseViewModel
    {
        private DBFirebase services;

        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }

        public Command SaveUsersCommand { get; set; }

        private ObservableCollection<Users> users = new ObservableCollection<Users>();

        public ObservableCollection<Users> UserList
        {
            get { return users; }

            set
            {
                users = value;
                OnPropertyChanged();
            }
        }


        public UsersVM()
        {
            services = new DBFirebase();
            UserList = services.GetUsersList();
            SaveUsersCommand = new Command(
                async () => await SaveUsersAsync(FirstName, Email, Password, Address));
        }

        public async Task SaveUsersAsync(string firstname, string email, string password, string address)
        {
            await services.AddUser(firstname, email, password, address);
        }
    }
}
