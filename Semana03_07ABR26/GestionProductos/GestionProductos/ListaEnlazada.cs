using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProductos
{
    public class ListaEnlazada
    {
        // Atributo privado: solo esta clase conoce el nodo inicial
        private Nodo cabeza;

        public ListaEnlazada()
        {
            cabeza = null;  // Lista vacia al inicio
        }

        // ── INSERTAR AL FINAL ─────────────────────────────────────
        // Complejidad: O(n) — se recorre toda la lista para llegar al ultimo nodo
        public void InsertarAlFinal(Producto dato)
        {
            Nodo nuevo = new Nodo(dato);
            if (cabeza == null)
            {
                cabeza = nuevo;  // Primer elemento de la lista
                return;
            }
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;  // Enlaza el nuevo nodo al final
        }

        // ── RECORRER ─────────────────────────────────────────────
        // Recorre la lista desde la cabeza hasta null
        public List<Producto> ObtenerTodos()
        {
            List<Producto> resultado = new List<Producto>();
            Nodo actual = cabeza;
            while (actual != null)
            {
                resultado.Add(actual.Dato);
                actual = actual.Siguiente;
            }
            return resultado;
        }



        // ── BUSCAR ───────────────────────────────────────────────
        // Recorre la lista nodo por nodo comparando el nombre del producto.
        // Retorna el nodo encontrado o null si no existe.
        // Complejidad: el peor caso peor, cual el elemento esta al final o no existe
        public Nodo Buscar(string nombre)
        {
            Nodo actual = cabeza;
            while (actual != null)
            {
                // Comparacion sin distincion de mayusculas/minusculas
                if (actual.Dato.Nombre.Equals(nombre,
                    StringComparison.OrdinalIgnoreCase))
                {
                    return actual;  // Encontrado: retorna el nodo
                }
                actual = actual.Siguiente;
            }
            return null;  // No encontrado
        }

        // ── ORDENAMIENTO BURBUJA ─────────────────────────────────
        // Ordena la lista por Precio de forma ascendente.
        // Intercambia el contenido (Dato) de los nodos, no los punteros.
        public void OrdenarBurbuja()
        {
            if (cabeza == null) return;  // Lista vacia: nada que ordenar
            bool hayIntercambio;
            do
            {
                hayIntercambio = false;
                Nodo actual = cabeza;

                while (actual.Siguiente != null)
                {
                    // Si el nodo actual tiene mayor precio que el siguiente: intercambiar
                    if (actual.Dato.Precio > actual.Siguiente.Dato.Precio)
                    {
                        // Swap: se intercambia el Dato, no los punteros
                        Producto temp = actual.Dato;
                        actual.Dato = actual.Siguiente.Dato;
                        actual.Siguiente.Dato = temp;
                        hayIntercambio = true;
                    }
                    actual = actual.Siguiente;
                }
            } while (hayIntercambio);  // Repite hasta que no haya intercambios
        }

        // ── MEZCLA ORDENADA ──────────────────────────────────────
        // Pre-condicion: ambas listas deben estar ordenadas por Precio.
        // Retorna una nueva lista con los elementos de ambas en orden ascendente.
        public ListaEnlazada Mezclar(ListaEnlazada otraLista)
        {
            ListaEnlazada resultado = new ListaEnlazada();
            Nodo pA = this.cabeza;         // Puntero a la lista actual
            Nodo pB = otraLista.cabeza;    // Puntero a la otra lista

            while (pA != null && pB != null)
            {
                if (pA.Dato.Precio <= pB.Dato.Precio)
                {
                    resultado.InsertarAlFinal(pA.Dato);
                    pA = pA.Siguiente;
                }
                else
                {
                    resultado.InsertarAlFinal(pB.Dato);
                    pB = pB.Siguiente;
                }
            }
            // Conectar la cola restante de la lista no agotada
            while (pA != null)
            {
                resultado.InsertarAlFinal(pA.Dato);
                pA = pA.Siguiente;
            }
            while (pB != null)
            {
                resultado.InsertarAlFinal(pB.Dato);
                pB = pB.Siguiente;
            }
            return resultado;
        }

    }
}
