using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chainOfResponsability
{
    //manejador de comprobar saldo
    internal class checarBalance : AbstractHandler
    {

        //comprobador de saldo
        public override object Handle(string request)
        {
            if(request == "Verificar Saldo")
            {
                return "No hay salado";
            }
            return base.Handle(request);
        }
    }
}
