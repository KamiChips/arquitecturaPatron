using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractFactoryE
{
    internal class FabricaConcreto : IAbstractFactory
    {
        public IProductoA crearProductoA()
        {
            return new productoConcretoA();
        }

        public IProductoB crearProductoB()
        {
            return new productoConcretoB();
        }
    }
}
