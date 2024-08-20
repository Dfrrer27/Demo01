using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    internal class Estudiante : Persona
    {
        public int Codigo { get; set; }

        public String InformarcionCompleta { get; set; }

        public void AsignarInformarcionCompleta()
        {
            InformarcionCompleta = Nombres + " " + Apellidos + " " + Codigo;
        }


    }
}
