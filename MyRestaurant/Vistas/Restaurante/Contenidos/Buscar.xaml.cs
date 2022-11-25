using MyRestaurant.Entidades;
using MyRestaurant.Modelos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        Platillos temp=new Platillos();
        ObservableCollection<Platillos> platillos=new ObservableCollection<Platillos>();
        
        
        public Buscar (Usuario usuario)
		{
			InitializeComponent ();
            this.admin = usuario;
            repositorioRest = new Repositorio<Restaurantes>();
            restaurant = repositorioRest.Query(r => r.NombreRes == usuario.Nombres).SingleOrDefault();            
            platillos= restaurant.Platillos;
            platillosListView.ItemsSource = platillos;
            
        }
     
        public void actualizarLista()
        {
            restaurant = repositorioRest.Query(r => r.NombreRes == admin.Nombres).SingleOrDefault();
        }

        private void btnModificarPlatillo_Clicked(object sender, EventArgs e)
        {
            if (temp.precioP != null || temp.nombreP != null)
            {
                int index = platillos.IndexOf(platillosListView.SelectedItem as Platillos);
                platillos[index] = temp;
                restaurant.Platillos = platillos;
                repositorioRest.Update(restaurant);
                DisplayAlert("Éxito", "Se ha modificado el platillo", "okay");
                actualizarLista();
            }
            else
            {
                DisplayAlert("La wea", "Nel pastel", "okay");
            }
            
        }

        private void btnEliminarPlatillo_Clicked(object sender, EventArgs e)
        {
            platillos.Remove(temp);
            restaurant.Platillos = platillos;
            repositorioRest.Update(restaurant);
            DisplayAlert("Éxito", "Se ha eliminado el platillo", "okay");
        }

        private void platillosListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Platillos elem = platillosListView.SelectedItem as Platillos;
            entryPlatillo.Text = elem.nombreP.ToString();
            entryPrecio.Text = elem.precioP.ToString();
            temp = elem;
        }

        private void entryPlatillo_Unfocused(object sender, FocusEventArgs e)
        {
            temp.nombreP=entryPlatillo.Text;
        }


        private void entryPrecio_Unfocused(object sender, FocusEventArgs e)
        {
            temp.precioP=entryPrecio.Text;
        }
    }
}