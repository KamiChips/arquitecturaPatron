using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{

    //Representa al dispositivo
    internal class Dispositivo
    {
        public void Prender()
        {
            Console.WriteLine("Dispositivo encendido");
        }

        public void Apagar()
        {
            Console.WriteLine("Dispositivo Apagado");
        }
    }
}
