namespace Semana01Ejemplo01
{
    internal class ListaEnlazada
    {
		// Referencia al primer nodo de la lista
		private Nodo Cabeza;

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

    }
}
