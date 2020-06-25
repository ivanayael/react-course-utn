using System;

namespace ejercicio_gimnasio{

public class Boxeador {
    
    private String nombre;

    private String apellido;

    private int edad;

    private decimal altura;
    
    private String peso;

    private String categoria;
    
    private Asignacion asignacion;
    
    public String getNombre() {
        return this.nombre;
    }

    
    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

     public String getApellido() {
        return this.apellido;
    }

    
    public void setApellido(String apellido) {
        this.apellido = apellido;
    }

     public int getEdad() {
        return this.edad;
    }
    
    public void setEdad(int edad) {
        this.edad = edad;
    }

     public decimal getAltura() {
        return this.altura;
    }
    
    public void setAltura(decimal altura) {
        this.altura = altura;
    }

    
    public String getPeso() {
        return this.peso;
    }
    
    public void setPeso(String peso) {
        this.peso = peso;
    }

    
    public String getCategoria() {
        return this.categoria;
    }
    
    public String setCategoria(String peso) {
        String categoria;
        float pesaje = float.Parse(peso);

        if (((pesaje >= 48.988) && (pesaje <= 52.162))) {
            categoria = "Califica en categoria Mosca";
        }
        else if (((pesaje >= 52.163)  && (pesaje <= 55.337))) {
            categoria = "Califica en categoria Gallo";
        }
        else if (((pesaje >= 55.338)  && (pesaje <= 58.966))) {

            categoria = "Califica en categoria Pluma";
        }
        else if (((pesaje >= 58.967)   && (pesaje <= 63.502))) {

            categoria = "Califica en categoria Ligero";
        }
        else if (((pesaje >= 63.503)  && (pesaje <= 69.852))) {
           
            categoria = "Califica en categoria Welter";
        }
        else if (((pesaje >= 69.853) && (pesaje <= 76.204))) {
            categoria = "Califica en categoria Mediano";
        }
        else if (((pesaje >= 76.205)  && (pesaje <= 90.999))) {
            categoria = "Califica en categoria Mediopesado";
        }
        else if ((pesaje >= 91)) {
            categoria = "Califica en categoria Mediopesado";
        }
        else {
            categoria = "Debe hacer dieta y repesaje";
        }
        this.categoria = categoria;
        return categoria;
    }
    
    public String setDieta(String peso) {
        String dieta;
        float dietaengorde = float.Parse(peso);

        if ((dietaengorde < 48.988)) {
            dieta = "Debe hacer dieta para Mosca";
        }
        else if (((dietaengorde > 50.802)  && (dietaengorde < 52.163))) {
            dieta = "Debe hacer dieta para Gallo";
        }
        else if (((dietaengorde > 53.525)  && (dietaengorde < 55.338))) {
            dieta = "Debe hacer dieta para Pluma";
        }
        else if (((dietaengorde > 57.152) && (dietaengorde < 58.967))) {
            dieta = "Debe hacer dieta para Ligero";
        }
        else if (((dietaengorde > 61.237)  && (dietaengorde < 63.503))) {
            dieta = "Debe hacer dieta para Welter";
        }
        else if (((dietaengorde > 66.678)  && (dietaengorde < 69.853))) {
            dieta = "Debe hacer dieta para Mediano";
        }
        else if (((dietaengorde > 72.562)  && (dietaengorde < 76.205))) {
            dieta = "Debe hacer dieta para Mediopesado";
        }
        else if (((dietaengorde > 79.378) && (dietaengorde < 91))) {
            dieta = "Debe hacer dieta para Pesado";
        }
        else {
            dieta = "No es necesaria la dieta";
        }
        
        return dieta;
    }
    
    public Asignacion getAsignacion() {
        return this.asignacion;
    }
    
    public void setAsignacion(Asignacion asignacion) {
        this.asignacion = asignacion;
    }
    
    public Boxeador(String nombre, String apellido, int edad, decimal altura, String peso) {
        this.nombre = nombre;
        this.apellido = apellido;
        this.edad = edad;
        this.altura = altura;
        this.peso = peso;
    }
    

    public String toString() {
        return (@"Boxeador \n Nombre"  + this.getNombre() + "\n Apellido" + this.getApellido() +
        "\n Edad"  + this.getEdad() + "\n Altura" + this.getAltura() +  "\n Peso" + this.getPeso() +
        "\n Categoria"  + this.getCategoria() +  "\n Asignacion"  + this.getAsignacion() );
    }

}
}