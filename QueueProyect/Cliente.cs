using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueProyect
{
    class Cliente
    {
        string nombre;
        int cantProducto;

        public string Nombre { get => nombre; set => nombre = value; }
        public int CantProducto { get => cantProducto; set => cantProducto = value; }
        
        public Cliente(string Nombre, int CantProducto)
        {
            nombre = Nombre;
            cantProducto = CantProducto;
        }
    }
}
