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
    public partial class CategoriaAretes : ContentPage
    {
        public CategoriaAretes()
        {
            InitializeComponent();
        }
        //Funcionamiento de los botones 
        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new arete1());
        }

        private async void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new arete2());
        }

        private async void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new arete3());
        }

        private async void ImageButton_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new arete4());
        }
    }
}