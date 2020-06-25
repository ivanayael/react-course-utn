using System;

namespace ejercicio_gimnasio{

public class Entrenador {
    
    private String nombre;
    
    private int Fichado = 0;
    
    public String getNombre() {
        return this.nombre;
    }
    
    
    public void setNombre(String nombre) {
        this.nombre = nombre;
    }
    
    public int getFichado() {
        return this.Fichado;
    }
    
    public void setFichado(int Fichado) {
        this.Fichado = Fichado;
    }
    
    public Entrenador(String nombre) : base() {
        this.nombre = nombre;
    }
    
    public void setAsignacion(Boxeador boxeador) {
        if ((this.Fichado < 5)) {
            boxeador.setAsignacion(new Asignacion(this.Fichado));
            Console.WriteLine("El boxeador "+ boxeador.getNombre() + " fue fichado y asignado al entrenador : " + this.nombre);
            Console.WriteLine(boxeador.setCategoria(boxeador.getPeso()));
            Console.WriteLine(boxeador.setDieta(boxeador.getPeso()));
            this.Fichado++;
        } else {
            Console.WriteLine("El entrenador " + this.nombre + " no puede antender a mas boxeadores");
        }
        
    }
    
    public void getAsignacion(Boxeador boxeador) {
       Console.WriteLine("El boxeador " + boxeador.getNombre());
       Console.WriteLine("Tiene el Peso " + boxeador.getPeso());
    }
}

}