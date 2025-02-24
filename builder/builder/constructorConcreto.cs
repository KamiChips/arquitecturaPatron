using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    internal class constructorConcreto : IBuilder
    {
        private Producto _producto = new Producto();

        public void construirParteA()
        {
            _producto.Add("Parte A");
        }
        public void construirParteB()
        {
            _producto.Add("Parte B");
        }
        public void construirParteC()
        {
            _producto.Add("Parte C");
        }

        public Producto GetResultado()
        {
            Producto resultado = _producto;
            _producto = new Producto();
            return resultado;
        }
    }
}
