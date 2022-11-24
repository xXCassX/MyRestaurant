using MyRestaurant.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRestaurant.Modelos
{
    class AgregarPlatillosModel
    {
        private Repositorio<Platillos> repositorioPlatillos;
        public Usuario Admin { get; set; }
        public string nombreP { get; set; }
        public string precioP { get; set; }

        public AgregarPlatillosModel(Usuario usuario)
        {
            Admin= usuario;
            repositorioPlatillos=new Repositorio<Platillos>();

        }
    }
}
