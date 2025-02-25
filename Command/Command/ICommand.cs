using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    //interfaz para ejecutar comandos
    internal interface ICommand
    {
        void Executar();
    }
}
