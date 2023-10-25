using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerLib {
	public class Hotel: Propiedad {
		public enum TipoHabitación {
			Simple = 0,
			Doble = 80,
			Triple = 150,
		}

		public Hotel(int número, string dirección,  int estrellas, int cntSimple, int cntDoble, int cntTriple): base(número, dirección) {
			this.Estrellas = estrellas;
			this.CntSimple = cntSimple;
			this.CntDoble = cntDoble;
			this.CntTriple = cntTriple;
		}

		public int Estrellas { get; private set; }

		public int CntSimple { get; private set; }

		public int CntDoble { get; private set; }

		public int CntTriple { get; private set; }

		public void AgregarHabitación(TipoHabitación tipo) {
			switch(tipo) {
			case TipoHabitación.Simple: this.CntSimple++; break;
			case TipoHabitación.Doble:  this.CntDoble++; break;
			case TipoHabitación.Triple: this.CntTriple++; break;
			default: break;
			}
		}

		public void QuitarHabitación(TipoHabitación tipo) {
			switch(tipo) {
			case TipoHabitación.Simple: this.CntSimple--; break;
			case TipoHabitación.Doble: this.CntDoble--; break;
			case TipoHabitación.Triple: this.CntTriple--; break;
			default: break;
			}
		}

		public double PrecioPorDía(TipoHabitación tipo) {
			double precio = Sistema.PrecioBase;

			precio += precio * (int)tipo / 100;

			if(this.Estrellas >= 3)
				precio += precio * 0.4;

			return precio;
		}

		public override string Imprimir() {
			throw new NotImplementedException("Falta implementar loco");
		}
	}
}
