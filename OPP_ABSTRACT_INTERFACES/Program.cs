﻿namespace OPP_ABSTRACT_INTERFACES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------");

            var auto = new Auto();
            auto.cantidadLlantas();


            var bicilceta = new Bicicleta();
            bicilceta.cantidadLlantas();

            var camion = new Camion();
            camion.tocarClaxon();

        }
    }
}
