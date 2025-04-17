using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_ABSTRACT_INTERFACES
{
    public  abstract class Vehiculo
    {
        public abstract void tocarClaxon();
       
        public void costoVehiculo()
        {
            Console.WriteLine("el vehiculo tiene costo");
        }

    }
}
