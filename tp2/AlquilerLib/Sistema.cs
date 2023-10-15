using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerLib {
	class Sistema {
		List<Propiedad> propiedades;

		public Sistema() {
			this.propiedades = new List<Propiedad>();
		}

		public Propiedad ConsultarPropiedad(int número) {
			this.propiedades.Sort();

			Propiedad buscada = new Casa(número, "", 0);
			int idx = this.propiedades.BinarySearch(buscada);

			if(idx < 0)
				return null;

			return this.propiedades[idx];
		}

		public void AlquilarPropiedad(int nroPropiedad, Alquiler alquiler) {
			this.ConsultarPropiedad(nroPropiedad).Alquilar(alquiler);
		}

		public void CancelarAlquiler(int nroPropiedad, int nroAlquiler) {
			this.ConsultarPropiedad(nroPropiedad).CancelarAlquiler(nroAlquiler);
		}
	}
}
