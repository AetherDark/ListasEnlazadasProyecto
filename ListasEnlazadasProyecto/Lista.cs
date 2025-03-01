using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEnlazadasProyecto
{
    public class Lista
    {
        private Nodo cabeza;

        public Lista()
        {
            cabeza = null;
        }

        public static bool EsLetraValida(char c)
        {
            return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
        }

        public static int CompararLetras(char a, char b)
        {
            int comp = char.ToUpper(a).CompareTo(char.ToUpper(b));

            if (comp == 0)
            {
                return char.IsUpper(a) ? -1 : 1;
            }

            return comp;
        }

        public void ClearList()
        {
            cabeza = null;
        }

        public string MostrarLista()
        {
            if (cabeza == null)
            {
                return "La lista está vacía.";
            }

            List<char> elementos = new List<char>();
            Nodo actual = cabeza;

            while (actual != null)
            {
                elementos.Add(actual.Dato);
                actual = actual.Siguiente;
            }

            return string.Join(" -> ", elementos);
        }

        public string BuscarEnLista()
        {
            Console.Write("Ingrese la letra a buscar: ");
            char letra;

            while (!char.TryParse(Console.ReadLine(), out letra) || !EsLetraValida(letra))
            {
                Console.WriteLine("Entrada no válida. Ingrese una letra (A-Z o a-z).");
            }

            int count = 0;
            Nodo actual = cabeza;

            while (actual != null)
            {
                if (actual.Dato == letra)
                    count++;
                actual = actual.Siguiente;
            }

            return count > 0 ? $"La letra '{letra}' se encontró {count} veces." : $"La letra '{letra}' no se encontró en la lista.";
        }

        public string InsertarEnLista()
        {
            Console.Write("Ingrese la letra a insertar: ");
            char letra;

            while (!char.TryParse(Console.ReadLine(), out letra) || !EsLetraValida(letra))
            {
                Console.WriteLine("Entrada no válida. Ingrese una letra (A-Z o a-z).");
            }

            Nodo nuevo = new Nodo(letra);

            if (cabeza == null || CompararLetras(letra, cabeza.Dato) < 0)
            {
                nuevo.Siguiente = cabeza;
                cabeza = nuevo;
            }
            else
            {
                Nodo actual = cabeza;

                while (actual.Siguiente != null && CompararLetras(actual.Siguiente.Dato, letra) < 0)
                {
                    actual = actual.Siguiente;
                }

                nuevo.Siguiente = actual.Siguiente;
                actual.Siguiente = nuevo;
            }

            return $"La letra '{letra}' se insertó en la lista.";
        }

        public string EliminarDeLista()
        {
            Console.Write("Ingrese la letra a eliminar: ");
            char letra;

            while (!char.TryParse(Console.ReadLine(), out letra) || !EsLetraValida(letra))
            {
                Console.WriteLine("Entrada no válida. Ingrese una letra (A-Z o a-z).");
            }

            bool found = false;

            while (cabeza != null && cabeza.Dato == letra)
            {
                cabeza = cabeza.Siguiente;
                found = true;
            }

            Nodo actual = cabeza;

            while (actual != null && actual.Siguiente != null)
            {
                if (actual.Siguiente.Dato == letra)
                {
                    actual.Siguiente = actual.Siguiente.Siguiente;
                    found = true;
                }
                else
                {
                    actual = actual.Siguiente;
                }
            }

            return found ? $"La letra '{letra}' se eliminó de la lista." : $"La letra '{letra}' no se encontró en la lista.";
        }
    }
}
