using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{   //es el contenedor que puede tener hijos
    internal class Compuesto : Componente
    {
        protected List<Componente> _hijo = new List<Componente>();
        public override void Add(Componente componente)
        {
            _hijo.Add(componente);
        }

        public override void Remove(Componente componente)
        {
            _hijo.Remove(componente);
        }

        //ejecuta la operacion en todos los hijos
        public override string Operacion()
        {
            int i = 0;
            string resultado = "Rama (";

            foreach (Componente componente in _hijo)
            {
                resultado += componente.Operacion();
                if (i != _hijo.Count - 1)
                {
                    resultado += "+";
                }
                i++;
            }
            return resultado + ")";
        }
        public override bool IsComposite()
        {
            return true;
        }
    }
}
