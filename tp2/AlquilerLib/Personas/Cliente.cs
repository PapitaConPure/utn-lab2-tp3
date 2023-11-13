using System;
using System.Collections.Generic;
using AlquilerLib.Constructores;

namespace AlquilerLib {
	[Serializable]
	public class Cliente: Persona {
		public Cliente(DatosPersona datosPersona, int cantPasajeros) : base(datosPersona) {
			this.CantPasajeros = cantPasajeros;
			pasajeros = new List<Persona>();
		}
		public int CantPasajeros { get; private set; }
		List<Persona> pasajeros;
		public List<Persona> Pasajeros { get { return this.pasajeros; } }
		public override string Exportar() {
			return string.Join(";", base.Exportar(), this.CantPasajeros);
		}
		public void AgregarPasajero(Persona nueva)
        {
			pasajeros.Add(nueva);
        }
	}
}
