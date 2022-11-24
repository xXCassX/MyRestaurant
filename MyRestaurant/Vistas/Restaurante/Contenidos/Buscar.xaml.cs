using MyRestaurant.Entidades;
using MyRestaurant.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyRestaurant.Vistas.Restaurante.Contenidos
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Buscar : ContentPage
	{
        Usuario admin;
        Repositorio<Restaurantes> repositorioRest;
        Restaurantes restaurant;
        public Buscar (Usuario usuario)
		{
			InitializeComponent ();
            this.admin = usuario;
            repositorioRest = new Repositorio<Restaurantes>();
            restaurant = repositorioRest.Query(r => r.NombreRes == usuario.Nombres).SingleOrDefault();

            BindingContext= restaurant;

        }

        private void btnModificarPlatillo_Clicked(object sender, EventArgs e)
        {

        }

        private void btnEliminarPlatillo_Clicked(object sender, EventArgs e)
        {

        }
    }
}