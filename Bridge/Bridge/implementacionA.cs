using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class implementacionA : IImplementacion
    {
        //implementacion concreta en A
        public string operacionDeImplementacion()
        {
            return "Implementacion A";
        }
    }
}
