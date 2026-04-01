using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02Ejemplo01
{
    internal class ListaEnlazada
    {
        public Nodo Cabeza { get; set; }
        public ListaEnlazada()
        {
            Cabeza = null;
        }
        public void Agregar(Elemento elemento)
        {
            Nodo nuevoNodo = new Nodo(elemento);
            if (Cabeza == null)
            {
                Cabeza = nuevoNodo;
            }
            else
            {
                Nodo actual = Cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevoNodo;
            }
        }
        public void Mostrar()
        {
            if (Cabeza == null) {
                Console.WriteLine("La lista está vacía.");
                return;
            }
            Nodo actual = Cabeza;
            while (actual != null)
            {
                Console.WriteLine(actual.Dato);
                actual = actual.Siguiente;
            }
        }

        public Nodo Buscar(string nombre)
        {
            Nodo actual = Cabeza;
            while (actual != null)
            {
                if (actual.Dato.Nombre.Equals(nombre, 
                    StringComparison.OrdinalIgnoreCase))
                {
                    return actual; // Encontrado
                }
                actual = actual.Siguiente;
            }
            return null; // No encontrado
        }

        public void OrdenamientoBurbuja()
        {
            if (Cabeza == null) return; // Lista vacía
            bool hayIntercambio;
            do
            {
                hayIntercambio = false;
                Nodo actual = Cabeza;
                while (actual.Siguiente != null)
                {
                    if (actual.Dato.Precio > actual.Siguiente.Dato.Precio)
                    {
                        // Intercambiar los datos de los nodos
                        Elemento temp = actual.Dato;
                        actual.Dato = actual.Siguiente.Dato;
                        actual.Siguiente.Dato = temp;
                        hayIntercambio = true;
                    }
                    actual = actual.Siguiente;
                }
            } while (hayIntercambio);
        }

        public void OrdenamientoInsercion()
        {
            if (Cabeza == null || Cabeza.Siguiente == null)
                return; // Lista vacía o con un solo elemento
            Nodo actual = Cabeza.Siguiente;
            Cabeza.Siguiente = null; // Desconectar el primer nodo
            while (actual != null)
            {
                Nodo siguiente = actual.Siguiente; // Guardar el siguiente nodo
                if (actual.Dato.Precio < Cabeza.Dato.Precio)
                {   // Insertar al inicio
                    actual.Siguiente = Cabeza;
                    Cabeza = actual;
                } else {
                    // Buscar la posición correcta en la parte ordenada
                    Nodo temp = Cabeza;
                    while (temp.Siguiente != null && temp.Siguiente.Dato.Precio < actual.Dato.Precio)
                    {
                        temp = temp.Siguiente;
                    }
                    // Insertar después de temp
                    actual.Siguiente = temp.Siguiente;
                    temp.Siguiente = actual;
                }
                actual = siguiente; // Mover al siguiente nodo
            }
        }

       
    }
}
