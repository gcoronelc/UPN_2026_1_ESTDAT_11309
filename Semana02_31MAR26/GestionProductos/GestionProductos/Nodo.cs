using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProductos
{
    public class Nodo
    {
        public Producto Dato { get; set; }      // Datos del nodo
        public Nodo Siguiente { get; set; }     // Referencia al proximo nodo

        public Nodo(Producto dato)
        {
            Dato = dato;
            Siguiente = null;  // Al crearse, no apunta a ningun nodo
        }
    }
}
