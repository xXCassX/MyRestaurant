using System;
using System.Collections.Generic;
using System.Text;

namespace MyRestaurant.Entidades
{
    public class Restaurantes:BaseDTO
    {
        public string UIDRes { get; set; }
        public string NombreRes { get; set; }
        public string ColleccionPlatillosYBebidas { get; set; }

        public override string ToString()
        {
            return UIDRes;
        }
    }
}
