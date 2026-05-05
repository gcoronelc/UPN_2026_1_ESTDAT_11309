using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCola
{
    internal class Cola
    {

        private Nodo primero;
        private Nodo ultimo;

        public Cola()
        {
            this.primero = null;
            this.ultimo = null;
        }

        public void enqueue(Alumno dato)
        {
            Nodo nodo = new Nodo(dato);
            if(this.primero == null)
            {
                this.primero = nodo;
                this.ultimo = nodo;
                return;          
            }
            this.ultimo.siguiente = nodo;
            this.ultimo = nodo;
        }

        public Nodo dequeue()
        {
            if(this.primero == null)
            {
                return null;
            }
            Nodo nodo;
            if(this.primero == this.ultimo)
            {
                nodo = this.primero;
                this.primero = this.ultimo = null;
                return nodo;
            }
            nodo = this.primero;
            this.primero = nodo.siguiente;
            nodo.siguiente = null;
            return nodo;
        }

        public bool eliminarNodo(string nombre)
        {
            if (this.primero == null) return false;

            // Caso 1: El nodo a eliminar es el primero
            if (this.primero.dato.nombre == nombre) // Asumiendo que Alumno tiene la propiedad Nombre
            {
                this.dequeue();
                return true;
            }

            Nodo actual = this.primero;
            // Buscamos el nodo anterior al que queremos eliminar
            while (actual.siguiente != null && actual.siguiente.dato.nombre != nombre)
            {
                actual = actual.siguiente;
            }

            // Si no lo encuentra
            if (actual.siguiente == null)
            {
                return false;
            }

            // Si lo encontramos
            Nodo nodoAEliminar = actual.siguiente;

            // Caso 2: El nodo a eliminar es el último
            if (nodoAEliminar == this.ultimo)
            {
                this.ultimo = actual;
                actual.siguiente = null;
            }
            // Caso 3: El nodo está en medio
            else
            {
                actual.siguiente = nodoAEliminar.siguiente;
                nodoAEliminar.siguiente = null;
            }

            return true;
           
        }
    }
}
