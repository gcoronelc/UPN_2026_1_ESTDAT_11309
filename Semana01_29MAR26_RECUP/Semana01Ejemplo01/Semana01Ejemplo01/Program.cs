// Programa principal para probar la lista enlazada

// Importando el namespace para usar las clases Nodo y ListaEnlazada
using Semana01Ejemplo01;

// Crear la lista
ListaEnlazada lista = new ListaEnlazada();

// Insertar 3 elementos
lista.AgregarAlFinal(10);
lista.AgregarAlFinal(20);
lista.AgregarAlFinal(30);

// Listar elementos
Console.WriteLine("Elementos de la lista enlazada:");
lista.Imprimir();

// Fin del programa
Console.WriteLine("Presione una tecla para salir...");
Console.ReadKey();

