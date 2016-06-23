using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Juego : Entidades
    {
        public string Nombre { get; set; }
        public Plataforma PlatJuego{ get; set; }
        public Marca MarcaJuego { get; set; }
        public Genero GenJuego { get; set; }
        

    }
}
