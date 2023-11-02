using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerLib
{
    class Habitación
    {
        Hotel Hotel { get; }
        public int Número { get; set; }
        public Hotel.TipoHabitación Tipo { get; }
        //public int Camas { get; }
        //public bool noDisponible { get; set; }
        public List<Alquiler> Reservas { get; }

        public Habitación(int nro, Hotel.TipoHabitación tipo, Hotel unHotel)
        {
            //this.Número = nro;
            this.Tipo = tipo;
            this.Hotel = unHotel;
            this.Reservas = new List<Alquiler>();
        }
        //public int CompareTo(object obj)
        //{
        //    return this.Número.CompareTo(((Habitación)obj).Número);
        //}
        //public override string ToString()
        //{
        //    string i = "Disponible";
        //    if (noDisponible)
        //    {
        //        i = "No Disponible";
        //    }
        //    return $"Número:{Número}, Tipo:{Tipo}, Camas:{Camas},{i}";
        //}
    }
}

