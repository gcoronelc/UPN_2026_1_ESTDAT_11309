using Semana02Ejemplo01;

ListaEnlazada lista = new ListaEnlazada();

lista.Agregar(new Elemento("Teclado", 80.50));
lista.Agregar(new Elemento("Mouse", 45.00));
lista.Agregar(new Elemento("Monitor", 450.00));
lista.Agregar(new Elemento("Impresora", 730.80));
lista.Agregar(new Elemento("Memoria RAM", 220.00));

lista.Mostrar();

string NombreBuscado = "Monitor";
Nodo nodoBuscado = lista.Buscar(NombreBuscado);
Console.WriteLine("\nElemento buscado:",NombreBuscado);
Console.WriteLine(nodoBuscado != null ? nodoBuscado.Dato.ToString() : "Elemento no encontrado.");

/*
Console.WriteLine("\nOrdenamiento Burbuja");
lista.OrdenamientoBurbuja();
lista.Mostrar();

Console.WriteLine("\nOrdenamiento por Insercion");
lista.OrdenamientoInsercion();
lista.Mostrar();

*/

/*
ListaEnlazada lista1 = new ListaEnlazada();
lista1.Agregar(new Elemento("Producto L1A", 30.00));
lista1.Agregar(new Elemento("Producto L1B", 70.00));
lista1.Agregar(new Elemento("Producto L1C", 90.00));

ListaEnlazada lista2 = new ListaEnlazada();
lista2.Agregar(new Elemento("Producto L2A", 50.00));
lista2.Agregar(new Elemento("Producto L2B", 80.00));
lista2.Agregar(new Elemento("Producto L2C", 100.00));

ListaEnlazada listaCombinada = OperacionesListas.MezclarOrdenadoPorPrecio(lista1, lista2);
Console.WriteLine("\nLista Combinada Ordenada por Precio:");
listaCombinada.Mostrar();
*/