using MyRestaurant.Entidades;
using MyRestaurant.Modelos;
using MyRestaurant.Vistas.Restaurante.Contenidos;
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
	public partial class MenuRestaurante : TabbedPage
	{

		Usuario restAdm;
        private LoginModel model;

        public MenuRestaurante (Usuario restAdm)
		{
            InitializeComponent();
            this.restAdm = restAdm;

			Children.Add(new Agregar(restAdm));
			Children.Add(new Buscar(restAdm));
			Title=restAdm.Nombres.ToString();
        }

    }
}