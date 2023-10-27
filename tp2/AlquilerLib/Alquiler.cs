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

		public Residencia Residencia {
			get { return this.residencia; }
			set {
				if(this.residencia != null)
					throw new InvalidOperationException("No se puede cambiar la residencia de un alquiler ya emitido");

				this.residencia = value;

				if(value is Hotel)
					this.TipoHabitación = (value as Hotel).VerTipoHabitación(this.cliente.CantPasajeros);
			}
		}

		public Alquiler(int número, DateTime fechaReserva, DateTime checkIn, DateTime checkOut, Cliente cliente, double precioBase)
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
			this.PrecioBase = precioBase * (int)(this.CheckOut - this.CheckIn).TotalDays;
			this.cliente = cliente;
		}

		public int CompareTo(object obj) {
			return this.Número.CompareTo((obj as Alquiler).Número);
		}

		public string Imprimir() {
			return string.Join(";",
				this.residencia.Número,
				this.Número,
				this.cliente.Número,
				this.FechaReserva.Ticks,
				this.CheckIn.Ticks,
				this.CheckOut.Ticks,
				this.residencia.PrecioPorDía(this.Número),
				this.PrecioTotal);
        }
    }
}
