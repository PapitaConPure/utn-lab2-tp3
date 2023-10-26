using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerLib {
	[Serializable]
	public abstract class Residencia : IImprimible, IComparable {
		protected string[] servicios;
		protected double precioDía;
		private int cServicios = 0;
		private List<Alquiler> alquileres = new List<Alquiler>();

		public Residencia(int número, string dirección, Image[] imágenes) //Persona propietario
		{
			this.Número = número;
			this.Dirección = dirección;
			this.alquileres = new List<Alquiler>();
            this.servicios = new string[6];
			this.Imágenes = imágenes;
		}

		public int CServicios { get { return this.cServicios; } }

		public int Número { get; private set; }

		public string Dirección { get; private set; }

		public Image[] Imágenes { get; private set; }

		public Alquiler[] Alquileres {
			get { return this.alquileres.ToArray(); }
		}

		public double CalcularPrecioTotal()
		{
			return 0;
		}

        public void Alquilar(Alquiler alquiler)
        {
            this.alquileres.Add(alquiler);
			alquiler.Residencia = this;
        }

        public void QuitarAlquiler(int nroAlquiler)
        {
            this.alquileres.Remove(this.VerAlquiler(nroAlquiler));
        }

        public Alquiler VerAlquiler(int nroAlquiler)
        {
            this.alquileres.Sort();

            Alquiler buscado = new Alquiler(
                nroAlquiler,
                new DateTime(2023, 01, 05),
                new DateTime(2023, 01, 06),
                new DateTime(2023, 01, 08),
				new Cliente(0, 0, 0, "", "", 0));

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
                    alquiler.CheckOut.CompareTo(otro.CheckIn) < 0
                    || alquiler.CheckIn.CompareTo(otro.CheckOut) > 0;

            return puede;
        }

        public abstract double PrecioPorDía(int nroAlquiler);

        public abstract double PrecioTotal(int nroAlquiler);

        public string[] VerServicios()
        {
            return this.servicios;
        }
        public void AgregarServicio(string servicio)
		{
			this.servicios[this.cServicios++]= servicio;
		}

		public string Imprimir() {
			return $"{this.Número}";
		}

		public int CompareTo(object obj) {
			return this.Número.CompareTo((obj as Residencia).Número);
		}
	}
}
