using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerLib {
	[Serializable]
	public class Alquiler: IComparable, IImprimible {
		private Residencia residencia;
		private Cliente cliente;

		public int Número{ get;private set; }

		public DateTime FechaReserva { get; private set; }

		public DateTime CheckIn { get; private set; }

		public DateTime CheckOut { get; private set; }

		public double PrecioTotal {
			get {
				return this.residencia.PrecioTotal(this.Número);
			}
		}

		public Hotel.TipoHabitación tipoHabitación { get; set; }

		public Cliente Cliente {
			get { return this.cliente; }
		}

		public Alquiler(int número,DateTime fechaReserva, DateTime checkIn, DateTime checkOut, Residencia propiedad, Cliente cliente)
		{
			this.Número = número;
			this.FechaReserva= fechaReserva;

			if(checkIn > checkOut) {
				DateTime fechaAuxiliar = checkIn;
				checkIn = checkOut;
				checkOut = fechaAuxiliar;
			}

			this.CheckIn= checkIn;
			this.CheckOut = checkOut;
			this.residencia = propiedad;
			this.cliente = cliente;
		}

		public int CompareTo(object obj) {
			return this.Número.CompareTo((obj as Alquiler).Número);
		}

        public string Imprimir() {
			string retornoBase = this.residencia.Imprimir();

			if(this.residencia is Hotel) {
				retornoBase += $";{this.tipoHabitación}";
			}

			return string.Join(";", retornoBase, this.cliente.Imprimir(), this.FechaReserva, this.CheckIn, this.CheckOut, this.PrecioTotal);
        }
    }
}
