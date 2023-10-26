using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerLib {
	public class Cliente: Persona {
		public int CantPasajeros { get; private set; }

		public Cliente(int cantPasajeros, int dni, string nombre, string apellido, int tel): base(dni, nombre, tel, apellido) {
			this.CantPasajeros = cantPasajeros;
		}

		public override string Imprimir() {
			return string.Join(";", base.Imprimir(), this.CantPasajeros);
		}
	}
}
