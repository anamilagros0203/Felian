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
    public partial class arete4 : ContentPage
    {
        //BindingContext para definir enlaces de datos para vincular las propiedades de dis vistas 
        public arete4()
        {
            InitializeComponent();
            BindingContext = new FelianViewModel();
        }
        //Para el registro de la base de datos del producto
        private async void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var felianproducto = e.Item as FelianProducto;
            if (felianproducto == null)
                return;
        }
        //Para que funcine los botones 
        private async void Next_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new arete4pago());
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ubicacion());
        }

        private async void Button_Clicked1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MetodoPagoPage());
        }
    }
}