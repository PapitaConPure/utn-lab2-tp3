using System;
using AlquilerLib.Constructores;

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
			this.cliente = new Cliente(new DatosPersona(dni, nombre, apellido, tel), cantPasajeros);
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
				this.FechaReserva.ToString(),
				this.CheckIn.ToShortDateString(),
				this.CheckOut.ToShortDateString(),
				this.residencia.PorcentajePorDía(this.Número)*this.PrecioBase,
				this.PrecioTotal);
        }
    }
}
