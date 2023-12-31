﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerLib {
	[Serializable]
	public class Hotel: Residencia {
		public enum TipoHabitación {
			Simple = 0,
			Doble = 80,
			Triple = 150,
		}
		
		private readonly List<Habitación> habitaciones;
		public List<Habitación> Habitaciones { get { return this.habitaciones; } }

		/// <summary>
		/// Crea un nuevo hotel con los datos de residencia especificados y la categoría indicada.
		/// También se indica el tipo y cantidad de camas disponibles
		/// </summary>
		/// <param name="número">Número del hotel</param>
		/// <param name="dirección">Dirección del hotel</param>
		/// <param name="estrellas">Categoría del hotel, en estrellas</param>
		/// <param name="cntSimple">Cantidad de camas simples del hotel</param>
		/// <param name="cntDoble">Cantidad de camas dobles del hotel</param>
		/// <param name="cntTriple">Cantidad de camas triples del hotel</param>
		/// <param name="imágenes">Imágenes de muestra del hotel del hotel</param>
		/// <exception cref="ArgumentException"></exception>
		public Hotel(int número, string dirección, int estrellas, int cntSimple, int cntDoble, int cntTriple, Image[] imágenes)
		: base(número, dirección, imágenes) {
			this.habitaciones = new List<Habitación>();
			this.Estrellas = estrellas;
			this.CntSimple = cntSimple;

			int i;
			Habitación nueva;
			for ( i = 0; i < cntSimple; i++)
            {
				nueva = new Habitación(TipoHabitación.Simple);
				this.habitaciones.Add(nueva);
            }

			this.CntDoble = cntDoble;
			for (i = 0; i < cntDoble; i++)
			{
				nueva = new Habitación(TipoHabitación.Doble);
				this.habitaciones.Add(nueva);
			}

			this.CntTriple = cntTriple;
			for (i = 0; i < cntTriple; i++)
			{
				nueva = new Habitación(TipoHabitación.Triple);
				this.habitaciones.Add(nueva);
			}
		}

		public int Estrellas { get; set; }

		public int CntSimple { get; set; }

		public int CntDoble { get; set; }

		public int CntTriple { get; set; }

		public override bool Alquilar(DateTime hoy, DateTime ingreso, DateTime salida, int cantPasajeros, int dni, string nombre, string apellido, long tel, double precioBase, out Alquiler nuevo) {
			
			Alquiler alquiler = new Alquiler(ingreso,salida);
			bool encontro = false;
			int i = 0;
            while (!encontro && i < this.habitaciones.Count)
            {
                if (this.habitaciones[i].PuedeAlquilar(alquiler, cantPasajeros))
                {
					alquiler = new Alquiler(this.contAlquileres++, hoy, ingreso, salida, this, this.habitaciones[i], cantPasajeros, dni, nombre, apellido, tel, precioBase);
					this.habitaciones[i].Alquilar(alquiler);
					this.AgregarAlquiler(alquiler);
					encontro = true;
				}
				i++;
            }
			alquiler.TipoHabitación = this.VerTipoHabitación(cantPasajeros);
			nuevo = alquiler;
			return encontro;
		}

        public override double CalcularPrecioTotal()
        {
			double precio = 1;

			precio += (int)this.VerTipoHabitación(2) / 100;

			if (this.Estrellas >= 3)
				precio *= 1.4;
			return precio;
		}

        public override double PorcentajePorDía(int nroAlquiler) {
			Alquiler alquiler = this.VerAlquiler(nroAlquiler);
			double precio = 1;

			precio += (double)this.VerTipoHabitación(alquiler.Cliente.CantPasajeros) / 100;

			if(this.Estrellas >= 3)
				precio *= 1.4;

			return precio;
		}

        public override double PrecioTotal(int nroAlquiler)
        {
            Alquiler alquiler = this.VerAlquiler(nroAlquiler);
			TimeSpan diferencia = alquiler.CheckOut.Subtract(alquiler.CheckIn);
			double precioFinal = (this.PorcentajePorDía(nroAlquiler)*(int)diferencia.TotalDays) * ((1 + (int)diferencia.TotalDays*0.03 
								 - 0.015*((int)diferencia.TotalDays-1)));
			return precioFinal;
		}

		public TipoHabitación VerTipoHabitación(int cantPasajeros) {
			if(cantPasajeros > 4) {
				return TipoHabitación.Triple;
			} else if(cantPasajeros > 2) {
				return TipoHabitación.Doble;
			} else {
				return TipoHabitación.Simple;
			}
		}

		public override string ToString()
        {
			return $"{"Hotel",-12} {this.Dirección,-30} {this.Número,-10}";
		}
    }
}
