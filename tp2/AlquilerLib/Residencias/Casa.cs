using System;
using System.Drawing;
using AlquilerLib.Constructores;

namespace AlquilerLib {
	[Serializable]
	public class Casa: Residencia, IExportable {
		/// <summary>
		/// Crea una nueva casa con los datos de residencia, el mínimo de días, las camas disponibles y los datos del propietario especificados
		/// </summary>
		/// <param name="número">Número de casa</param>
		/// <param name="dirección">Dirección de la casa</param>
		/// <param name="mínimoDías">Mínimo de días permitido para alquilar la casa</param>
		/// <param name="camas">Camas disponibles para los alquileres de la casa</param>
		/// <param name="dni">DNI del propietario de la casa</param>
		/// <param name="nombre">Nombre/s del propietario de la casa</param>
		/// <param name="tel">Teléfono del propietario de la casa</param>
		/// <param name="apellido">Apellido/s del propietario de la casa</param>
		/// <param name="imágenes">Imágenes de muestra de la casa</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="FormatException"></exception>
		public Casa(int número, string dirección, int mínimoDías, int camas, DatosPersona datosPropietario, Image[] imágenes)
		: base(número, dirección, imágenes) {
			this.CamasDisponibles= camas;
			this.MínimoPermitido = mínimoDías;
			this.Propietario = new Persona(datosPropietario);
		}

		/// <summary>
		/// Solamente para búsqueda binaria
		/// </summary>
		/// <param name="número">Número de residencia a buscar</param>
		internal Casa(int número): base(número) {}

		public int MínimoPermitido { get; set; }

		public int CamasDisponibles { get; set; }

		public Persona Propietario { get; set; }

        public override double CalcularPrecioTotal()
        {
            return this.PorcentajePorDía(0);
        }

        public override double PorcentajePorDía(int nroAlquiler) {
			return (1 + this.CamasDisponibles * 0.07) * (1 + this.CServicios * 0.14);
		}

        public override double PrecioTotal(int nroAlquiler)
        {
			Alquiler alquiler = this.VerAlquiler(nroAlquiler);
			TimeSpan diferencia = alquiler.CheckOut.Subtract(alquiler.CheckIn);
			double PrecioFinal = this.PorcentajePorDía(nroAlquiler) * (diferencia.Days-this.MínimoPermitido) * 0.9 + this.PorcentajePorDía(nroAlquiler) * this.MínimoPermitido;
			return PrecioFinal;
        }

        public override bool PuedeAlquilar(Alquiler alquiler) {
			return base.PuedeAlquilar(alquiler) && alquiler.Cliente.CantPasajeros<=this.CamasDisponibles;
		}

		public override string ToString()
        {
			return $"Casa: {this.Dirección}, {this.Número}";
        }
    }
}
