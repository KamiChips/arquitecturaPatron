using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractFactoryE
{
    internal interface IProductoB
    {
        string operacionB();
        string otraOperacion(IProductoA collaborator);
    }
}
