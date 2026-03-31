// Programa principal para probar la lista enlazada

// Importando el namespace para usar las clases Nodo y ListaEnlazada
using Semana01Ejemplo01;

// Crear la lista
ListaEnlazada lista = new ListaEnlazada();

// Insertar 3 elementos
lista.AgregarAlInicio(10);
lista.AgregarAlInicio(20);
lista.AgregarAlInicio(30);
lista.AgregarAlFinal(50);
lista.AgregarAlFinal(25);
lista.AgregarAlFinal(40);
lista.AgregarAlFinal(35);

// Listar elementos
Console.WriteLine("Elementos de la lista enlazada:");
lista.Imprimir();

// Buscar nodo
Nodo encontrado = lista.buscar(10);
string repo = (encontrado == null) ? "NULL" : encontrado.Dato.ToString();
Console.WriteLine("Encontrado: " + repo);

// Ordenar Lista
lista.OrdenamientoBurbuja();
lista.Imprimir();


ListaEnlazada lista1 = new ListaEnlazada();
lista1.AgregarAlFinal(45);
lista1.AgregarAlFinal(30);
lista1.AgregarAlFinal(55);
lista1.AgregarAlFinal(40);
lista1.OrdenamientoBurbuja();

ListaEnlazada lista2 = new ListaEnlazada();
lista2.AgregarAlFinal(25);
lista2.AgregarAlFinal(100);
lista2.AgregarAlFinal(60);
lista2.AgregarAlFinal(33);
lista2.OrdenamientoBurbuja();

ListaEnlazada listaNueva = Utilitario.mezclar(lista1, lista2);

Console.WriteLine("========================================");
lista1.Imprimir();
lista2.Imprimir();
listaNueva.Imprimir();




// Fin del programa
Console.WriteLine("Presione una tecla para salir...");
Console.ReadKey();


