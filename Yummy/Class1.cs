using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yummy
{
    class Nodo
    {
        public Nodo enlaceAdelante;
        public Nodo enlaceAtras;
        public Nodo()
        {
            enlaceAdelante = null;
            enlaceAtras = null;
        }
    }

    class Lista
    {
        public Nodo primero;
        public Nodo cursor;
        public Nodo ultimo;

        public Lista()
        {
            primero = null;
            cursor = null;
            ultimo = null;
        }

        public void inicializar()
        {
            primero = null;
            cursor = null;
            ultimo = null;
        }

        public bool vacia()
        {
            if (primero == null)
                return true;
            else
                return false;
        }

        public void insertar(Nodo nodo)
        {
            if (vacia())
            {
                primero = nodo;
                cursor = nodo;
                ultimo = nodo;
                nodo.enlaceAtras = null;
            }
            else
            {
                Nodo aux;
                aux = ultimo;
                ultimo.enlaceAdelante = nodo;
                ultimo = nodo;
                cursor = nodo;
                ultimo.enlaceAtras = aux;
            }
            nodo.enlaceAdelante = null;
        }

        public void insertarMedio(Nodo nodo)
        {
            if (vacia())
            {
                primero = nodo;
                cursor = nodo;
                ultimo = nodo;
                nodo.enlaceAtras = null;
            }
            else
            {
                Nodo aux1;
                Nodo aux2;
                aux1 = getAntCursor();
                aux2 = getProxCursor();
                ultimo.enlaceAdelante = nodo;
                ultimo = nodo;
                cursor = nodo;
                ultimo.enlaceAtras = aux1;
                ultimo.enlaceAdelante = aux2;
            }
            nodo.enlaceAdelante = null;
        }

        public Nodo eliminarPrimero()
        {
            if (vacia())
                return null;
            else
            {
                if (primero == ultimo)
                    inicializar();
                else
                {
                    if (cursor == primero)
                    {
                        cursor = primero.enlaceAdelante;
                        primero = primero.enlaceAdelante;
                        primero.enlaceAtras = null;
                    }

                }
                return primero;
            }
        }
        public Nodo eliminar()
        {
            Nodo pAux;
            Nodo qAux;
            if (cursor == null)
                return null;
            else
            {
                if (cursor == primero)
                    return eliminarPrimero();
                else
                {
                    pAux = getAntCursor();
                    qAux = getProxCursor();
                    pAux.enlaceAdelante = cursor.enlaceAdelante;
                    qAux.enlaceAtras = cursor.enlaceAtras;
                    if (cursor == ultimo)
                    {
                        ultimo = pAux;
                    }
                    cursor = pAux.enlaceAdelante;
                    return cursor;
                }

            }
        }

        public Nodo getPrimero()
        {
            return primero;
        }

        public Nodo getUltimo()
        {
            return ultimo;
        }
        public Nodo getCursor()
        {
            return cursor;
        }
        public Nodo getProxCursor()
        {
            if (cursor != null)
                return cursor.enlaceAdelante;
            else
                return null;
            if (cursor == ultimo)
            {
                return primero;
            }
            else
                return cursor.enlaceAdelante;
        }

        public Nodo getAntCursor()
        {
            if (cursor != null)
                return cursor.enlaceAtras;
            else
                return null;
            if (cursor == primero)
            {
                return ultimo;
            }
            else
                return cursor.enlaceAtras;
        }
        public void setCursor(Nodo p)
        {
            cursor = p;
        }
    }
}
