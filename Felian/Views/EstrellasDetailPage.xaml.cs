using Felian.Models;
using Felian.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Felian.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EstrellasDetailPage : ContentPage
    {
        public EstrellasDetailPage()
        {
            InitializeComponent();
        }
        //Boton
        private async void Next_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FelianPagoPage());
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ubicacion());
        }
        private async void Button_Clicked1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MetodoPagoPage());
        }

        //Base de datos producto
        private async void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var felianproducto = e.Item as FelianProducto;
            if (felianproducto == null)
                return;
        }
    }
}