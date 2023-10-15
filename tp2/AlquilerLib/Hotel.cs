using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerLib {
	class Hotel: Propiedad {
		private int estrellas;
		private List<Habitación> habitaciones;

		public Hotel(int estrellas) {
			this.estrellas = estrellas;
			this.habitaciones = new List<Habitación>();
		}

		public void AgregarHabitación(int número, Habitación.TipoHabitación tipo) {
			this.habitaciones.Add(new Habitación(número, tipo));
		}

		public void QuitarHabitación(int número) {
			this.habitaciones.Remove(this.VerHabitación(número));
		}

		public double PrecioPorDía(int número) {
			double precio = this.precioBase;

			precio += precio * this.VerHabitación(número).PcntAdicional;

			if(this.estrellas >= 3)
				precio += precio * 0.4;

			return precio;
		}

		private Habitación VerHabitación(int número) {
			Habitación encontrada = null;
			int c = 0;

			while(c < this.habitaciones.Count && encontrada == null) {
				if(this.habitaciones[c].Número == número)
					encontrada = this.habitaciones[c];
				c++;
			}

			return encontrada;
		}

		public override string Imprimir() {
			return "";
		}
	}
}
