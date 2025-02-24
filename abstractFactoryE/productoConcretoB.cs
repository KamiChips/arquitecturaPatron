using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractFactoryE
{
    internal class productoConcretoB : IProductoB
    {
        public string operacionB()
        {
            return "Producto B";
        }

        public string otraOperacion(IProductoA collaborator)
        {
            return $"B colaborando con {collaborator.operacionA()}";
        }
    }
}
