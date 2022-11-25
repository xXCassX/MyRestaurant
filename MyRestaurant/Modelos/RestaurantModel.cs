using MyRestaurant.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRestaurant.Modelos
{
    class RestaurantModel
    {
        public Restaurantes restaurantes { get; set; }
        public List<Platillos> platillos { get; set; }

    }
}
