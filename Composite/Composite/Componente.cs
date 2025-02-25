using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal abstract class Componente
    {
        //Clase base -> define las operaciones comunes
        public Componente() { }

        public abstract string Operacion();
        //metodos para eliminar y agregar
        public virtual void Add(Componente componente) { }
        public virtual void Remove(Componente componente) { }

        public virtual bool IsComposite() {  return false; }
    }
}
