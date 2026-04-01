namespace Semana02Ejemplo01
{
    internal class Elemento
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public Elemento(string nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public override string ToString()
        {
            return $"{Nombre} - S/.{Precio}";
        }
    }
}
