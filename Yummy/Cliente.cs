using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yummy
{
    public class Cliente
    {
        public int carnet;
        public string nombreCompleto;
        public Cliente(int ci, string nombre)
        {
            this.carnet = ci;
            this.nombreCompleto = nombre;
        } 
    }

    public class Producto
    {
        public int codigo;
        public string descripcion;
        public float precio;
        public Producto(int cod, string des,float precio)
        {
            this.codigo = cod;
            this.descripcion = des;
            this.precio = precio;

        }

    }
}
