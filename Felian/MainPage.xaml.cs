using Felian.Models;
using Felian.ViewModels;
using Felian.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Felian
{
    public partial class MainPage : ContentPage
    {
        //BindingContext para definir enlaces de datos para vincular las propiedades de dos vistas 
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new UsersVM();
        }
        private async void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var users = e.Item as Users;
            if (users == null)
                return;

        }
        //Funcionamiento de los botones
        private async void Next_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FelianPage());
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new login());
        }
    }
}
