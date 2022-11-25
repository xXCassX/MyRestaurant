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

	public partial class Agregar : ContentPage
	{
        Repositorio<Restaurantes> repositorioRest;
        Restaurantes restaurant;
		PlatillosModel model;
		Platillos platillo=new Platillos();
        public Usuario admin;
		
		
        public Agregar (Usuario usuario)
		{
			InitializeComponent ();
			this.admin = usuario;
			repositorioRest = new Repositorio<Restaurantes>();
			restaurant = repositorioRest.Query(r=>r.NombreRes==usuario.Nombres).SingleOrDefault();
			model = BindingContext as PlatillosModel;
        }

        private void btnAgregarPlatillo_Clicked(object sender, EventArgs e)
        {
			if (string.IsNullOrEmpty(model.nombreP) || string.IsNullOrEmpty(model.precioP))
			{
                DisplayAlert("Error", "No pueden haber campos vacíos", "Okay");
			}
			else {
				platillo.nombreP=model.nombreP.ToString();
				platillo.precioP=model.precioP.ToString();
				restaurant.Platillos.Add(platillo);
				repositorioRest.Update(restaurant);
                DisplayAlert("Éxito", "Se ha agregado el platillo", "Okay");
				
            }
			

        }
    }
}