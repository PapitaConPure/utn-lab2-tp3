using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerLib {
	public class Sistema {
		public static double PrecioBase;
		List<Propiedad> propiedades;

		public Sistema() {
			this.propiedades = new List<Propiedad>();
		}

		public void AgregarPropiedad(Propiedad propiedad) {
			this.propiedades.Add(propiedad);
		}

		public Propiedad ConsultarPropiedad(int número) {
			this.propiedades.Sort();

			Propiedad buscada = new Casa(número, "");
			int idx = this.propiedades.BinarySearch(buscada);

			if(idx < 0)
				return null;

			return this.propiedades[idx];
		}

		/// <summary>
		/// Alquila una la <see cref="Propiedad"/> bajo el número indicado
		/// </summary>
		/// <param name="nroPropiedad"></param>
		/// <param name="alquiler"></param>
		/// <returns><see langword="true"/> si se pudo alquilar la Propiedad</returns>
		public bool AlquilarPropiedad(int nroPropiedad, Alquiler alquiler) {
			Propiedad propiedad = this.ConsultarPropiedad(nroPropiedad);

			if(propiedad is null)
				return false;

			propiedad.Alquilar(alquiler);
			return true;
		}

		/// <summary>
		/// Cancela el <see cref="Alquiler"/> bajo el número de alquiler indicado, alojado en la <see cref="Propiedad"/> bajo el número indicado
		/// </summary>
		/// <param name="nroPropiedad"></param>
		/// <param name="nroAlquiler"></param>
		/// <returns><see langword="true"/> si se pudo cancelar el Alquiler</returns>
		public bool CancelarAlquiler(int nroPropiedad, int nroAlquiler) {
			Propiedad propiedad = this.ConsultarPropiedad(nroPropiedad);

			if(propiedad is null)
				return false;

			propiedad.QuitarAlquiler(nroAlquiler);
			return true;
		}
	}
}
