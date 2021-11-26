using Felian.Models;
using Felian.Services;
using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Felian.ViewModels
{
    public class FelianViewModel : BaseViewModel
    {
        private DBFirebase1 services;

        public string Name { get; set; }
        public int Quantity { get; set; }

        public Command SaveFelianProductoCommand { get; set; }

        private ObservableCollection<FelianProducto> felianproducto = new ObservableCollection<FelianProducto>();

        public ObservableCollection<FelianProducto> FelianProductoList
        {
            get { return felianproducto; }

            set
            {
                felianproducto = value;
                OnPropertyChanged();
            }
        }

        public FelianViewModel()
        {
            services = new DBFirebase1();
            FelianProductoList = services.GetFelianProductoList();
            SaveFelianProductoCommand = new Command(
                async () => await SaveFelianProductoAsync(Name, Quantity));
        }

        public async Task SaveFelianProductoAsync(string name,int quantity)
        {
            await services.AddFelianProducto(name, quantity);
        }
    }
}
