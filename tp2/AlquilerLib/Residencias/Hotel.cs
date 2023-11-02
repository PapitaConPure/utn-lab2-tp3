using System;
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
			this.Estrellas = estrellas;
			this.CntSimple = cntSimple;
			this.CntDoble = cntDoble;
			this.CntTriple = cntTriple;
		}

		public int Estrellas { get; set; }

		public int CntSimple { get; set; }

		public int CntDoble { get; set; }

		public int CntTriple { get; set; }

		public override bool Alquilar(DateTime hoy, DateTime ingreso, DateTime salida, int cantPasajeros, int dni, string nombre, string apellido, long tel, double precioBase, out Alquiler nuevo) {
			bool puedeAlquilar = base.Alquilar(hoy, ingreso, salida, cantPasajeros, dni, nombre, apellido, tel, precioBase, out nuevo);

			nuevo.TipoHabitación = this.VerTipoHabitación(cantPasajeros);

			return puedeAlquilar;
		}

        public override double CalcularPrecioTotal()
        {
            return 1000;
        }

        public override double PorcentajePorDía(int nroAlquiler) { ///terminar de codificar
			Alquiler alquiler = this.VerAlquiler(nroAlquiler);
			double precio = 1;

			precio += (int)this.VerTipoHabitación(alquiler.Cliente.CantPasajeros) / 100;

			if(this.Estrellas >= 3)
				precio *= 1.4;

			return precio;
		}

        public override double PrecioTotal(int nroAlquiler)
        {
            Alquiler alquiler = this.VerAlquiler(nroAlquiler);
			TimeSpan diferencia = alquiler.CheckOut.Subtract(alquiler.CheckIn);
			//double precioFinal = PrecioPorDía(nroAlquiler) * diferencia.Days;
			double precioFinal = this.PorcentajePorDía(nroAlquiler) * (1 + (int)diferencia.TotalDays * 0.03);
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
			return $"Hotel: {this.Dirección}, {this.Número}";
		}
    }
}
