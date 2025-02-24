using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryMethodE
{
    internal class productoConcreto : IProducto
    {
        public string operacion()
        {
            return "Producto de Concreto";
        }
    }
}
