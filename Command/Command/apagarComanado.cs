using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    //Representa el apagar un dispositivo
    internal class apagarComanado : ICommand
    {
        private Dispositivo _dispositivo;

        public apagarComanado(Dispositivo dispositivo)
        {
            _dispositivo = dispositivo;
        }
        public void Executar()
        {
            _dispositivo.Apagar();
        }
    }
}
