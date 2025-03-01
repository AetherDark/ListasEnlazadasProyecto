using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEnlazadasProyecto
{
    public class Nodo
    {
        public char Dato { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(char dato)
        {
            this.Dato = dato;
            this.Siguiente = null;
        }
    }
}
