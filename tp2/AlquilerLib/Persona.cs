using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerLib
{
    public class Persona
    {
        public int Dni { get; }
        public string Nombre { get; }
        public string Apellido { get; }
        public int Tel { get; }

        public Persona(int dni,string nombre, int tel, string apellido)
        {
            Dni = dni;
            Nombre = nombre;
            Tel = tel;
            Apellido = apellido;
        }
    }
}
