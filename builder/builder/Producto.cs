using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    internal class Producto
    {
        private List<object> _partes = new List<object>();

        public void Add(string part)
        {
            _partes.Add(part);
        }

        public string parteLista()
        {
            return string.Join(",", _partes);
        }
    }
}
