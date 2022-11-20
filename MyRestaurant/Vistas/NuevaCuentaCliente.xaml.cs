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
    public partial class NuevaCuentaCliente : ContentPage
    {
        Repositorio<Usuario> repositorioUsuario;
        Repositorio<Clientes> repositorioClientes;
        NuevaCuentaClienteModel model;
        
        public NuevaCuentaCliente()
        {
            InitializeComponent();
            model = BindingContext as NuevaCuentaClienteModel;
            repositorioUsuario = new Repositorio<Usuario>();
            repositorioClientes = new Repositorio<Clientes>();
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
                    if (string.IsNullOrEmpty(model.Usuario.Email) || string.IsNullOrEmpty(model.Usuario.Nombres) || string.IsNullOrEmpty(model.Usuario.Apellidos) || string.IsNullOrEmpty(model.cliente.Direccion))
                    {
                        DisplayAlert("Nueva Cuenta", "Hay datos faltantes", "Ok");
                    }
                    else
                    {
                        model.Usuario.EsAdministrador = false;
                        Usuario u = repositorioUsuario.Create(model.Usuario);
                        if (u != null)
                        {
                            model.cliente.UID = u.Id;
                            if (repositorioClientes.Create(model.cliente) != null)
                            {
                                DisplayAlert("Éxito", "Tu cuenta ha sido creada, ya puede iniciar sesión", "Ok");
                            }
                            else 
                            {
                                DisplayAlert("Error", repositorioClientes.Error, "Ok");
                            }
                        }
                        else
                        {
                            DisplayAlert("Error", repositorioUsuario.Error, "Ok");
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