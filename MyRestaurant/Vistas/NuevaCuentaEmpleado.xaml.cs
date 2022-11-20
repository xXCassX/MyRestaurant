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
    public partial class NuevaCuentaEmpleado : ContentPage
    {
        NuevaCuentaAdmonModel model;
        Repositorio<Usuario> usuarioRepositorio;
        
        public NuevaCuentaEmpleado()
        {
            InitializeComponent();
            model = BindingContext as NuevaCuentaAdmonModel;
            usuarioRepositorio = new Repositorio<Usuario>();
            
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
                    if (string.IsNullOrEmpty(model.Usuario.Email) || string.IsNullOrEmpty(model.Usuario.Nombres) || string.IsNullOrEmpty(model.Usuario.Apellidos))
                    {
                        DisplayAlert("Nueva Cuenta", "Hay datos faltantes", "Ok");
                    }
                    else 
                    {
                        model.Usuario.EsAdministrador = true;
                        Usuario u = usuarioRepositorio.Create(model.Usuario);
                        if (u != null)
                        {
                            DisplayAlert("Éxito", "Tu cuenta ha sido creada, ya puede iniciar sesión", "Ok");
                        }
                        else
                        {
                            DisplayAlert("Error", usuarioRepositorio.Error, "Ok");
                        }
                    }
                }
                else 
                {
                    DisplayAlert("Nueva Cuenta", "Las contraseñas no coinciden", "Ok");
                }
            }

        }
    }
}