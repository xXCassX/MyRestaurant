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
               
            };        
        } 
    }
}
