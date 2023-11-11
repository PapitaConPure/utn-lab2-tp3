using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerLib.Utilidades
{
    public class DniException : ApplicationException
    {
        public DniException() : base()
        {

        }
        public DniException(string msj): base(msj)
        {

        }
        public DniException(string msj, Exception inner) : base(msj, inner)
        {

        }
    }
}
