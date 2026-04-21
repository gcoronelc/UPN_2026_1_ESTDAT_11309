using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPila
{
    internal class Dato
    {

        public string nombre {  get; set; }
        public int nota { get; set; }

        public Dato(string nombre, int nota) {
            this.nombre = nombre;
            this.nota = nota;
        }

        public override string ToString()
        {
            return $"(Nombre: {nombre}, Nota:{nota})";
        }

    }
}
