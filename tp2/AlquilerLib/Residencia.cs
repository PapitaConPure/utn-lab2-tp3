using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace AlquilerLib {
	[Serializable]
	public abstract class Residencia: IExportable, IComparable {
		private readonly List<Alquiler> alquileres = new List<Alquiler>();
		protected string[] servicios;
		protected double precioDía;
		protected int contAlquileres = 0;
		private int cServicios = 0;

		public int Número { get; set; }

		public string Dirección { get; private set; }

		public Image[] Imágenes { get; private set; }

		public Alquiler[] Alquileres {
			get { return this.alquileres.ToArray(); }
		}

		public int ContAlquileres {
			get { return this.contAlquileres; }
		}

		public int CServicios {
			get { return this.cServicios; }
		}

		/// <summary>
		/// Crea una nueva residencia con el número, la dirección y las imágenes especificadas
		/// </summary>
		/// <param name="número">Número de residencia</param>
		/// <param name="dirección">Dirección de la residencia</param>
		/// <param name="imágenes">Imágenes de muestra de la residencia</param>
		/// <exception cref="ArgumentException"></exception>
		public Residencia(int número, string dirección, Image[] imágenes) {
			if(dirección.Length == 0)
				throw new ArgumentException("La dirección de la residencia no puede estar vacía");

			if(imágenes.Length != 2)
				throw new ArgumentException("La residencia debe tener 2 imágenes");

			foreach(Image imagen in imágenes)
				if(imagen is null)
					throw new ArgumentException("La residencia debe tener 2 imágenes");

			this.Número = número;
			this.Dirección = dirección.Trim().Substring(0, 28).ToUpper();
			this.alquileres = new List<Alquiler>();
            this.servicios = new string[6];
			this.Imágenes = imágenes;
		}

		/// <summary>
		/// Solamente para búsqueda binaria
		/// </summary>
		/// <param name="número">Número de residencia a buscar</param>
		internal Residencia(int número) {
			this.Número = número;
		}

		virtual public double CalcularPrecioTotal() {
			return 0;
		}

        public virtual bool Alquilar(DateTime hoy, DateTime ingreso, DateTime salida, int cantPasajeros, int dni, string nombre, string apellido, long tel, double precioBase, out Alquiler nuevo)
        {
			nuevo = new Alquiler(this.contAlquileres, hoy, ingreso, salida, this, cantPasajeros, dni, nombre, apellido, tel, precioBase);

			//Creo estar bastante seguro de que es literalmente imposible de que tengas 999 alquileres en 3 meses
			if(this.contAlquileres < 999)
				this.contAlquileres++;
			else
				this.contAlquileres = 0;

			bool puedeAlquilar = this.PuedeAlquilar(nuevo);

			if(puedeAlquilar)
				this.AgregarAlquiler(nuevo);

			return puedeAlquilar;
        }

        public virtual bool Alquilar(int nro, DateTime hoy, DateTime ingreso, DateTime salida, int cantPasajeros, int dni, string nombre, string apellido, long tel, double precioBase, out Alquiler nuevo)
        {
            nuevo = new Alquiler(nro, hoy, ingreso, salida, this, cantPasajeros, dni, nombre, apellido, tel, precioBase);
            bool puedeAlquilar = this.PuedeAlquilar(nuevo);

            if (puedeAlquilar)
                this.AgregarAlquiler(nuevo);

            return puedeAlquilar;
        }

        public bool QuitarAlquiler(int nroAlquiler) {
			Alquiler alquiler = this.VerAlquiler(nroAlquiler);

			if(alquiler is null)
				return false;

			bool pudo = this.alquileres.Remove(alquiler);
            if(pudo) {
				if(this is Hotel) {
					alquiler.Habitacion.QuitarAlquiler(alquiler);
                }
            }
			return pudo;
		}

        public Alquiler VerAlquiler(int nroAlquiler) {
            this.alquileres.Sort();

            Alquiler buscado = new Alquiler(nroAlquiler);

            int idx = this.alquileres.BinarySearch(buscado);
            if (idx < 0)
                return null;

            return this.alquileres[idx];
        }

        public virtual bool PuedeAlquilar(Alquiler alquiler) {
            bool puede = true;

            foreach (Alquiler otro in this.alquileres)
                puede &=
                    alquiler.CheckOut.CompareTo(otro.CheckIn) < 0
                    || alquiler.CheckIn.CompareTo(otro.CheckOut) > 0;

            return puede;
        }

        public abstract double PorcentajePorDía(int nroAlquiler);

        public abstract double PrecioTotal(int nroAlquiler);

        public void AgregarServicio(string servicio)
		{
			if(!this.servicios.Contains(servicio))
				this.servicios[this.cServicios++]= servicio;
		}
		public void AgregarAlquiler(Alquiler alquiler)
        {
			this.alquileres.Add(alquiler);
		}

		public void LimpiarAlquileres() {
			this.alquileres.Clear();
		}

		public void LimpiarServicios() {
			this.servicios = new string[6];
			this.cServicios = 0;
		}

		public string[] VerServicios() {
			string[] resultado = new string[this.CServicios];
			
			for(int i = 0; i < this.CServicios; i++)
				resultado[i] = this.servicios[i];

			return resultado;
		}

		public string Exportar() {
			return $"{this.Número}";
		}

		public int CompareTo(object obj) {
			return this.Número.CompareTo((obj as Residencia).Número);
		}
    }
}
