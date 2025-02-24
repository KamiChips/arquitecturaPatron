using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    //interfaz que el cliente espera utilizar
    internal interface ITarget
    {
        string getRequest();
    }
}
