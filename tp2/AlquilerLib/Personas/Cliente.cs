using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerLib {
	[Serializable]
	public class Cliente: Persona {
		public Cliente(int número, int cantPasajeros, int dni, string nombre, string apellido, int tel)
		: base(dni, nombre, tel, apellido) {
			this.Número = número;
			this.CantPasajeros = cantPasajeros;
		}

		public int CantPasajeros { get; private set; }

		public int Número { get; private set; }

		public override string Imprimir() {
			return string.Join(";", base.Imprimir(), this.CantPasajeros);
		}
	}
}
