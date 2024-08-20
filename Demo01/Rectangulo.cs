using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    internal class Rectangulo
    {

        public int Base { get; set; }
        public int Altura { get; set; }

        public int CalcularArea()
        {
            return Base * Altura;
        }

        public int CalcularPerimetro()
        {
            return (Base * Altura) / 2;
        }

    }
}
