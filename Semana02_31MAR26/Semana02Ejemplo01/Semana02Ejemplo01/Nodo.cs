using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02Ejemplo01
{
    internal class Nodo
    {
        public Elemento Dato { get; set; }
        public Nodo Siguiente { get; set; }
        public Nodo(Elemento dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
