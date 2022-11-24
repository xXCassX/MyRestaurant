using MyRestaurant.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRestaurant.Modelos
{
    class NuevoRestaurantModel
    {
        public Restaurantes Restaurantes;
        public NuevoRestaurantModel() { 
            Restaurantes= new Restaurantes();
        }
    }
}
