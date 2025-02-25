using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    /// <summary>
    /// Clase que se encarga de almacenar
    /// y ejecutar los comandos
    /// </summary>
    internal class controlRemoto
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void PresionarBoton()
        {
            if(_command != null)
            {
                _command.Executar();
            }
        }
    }
}
