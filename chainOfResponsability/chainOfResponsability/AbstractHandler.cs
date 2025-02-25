using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chainOfResponsability
{
    //implementacion determinada del manejador
    internal class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;
        //Maneja las solicitudes, pasa al siguiente
        //en caso de que no pueda ser manejada
        public virtual object Handle(string request)
        {
            if (_nextHandler != null)
            {
                return _nextHandler.Handle(request);
            }
            return "Solicitud no procesada";
        }
        //configura el siguiente manejador
        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }
    }
}
