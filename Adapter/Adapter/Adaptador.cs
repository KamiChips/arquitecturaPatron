using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    //esta clase hace que Adaptar sea compatible con Target
    internal class Adaptador : ITarget
    {
        private readonly Adaptar _adaptar;
        public string getRequest()
        {
            return $"Adaptado: {_adaptar.getEspeciRequest()}";
        }
    }
}
