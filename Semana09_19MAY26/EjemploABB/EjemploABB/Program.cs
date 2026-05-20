using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABB
{
	internal class Program
	{
		static void Main(string[] args)
		{

			ArbolBinario arbol = new ArbolBinario();

			arbol.Insertar(50);
			arbol.Insertar(80);
			arbol.Insertar(30);
			arbol.Insertar(70);
			arbol.Insertar(75);
			arbol.Insertar(20);
			arbol.Insertar(25);

			arbol.MostrarJerarquico();
			Console.WriteLine("======================");
			arbol.MostrarComoArbol();
			Console.ReadKey();

		}
	}
}
