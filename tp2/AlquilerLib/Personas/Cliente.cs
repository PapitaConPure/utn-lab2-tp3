using System;
using AlquilerLib.Constructores;

namespace AlquilerLib {
	[Serializable]
	public class Cliente: Persona {
		public Cliente(DatosPersona datosPersona, int cantPasajeros) : base(datosPersona) {
			this.CantPasajeros = cantPasajeros;
		}
		public int CantPasajeros { get; private set; }

		public override string Exportar() {
			return string.Join(";", base.Exportar(), this.CantPasajeros);
		}
	}
}
