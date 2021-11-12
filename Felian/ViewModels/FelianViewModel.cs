using Felian.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Essentials;

namespace Felian.ViewModels
{
    public class FelianViewModel
    {
        public ObservableCollection<FelianProducto> felian { get; set; }

        public FelianViewModel()
        {
            felian = new ObservableCollection<FelianProducto>
            {
                new FelianProducto
                {
                    Name = "Mariposa", Price = "56", Picture ="mariposa.jpeg"
                },
                new FelianProducto
                {
                    Name = "Tres en uno", Price = "70", Picture ="3en1.jpg"
                },
                new FelianProducto
                {
                    Name = "Diamantes", Price = "100", Picture ="diamantes.jpg"
                },
                new FelianProducto
                {
                    Name = "Estrellas", Price = "56", Picture ="estrellas.jpg"
                },
                new FelianProducto
                {
                    Name = "Perlas", Price = "110", Picture ="perlas.jpeg"
                },
            };
        }
    }
}