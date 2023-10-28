using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerLib {
	[Serializable]
	public abstract class Residencia: IExportable, IComparable {
		protected string[] servicios;
		protected double precioDía;
		private int cServicios = 0;
		private List<Alquiler> alquileres = new List<Alquiler>();
		private int contAlquileres = 0;

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
			this.Dirección = dirección;
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

        public bool Alquilar(DateTime hoy, DateTime ingreso, DateTime salida, Cliente cliente,double precioBase)
        {
			Alquiler alquiler = new Alquiler(contAlquileres++, hoy, ingreso, salida,this, cliente,precioBase);
			bool puedeAlquilar = this.PuedeAlquilar(alquiler);
			if(puedeAlquilar)this.alquileres.Add(alquiler);
			return puedeAlquilar;
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
				new Cliente(0, 0, 0, "", "", 0),
				0);

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

        public void AgregarServicio(string servicio)
		{
			if(!this.servicios.Contains(servicio))
				this.servicios[this.cServicios++]= servicio;
		}

		public void LimpiarServicios() {
			this.servicios = new string[6];
			this.cServicios = 0;
		}

		public string[] VerServicios() {
			return this.servicios;
		}

		public string Imprimir() {
			return $"{this.Número}";
		}

		public int CompareTo(object obj) {
			return this.Número.CompareTo((obj as Residencia).Número);
		}
	}
}
