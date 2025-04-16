using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_CLASES
{
    class Producto
    {
        private string _codigo;
        private string _nombre;
        private decimal _precio;
        private int _stock;



        public string Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public decimal Precio { get => _precio; set => _precio = value; }
        public int Stock { get => _stock; set => _stock = value; }

        public Producto(string codigo, string nombre, decimal precio, int stock)
        {
            _codigo = codigo;
            _nombre = nombre;
            _precio = precio;
            _stock = stock;
        }
    }
}
