using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_CLASES
{
    class Cliente
    {

        private string _codigo;
        private string _nombre;

        private string _apPaterno;
        private string _apMaterno;
        private string _direccion;
        private DateOnly _fechaNacimiento;
        private string _sexo;
        private string _correo;
        private string _telefono;



        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public string ApPaterno { get => _apPaterno; set => _apPaterno = value; }
        public string ApMaterno { get => _apMaterno; set => _apMaterno = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Sexo { get => _sexo; set => _sexo = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }

        public Cliente(string codigo, string nombre, string apPaterno, string apMaterno, string direccion, string sexo, string correo, string telefono)
        {
            _codigo = codigo;
            _nombre = nombre;
            _apPaterno = apPaterno;
            _apMaterno = apMaterno;
            _direccion = direccion;
            _sexo = sexo;
            _correo = correo;
            _telefono = telefono;
        }

    }
}
