using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02Ejemplo01
{
    internal static class OperacionesListas
    {
        public static ListaEnlazada MezclarOrdenadoPorPrecio(ListaEnlazada lista1, ListaEnlazada lista2)
        {
            // Validar que las listas no sean nulas
            if (lista1 == null) throw new ArgumentNullException(nameof(lista1));
            if (lista2 == null) throw new ArgumentNullException(nameof(lista2));

            // Si alguna lista está vacía, devolver la otra (reusando nodos).
            if (lista1.Cabeza == null) return lista2;
            if (lista2.Cabeza == null) return lista1;

            // Punteros para recorrer ambas listas
            Nodo? a = lista1.Cabeza;
            Nodo? b = lista2.Cabeza;

            // Elegir la cabeza de la lista resultante
            Nodo? cabezaResultado;
            if (a!.Dato.Precio <= b!.Dato.Precio)
            {
                cabezaResultado = a;
                a = a.Siguiente;
            }
            else
            {
                cabezaResultado = b;
                b = b.Siguiente;
            }

            Nodo cola = cabezaResultado!;

            // Mezcla iterativa: siempre enganchar el nodo con menor precio
            while (a != null && b != null)
            {
                if (a.Dato.Precio <= b.Dato.Precio)
                {
                    cola.Siguiente = a;
                    a = a.Siguiente;
                }
                else
                {
                    cola.Siguiente = b;
                    b = b.Siguiente;
                }

                cola = cola.Siguiente!;
            }

            // Adjuntar el resto de la lista que aún tenga nodos
            cola.Siguiente = (a != null) ? a : b;

            // Construir la nueva lista enlazada (misma cadena de nodos, nueva "caja")
            return new ListaEnlazada { Cabeza = cabezaResultado };
        }
    }
}
