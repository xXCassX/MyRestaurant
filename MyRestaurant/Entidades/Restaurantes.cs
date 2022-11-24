using System;
using System.Collections.Generic;
using System.Text;

namespace MyRestaurant.Entidades
{
    public class Restaurantes:BaseDTO
    {

        public string NombreRes { get; set; }

        public List<Platillos> Platillos { get; set;}

        public Restaurantes() {
            Platillos= new List<Platillos>();
        }

    }
}
