using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    /// <summary>
    /// hacemos una coleccion 
    /// basicamente unaa lista que contiene
    /// tareas pendientes
    /// </summary>
    internal class coleccionTareas : IteradorAgregar
    {
        private List<string> _tareas = new List<string>();
        
        //acceder a la lista de tareas
        public List<string> GetTareas()
        {
            return _tareas;
        }

        //agregar tarea(s) a la lista
        public void agregarTarea(string tarea)
        {
            _tareas.Add(tarea);
        }

        //crea y regresa un iterador para esta coleccion
        public override IEnumerator GetEnumerator()
        {
            return new IteradorTareas(this);
        }
    }
}
