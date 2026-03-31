using System.Collections;
using System.Data;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Semana01Ejemplo01
{
    internal  class ListaEnlazada
    {
		// Referencia al primer nodo de la lista
		public Nodo Cabeza;

		// Constructor para inicializar la lista vacía
		public ListaEnlazada()
        {
            Cabeza = null;
        }

		// Método para agregar un nuevo nodo al final de la lista
		// Aplicando el principio Guard Clause
		public void AgregarAlFinal(int dato)
        {
            Nodo nuevoNodo = new Nodo(dato);
            if (Cabeza == null)
            {
                Cabeza = nuevoNodo;
                return;
            }
            Nodo actual = Cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoNodo;
        }

        public void AgregarAlInicio(int dato)
        {
            Nodo nuevo = new Nodo(dato)
            {
                Siguiente = Cabeza
            };
            Cabeza = nuevo;
        }

        public Nodo buscar(int dato)
        {
            Nodo actual = Cabeza; 
            while (actual != null) { 
                if (actual.Dato == dato) 
                    return actual; 
                actual = actual.Siguiente; }
            return null;
        }

		// Método para imprimir los elementos de la lista
		public void Imprimir()
        {
			// Principio Fail First: Verificar si la lista está vacía antes de intentar imprimir
			if (Cabeza == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }
			// Recorrer la lista desde la cabeza hasta el final, imprimiendo cada dato
			Nodo actual = Cabeza; // Empezar desde el primer nodo
			while (actual != null)
            {
                Console.Write(actual.Dato + " -> ");
                actual = actual.Siguiente;
            }
			Console.WriteLine(" NULL ");
		}

        public void OrdenamientoBurbuja()
        {
            if (Cabeza == null) return; // Lista vacía
            bool hayIntercambio; // Para controlar si esta ordenada
            do
            {
                hayIntercambio = false;
                Nodo actual = Cabeza;
                while (actual.Siguiente != null)
                {
                    if (actual.Dato > actual.Siguiente.Dato)
                    {
                        // Intercambiar los datos de los nodos
                        int temp = actual.Dato;
                        actual.Dato = actual.Siguiente.Dato;
                        actual.Siguiente.Dato = temp;
                        hayIntercambio = true;
                    }
                    actual = actual.Siguiente;
                } // Buble while
            } while (hayIntercambio);
        }

    }
}
