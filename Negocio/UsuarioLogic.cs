using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Data.Database;

namespace Negocio
{
    public class UsuarioLogic : BusinessLogic
    {
        public Data.Database.UsuarioAdapter UsuarioData { get; set; }

        public UsuarioLogic() {
            this.UsuarioData = new UsuarioAdapter();
        }

        public Usuario GetOne(int id) {
            return this.UsuarioData.GetOne(id) ;
        }

        public List<Usuario> GetAll() {
            return this.UsuarioData.GetAll();
        }

        public void Delete(int id) {
            this.UsuarioData.Delete(id);
        }

        public void Save(Entidades.Usuario user) {
            this.UsuarioData.Save(user);
        }
    }
}
