using System;

namespace ejercicio
{
    class Lista
    {
        private int size;
        private Nodo primero = new Nodo();
        private Nodo ultimo = new Nodo();

        public Lista()
        {
            primero = null;
            ultimo = null;
            size = 0;
        }

        public void insertarNodo()
        {
            Nodo nuevo = new Nodo();
            Console.Write("Ingrese el dato que contendra el nuevo nodo: ");
            nuevo.Dato = int.Parse(Console.ReadLine());

            if (primero == null)
            {
                primero = nuevo;
                primero.Siguiente = null;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                ultimo = nuevo;
            }
            Console.WriteLine("\n Nodo Ingresado\n ");
            size++;
        }

        public void buscarNodo()
        {
            Nodo actual = new Nodo();
            actual = primero;
            bool encontrado = false;
            Console.Write(" Ingrese el dato del nodo a buscar: ");
            int nodoBuscado = int.Parse(Console.ReadLine());
            if (primero != null)
            {
                while (actual != null && encontrado != true)
                {
                    if (actual.Dato == nodoBuscado)
                    {
                        Console.WriteLine("\n El nodo con el dato ( {0} ) encontrado", nodoBuscado);
                        encontrado = true;
                    }
                    actual = actual.Siguiente;
                }
                if (!encontrado)
                {
                    Console.WriteLine("\n Nodo no encontrado\n");
                }
            }
            else
            {
                Console.WriteLine("\n La lista está vacia \n");
            }
        }

        public void modificarNodo()
        {
            Nodo actual = new Nodo();
            actual = primero;
            bool encontrado = false;
            Console.Write(" Ingrese el dato del nodo a modificar: ");
            int nodoBuscado = int.Parse(Console.ReadLine());
            if (primero != null)
            {
                while (actual != null && encontrado != true)
                {
                    if (actual.Dato == nodoBuscado)
                    {
                        Console.WriteLine("\n El nodo con el dato ( {0} ) encontrado", nodoBuscado);
                        Console.Write("Ingrese un nuevo dato para el Nodo");
                        actual.Dato = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n Nodo modificado\n");
                        encontrado = true;
                    }
                    actual = actual.Siguiente;
                }
                if (!encontrado)
                {
                    Console.WriteLine("\n Nodo no encontrado\n");
                }
            }
            else
            {
                Console.WriteLine("\n La lista está vacia \n");
            }
        }

        public void elminarNodo()
        {
            Nodo actual = new Nodo();
            actual = primero;
            Nodo anterior = new Nodo();
            anterior = null;
            bool encontrado = false;
            Console.Write(" Ingrese el dato del nodo a buscar para eliminar: ");
            int nodoBuscado = int.Parse(Console.ReadLine());
            if (primero != null)
            {
                while (actual != null && encontrado != true)
                {
                    if (actual.Dato == nodoBuscado)
                    {
                        if (actual == primero)
                        {
                            primero = primero.Siguiente;
                        }
                        else if (actual == ultimo)
                        {
                            anterior.Siguiente = null;
                            ultimo = anterior;
                        }
                        else
                        {
                            anterior.Siguiente = actual.Siguiente;
                        }
                        Console.WriteLine("\n Nodo eliminado con exito\n");
                        encontrado = true;
                    }
                    anterior = actual;
                    actual = actual.Siguiente;
                }
                if (!encontrado)
                {
                    Console.WriteLine("\n Nodo no encontrado\n");
                }
            }
            else
            {
                Console.WriteLine("\n La lista está vacia \n");
            }
        }

        public int getSize()
        {
            return size;
        }

        public void desplegarLista()
        {
            Nodo actual = new Nodo();
            actual = primero;
            if (primero != null)
            {
                while (actual != null)
                {
                    Console.WriteLine(" {0} ", actual.Dato);
                    actual = actual.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("\n La lista está vacia \n");
            }
        }
    }
}