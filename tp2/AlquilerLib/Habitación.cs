using System;

namespace AlquilerLib {
	public class Habitación:Propiedad, IComparable {
		private TipoHabitación tipo;
		private double adicional;
		public enum TipoHabitación {
			Simple = 0,
			Doble = 80,
			Triple = 150,
		}

		public Habitación(int número,TipoHabitación tipo):base(número) {
			this.Número = número;
			this.tipo = tipo; 
		}
		//cuestionar
		public int Número
		{
			get;
		}

		public double PcntAdicional {
			get {
				return (int)this.tipo / 100;
			}
		}

        public override bool PuedeAlquilar(Alquiler alquiler)
        {
            if (!base.PuedeAlquilar(alquiler))
                return false;
			//CUESTIONAR
            //Lógica de alquiler de casa nose

            return true;
		}
		public int CompareTo(object obj)//ni se q error sale acá
		{
			return this.Número.CompareTo((obj as Habitación).Número);
		}

        public override string Imprimir()
        {
            return "";
        }
    }
}
