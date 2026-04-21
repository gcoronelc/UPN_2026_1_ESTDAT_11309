using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPila
{
    internal class Pila
    {
        private int tamanio;
        private Nodo top;

        public Pila() { 
            this.tamanio = 0;
            this.top = null;
        }

        public void push(Dato dato)
        {
            this.tamanio++;
            Nodo nodo = new Nodo(dato);
            nodo.siguiente = this.top;
            this.top = nodo;
        }

        public int size()
        {
            return tamanio;
        }

        public Nodo pop()
        {
            if(top == null)
            {
                return null;
            }
            Nodo nodo = top;
            top = nodo.siguiente;
            top.siguiente = null;
            this.tamanio--;
            return nodo;
        }

    }
}
