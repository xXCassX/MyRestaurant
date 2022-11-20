﻿using MyRestaurant.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRestaurant.Modelos
{
    public class NuevaCuentaAdmonModel
    {
        public Usuario Usuario { get; set; }
        
        public string Password2 { get; set; }

        public NuevaCuentaAdmonModel()
        {
            Usuario = new Usuario();
        }

    }
}
