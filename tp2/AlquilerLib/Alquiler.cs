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

		public double PrecioBase { get; private set; }

		public double PrecioTotal {
			get {
				return this.PrecioBase * this.residencia.PrecioTotal(this.Número);
			}
		}

		public Hotel.TipoHabitación TipoHabitación { get; private set; }

		public Cliente Cliente {
			get { return this.cliente; }
		}

		public Alquiler(int número, DateTime fechaReserva, DateTime checkIn, DateTime checkOut, Residencia residencia, Cliente cliente)
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
			this.PrecioBase = Sistema.PrecioBase * (this.CheckOut - this.CheckIn).TotalDays;
			this.residencia = residencia;

			if(residencia is Hotel) {
				Hotel hotel = residencia as Hotel;
				this.TipoHabitación = hotel.VerTipoHabitación(cliente.CantPasajeros);
			}

			this.cliente = cliente;
		}

		public int CompareTo(object obj) {
			return this.Número.CompareTo((obj as Alquiler).Número);
		}

        public string Imprimir() {
			return string.Join(";", this.residencia.Imprimir(), this.cliente.Imprimir(), this.FechaReserva, this.CheckIn, this.CheckOut, this.PrecioTotal);
        }
    }
}
