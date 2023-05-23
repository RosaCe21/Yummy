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
        public Producto(int cod)
        {
            this.codigo = cod;
        }

    }
}
