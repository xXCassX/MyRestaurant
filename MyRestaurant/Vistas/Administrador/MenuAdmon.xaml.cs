using MyRestaurant.Entidades;
using MyRestaurant.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyRestaurant.Vistas.Administrador
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuAdmon : ContentPage
    {
        Usuario Administrador;

        public MenuAdmon(Usuario Administrador)
        {
            InitializeComponent();
            this.Administrador = Administrador;
            BindingContext = new MenuAdmonModel (Administrador);
            
        }

        private void btnResAs_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RestaurantesAsociados());
        }

        private void btnPedidos_Clicked(object sender, EventArgs e)
        {

        }
    }
}