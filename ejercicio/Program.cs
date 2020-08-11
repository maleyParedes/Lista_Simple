using System;
using System.Configuration;

namespace ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista lis = new Lista();

            lis.insertarNodo();
            lis.insertarNodo();
            lis.insertarNodo();
            lis.insertarNodo();
            lis.insertarNodo();

            Console.WriteLine("\n La lista de nodos ingresada es: ");
            lis.desplegarLista();

            //lis.buscarNodo();
            //lis.modificarNodo();

            lis.elminarNodo();

            lis.desplegarLista();

            lis.elminarNodo();

            lis.desplegarLista();
        }
    }
}
