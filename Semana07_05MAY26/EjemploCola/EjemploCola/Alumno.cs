using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCola
{
    internal class Alumno
    {

        public string nombre {  get; set; }
        public int nota {  get; set; }

        public Alumno(string nombre, int nota)
        {
            this.nombre = nombre;
            this.nota = nota;
        }

        

    }
}
