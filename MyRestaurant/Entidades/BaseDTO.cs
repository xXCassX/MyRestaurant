using System;
using System.Collections.Generic;
using System.Text;

namespace MyRestaurant.Entidades
{
    public abstract class BaseDTO
    {
        public String Id { get; set; }
        public DateTime FechaHora { get; set; }
    }
}
