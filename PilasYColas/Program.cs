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
                // =======================
                //     EJEMPLO DE PILA
                // =======================
                Console.WriteLine("=== PILA (LIFO) ===");
                Pila pila = new Pila();

                // Agregamos elementos a la pila
                pila.Agregar("A");
                pila.Agregar("B");
                pila.Agregar("C");
                pila.Agregar("D");
                pila.Agregar("E");

                Imprimir(pila);

                // Vamos quitando uno por uno.
                for (int i = 0; i < 5; i++)
                {
                    pila.Eliminar();
                    Imprimir(pila);
                }

                // =======================
                //     EJEMPLO DE COLA
                // =======================
                Console.WriteLine("\n=== COLA (FIFO) ===");
                Cola cola = new Cola();

                // Agregamos elementos a la cola.
                cola.Agregar("A");
                cola.Agregar("B");
                cola.Agregar("C");
                cola.Agregar("D");
                cola.Agregar("E");

                Imprimir(cola);

                // Vamos quitando uno por uno
                for (int i = 0; i < 5; i++)
                {
                    cola.Eliminar();
                    Imprimir(cola);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // Método para imprimir una pila
        static void Imprimir(Pila pila)
        {
            Console.WriteLine("Contenido de la pila:");
            Console.WriteLine(pila.ObtenerDatos());
            Console.WriteLine();
        }

        // Método para imprimir una cola
        static void Imprimir(Cola cola)
        {
            Console.WriteLine("Contenido de la cola:");
            Console.WriteLine(cola.ObtenerDatos());
            Console.WriteLine();
        }
    }

    // =======================
    //     CLASE PILA
    // =======================
    public class Pila
    {
        private List<string> lista = new List<string>();

        // Agrega un dato al final (arriba de la pila)
        public void Agregar(string dato)
        {
            lista.Add(dato);
        }

        // Elimina el último dato (el de arriba)
        public void Eliminar()
        {
            if (lista.Count == 0)
                throw new Exception("La pila está vacía");
            lista.RemoveAt(lista.Count - 1);
        }

        // Muestra los datos en orden de arriba hacia abajo
        public string ObtenerDatos()
        {
            if (lista.Count == 0)
                return "(vacía)";

            // Hacemos una copia invertida para que se vea la pila desde arriba
            List<string> copia = new List<string>(lista);
            copia.Reverse();
            return string.Join(", ", copia);
        }
    }

    // =======================
    //     CLASE COLA
    // =======================
    public class Cola
    {
        private List<string> lista = new List<string>();

        // Agrega un dato al final (último de la fila)
        public void Agregar(string dato)
        {
            lista.Add(dato);
        }

        // Elimina el primer dato (el primero que entró)
        public void Eliminar()
        {
            if (lista.Count == 0)
                throw new Exception("La cola está vacía");
            lista.RemoveAt(0);
        }

        // Muestra los datos en orden (de primero a último)
        public string ObtenerDatos()
        {
            if (lista.Count == 0)
                return "(vacía)";
            return string.Join(", ", lista);
        }
    }
}

