namespace Semana01Ejemplo01
{
    internal class Nodo
    {
        public int Dato { get; set; }
        public Nodo Siguiente { get; set; }

		// Constructor para inicializar el nodo con un dato
		public Nodo(int dato)
        {
            Dato = dato;
            Siguiente = null;
        }

    }
}
