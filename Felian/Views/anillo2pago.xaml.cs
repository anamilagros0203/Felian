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
    public partial class anillo2pago : ContentPage
    {
        public anillo2pago()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
            //Funcionamiento del boton
        {
            await Navigation.PushAsync(new anillo2CR());
        }
    }
}