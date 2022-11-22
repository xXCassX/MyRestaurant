using MyRestaurant.Entidades;
using MyRestaurant.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyRestaurant.Vistas.Restaurante
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuRestaurante : ContentPage
	{

		Usuario restAdm;
		public MenuRestaurante (Usuario restAdm)
		{
            InitializeComponent();
            this.restAdm = restAdm;
			BindingContext = new MenuRestModel (restAdm);
        }
	}
}