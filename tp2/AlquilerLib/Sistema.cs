using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerLib {
	/// <summary>
	/// Representa un sistema de alquileres
	/// </summary>
	[Serializable]
	public class Sistema {
		/// <summary>
		/// El precio base con el que trabajan todas las propiedades del sistema
		/// </summary>
		public static double PrecioBase;

		private List<Residencia> residencias;

		/// <summary>
		/// Crea un sistema de propiedades con una lista de propiedades vacía
		/// </summary>
		public Sistema() {
			this.residencias = new List<Residencia>();
		}

		/// <summary>
		/// Vector de todos los objetos <see cref="Residencia"/> actuales del sistema
		/// </summary>
		/// <remarks>Se realiza una copia de todas las referencias al llamar la propiedad. Llamar con cuidado</remarks>
		public Residencia[] Residencias {
			get { return this.residencias.ToArray(); }
		}

		/// <summary>
		/// Agrega una propiedad al sistema
		/// </summary>
		/// <param name="propiedad">propiedad a incorporar</param>
		public void AgregarResidencia(Residencia propiedad) {
			this.residencias.Add(propiedad);
		}

		/// <summary>
		/// Quita la <see cref="Residencia"/> bajo el número indicado
		/// </summary>
		/// <param name="nroResidencia"></param>
		/// <returns><see langword="true"/> si se pudo quitar la <see cref="Residencia"/></returns>
		public bool QuitarResidencia(int nroResidencia) {
			Residencia propiedad = this.VerResidencia(nroResidencia);
			if(propiedad != null) {
				this.residencias.Remove(propiedad);
				return true;
			} else {
				return false;
			}
		}

		/// <summary>
		/// Consulta una propiedad por número de propiedad
		/// </summary>
		/// <param name="nroPropiedad">número de propiedad a buscar</param>
		/// <returns>La <see cref="Residencia"/> bajo el número indicado, o <see langword="null"/> si no se encuentra</returns>
		public Residencia VerResidencia(int número) {
			this.residencias.Sort();

			Residencia buscada = new Casa(número, "",0,0,0,"",0,"", new Image[] { });
			int idx = this.residencias.BinarySearch(buscada);

			if(idx < 0)
				return null;

			return this.residencias[idx];
		}

		/// <summary>
		/// Alquila la <see cref="Residencia"/> bajo el número indicado si existe
		/// </summary>
		/// <param name="nroResidencia">número de la residencia a alquilar</param>
		/// <param name="alquiler">alquiler a relacionar con la propiedad</param>
		/// <returns><see langword="true"/> si se pudo alquilar la <see cref="Residencia"/></returns>
		public bool AlquilarResidencia(int nroResidencia, Alquiler alquiler) {
			Residencia propiedad = this.VerResidencia(nroResidencia);

            if (propiedad is null)
                return false;

            if (!propiedad.PuedeAlquilar(alquiler))
				return false;

			propiedad.Alquilar(alquiler);
			return true;
		}

		/// <summary>
		/// Cancela el alquiler indicado para la residencia indicada
		/// </summary>
		/// <param name="nroResidencia"></param>
		/// <param name="nroAlquiler"></param>
		/// <returns><see langword="true"/> si se pudo cancelar el alquiler</returns>
		public bool CancelarAlquiler(int nroResidencia, int nroAlquiler) {
			Residencia propiedad = this.VerResidencia(nroResidencia);

			if(propiedad is null)
				return false;

			propiedad.QuitarAlquiler(nroAlquiler);
			return true;
		}
	}
}
