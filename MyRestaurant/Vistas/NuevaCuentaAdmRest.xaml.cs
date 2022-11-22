using MyRestaurant.Entidades;
using MyRestaurant.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyRestaurant.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NuevaCuentaAdmRest : ContentPage
	{
        Repositorio<Usuario> repositorioUser;
        NuevaCuentaAdmRestModel model;
        public NuevaCuentaAdmRest ()
		{
			InitializeComponent ();
            model = BindingContext as NuevaCuentaAdmRestModel;
            repositorioUser = new Repositorio<Usuario>();
        }

        private void btnCrearCuenta_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(model.Password2))
            {
                DisplayAlert("Nueva Cuenta", "La contraseña no puede estar vacía", "Ok");
            }
            else
            {
                if (model.Password2 == model.Usuario.Password)
                {
                    if (string.IsNullOrEmpty(model.Usuario.Email) || string.IsNullOrEmpty(model.Usuario.Nombres))
                    {
                        DisplayAlert("Nueva Cuenta", "Hay datos faltantes", "Ok");
                    }
                    else
                    {
                        model.Usuario.EsAdministrador = false;
                        model.Usuario.EsAdmonRestaurant = true;
                        Usuario u = repositorioUser.Create(model.Usuario);
                        if (u != null)
                        {

                            DisplayAlert("Éxito", "Tu cuenta ha sido creada, ya puede iniciar sesión", "Ok");

                        }
                        else
                        {
                            DisplayAlert("Error", repositorioUser.Error, "Ok");
                        }
                    }
                }
                else
                {
                    DisplayAlert("Nueva Cuenta", "Las contraseñas no coinciden", "Ok");
                }
            }
        }

        private void btn_Clicked(object sender, EventArgs e)
        {

        }
    }
}