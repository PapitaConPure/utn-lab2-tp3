using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerLib {
	public class Alquiler: IComparable {
		Propiedad propiedad;
		public Propiedad GetPropiedad { get { return propiedad; } }
		public int Número{get;private set;}
		public DateTime FechaReservada{get;private set;}
		public DateTime FechaEntrada {get;private set;}
		public DateTime FechaSalida { get;private set;}
		public double PrecioTotal { get;private set;}
		public Alquiler(int número,DateTime fechaReservada,DateTime fechaEntrada, DateTime fechaSalida,Propiedad propiedad)
		{
			this.Número = número;
			this.FechaReservada= fechaReservada;
			this.FechaEntrada= fechaEntrada;
			this.FechaSalida = fechaSalida;
			this.PrecioTotal = 0;
			this.propiedad=propiedad;
		}

		public int CompareTo(object obj) {
			return this.Número.CompareTo(obj);
		}
	}
}
