using System;
using System.Collections.Generic;
using System.Text;

namespace MyRestaurant.Entidades
{
    public class Usuario:BaseDTO
    {
        public string UID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool EsAdministrador { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

    }
}
