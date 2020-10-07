using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class CapacidadInsuficienteException : Exception
    {
        public CapacidadInsuficienteException(string msj) : base(msj) { }
    }
}
