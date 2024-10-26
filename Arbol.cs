using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s11p07
{
    public class Arbol
    {
        public Nodo nodo { get; set; }

        public Arbol(string dato)
        {
            nodo = new Nodo(dato);
        }

        public Arbol()
        {
            nodo = null;
        }

        public void mostrarEnOrden(Nodo nodo)
        {
            if (nodo == null)
                return;
            mostrarEnOrden(nodo.izquierda);
            Console.Write(nodo.dato + "\t");
            mostrarEnOrden(nodo.derecha);
        }

        public void mostrarPreOrden(Nodo nodo)
        {
            if (nodo == null)
                return;

            Console.Write(nodo.dato + "\t");

            mostrarPreOrden(nodo.izquierda);
            mostrarPreOrden(nodo.derecha);
        }

        public void mostrarPostOrden(Nodo nodo)
        {
            if (nodo == null)
                return;

            // First recur on left subtree
            mostrarPostOrden(nodo.izquierda);
            mostrarPostOrden(nodo.derecha);
            Console.Write(nodo.dato + "\t");
        }

    }
}
