﻿using System;
using System.Collections.Generic;

namespace AlquilerLib
{
    [Serializable]
    public class Habitación{
    
        Hotel Hotel { get; }
        public int Número { get; set; }
        public Hotel.TipoHabitación Tipo { get; }
        //public int Camas { get; }
        //public bool noDisponible { get; set; }
        public List<Alquiler> Reservas { get; set; }

        public Habitación(Hotel.TipoHabitación tipo, Hotel unHotel)
        {
            //this.Número = nro;
            this.Tipo = tipo;
            this.Hotel = unHotel;
            this.Reservas = new List<Alquiler>();
        }

        public bool PuedeAlquilar(Alquiler alquiler, int pasajeros)
        {
            bool puede = true;

            foreach (Alquiler otro in this.Reservas)
            { 
                puede &=
                    alquiler.CheckOut.CompareTo(otro.CheckIn) < 0
                    || alquiler.CheckIn.CompareTo(otro.CheckOut) > 0;
            }
            puede &=
                    (pasajeros > 4 && pasajeros < 7 && this.Tipo == Hotel.TipoHabitación.Triple)
                    || (pasajeros > 2 && pasajeros < 5 && this.Tipo == Hotel.TipoHabitación.Doble)
                    || (pasajeros > 0 && pasajeros < 3 && this.Tipo == Hotel.TipoHabitación.Simple);
            return puede;
        }
        public void Alquilar(Alquiler alq)
        {
            this.Reservas.Add(alq);
        }
        public void QuitarAlquiler(Alquiler alq)
        {
            this.Reservas.Remove(alq);
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

