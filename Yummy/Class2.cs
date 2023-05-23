using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yummy
{
    struct nodoPedido
    {
        public string nombre;
        public int cantidad;


    }

    class NodoPedido : Nodo
    {
        public nodoPedido info;
        public NodoPedido(string nom, int ct) : base()
        {
            info.nombre = nom;
            info.cantidad = ct;
        }

        public string damePedido()
        {
            return info.nombre;
        }

        public int dameCantidad()
        {
            return info.cantidad;
        }
    }

    class LisAsig : Lista
    {
        public LisAsig() : base() { }

        public void crearLista(string a, int cant)
        {
            insertar(new NodoPedido(a, cant));
        }

        public void crearLista2(string a, int cant)
        {
            insertarMedio(new NodoPedido(a, cant));
        }
        public Nodo sucessor(string a)
        {
            return getProxCursor();
        }

        public Nodo antecessor(string a)
        {
            return getAntCursor();
        }

        public Nodo eliminarLista(String a)
        {
            Nodo aux = cursor;
            if (BuscarAsig(a))
            {
                return eliminar();
            }
            else
            {
                cursor = aux;
                return cursor;
            }
        }
        public bool BuscarAsig(String nom)
        {
            bool bus = false;
            Nodo p;
            p = primero;
            while (p != null && bus == false)
            {
                if (((NodoPedido)p).damePedido().Equals(nom))
                    bus = true;
                else
                    p = p.enlaceAdelante;
            }
            if (bus)
                cursor = p;
            return bus;
        }
    }
}
