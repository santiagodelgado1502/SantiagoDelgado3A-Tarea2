using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    class CLista
    {
        CNodo cabeza;
        public CLista()
        {
            cabeza = null;
        }
        public void InsertarDato(int dat)
        {
            CNodo NuevoNodo;
            CNodo antes, luego;
            NuevoNodo = new CNodo();
            NuevoNodo.dato = dat;
            int ban = 0;
            if (cabeza == null)
            { 
                NuevoNodo.siguiente = null;
                cabeza = NuevoNodo;
            }
            else
            {
                if (dat < cabeza.dato)
                {
                    NuevoNodo.siguiente = cabeza;
                    cabeza = NuevoNodo;
                }
                else
                {
                    antes = cabeza;
                    luego = cabeza;
                    while (ban == 0)
                    {
                        if (dat >= luego.dato)
                        {
                            antes = luego;
                            luego = luego.siguiente;
                        }
                        if (luego == null)
                        {
                            ban = 1;
                        }
                        else
                        {
                            if (dat < luego.dato)
                            {
                                ban = 1;
                            }
                        }
                    }
                    antes.siguiente = NuevoNodo;
                    NuevoNodo.siguiente = luego;
                }
            }
        }
        public void EliminarDato(int dat)
        {
            CNodo antes, luego;
            int ban = 0;
            if (Vacia())
            {
                Console.WriteLine("Lista vacía ");
            }
            else
            {
                if (dat < cabeza.dato)
                {
                    Console.WriteLine("dato no existe en la lista ");
                }
                else
                {
                    if (dat == cabeza.dato)
                    {
                        cabeza = cabeza.siguiente;
                    }
                    else
                    {
                        antes = cabeza;
                        luego = cabeza;
                        while (ban == 0)
                        {
                            if (dat > luego.dato)
                            {
                                antes = luego;
                                luego = luego.siguiente;
                            }
                            else ban = 1;
                            if (luego == null)
                            {
                                ban = 1;
                            }
                            else
                            {
                                if (luego.dato == dat)
                                    ban = 1;
                            }
                        }
                        if (luego == null)
                        {
                            Console.WriteLine("dato no existe en la Lista ");
                        }
                        else
                        {
                            if (dat == luego.dato)
                            {
                                antes.siguiente = luego.siguiente;
                            }
                            else
                                Console.WriteLine("dato no existe en la Lista ");
                        }
                    }
                }
            }
        }
        public bool Vacia()
        {
            return (cabeza == null);
        }

        public void VisualizarDatos()
        {
            CNodo Temporal;
            Temporal = cabeza;
            if (!Vacia())
            {
                while (Temporal != null)
                {
                    Console.WriteLine(" " + Temporal.dato + " ");
                    Temporal = Temporal.siguiente;
                }
                Console.WriteLine("");
            }
            else
                Console.WriteLine("Lista vacía");
        }
    }

    public class ListaSEnlazada
    {
        public static void main(String args[])
        {
            CLista objLista = new CLista();
            Console.WriteLine("Lista Original:");
            objLista.InsertarDato(9);
            objLista.InsertarDato(20);
            objLista.InsertarDato(7);
            
            objLista.VisualizarDatos();
            Console.WriteLine("\nLista Sin el : ");
            objLista.EliminarDato(1);
            objLista.VisualizarDatos();
        }
    }

}
}

