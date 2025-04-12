namespace Week2_Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
             

            Console.WriteLine("Clase Vehiculo:");

            Vehiculo vehiculo = new Vehiculo("Corolla","Toyota","Azul Plateado", "2020");

            Console.WriteLine(vehiculo.getColor());
 

        }
    }
}
