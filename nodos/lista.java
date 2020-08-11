package nodos;

public class lista {

    public static void main(String[] args) {
        listaEnlazada lista = new listaEnlazada();

        
        lista.addPrimero(20);
        lista.addPrimero(15);
        lista.addPrimero(10);
        lista.addPrimero(6);
        lista.addPrimero(4);
        lista.addPrimero(1);

        //lista.eliminar(2);
        lista.cortar(3);

        System.out.println("Primer elemento: " + lista.obtener(0));
        System.out.println("Ultimo: " + lista.obtener(lista.size() - 1));
        //System.out.println("Index 2: " + lista.obtener(2));

        System.out.println("Tamano: " + lista.size());
    }
}

/**
 * Nodo
 */
class Nodo {

    Object valor;
    Nodo siguiente;

    public Nodo(final Object valor) {
        this.valor = valor;
        siguiente = null;
    }

    public Object obtenerValor() {
        return valor;
    }

    public void enlazarSiguiente(final Nodo n) {
        siguiente = n;

    }

    public Nodo obtenerSiguiente() {
        return siguiente;
    }

}

class listaEnlazada {
    Nodo cabeza;
    int size;

    public listaEnlazada() {
        cabeza = null;
        size = 0;
    }

    public Object obtener(int index) {
        int contador = 0;
        Nodo temporal = cabeza;
        while (contador < index) {
            temporal = temporal.obtenerSiguiente();
            contador++;
        }
        return temporal.obtenerValor();
    }

    public void addPrimero(Object obj) {
        if (cabeza == null) {
            cabeza = new Nodo(obj);
        } else {
            Nodo temp = cabeza;
            Nodo nuevo = new Nodo(obj);
            nuevo.enlazarSiguiente(temp);
            cabeza = nuevo;
        }
        size++;
    }

    public void eliminarPrimero() {
        cabeza = cabeza.obtenerSiguiente();
        size--;
    }

    public void cortar(int index) {
        // Cortar la lista
        int contador = 0;
        Nodo temporal = cabeza;
        while (contador < index - 1) {
            temporal = temporal.obtenerSiguiente();
            contador++;
        }
        temporal.enlazarSiguiente(null);
        size = index;
    }

    public void eliminar(int index) {
        if (index == 0) {
            cabeza = cabeza.obtenerSiguiente();
        } else {
            int contador = 0;
            Nodo temporal = cabeza;

            while (contador < index - 1) {
                temporal = temporal.obtenerSiguiente();
                contador++;
            }
            temporal.enlazarSiguiente(temporal.obtenerSiguiente().obtenerSiguiente());
        }
        size--;
    }

    public int size() {
        return size;
    }

    public boolean estaVacia() {
        return (cabeza == null) ? true : false;
    }
}
