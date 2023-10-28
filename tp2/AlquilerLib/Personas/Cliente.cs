using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerLib {
	[Serializable]
	public class Cliente: Persona {
		public Cliente(int cantPasajeros, int dni, string nombre, string apellido, long tel)
		: base(dni, nombre, apellido, tel) {
			this.CantPasajeros = cantPasajeros;
		}

		public int CantPasajeros { get; private set; }

		public override string Exportar() {
			return string.Join(";", base.Exportar(), this.CantPasajeros);
		}
	}
}
