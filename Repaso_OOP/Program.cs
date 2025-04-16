using Repaso_OOP.Models;

namespace Repaso_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Song song = new Song("Something","Daft Punk","Electronic","Discovery",240);
            Console.WriteLine( song.namePublic);
            Console.WriteLine(song.genero);
            Console.WriteLine("");

            Song song2 = new Song("Around the World", "Daft Punk", "Electronic", "Discovery", 240);
            Console.WriteLine(song2.namePublic);
            Console.WriteLine(song2.genero);

            Console.WriteLine("");
            Song song3 = new Song("Get Lucky", "Daft Punk" , 240);
            Console.WriteLine(song3.namePublic);
            Console.WriteLine(song3.artista);
            song3.namePublic = "new";
            Console.WriteLine(song3.namePublic);
        }

        //public class Song
        //{
        //    public string name;
        //    public string artista;
        //    public string genero;
        //    public string albunName;
        //    public int duracionSecond;

        //    public Song(string name, string artista, string genero, string albunName, int duracionSecond)  
        //    {
        //        this.name = name;
        //        this.artista = artista;
        //        this.genero = genero;
        //        this.albunName = albunName;
        //        this.duracionSecond = duracionSecond;
        //    }
        //    //aplicando polimorfismo al metodo
        //    public Song(string name, string artista,   int duracionSecond)
        //    {
        //        this.name = name;
        //        this.artista = artista;
        //        this.duracionSecond = duracionSecond;
        //    }

        //}



    }
}
