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

		public int CntSimple { get; set; }

		public int CntDoble { get; set; }

		public int CntTriple { get; set; }

		public override double PrecioPorDía(int nroAlquiler) { ///terminar de codificar
			Alquiler alquiler = VerAlquiler(nroAlquiler);
			double precio = Sistema.PrecioBase;

			precio += precio * (int)VerTipoHabitación(alquiler.Cliente.CantPasajeros) / 100;

			if(this.Estrellas >= 3)
				precio += precio * 0.4;

			return precio;
		}
        public override double PrecioTotal(int nroAlquiler)
        {
            Alquiler alquiler = VerAlquiler(nroAlquiler);
			return alquiler.PrecioTotal;
		}
		public TipoHabitación VerTipoHabitación(int cantPasajeros)
		{
			if (cantPasajeros > 4)
			{
				return TipoHabitación.Triple;
			}else if (cantPasajeros > 2)
			{
				return TipoHabitación.Doble;
			}
			else
			{
				return TipoHabitación.Simple;
			}
		}
        public override string Imprimir() {
		
		}
	}
}
