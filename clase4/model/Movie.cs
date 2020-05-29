using System;

namespace clase4{

    public abstract class Movie{

        public string name {get; set;}
        public string duration { get; set; }

        public double moneyplan { get; set; }


        public abstract void RollCredits();

    }
}