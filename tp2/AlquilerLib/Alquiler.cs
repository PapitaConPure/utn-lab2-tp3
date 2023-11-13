using System;
using AlquilerLib.Constructores;

namespace AlquilerLib {
	[Serializable]
	public class Alquiler: IComparable, IExportable, IGuardable {
		private readonly Residencia residencia;
		private readonly Cliente cliente;
		private readonly Habitación habitacion;

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

		public Alquiler(int número, DateTime fechaReserva, DateTime checkIn, DateTime checkOut, Residencia residencia,Habitación unaHabitacion,
		int cantPasajeros, int dni, string nombre, string apellido, long tel, double precioBase)
		{
			this.Número = número;
			this.FechaReserva = fechaReserva;

			if (checkIn > checkOut)
			{
				DateTime fechaAuxiliar = checkIn;
				checkIn = checkOut;
				checkOut = fechaAuxiliar;
			}

			this.CheckIn = checkIn;
			this.CheckOut = checkOut;
			this.residencia = residencia;
			this.habitacion = unaHabitacion;
			this.PrecioBase = precioBase * (int)(this.CheckOut - this.CheckIn).TotalDays;
			this.cliente = new Cliente(new DatosPersona(dni, nombre, apellido, tel), cantPasajeros);
		}
		public Alquiler(int número)
		{
			this.Número = número;
		}
		public Alquiler(DateTime entrada, DateTime salida)
        {
			this.CheckIn = entrada;
			this.CheckOut = salida;
        }
		public Alquiler(DateTime ingreso, DateTime salida, int dni, string n, string ap, int tel, int pas)
        {
			this.CheckIn = ingreso;
			this.CheckOut = salida;
			this.cliente = new Cliente(new DatosPersona(dni, n, ap, tel), pas);
        }

		public int Número{ get;private set; }

		public DateTime FechaReserva { get; private set; }

		public DateTime CheckIn { get; private set; }
		
		public DateTime CheckOut { get; private set; }

		public TimeSpan CantDias { get { return CheckOut.Subtract(CheckIn); } }

		public double PrecioBase { get; private set; }

		public Residencia Residencia { get { return this.residencia; } }
		public Habitación Habitacion { get { return this.habitacion; } }

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
				this.Número,
				this.cliente.Exportar(),
				this.FechaReserva.ToString(),
				this.CheckIn.ToShortDateString(),
				this.CheckOut.ToShortDateString(),
				this.residencia.PorcentajePorDía(this.Número)*this.PrecioBase,
				this.PrecioTotal);
        }
		public string Guardar()
        {
			return string.Join(";",residencia.Número, Cliente.Dni, 
								CheckIn.ToShortDateString(), CheckOut.ToShortDateString());
        }

		public void Modificar(DateTime checkIn, DateTime checkOut)
        {
			this.CheckIn = checkIn;
			this.CheckOut = checkOut;
		}
    }
}
