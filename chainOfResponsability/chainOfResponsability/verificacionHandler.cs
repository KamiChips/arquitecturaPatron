using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chainOfResponsability
{
    //manejador para verificar si el usuario tiene una cuenta
    internal class verificacionHandler : AbstractHandler
    {

        //verifica si hay una cuenta existente del usuario
        public override object Handle(string request)
        {
            if (request == "Verificar cueanta")
            {
                return "Cuenta Verificada";
            }
            return base.Handle(request);
        }  

    }
}
