using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Abstraer
    {
        protected IImplementacion _implementacion;

        public Abstraer(IImplementacion implementacion)
        {
            _implementacion = implementacion;
        }

        public virtual string Operacion()
        {
            return $"Abstraccion: {_implementacion.operacionDeImplementacion()}";
        }
    }
}
