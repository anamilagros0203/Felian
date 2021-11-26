using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Felian.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FelianPage : ContentPage
    {
        public FelianPage()
        {
            InitializeComponent();
        }
       
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ubicacion());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HistorialPage());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoriaCollares());
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoriaAnillos());
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoriaAretes());
        }
    }
}