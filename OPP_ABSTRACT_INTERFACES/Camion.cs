using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_ABSTRACT_INTERFACES
{
    class Camion : Vehiculo
    {
        public override void tocarClaxon()
        {
            Console.WriteLine("El camion toca el claxon TRRRRRR");
        }
    }
}
