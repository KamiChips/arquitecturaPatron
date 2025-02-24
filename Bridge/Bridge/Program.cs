using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Program
    {
        static void main()
        {
            IImplementacion implementacionA = new implementacionA();
            Abstraer abstraccion = new Abstraer(implementacionA);
            Console.WriteLine(abstraccion.Operacion());

            IImplementacion implementacionB = new implementacionB();
            abstraccion = new Abstraer(implementacionB);
            Console.WriteLine(abstraccion.Operacion());
        }
    }
}
