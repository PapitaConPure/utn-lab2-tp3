using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerLib {
	public abstract class Residencia : IImprimible, IComparable {
		protected string[] servicios;
		protected double precioDía;
		private int cServicios = 0;
		protected List<Alquiler> alquileres = new List<Alquiler>();
		private Image[] imágenes;

		public Residencia(int número, string dirección, Image[] imágenes) //Persona propietario
		{
			this.Número = número;
			this.Dirección = dirección;
			this.alquileres = new List<Alquiler>();
            this.servicios = new string[6];
			this.imágenes = new Image[2];
		}

		public int CServicios { get { return cServicios; } }

		public int Número { get; private set; }

		public string Dirección { get; private set; }

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
                new Casa(0, "",0,0,0,"",0,"", new Image[] { }),
				new Cliente(0,0,"","",0),0);

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

        public abstract double PrecioPorDía(int nroAlquiler);
        public abstract double PrecioTotal(int nroAlquiler);

        public string[] VerServicios()
        {
            return servicios;
        }
        public void AgregarServicio(string servicio)
		{
			servicios[cServicios++]= servicio;
		}

		public string Imprimir() {
			return $"{this.Dirección};{this.Número}";
		}

		public int CompareTo(object obj) {
			return this.Número.CompareTo((obj as Residencia).Número);
		}
	}
}
