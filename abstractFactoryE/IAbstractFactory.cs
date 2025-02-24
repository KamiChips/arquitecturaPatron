using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractFactoryE
{
    internal interface IAbstractFactory
    {
        IProductoA crearProductoA();
        IProductoB crearProductoB();
    }
}
