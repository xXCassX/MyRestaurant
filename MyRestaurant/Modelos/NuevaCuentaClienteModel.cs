using MyRestaurant.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRestaurant.Modelos
{
    internal class NuevaCuentaClienteModel
    {
        public Usuario Usuario { get; set; }

        public Clientes cliente { get; set; }

        public string Password2 { get; set; }

        public NuevaCuentaClienteModel()
        {
            Usuario = new Usuario();
        }
    }
}
