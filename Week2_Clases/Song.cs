using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Clases
{
    class Song
    {
        public string Album { get; set; }
        public string Title { get; set; }
        public string Descripcion { get; set; }
        public string Genere { get; set; }

        public Song(string albun, string title,string descripcion, string genere)
        {
            Album = albun;
            Title = title;
            Descripcion = descripcion;
            Genere = genere;

        }

        public double getAmount(double amount)
        {
            if (amount <0)
            {
                throw new Exception("ERROR");
            }
            //amount = this.am
            return amount;
        }


    }
}
