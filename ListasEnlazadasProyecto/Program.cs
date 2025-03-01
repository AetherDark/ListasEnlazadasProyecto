using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEnlazadasProyecto
{
    class Program
    {
        private static bool finalizarPrograma()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("¿Estas seguro de querer finalizar? (s/n): ");
                string respuesta = Console.ReadLine()?.ToLower();

                if (respuesta == "n")
                {
                    return false;
                }
                else if (respuesta == "s")
                {
                    Console.WriteLine("¡Adiós!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Por favor, ingresa 's' para sí o 'n' para no.");
                    Console.ReadKey();
                }
            }
        }

        static void Main(string[] args)
        {
            Lista lista = new Lista();
            bool finalizar = false;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Menú de Listas Enlazadas ===");
                Console.WriteLine("1. Inicializar / Borrar Lista" +
                                "\n2. Insertar" +
                                "\n3. Eliminar" +
                                "\n4. Buscar" +
                                "\n5. Mostrar" +
                                "\n6. Creditos" +
                                "\n7. Salir" +
                                "\nSeleccione una opcion:");

                int opcion;

                while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 7)
                {
                    Console.WriteLine("Entrada no válida. Ingrese un número entre 1 y 7.");
                }

                if (opcion == 7)
                {
                    if (finalizarPrograma() == true)
                    {
                        finalizar = true;
                    }
                }

                if (finalizar) break;

                CapturaDatos captura = new CapturaDatos(opcion, lista);
                captura.EjecutarOpcion();
                Console.WriteLine("\nPresiona Enter para volver al menú...");
                Console.ReadLine();
            }
        }
    }
}
