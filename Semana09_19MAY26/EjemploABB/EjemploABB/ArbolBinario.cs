using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploABB
{
	public class ArbolBinario
	{

		public Nodo Raiz;

		public ArbolBinario()
		{
			this.Raiz = null;
		}

		public void Insertar(int valor)
		{
			Raiz = InsertarRecursivo(Raiz, valor);
		}

		private Nodo InsertarRecursivo(Nodo nodo, int valor)
		{
			if (nodo == null)
				return new Nodo(valor);

			if (valor < nodo.Valor)
				nodo.Izquierda = InsertarRecursivo(nodo.Izquierda, valor);
			else if (valor > nodo.Valor)
				nodo.Derecha = InsertarRecursivo(nodo.Derecha, valor);

			return nodo;
		}


		/**
		 * Muestra el árbol de forma jerárquica.
		 * La raíz se muestra en la parte superior, y los hijos se muestran debajo con indentación.
		 */
		public void MostrarJerarquico()
		{
			if (Raiz == null)
			{
				Console.WriteLine("Árbol vacío.");
				return;
			}

			Console.WriteLine("Raíz: " + Raiz.Valor);
			MostrarHijos(Raiz, "");
		}

		private void MostrarHijos(Nodo nodo, string prefijo)
		{
			if (nodo == null)
				return;

			bool tieneIzquierda = nodo.Izquierda != null;
			bool tieneDerecha = nodo.Derecha != null;

			if (tieneIzquierda)
			{
				bool esUltimo = !tieneDerecha;

				Console.WriteLine(
					prefijo +
					(esUltimo ? "└── " : "├── ") +
					"Izq: " + nodo.Izquierda.Valor
				);

				MostrarHijos(
					nodo.Izquierda,
					prefijo + (esUltimo ? "    " : "│   ")
				);
			}

			if (tieneDerecha)
			{
				Console.WriteLine(
					prefijo +
					"└── " +
					"Der: " + nodo.Derecha.Valor
				);

				MostrarHijos(
					nodo.Derecha,
					prefijo + "    "
				);
			}
		}

		/**
		 * Muestra el árbol de forma visual, representándolo como un árbol con ramas.
		 * La raíz se muestra en la parte superior, y los hijos se muestran debajo con líneas que representan las ramas.
		 */


		public void MostrarComoArbol()
		{
			Console.OutputEncoding = Encoding.UTF8;

			if (Raiz == null)
			{
				Console.WriteLine("Árbol vacío.");
				return;
			}

			Dictionary<Nodo, PosicionNodo> posiciones = new Dictionary<Nodo, PosicionNodo>();

			int indice = 0;
			AsignarPosiciones(Raiz, 0, ref indice, posiciones);

			int altura = CalcularAltura(Raiz);
			int separacion = 8;
			int margen = 4;

			foreach (var posicion in posiciones.Values)
			{
				posicion.X = margen + posicion.X * separacion;
			}

			int filas = altura * 2 - 1;
			int columnas = Math.Max(60, margen * 2 + indice * separacion + 10);

			char[,] lienzo = new char[filas, columnas];

			for (int i = 0; i < filas; i++)
			{
				for (int j = 0; j < columnas; j++)
				{
					lienzo[i, j] = ' ';
				}
			}

			foreach (var item in posiciones)
			{
				Nodo nodo = item.Key;
				PosicionNodo posicion = item.Value;

				int? xIzquierda = null;
				int? xDerecha = null;

				if (nodo.Izquierda != null)
				{
					xIzquierda = posiciones[nodo.Izquierda].X;
				}

				if (nodo.Derecha != null)
				{
					xDerecha = posiciones[nodo.Derecha].X;
				}

				DibujarConector(lienzo, posicion.Y + 1, posicion.X, xIzquierda, xDerecha);
			}

			foreach (var posicion in posiciones.Values)
			{
				EscribirTexto(lienzo, posicion.Y, posicion.X, posicion.Texto);
			}

			for (int i = 0; i < filas; i++)
			{
				StringBuilder linea = new StringBuilder();

				for (int j = 0; j < columnas; j++)
				{
					linea.Append(lienzo[i, j]);
				}

				Console.WriteLine(linea.ToString().TrimEnd());
			}
		}

		private void AsignarPosiciones(
			Nodo nodo,
			int nivel,
			ref int indice,
			Dictionary<Nodo, PosicionNodo> posiciones)
		{
			if (nodo == null)
				return;

			AsignarPosiciones(nodo.Izquierda, nivel + 1, ref indice, posiciones);

			posiciones[nodo] = new PosicionNodo
			{
				X = indice,
				Y = nivel * 2,
				Texto = nodo.Valor.ToString()
			};

			indice++;

			AsignarPosiciones(nodo.Derecha, nivel + 1, ref indice, posiciones);
		}

		private int CalcularAltura(Nodo nodo)
		{
			if (nodo == null)
				return 0;

			int alturaIzquierda = CalcularAltura(nodo.Izquierda);
			int alturaDerecha = CalcularAltura(nodo.Derecha);

			return Math.Max(alturaIzquierda, alturaDerecha) + 1;
		}

		private void DibujarConector(
			char[,] lienzo,
			int fila,
			int xPadre,
			int? xIzquierda,
			int? xDerecha)
		{
			if (fila >= lienzo.GetLength(0))
				return;

			if (xIzquierda.HasValue && xDerecha.HasValue)
			{
				Poner(lienzo, fila, xIzquierda.Value, '┌');

				for (int x = xIzquierda.Value + 1; x < xPadre; x++)
					Poner(lienzo, fila, x, '─');

				Poner(lienzo, fila, xPadre, '┴');

				for (int x = xPadre + 1; x < xDerecha.Value; x++)
					Poner(lienzo, fila, x, '─');

				Poner(lienzo, fila, xDerecha.Value, '┐');
			}
			else if (xIzquierda.HasValue)
			{
				Poner(lienzo, fila, xIzquierda.Value, '┌');

				for (int x = xIzquierda.Value + 1; x < xPadre; x++)
					Poner(lienzo, fila, x, '─');

				Poner(lienzo, fila, xPadre, '┘');
			}
			else if (xDerecha.HasValue)
			{
				Poner(lienzo, fila, xPadre, '└');

				for (int x = xPadre + 1; x < xDerecha.Value; x++)
					Poner(lienzo, fila, x, '─');

				Poner(lienzo, fila, xDerecha.Value, '┐');
			}
		}

		private void EscribirTexto(char[,] lienzo, int fila, int columnaCentro, string texto)
		{
			int inicio = columnaCentro - texto.Length / 2;

			for (int i = 0; i < texto.Length; i++)
			{
				Poner(lienzo, fila, inicio + i, texto[i]);
			}
		}

		private void Poner(char[,] lienzo, int fila, int columna, char caracter)
		{
			if (fila >= 0 && fila < lienzo.GetLength(0) &&
				columna >= 0 && columna < lienzo.GetLength(1))
			{
				lienzo[fila, columna] = caracter;
			}
		}

		private class PosicionNodo
		{
			public int X { get; set; }
			public int Y { get; set; }
			public string Texto { get; set; }
		}



	}
}
