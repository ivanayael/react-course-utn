using System;

namespace clase3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("View Layer");
            Console.WriteLine("My second app in c# netCore");

            Pizza p1 = createPizza("mold", "tomato", "muzzarella", 20.5);
        }

        //builder pattern
        public static Pizza createPizza(string MazzaType, string ingredient1, string ingredient2, double size){
            Pizza pizza = new Pizza();

            pizza.MazzaType = MazzaType;
            pizza.ingredient1 = ingredient1;
            pizza.ingredient2 = ingredient2;
            pizza.size = size;

            return pizza;
        }
    }
}
