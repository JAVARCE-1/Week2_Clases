namespace Week2_Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Vehiculo vehiculo = new Vehiculo("Corolla","Toyota","Azul Plateado", "2025-02-01");

            Console.WriteLine(vehiculo.getColor());
 

        }
    }
}
