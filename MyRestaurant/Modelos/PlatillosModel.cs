using MyRestaurant.Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MyRestaurant.Modelos
{
    public class PlatillosModel
    {
        
        ObservableCollection<Platillos> LPlatillos {get; set;}

        public PlatillosModel()
        {
            LPlatillos = new ObservableCollection<Platillos>
            {
                new Platillos
                {
                    descripcionP = "plato 1",
                    precioP = "$14.45",
                    iconoP = "https://i.ibb.co/0cpFpv4/IMG01.png"
                },
                new Platillos
                {
                    descripcionP = "plato 2",
                    precioP = "$64.59",
                    iconoP = "https://i.ibb.co/bBS7Lh2/IMG03.png"
                },
                new Platillos
                {
                    descripcionP = "plato 3",
                    precioP = "$23.45",
                    iconoP = "https://i.ibb.co/H4J330b/IMG04.png"
                }
            };        
        } 
    }
}
