using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Personas : Entidades
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNac { get; set; }
        public int Telefono { get; set; }

    
    }
}
