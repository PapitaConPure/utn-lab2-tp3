using System;

namespace AlquilerLib {
	public class Habitación: IComparable {
		private TipoHabitación tipo;

		public enum TipoHabitación {
			Simple = 0,
			Doble,
			Triple,
		}

		public Habitación(int número, TipoHabitación tipo) {
			this.Número = número;
			this.tipo = tipo; 
		}

		public int Número { get; private set; }

		public double PcntAdicional {
			get {
				switch(this.tipo) {
				case TipoHabitación.Doble:  return 0.8;
				case TipoHabitación.Triple: return 1.5;
				default: return 0;
				}
			}
		}

		public int CompareTo(object obj) {
			return this.Número.CompareTo(obj);
		}
	}
}
