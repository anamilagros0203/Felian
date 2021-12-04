using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Felian
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Para poner navegar entre las paginas
            MainPage = new  NavigationPage(new Views.Inicio());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
