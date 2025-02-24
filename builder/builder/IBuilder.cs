using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    internal interface IBuilder
    {
        void construirParteA();
        void construirParteB();
        void construirParteC();
        Producto GetResultado();
    }
}
