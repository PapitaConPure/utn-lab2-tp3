using System;

namespace AlquilerLib {
	public class Habitación: IComparable {
		private TipoHabitación tipo;
		private double adicional;
		public enum TipoHabitación {
			Simple = 0,
			Doble = 80,
			Triple = 150,
		}

		public Habitación(int número, TipoHabitación tipo) {
			this.Número = número;
			this.tipo = tipo; 
		}

		public int Número { get; private set; }

		public double PcntAdicional {
			get {
				return (int)this.tipo / 100;
			}
		}

		public int CompareTo(object obj) {
			return this.Número.CompareTo((obj as Habitación).Número);
		}
	}
}
