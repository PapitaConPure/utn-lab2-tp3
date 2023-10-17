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

		/// <summary>
		/// Agrega una propiedad al sistema
		/// </summary>
		/// <param name="propiedad">propiedad a incorporar</param>
		public void AgregarPropiedad(Propiedad propiedad) {
			this.propiedades.Add(propiedad);
		}

		/// <summary>
		/// Consulta una propiedad por número de propiedad
		/// </summary>
		/// <param name="nroPropiedad">número de propiedad a buscar</param>
		/// <returns>La <see cref="Propiedad"/> bajo el número indicado, o <see langword="null"/> si no se encuentra</returns>
		public Propiedad ConsultarPropiedad(int número) {
			this.propiedades.Sort();

			Propiedad buscada = new Casa(número, "");
			int idx = this.propiedades.BinarySearch(buscada);

			if(idx < 0)
				return null;

			return this.propiedades[idx];
		}

		/// <summary>
		/// Alquila la propiedad bajo el número indicado si existe
		/// </summary>
		/// <param name="nroPropiedad">número de la propiedad a alquilar</param>
		/// <param name="alquiler">alquiler a relacionar con la propiedad</param>
		/// <returns><see langword="true"/> si se pudo alquilar la <see cref="Propiedad"/></returns>
		public bool AlquilarPropiedad(int nroPropiedad, Alquiler alquiler) {
			Propiedad propiedad = this.ConsultarPropiedad(nroPropiedad);

			if(propiedad is null)
				return false;

			propiedad.Alquilar(alquiler);
			return true;
		}

		/// <summary>
		/// Cancela el alquiler indicado para la propiedad indicada
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
