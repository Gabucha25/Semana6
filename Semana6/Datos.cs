using System;
using System.Collections.Generic;
using System.Text;

namespace Semana6
{
    class Datos
    {
        public int código { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }

        //Sobreescribir
        public override string ToString()
        {
            return nombre;
        }
    }

}
