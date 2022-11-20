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
    public partial class CreaCuenta : ContentPage
    {
        public CreaCuenta()
        {
            InitializeComponent();
        }

        private void btnCuentaEmpleado_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NuevaCuentaEmpleado());
        }

        private void btnCliente_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NuevaCuentaCliente());
        }
    }
}