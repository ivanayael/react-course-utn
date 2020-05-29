using System;

namespace clase4
{
    // dos puntos sirve para extender e implementar 
    // clase abstract y/o N interfaces
    /*
        Puedo extender de una sola clase 
        Puedo implementar multiples interfaces
    */
    public class Action : Movie
    {
        
        public override void RollCredits()
        {
            Console.WriteLine("Action Time is Over!");
        }

       
    }
}