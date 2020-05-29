using System;

namespace clase4{

    public class Pelicula{

        public string nombre {get; set;}
        public string duracion { get; set; }

        public double Presupuesto { get; set; }


        public abstract void MostrarCreditos(){
            Console.WriteLine("Credits Rolling");
        }

    }
}