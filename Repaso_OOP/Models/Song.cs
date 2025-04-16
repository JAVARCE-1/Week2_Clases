using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_OOP.Models
{
    class Song
    {

        private string _name;
        public string namePublic  //
        {
            get => _name;
            set => _name=value;
        }
        public string artista;
        public string genero;
        public string albunName;
        public int duracionSecond;

        public Song(string name, string artista, string genero, string albunName, int duracionSecond)
        {
            this._name = name;
            this.artista = artista;
            this.genero = genero;
            this.albunName = albunName;
            this.duracionSecond = duracionSecond;
        }
        //aplicando polimorfismo al metodo
        public Song(string name, string artista, int duracionSecond)
        {
            this._name = name;
            this.artista = artista;
            this.duracionSecond = duracionSecond;
        }

        public string MostrarNombreCancion(string nombre)
        {
            return _name + "" + nombre;
        }


    }
}

