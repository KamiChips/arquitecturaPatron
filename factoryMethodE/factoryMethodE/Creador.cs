using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryMethodE
{
    internal abstract class Creador
    {

        public abstract IProducto crearProducto();

        public string operacion()
        {
            var product = crearProducto();
            return $"Creador: {product,operacion()}";
        }
    }
}
