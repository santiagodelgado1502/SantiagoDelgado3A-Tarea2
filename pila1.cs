using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila
{
    class pila1
    {
        Nodo Primero; 

        public pila1()
        {
            Primero = null; 
        }

        public void InsertarElemento(char Dato)
        {
            if (Primero == null)
            { 
                Primero = new Nodo(Dato, null);
            }
            else
            {
                Nodo NuevoElemento = new Nodo(Dato, Primero);
                Primero = NuevoElemento;
            }
        }
        public void EliminarElemento()
        {
            if (Primero == null) { 
                System.Console.WriteLine("Pila vacía");
            }
            else if (Primero.Siguiente == null)
                Primero = null;

            else
                Primero = Primero.Siguiente;
        }
        public char ObtenerElemento(int Indice)
        {
            if (Primero == null)
            {
                System.Console.WriteLine("Pila vacía");
                return null;
            }

            else
            {
                int Contador = 1;

                Nodo NodoActual = Primero;

                while (NodoActual is Nodo)
                {
                    if (Contador == Indice)
                    { 
                        return NodoActual.Valor;
                    }
                Contador++; 
                    NodoActual = ActualNodo.Siguiente;
                }

                System.Console.WriteLine("No existe");
                return null;
            }

        }
}
}
