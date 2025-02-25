using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Program
    {
        static void main()
        {
            // Crear un dispositivo
            var device = new Dispositivo();

            // Crear comandos para el dispositivo
            var turnOnCommand = new prenderComando(device);
            var turnOffCommand = new apagarComanado(device);

            // Crear el control remoto
            var remote = new controlRemoto();

            remote.SetCommand(turnOnCommand);
            remote.PresionarBoton(); 

            remote.SetCommand(turnOffCommand);
            remote.PresionarBoton(); 
        }
    }
}
