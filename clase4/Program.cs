using System;

namespace clase4
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Creando peliculas");

            // Toda clase abstra no se puede instanciar a si misma
            // variable de forma estatica   ----> new ---> instancia en memoria

            Movie movie1 = new Horror();

            movie1.name = "Pixel";

            Console.WriteLine(" type  " + movie1.GetType().Name + " nombre de la pelicula " + movie1.name);

            Console.WriteLine("Corregimos el error de catalogar a la peli");
            
            movie1 = new Comedy(); // generar el nuevo espacio en memoria ---> todos sus atributos son nulos o vacios 
            
            movie1.name = "Pixel";

            Console.WriteLine(" tipo  " + movie1.GetType().Name + " nombre de la pelicula " + movie1.name);

            movie1.RollCredits();

            MovieController pc = new MovieController();

            Movie newmovie= pc.createMovie(Genre.Horror);

            Console.WriteLine(newmovie.GetType().Name);
        }

    }
}