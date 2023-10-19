﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerLib {
	public abstract class Propiedad : IImprimible, IComparable {
		protected string dirección;
		protected string[] servicios;
		protected double precioDía;
		protected int maxPasajeros;
		private int cServicios = 0;
		protected List<Alquiler> alquileres = new List<Alquiler>();

		public int CServicios	{get { return cServicios; }}
		public int Número{get;private set;}

        public Propiedad(int número, string dirección)
		{
			this.Número = número;
			this.dirección = dirección;
			this.alquileres = new List<Alquiler>();
            servicios = new string[5];
        }

		public double CalcularPrecioTotal()
		{
			return 0;
		}

        public void Alquilar(Alquiler alquiler)
        {
            this.alquileres.Add(alquiler);
        }

        public void QuitarAlquiler(int nroAlquiler)
        {
            this.alquileres.Remove(VerAlquiler(nroAlquiler));
        }

        public Alquiler VerAlquiler(int nroAlquiler)
        {

            this.alquileres.Sort();

            Alquiler buscado = new Alquiler(
                nroAlquiler,
                new DateTime(2023, 01, 05),
                new DateTime(2023, 01, 06),
                new DateTime(2023, 01, 08),
                new Casa(0, ""));

            int idx = this.alquileres.BinarySearch(buscado);

            if (idx < 0)
                return null;

            return this.alquileres[idx];
        }

        public virtual bool PuedeAlquilar(Alquiler alquiler)
        {
            bool puede = true;

            foreach (Alquiler otro in this.alquileres)
                puede &=
                    alquiler.FechaSalida.CompareTo(otro.FechaEntrada) < 0
                    || alquiler.FechaEntrada.CompareTo(otro.FechaSalida) > 0;

            return puede;
        }

        public string[] VerServicios()
        {
            return servicios;
        }
        public void AgregarServicio(string servicio)
		{
			servicios[cServicios++]= servicio;
		}


		public abstract string Imprimir();

		public int CompareTo(object obj) {
			return this.Número.CompareTo((obj as Propiedad).Número);
		}
	}
}
