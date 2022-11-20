using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace MyRestaurant.Entidades
{
    public class Pedidos: Restaurantes
    {
        public string NumPedido { get; set; }
        public string IdCliente { get; set; }
        public float MontoT { get; set; }
    }

}
