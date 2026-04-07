namespace EjemploListaDoble
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ListaDoble lista = new ListaDoble();

            lista.MostrarAdelante();

            lista.InsertarAlFinal(new Producto("Coca Cola", 4.50));
            lista.MostrarAdelante();
        }
    }
}
