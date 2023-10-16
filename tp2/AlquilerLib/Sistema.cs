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

		public Propiedad ConsultarPropiedad(int número) {
			this.propiedades.Sort();

			Propiedad buscada = new Casa(número, "");
			int idx = this.propiedades.BinarySearch(buscada);

			if(idx < 0)
				return null;

			return this.propiedades[idx];
		}

		public void AlquilarPropiedad(int nroPropiedad, Alquiler alquiler) {
			this.ConsultarPropiedad(nroPropiedad).Alquilar(alquiler);
		}

		public void CancelarAlquiler(int nroPropiedad, int nroAlquiler) {
			this.ConsultarPropiedad(nroPropiedad).QuitarAlquiler(nroAlquiler);
		}
		public void AgregarPropiedad(Propiedad propiedad)
		{
			this.propiedades.Add(propiedad);
		}
	}
}
