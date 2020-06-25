using System;

namespace ejercicio_gimnasio
{
    class Program
    {
        static void Main(string[] args)
        {
           
        Console.WriteLine("Bienvenido al sistema del gimnasio");
        int cantMaxBoxeadores = 20;
        int cantMaxEntrenadores = 4;
        String nombre;
        String apellido;
        String edad;
        String altura;
        String peso;

        String nombreEntrenador;
            Console.WriteLine("Escriba el nombre de cada entrenador y precione enter:");
            Gimnasio gimnasio = new Gimnasio();
            for (int j = 0; j < cantMaxEntrenadores; j++)
            {
                nombreEntrenador = Console.ReadLine();
                gimnasio.setEntrenador(nombreEntrenador);
            }

        try {
            for (int i = 0; i < cantMaxBoxeadores; i++) {
                Console.WriteLine("Ingreso el nuevo boxeador para pesaje");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Nombre:");
                nombre =  Console.ReadLine();
                Console.WriteLine("Apellido:");
                apellido= Console.ReadLine();
                Console.WriteLine("Edad:");
                edad = Console.ReadLine();
                int age;
                while(!int.TryParse(edad, out age))
                {
                   Console.WriteLine("la edad no es valida, ingreselo nuevamente");
                   edad = Console.ReadLine();
                }

                Console.WriteLine("Altura:");
                altura =  Console.ReadLine();
                decimal hight;
                while(!decimal.TryParse(altura, out hight))
                {
                   Console.WriteLine("La altura no es valida, ingresela nuevamente");
                   altura = Console.ReadLine();
                }
 
                Console.WriteLine("Peso:");
                peso = Console.ReadLine();
                float weight;
                while(!float.TryParse(peso, out weight))
                {
                   Console.WriteLine("El peso no es valido, ingreselo nuevamente");
                   peso = Console.ReadLine();
                }
                gimnasio.setBoxeador(nombre, apellido, int.Parse(edad), decimal.Parse(altura), peso.Replace(".",","));
                gimnasio.setAsignacion(i, peso.Replace(".",","));
            }
            
        }
        catch (FormatException ex) {
            Console.WriteLine("Error - Formato no valido: ", ex.Message);
        }
        catch (NullReferenceException nullEx) {
            Console.WriteLine("Error - Se ingresaron valores nulos: ",nullEx.Message);
        }
        catch (InvalidCastException inEx)
        {
            Console.WriteLine("Error - No se puede operar: ", inEx.Message);
        }
        
        for (int z = 0; (z < cantMaxEntrenadores); z++) {
            gimnasio.getBoxeadoresAtendidosPorEntrenador(z);
        }
        
        gimnasio.getBoxeadoresAtendidosTotales();
        }
    }
}
