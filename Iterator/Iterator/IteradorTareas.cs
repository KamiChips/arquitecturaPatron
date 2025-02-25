using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    //iterador para la coleccion de tareas
    internal class IteradorTareas : Iterator
    {
        private coleccionTareas _coleccion;
        private int _poiscion = -1;

        public IteradorTareas(coleccionTareas coleccion)
        {
            _coleccion = coleccion;
        }
        //retorna la tarea actual
        public override object Current()
        {
            return _coleccion.GetTareas()[_poiscion];
        }
        //reiniciar el iterador
        public override void Reset() { 
            _poiscion = -1;
        }
        //avanza a la siguienete tarea
        public override bool MoveNext()
        {
            _poiscion++;
            return _poiscion < _coleccion.GetTareas().Count;
        }
    }
}
