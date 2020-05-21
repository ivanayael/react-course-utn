using System;

namespace clase1
{
    public class Program
    {

        static void Main(string[] args) // ----> esto es un objeto
        {  // scope o ambito del metodo 
            
            Console.WriteLine("Hello World First Exercise with .NET Core!");
            Console.WriteLine("Creamos la primera persona");
            Persona p1 = new Persona();

            p1.nombre = "Lucas";
            p1.dormir();

            Console.WriteLine("Creamos la segunda persona");
            Persona p2 = new Persona();
            p2.nombre = "Ivana";
            p2.dormir();

            CuentaSueldo cs1 = new CuentaSueldo();
            // cs1.saldo = 10000;
            // MetodoMaliciso(10000);
            Console.WriteLine(cs1.getSaldo());
        }

        //contrato y firma (parametros de entrada)

        public static double MetodoMaliciso(double valor)
        {
            double resultado = valor - 100000;
            Console.WriteLine("Se ha ejecutado un metodo maligno" + resultado);
            return resultado;
        }
    }
}
