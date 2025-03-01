using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEnlazadasProyecto
{
    public class CapturaDatos
    {
        public int Opcion { get; set; }
        private Lista lista { get; set; }

        public CapturaDatos(int opcion, Lista lista)
        {
            this.Opcion = opcion;
            this.lista = lista;
        }

        public void EjecutarOpcion()
        {
            switch (Opcion)
            {
                case 1:
                    Console.Clear();
                    lista.ClearList();
                    Console.WriteLine("Lista inicializada/borrada.");
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine(lista.InsertarEnLista());
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine(lista.EliminarDeLista());
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine(lista.BuscarEnLista());
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine(lista.MostrarLista());
                    break;

                case 6:
                    Console.Clear();
                    Console.WriteLine("Materia: Estructura de Datos" +
                        "\nIntegrante: Jaret Eduardo Gonzalez Carrasco" +
                        "\nMatricula: 22170143");
                    break;
            }
        }
    }
}
