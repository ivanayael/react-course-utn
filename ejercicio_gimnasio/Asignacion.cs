using System;

    namespace ejercicio_gimnasio{
        public class Asignacion {
        
        private int NumeroAsignacion;
        
        public int getNumeroAsignacion() {
            return NumeroAsignacion;
        }
        
        public void setNumeroAsignacion(int NumeroAsignacion) {
            this.NumeroAsignacion = NumeroAsignacion;
        }
        
        public Asignacion(int NumeroAsignacion) : base() {
            this.NumeroAsignacion = NumeroAsignacion;
        }
        
    
        public String toString() {
            return ("Asignacion{" + ("NumeroAsignacion="  + (this.NumeroAsignacion + '}')));
        }
    }
}