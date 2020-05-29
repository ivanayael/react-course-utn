using System;

namespace clase3
{
    // visibiladad tipo nombre (Empieza en mayusc y tiene que tener el mismmo nombre del arciv )
    public class Pizza
    {

        // encapsulamiento
        public string mazzaType { get; set; } // pieda , medio molde , molde 

        public double size { get; set; }

        public string ingredient1 { get; set; }
        public string ingredient2 { get; set; }


        // constructores --> es decir como se inicializa el objeto
        /*
            Debe tener el mismo nombre de la clase pero no debe tener nombre de un metodo
        */
        public Pizza(string mazzaType, string ingredient1, string ingredient2, double size){
            this.mazzaType = mazzaType;
            this.ingredient1=ingredient1;
            this.ingredient2=ingredient2;
            this.size=size;
        }

        // sobrecarga de constructor
        public Pizza(){}

        // como quiero que interacture

    }
}