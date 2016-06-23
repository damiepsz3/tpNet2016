using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios : Entidades
    {
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public string Email { get; set; }
        public bool Habilitado { get; set; }
    }
}
