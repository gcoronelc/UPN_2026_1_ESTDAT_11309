namespace EjemploABB
{
	public class Nodo
	{
		public int Valor { get; set; }
		public Nodo Izquierda { get; set; }
		public Nodo Derecha { get; set; }

		public Nodo(int valor)
		{
			Valor = valor;
			this.Izquierda = null;
			this.Derecha = null;
		}

	}
}
