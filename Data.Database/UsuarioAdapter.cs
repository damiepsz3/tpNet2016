using System;
using System.Collections.Generic;
using System.Text;
using Entidades;

namespace Data.Database
{
    public class UsuarioAdapter:Adapter
    {
        #region DatosEnMemoria
        // Esta regi�n solo se usa en esta etapa donde los datos se mantienen en memoria.
        // Al modificar este proyecto para que acceda a la base de datos esta ser� eliminada
        private static List<Usuario> _Usuarios;

        private static List<Usuario> Usuarios
        {
            get
            {
                if (_Usuarios == null)
                {
                    _Usuarios = new List<Entidades.Usuario>();
                    Entidades.Usuario usr;
                    usr = new Entidades.Usuario();
                    usr.id = 1;
                    usr.state = Entidades.Entidades.States.Unmodified;
                    usr.Nombre = "Casimiro";
                    usr.Apellido = "Cegado";
                    usr.NombreUsuario = "casicegado";
                    usr.Clave = "miro";
                    usr.Email = "casimirocegado@gmail.com";
                    usr.Habilitado = true;
                    _Usuarios.Add(usr);

                    usr = new Entidades.Usuario();
                    usr.id = 2;
                    usr.state = Entidades.Entidades.States.Unmodified;
                    usr.Nombre = "Armando Esteban";
                    usr.Apellido = "Quito";
                    usr.NombreUsuario = "aequito";
                    usr.Clave = "carpintero";
                    usr.Email = "armandoquito@gmail.com";
                    usr.Habilitado = true;
                    _Usuarios.Add(usr);

                    usr = new Entidades.Usuario();
                    usr.id = 3;
                    usr.state = Entidades.Entidades.States.Unmodified;
                    usr.Nombre = "Alan";
                    usr.Apellido = "Brado";
                    usr.NombreUsuario = "alanbrado";
                    usr.Clave = "abrete sesamo";
                    usr.Email = "alanbrado@gmail.com";
                    usr.Habilitado = true;
                    _Usuarios.Add(usr);

                }
                return _Usuarios;
            }
        }
        #endregion

        public List<Usuario> GetAll()
        {
            return new List<Usuario>(Usuarios);
        }

        public Entidades.Usuario GetOne(int ID)
        {
            return Usuarios.Find(delegate(Usuario u) { return u.id == ID; });
        }

        public void Delete(int ID)
        {
            Usuarios.Remove(this.GetOne(ID));
        }

        public void Save(Usuario usuario)
        {
            if (usuario.state == Entidades.Entidades.States.New)
            {
                int NextID = 0;
                foreach (Usuario usr in Usuarios)
                {
                    if (usr.id > NextID)
                    {
                        NextID = usr.id;
                    }
                }
                usuario.id = NextID + 1;
                Usuarios.Add(usuario);
            }
            else if (usuario.state == Entidades.Entidades.States.Deleted)
            {
                this.Delete(usuario.id);
            }
            else if (usuario.state == Entidades.Entidades.States.Modified)
            {
                Usuarios[Usuarios.FindIndex(delegate(Usuario u) { return u.id == usuario.id; })]=usuario;
            }
            usuario.state = Entidades.Entidades.States.Unmodified;            
        }
    }
}