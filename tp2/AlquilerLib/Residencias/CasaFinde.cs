using System;
using System.Drawing;
using AlquilerLib.Constructores;

namespace AlquilerLib {
	[Serializable]
	public class CasaFinde: Casa {
		/// <summary>
		/// Crea una nueva casa de finde con los datos de residencia, el mínimo de días, las camas disponibles y los datos del propietario especificados
		/// </summary>
		/// <param name="número">Número de casa</param>
		/// <param name="dirección">Dirección de la casa</param>
		/// <param name="camas">Camas disponibles para los alquileres de la casa</param>
		/// <param name="dni">DNI del propietario de la casa</param>
		/// <param name="nombre">Nombre/s del propietario de la casa</param>
		/// <param name="tel">Teléfono del propietario de la casa</param>
		/// <param name="apellido">Apellido/s del propietario de la casa</param>
		/// <param name="imágenes">Imágenes de muestra de la casa</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="FormatException"></exception>
		public CasaFinde(int número, string dirección, int camas, DatosPersona datosPropietario, Image[] imágenes)
		: base(número, dirección, 3, camas, datosPropietario, imágenes) {}

		public override bool PuedeAlquilar(Alquiler alquiler) {
			return base.PuedeAlquilar(alquiler)
				&& this.EsFinde(alquiler.CheckIn)
				&& alquiler.CheckOut.Day < alquiler.CheckIn.Day + 3;
		}

		private bool EsFinde(DateTime fecha) {
			return fecha.DayOfWeek == DayOfWeek.Friday;
		}
	}
}
