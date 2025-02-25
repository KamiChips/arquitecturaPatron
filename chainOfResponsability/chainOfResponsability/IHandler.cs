using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chainOfResponsability
{   /// <summary>
/// esta interfaz define el comportamiento
/// de un manejador en la cadena
/// </summary>
    internal interface IHandler
    {
        IHandler SetNext (IHandler handler);
        object Handle(string request);
    }

}
