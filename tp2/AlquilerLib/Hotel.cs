using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerLib {
	class Hotel: Propiedad {
		private int estrellas;
		private List<Habitación> habitaciones;

		public Hotel(int número, string dirección, int estrellas): base(número, dirección) {
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
			double precio = Sistema.PrecioBase;

			precio += precio * this.VerHabitación(número).PcntAdicional;

			if(this.estrellas >= 3)
				precio += precio * 0.4;

			return precio;
		}

		public Habitación VerHabitación(int número) {
			this.habitaciones.Sort();

			Habitación buscada = new Habitación(número, Habitación.TipoHabitación.Simple);
			int idx = this.habitaciones.BinarySearch(buscada);

			if(idx < 0)
				return null;

			return this.habitaciones[idx];
		}

		public override string Imprimir() {
			return "";
		}
	}
}
