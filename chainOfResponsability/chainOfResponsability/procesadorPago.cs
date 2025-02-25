using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chainOfResponsability
{
    //manejador de proceso de pago
    internal class procesadorPago : AbstractHandler
    {
        public override object Handle(string request)
        {
            if(request == "Procesar pago")
            {
                return "Pago realizado";
            }   
            return base.Handle(request);
        }
    }
}
