using MyRestaurant.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRestaurant.Modelos
{
    public class MenuAdmonModel
    {
        public Usuario Administrador { get; set; }

        public MenuAdmonModel() 
        {
        
        }

        public MenuAdmonModel(Usuario usuario) 
        {
            Administrador = usuario;
        }
        
    }
}
