//La Clase Cambio (Nodo): Debe contener texto (String) y tipoOperacion (String - ej: "Escribir", "Borrar").
//El Problema: Cada vez que el usuario escribe algo, se agrega un nodo al final.
public class Cambio {
    private String texto;
    private String tipoOperacion;
    private Cambio siguiente;
    private Cambio anterior;

    public Cambio(String texto, String tipoOperacion)
    {
        this.texto = texto;
        this.tipoOperacion = tipoOperacion;
        this.siguiente = null;
        this.anterior = null;

    }

    public String getTexto()
    {
        this.texto = texto;
        return texto;
    }

    public String getTipoOperacion()
    {
        this.tipoOperacion = tipoOperacion;
        return tipoOperacion;
    }
    public Cambio getSiguiente()
    {
        return siguiente;

    }
    public void setSiguiente (Cambio siguiente)
    {
        this.siguiente = siguiente;

    }
    public Cambio getCambioACambio()
    {
        this.anterior = anterior;
        return anterior;
    }
    public void setCambioACambio (Cambio anterior)
    {
        this.anterior = anterior;
    }
    
}
