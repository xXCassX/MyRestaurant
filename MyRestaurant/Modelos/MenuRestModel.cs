using MyRestaurant.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRestaurant.Modelos
{
    internal class MenuRestModel
    {

        public Usuario restAdm { get; set; }

        public MenuRestModel()
        {

        }

        public MenuRestModel(Usuario usuario)
        {
            restAdm = usuario;
        }

    }
}
