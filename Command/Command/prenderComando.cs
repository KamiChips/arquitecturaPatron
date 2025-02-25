using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    //representa la accion prender un dispositivo
    internal class prenderComando : ICommand
    {
        private Dispositivo _dispositivo;
        public void Executar()
        {
            _dispositivo.Prender();
        }

        public prenderComando(Dispositivo dispositivo)
        {
            _dispositivo = dispositivo;
        }
    }
}
