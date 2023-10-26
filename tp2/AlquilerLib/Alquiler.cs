﻿using System;
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

		public DateTime FechaReservada{ get; private set; }

		public DateTime FechaEntrada { get; private set; }

		public DateTime FechaSalida { get; private set; }

		public double PrecioTotal {
			get {
				return this.residencia.PrecioTotal(this.Número);
			}
		}

		public Hotel.TipoHabitación tipoHabitación { get; set; }

		public Cliente Cliente {
			get { return this.cliente; }
		}

		public Alquiler(int número,DateTime fechaReservada,DateTime fechaEntrada, DateTime fechaSalida,Residencia propiedad,Cliente cliente)
		{
			this.Número = número;
			this.FechaReservada= fechaReservada;

			if(fechaEntrada > fechaSalida) {
				DateTime fechaAuxiliar = fechaEntrada;
				fechaEntrada = fechaSalida;
				fechaSalida = fechaAuxiliar;
			}

			this.FechaEntrada= fechaEntrada;
			this.FechaSalida = fechaSalida;
			this.residencia=propiedad;
			this.cliente= cliente;
		}

		public int CompareTo(object obj) {
			return this.Número.CompareTo((obj as Alquiler).Número);
		}

        public string Imprimir() {
			string retorno = this.residencia.Imprimir();

			if(this.residencia is Hotel) {
				retorno += $";{this.tipoHabitación}";
			}

			retorno += $";{this.cliente.Imprimir()};{this.FechaEntrada}";

			return retorno;
        }
    }
}
