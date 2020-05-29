using System;

namespace clase3
{
    class Program
    {
       static void Main(string[] args)
        {

            Console.WriteLine("View Layer");
            Console.WriteLine("My second app in c# netCore");

            Pizza p1 = new Pizza("mold", "tomato", "muzzarella", 20.5); // crear objetos
            Pizza p3 = crearPizza("mold", "tomato", "fontina cheese", 20.5);

            Console.WriteLine(idintificoPizza(p1));
            Console.WriteLine(idintificoPizza(p3));


            Muzzarela m1 = new Muzzarela();
            m1.mazzaType = "piedra";
            m1.ingredient1 = "jam";
            m1.ingredient2 = "muzarella";

            m1.cook(20.0);

            // factoria abstract ---> factoria de metodos
            Pizza p4 = new Muzzarela();

        }


        public static string idintifyPizza(Pizza pizza)
        {
            string result = "I don't know what kind of pizza is :(";

            // aplicar condiciones para resolver o deducir de que tipo es la pizza
            if (pizza.mazzaType == "mold" && pizza.ingredient2 == "muzzarella")
            {
                result = "Big muzzarella";
            }
            return result;
        }


        // como se construye la pizza

        // Builder 
        public static Pizza createPizza(string mazzaType, string ingredient1, string ingredient2, double size)
        {
            
            // void hace referencia a un proceso 
            Pizza pizza = new Pizza(); // <--- Creo la pizza

            pizza.mazzaType = mazzaType;
            pizza.ingredient1 = ingredient1;
            pizza.ingredient2 = ingredient2;
            pizza.size = size;

            return pizza;

            // fin del procesamiento ---> imprimira o modificar alguna variable interna o externa al proceso
        }
 
    }
}