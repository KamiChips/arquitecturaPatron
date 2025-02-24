using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{   //implementacion concreta en B
    internal class implementacionB : IImplementacion
    {
        public string operacionDeImplementacion()
        {
            return "Implementacion B";
        }
    }
}
