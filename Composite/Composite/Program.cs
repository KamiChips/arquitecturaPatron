using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Program
    {
        static void main()
        {
            // Creamos una estructura de árbol
            var hoja1 = new Hoja();
            var hoja2 = new Hoja();
            var rama1 = new Compuesto();
            rama1.Add(hoja1);

            var rama2 = new Compuesto();
            rama2.Add(hoja2);
            rama2.Add(rama1);

            Console.WriteLine(hoja1.Operacion()); // Imprime "Operación Hoja"
            Console.WriteLine(rama2.Operacion()); // Imprime "Rama(Operación Hoja+Rama(Operación Hoja))"
        }
    }
}
