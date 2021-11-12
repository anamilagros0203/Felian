using Felian.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFirebaseUser.Services
{
    public class DBFirebase

    {
        public FirebaseClient client;

        public DBFirebase()
        {
            client = new FirebaseClient(
                "https://felian-default-rtdb.firebaseio.com/");
        }

        public ObservableCollection<Users> GetUsersList()
        {
            var userdata = client
                .Child("Users")
                .AsObservable<Users>()
                .AsObservableCollection();
            return userdata;

        }

        public async Task AddUser(string firstName, string email, string password, string address)
        {
            Users u = new Users()
            {
                FirstName = firstName,
                Email = email,
                Password = password,
                Address = address,

            };
            await client
                .Child("Users")
                .PostAsync(u);
        }

        public async Task UpdateUser(string firstName, string email, string password, string address)
        {
            var toUpdateUser = (await client
                .Child("Users")
                .OnceAsync<Users>())
                .FirstOrDefault(a => a.Object.FirstName == firstName);

            Users u = new Users()
            {
                FirstName = firstName,
                Email = email,
                Password = password,
                Address = address,
            };
            await client
                .Child("Users")
                .Child(toUpdateUser.Key)
                .PutAsync(u);
        }
    }
}

