using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Entidades
    {
        public Entidades(){
        this.state = new States();
    }
        public int id { get; set; }
        public States state { get; set; }

        public enum States { 
        Deleted,
        New,
        Modified,
        Unmodified,
        }
    }
}
