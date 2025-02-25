using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    //Representa objetos finales sin hijos
    internal class Hoja : Componente
    {
        //implementacion para una hoja
        public override string Operacion()
        {
            return "Operacion Hoja";
        }
    }
}
