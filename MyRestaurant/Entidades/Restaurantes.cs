using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MyRestaurant.Entidades
{
    public class Restaurantes:BaseDTO
    {

        public string NombreRes { get; set; }

        public ObservableCollection<Platillos> Platillos { get; set;}

        public Restaurantes() {
                Platillos= new ObservableCollection<Platillos>();
        }

    }
}
