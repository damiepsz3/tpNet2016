using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class ModuloUsuario : Entidades
    {
        public int IdUsuario { get; set; }
        public int IdModulo { get; set; }
        public bool PermiteAlta { get; set; }
        public bool PermiteBaja { get; set; }
        public bool PermiteModificacion { get; set; }
        public bool PermiteConsulta { get; set; }
    }
}
