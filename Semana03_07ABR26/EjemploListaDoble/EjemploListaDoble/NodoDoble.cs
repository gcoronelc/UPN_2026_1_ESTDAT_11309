namespace EjemploListaDoble
{
    internal class NodoDoble
    {

        public Producto Dato { get; set; }
        public NodoDoble Siguiente { get; set; }
        public NodoDoble Anterior { get; set; }


        public NodoDoble(Producto dato)
        {
            Dato = dato;
            Siguiente = null;
            Anterior = null;
        }


    }
}
