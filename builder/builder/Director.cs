using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    internal class Director
    {
        private IBuilder _builder;

        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public void construirMinimo()
        {
            _builder.construirParteA();
        }

        public void construirCompleto()
        {
            _builder.construirParteB();
            _builder.construirParteC();
            _builder.construirParteA();
        }
    }
}
