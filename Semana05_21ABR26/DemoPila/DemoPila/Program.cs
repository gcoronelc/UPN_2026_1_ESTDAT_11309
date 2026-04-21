using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pila pila = new Pila();

            pila.push(new Dato("Alexandro", 15));
            pila.push(new Dato("Anny", 16));
            pila.push(new Dato("Gustavo", 18));

            Console.WriteLine($"Tamaño: {pila.size()}");

            Nodo nodo = pila.pop();
            Console.WriteLine(nodo.dato);
            Console.WriteLine($"Tamaño: {pila.size()}");

        }
    }
}
