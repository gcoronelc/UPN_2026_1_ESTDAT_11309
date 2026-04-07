using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploListaDoble
{
    internal class Producto
    {

        // Propiedades con acceso controlado (encapsulamiento)
        public string Nombre { get; set; }
        public double Precio { get; set; }


        // Constructor: inicializa los atributos al crear el objeto
        public Producto(string nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        // Representacion textual del objeto (utilizada en consola y grids)
        public override string ToString()
        {
            return $"{Nombre} - S/ {Precio:F2}";
        }
    
    }
}
