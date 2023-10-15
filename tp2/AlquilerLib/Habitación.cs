namespace AlquilerLib {
	class Habitación {
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
	}
}
