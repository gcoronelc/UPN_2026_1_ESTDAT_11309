using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCola
{
    internal class Nodo
    {

        public Alumno dato {  get; set; }
        public Nodo siguiente {  get; set; }

        public Nodo(Alumno dato)
        {
            this.dato = dato;
            this.siguiente = null;
        }

    }
}
