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
    public partial class CategoriaCollares : ContentPage
    {
        public CategoriaCollares()
        {
            InitializeComponent();
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FelianDetailPage());
        }

        private async void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DiamanteDetailPage());
        }

        private async void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EstrellasDetailPage());
        }

        private async void ImageButton_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PerlasDetailPage());
        }
    }
}