namespace OPP_CLASES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Invocar objetos de la clase");

            Producto prod = new Producto("001","teclado",75.5m,14);

            Console.WriteLine(prod.Nombre);


            Cliente cliente = new Cliente("cli01","Juan","Perez","Flores","av Lima","M","coreeo@correo","9999");

            Console.WriteLine(cliente.Nombre);
        }
    }
}
