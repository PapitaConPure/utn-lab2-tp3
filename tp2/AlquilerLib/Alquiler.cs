using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerLib {
	[Serializable]
	public class Alquiler: IComparable, IExportable {
		private Residencia residencia;
		private Cliente cliente;

		public Alquiler(int número, DateTime fechaReserva, DateTime checkIn, DateTime checkOut, Residencia residencia,
		int cantPasajeros, int dni, string nombre, string apellido, long tel, double precioBase) {
			this.Número = número;
			this.FechaReserva = fechaReserva;

			if(checkIn > checkOut) {
				DateTime fechaAuxiliar = checkIn;
				checkIn = checkOut;
				checkOut = fechaAuxiliar;
			}

			this.CheckIn = checkIn;
			this.CheckOut = checkOut;
			this.residencia = residencia;
			this.PrecioBase = precioBase * (int)(this.CheckOut - this.CheckIn).TotalDays;
			this.cliente = new Cliente(cantPasajeros, dni, nombre, apellido, tel);
		}
		public Alquiler(int número)
		{
			this.Número = número;
		}

		public int Número{ get;private set; }

		public DateTime FechaReserva { get; private set; }

		public DateTime CheckIn { get; private set; }

		public DateTime CheckOut { get; private set; }

		public double PrecioBase { get; private set; }

		public Residencia Residencia { get { return this.residencia; } }

		public double PrecioTotal {
			get {
				return this.PrecioBase * this.residencia.PrecioTotal(this.Número);
			}
		}

		public Hotel.TipoHabitación TipoHabitación { get; set; }

		public Cliente Cliente {
			get { return this.cliente; }
		}

		public int CompareTo(object obj) {
			return this.Número.CompareTo((obj as Alquiler).Número);
		}

		public string Exportar() {
			return string.Join(";",
				this.residencia.Número,
				this.cliente.Exportar(),
				this.FechaReserva.Ticks,
				this.CheckIn.Ticks,
				this.CheckOut.Ticks,
				this.residencia.PrecioPorDía(this.Número),
				this.PrecioTotal);
        }
    }
}
