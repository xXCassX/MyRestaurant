using MyRestaurant.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRestaurant.Modelos
{
    public class NuevaCuentaAdmRestModel
    {
        public Usuario Usuario { get; set; }
        public Restaurantes Restaurantes { get; set; }

        public string Password2 { get; set; }

        public NuevaCuentaAdmRestModel()
        {
            Usuario = new Usuario();
            Restaurantes=new Restaurantes();
        }

    }
}
