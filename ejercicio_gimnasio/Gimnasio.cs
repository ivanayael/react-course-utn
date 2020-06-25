using System;

namespace ejercicio_gimnasio{

    public class Gimnasio {
        private int boxeadorIngresado = 0;
    
        private int cantEntrenadores = 0;
        
        Boxeador[] listaBoxeadores = new Boxeador[20];

        Entrenador[] listaEntrenadores = new Entrenador[4];
        
        public void setBoxeador(String nombre, string apellido, int edad, decimal altura, String peso) {
            this.listaBoxeadores[this.boxeadorIngresado] = new Boxeador(nombre, apellido, edad, altura, peso);
            this.boxeadorIngresado++;
        }
        
        public void setEntrenador(String nombre) {
            if ((this.cantEntrenadores < 5)) {
                this.listaEntrenadores[this.cantEntrenadores] = new Entrenador(nombre);
                this.cantEntrenadores++;
            }
            else {
                Console.WriteLine("Los entrenadores no pueden atender mas boxeadores");
            }
            
        }
        
        public void setAsignacion(int numeroBoxeador,  string peso) {
            float pesaje = float.Parse(peso);
            if (((pesaje >= 48.988) && (pesaje <= 55.337))) {
                this.listaEntrenadores[0].setAsignacion(this.listaBoxeadores[numeroBoxeador]);
            }
            else if (((pesaje >= 55.338) && (pesaje <= 63.502))) {
                this.listaEntrenadores[1].setAsignacion(this.listaBoxeadores[numeroBoxeador]);
            }
            else if (((pesaje >= 63.503) && (pesaje <= 76.204))) {
                this.listaEntrenadores[2].setAsignacion(this.listaBoxeadores[numeroBoxeador]);
            }
            else {
                this.listaEntrenadores[3].setAsignacion(this.listaBoxeadores[numeroBoxeador]);
            }
            
        }
        
        public void getBoxeadoresAtendidosPorEntrenador(int numeroEntrenador) {
            Console.WriteLine("El entrenador " + this.listaEntrenadores[numeroEntrenador].getNombre() + " atendio: " + this.listaEntrenadores[numeroEntrenador].getFichado());
        }
        
        public void getBoxeadoresAtendidosTotales() {
            int acumulador = 0;
            foreach (Entrenador listaEntrenador in this.listaEntrenadores) {
                acumulador = (acumulador + listaEntrenador.getFichado());
            }
            
            Console.WriteLine("El Total de Boxeadores atendidos por entrenador es: " + acumulador);
        }
    }
}