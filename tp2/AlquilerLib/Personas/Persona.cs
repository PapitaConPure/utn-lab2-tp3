using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerLib {
	[Serializable]
	public class Persona: IImprimible {
        public int Dni { get; private set; }

        public string Apellido { get; private set; }

        public string Nombre { get; set; }

        public long Teléfono { get; set; }

        public Persona(int dni,string nombre, long tel, string apellido)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Teléfono = tel;
            this.Apellido = apellido;
        }

		public virtual string Imprimir() {
			return string.Join(";", this.Dni, this.Nombre, this.Apellido, this.Teléfono);
		}
	}
}
