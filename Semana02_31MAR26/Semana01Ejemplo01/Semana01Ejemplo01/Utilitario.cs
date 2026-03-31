namespace Semana01Ejemplo01
{
    internal class Utilitario
    {

        public static ListaEnlazada mezclar(ListaEnlazada lista1, ListaEnlazada lista2)
        {
            ListaEnlazada listaNueva = new ListaEnlazada();

            Nodo actual1 = lista1.Cabeza;
            Nodo actual2 = lista2.Cabeza;

            // Mientras ambas listas tengan nodos por procesar
            while (actual1 != null && actual2 != null)
            {
                if (actual1.Dato <= actual2.Dato)
                {
                    listaNueva.AgregarAlFinal(actual1.Dato);
                    actual1 = actual1.Siguiente;
                }
                else
                {
                    listaNueva.AgregarAlFinal(actual2.Dato);
                    actual2 = actual2.Siguiente;
                }
            }

            // Anexar el remanente de lista1 (si lo hay)
            while (actual1 != null)
            {
                listaNueva.AgregarAlFinal(actual1.Dato);
                actual1 = actual1.Siguiente;
            }

            // Anexar el remanente de lista2 (si lo hay)
            while (actual2 != null)
            {
                listaNueva.AgregarAlFinal(actual2.Dato);
                actual2 = actual2.Siguiente;
            }

            return listaNueva;
        }


    }
}
