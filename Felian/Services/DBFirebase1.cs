using Felian.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Felian.Services
{
    public class DBFirebase1
    {
        public FirebaseClient client;

        public DBFirebase1()
        {
            client = new FirebaseClient(
                "https://registroproducto-default-rtdb.firebaseio.com/");
        }

        public ObservableCollection<FelianProducto> GetFelianProductoList()
        {
            var FelianProductodata = client
                .Child("FelianProducto")
                .AsObservable<FelianProducto>()
                .AsObservableCollection();
            return FelianProductodata;

        }

        public async Task AddFelianProducto(string name, int quantity)
        {
            FelianProducto u = new FelianProducto()
            {
                Name = name,
                Quantity = quantity

            };
            await client
                .Child("FelianProducto")
                .PostAsync(u);
        }

        public async Task UpdateFelianProducto(string name, int quantity)
        {
            var toUpdateFelianProducto = (await client
                .Child("FelianProducto")
                .OnceAsync<FelianProducto>())
                .FirstOrDefault(a => a.Object.Name == name);

            FelianProducto u = new FelianProducto()
            {
                Name = name,
                Quantity = quantity
            };
            await client
                .Child("FelianProducto")
                .Child(toUpdateFelianProducto.Key)
                .PutAsync(u);
        }
    }
}

