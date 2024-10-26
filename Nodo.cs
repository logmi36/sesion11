using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s11p07
{
    public class Nodo
    {
        public string dato { get; set; }
        public Nodo izquierda { get; set; }
        public Nodo derecha { get; set; }

        public Nodo(string dato)
        {
            this.dato = dato;
            izquierda = null;
            derecha = null;
        }

    }
}
