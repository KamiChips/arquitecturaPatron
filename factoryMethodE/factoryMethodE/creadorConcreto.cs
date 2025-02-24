using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryMethodE
{
    internal class creadorConcreto : Creador
    {
        public override IProducto crearProducto()
        {
            return new productoConcreto();
        }
    }
}
