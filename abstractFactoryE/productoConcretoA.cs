using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractFactoryE
{
    internal class productoConcretoA : IProductoA
    {
        public string operacionA()
        {
            return "Producto A";
        }
    }
}
