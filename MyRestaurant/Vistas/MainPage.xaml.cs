using MyRestaurant.Entidades;
using MyRestaurant.Modelos;
using MyRestaurant.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyRestaurant
{
    public partial class MainPage : ContentPage
    {
        Repositorio<Usuario> repositorio;
        LoginModel model;
        public MainPage()
        {
            InitializeComponent();
            repositorio = new Repositorio<Usuario>();
            model = BindingContext as LoginModel;
        }


        private void btnIniciarSesion_Clicked(object sender, EventArgs e)
        {
            Usuario user = repositorio.Query(p => p.Email == model.Email && p.Password == model.Password).SingleOrDefault();
            if (user != null)
            {
                //ingresar
                DisplayAlert("My Restaurant", "Bienvenido " + user.Nombres, "Ok");
                if (user.EsAdministrador)
                {
                    //Mandar a pantalla de administrador
                }
                else
                {
                    //Mandar a pantalla de usuario común
                }
            }
            else
            {
                DisplayAlert("Error", "Email y/o contraseña incorrecta", "Ok");
            }
        }

        private void btnCrearCuenta_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreaCuenta());
        }
    }
}
