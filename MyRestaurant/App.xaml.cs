using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyRestaurant
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var pagina = new NavigationPage(new MainPage());
            pagina.BarBackgroundColor = (Color)App.Current.Resources["DarkPrimaryColor"];
            MainPage = pagina;
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
