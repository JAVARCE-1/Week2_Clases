using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Clases
{
    class Vehiculo
    {

        private string Modelo;
        //private string Marca { get; set; }
        private string Marca;
        private string Color;
        private string Anio;

        public Vehiculo (string modelo, string marca, string color, string anio)
        {
            Modelo = modelo;
            Marca = marca;
            Color = color;
            Anio = anio;
        }

        public string getModelo()
        {
            return Modelo;
        }

        public void setModelo(string modelo)
        {
            this.Modelo= modelo;
        }

        public string getMarca()
        {
            return Marca;
        }

        public void setMarca(string marca)
        {
            this.Marca = marca;
        }

        public string getColor()
        {
            return Color;
        }

        public void setColor(string color)
        {
            this.Color = color;
        }

        public string getAnio()
        {
            return Anio;
        }

        public void setAnio(string anio)
        {
            this.Anio = anio;
        }

    }
}
