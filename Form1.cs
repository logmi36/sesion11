using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace s11p07
{
    public partial class Form1 : Form
    {

       public static  Arbol arbol = new Arbol();

        public Nodo nodo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            init();
            nodo = arbol.nodo;
            label1.Text = "";
            label2.Text = "";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) {
                nodo = nodo.izquierda;
                label1.Text = nodo.dato;
            }
            if (e.KeyData == Keys.Down)
            {
                label2.Text = label2.Text + label1.Text;
                label1.Text = "";
                nodo = arbol.nodo;
            }
            if (e.KeyData == Keys.Right)
            {
                nodo = nodo.derecha;
                label1.Text = nodo.dato;
            }
            if (e.KeyData == Keys.Escape)
            {
                Close();
            }
        }

        public void init() {
            

            arbol.nodo = new Nodo(null);
            arbol.nodo.izquierda = new Nodo("E");
            arbol.nodo.derecha = new Nodo("T");

            //=================================================

            arbol.nodo.izquierda.izquierda = new Nodo("I");
            arbol.nodo.izquierda.derecha = new Nodo("A");

            arbol.nodo.derecha.izquierda = new Nodo("N");
            arbol.nodo.derecha.derecha = new Nodo("M");

            //=================================================


            arbol.nodo.izquierda.izquierda.izquierda = new Nodo("S");
            arbol.nodo.izquierda.izquierda.derecha = new Nodo("U");

            arbol.nodo.izquierda.derecha.izquierda = new Nodo("R");
            arbol.nodo.izquierda.derecha.derecha = new Nodo("W");

            //=================================================


            arbol.nodo.izquierda.izquierda.izquierda.izquierda = new Nodo("H");
            arbol.nodo.izquierda.izquierda.izquierda.derecha = new Nodo("V");

            arbol.nodo.izquierda.izquierda.derecha.izquierda = new Nodo("F");
            arbol.nodo.izquierda.izquierda.derecha.derecha = new Nodo(null);


            //=================================================

            arbol.nodo.izquierda.derecha.izquierda.izquierda = new Nodo("L");
            arbol.nodo.izquierda.derecha.izquierda.derecha = new Nodo(null);

            arbol.nodo.izquierda.derecha.derecha.izquierda = new Nodo("P");
            arbol.nodo.izquierda.derecha.derecha.derecha = new Nodo("J");

            //=================================================

            arbol.nodo.derecha.izquierda = new Nodo("N");
            arbol.nodo.derecha.derecha = new Nodo("M");

            //=================================================

            arbol.nodo.derecha.izquierda.izquierda = new Nodo("D");
            arbol.nodo.derecha.izquierda.derecha = new Nodo("K");


            //=================================================


            arbol.nodo.derecha.izquierda.izquierda.izquierda = new Nodo("B");
            arbol.nodo.derecha.izquierda.izquierda.derecha = new Nodo("X");

            arbol.nodo.derecha.izquierda.derecha.izquierda = new Nodo("C");
            arbol.nodo.derecha.izquierda.derecha.derecha = new Nodo("Y");

            //=================================================


            arbol.nodo.derecha.derecha.izquierda = new Nodo("G");
            arbol.nodo.derecha.derecha.derecha = new Nodo("O");

            arbol.nodo.derecha.derecha.izquierda.izquierda = new Nodo("Z");
            arbol.nodo.derecha.derecha.izquierda.derecha = new Nodo("Q");

            //=================================================
        }

    }
}
