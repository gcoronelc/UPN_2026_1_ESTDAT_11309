using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola todos");
            
            Cola cola = new Cola();

            cola.enqueue(new Alumno("Gustavo", 18));
            cola.enqueue(new Alumno("Damariz", 20));
            cola.enqueue(new Alumno("Antony", 17));
            cola.enqueue(new Alumno("Anny", 30));
            cola.enqueue(new Alumno("Angelo", 20));

            cola.eliminarNodo("Anny");

            Nodo nodo = cola.dequeue();
            while (nodo != null)
            {
                Console.WriteLine($"({nodo.dato.nombre} - {nodo.dato.nota})");
                nodo = cola.dequeue();
            }

        }
    }
}
