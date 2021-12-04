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
    public partial class Perlaspago : ContentPage
    {
        public Perlaspago()
        {
            InitializeComponent();
        }
        //Funcionamiento del boton
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PerlasCR());
        }
    }
}