using System;

namespace clase4
{
    class Program
    {

       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           
            Pelicula peli1 = new Accion();
           
            Console.WriteLine("Tipo " + peli1.GetType().Name);
            peli1.MostrarCreditos();
           

        }
    }
}
