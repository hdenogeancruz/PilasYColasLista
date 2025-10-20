using System;
using System.Collections.Generic;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // ======== PILA (LIFO) ========
                Console.WriteLine("=== PILA ===");
                Pila pila = new Pila();
                pila.Agregar("A");
                pila.Agregar("B");
                pila.Agregar("C");
                pila.Agregar("D");
                pila.Agregar("E");

                Imprimir(pila);
                for (int i = 0; i < 5; i++)
                {
                    pila.Eliminar();
                    Imprimir(pila);
                }

                // ======== COLA (FIFO) ========
                Console.WriteLine("\n=== COLA ===");
                Cola cola = new Cola();
                cola.Agregar("A");
                cola.Agregar("B");
                cola.Agregar("C");
                cola.Agregar("D");
                cola.Agregar("E");

                Imprimir(cola);
                for (int i = 0; i < 5; i++)
                {
                    cola.Eliminar();
                    Imprimir(cola);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Imprimir(Pila pila)
        {
            Console.WriteLine("Mostrando contenido de la pila:");
            Console.WriteLine(pila.ObtenerDatos());
        }

        static void Imprimir(Cola cola)
        {
            Console.WriteLine("Mostrando contenido de la cola:");
            Console.WriteLine(cola.ObtenerDatos());
        }
    }

    // ======== CLASE PILA ========
    public class Pila
    {
        private List<string> lista;

        public Pila()
        {
            lista = new List<string>();
        }

        public void Agregar(string dato)
        {
            lista.Add(dato);
        }

        public void Eliminar()
        {
            if (lista.Count == 0)
                throw new Exception("La pila está vacía.");
            lista.RemoveAt(lista.Count - 1); // elimina el último
        }

        public string ObtenerDatos()
        {
            if (lista.Count == 0)
                return "(vacía)";
            lista.Reverse();
            string datos = string.Join(", ", lista);
            lista.Reverse(); // volvemos a dejarla como estaba
            return datos;
        }
    }

    // ======== CLASE COLA ========
    public class Cola
    {
        private List<string> lista;

        public Cola()
        {
            lista = new List<string>();
        }

        public void Agregar(string dato)
        {
            lista.Add(dato);
        }

        public void Eliminar()
        {
            if (lista.Count == 0)
                throw new Exception("La cola está vacía.");
            lista.RemoveAt(0); // elimina el primero
        }

        public string ObtenerDatos()
        {
            if (lista.Count == 0)
                return "(vacía)";
            return string.Join(", ", lista);
        }
    }
}
