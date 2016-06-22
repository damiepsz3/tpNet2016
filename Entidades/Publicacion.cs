using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Publicacion
    {
        public Usuarios Usuario { get; set; }
        public Juego MiJuego { get; set; }
        public List<Juego> Aceptantes { get; set; }
        public float Plata { get; set; }
    }
}

