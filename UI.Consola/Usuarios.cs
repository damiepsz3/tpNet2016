using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using Entidades;

namespace UI.Consola
{
    public class Usuarios
    {
        public UsuarioLogic logic {get; set;}

        public Usuarios(){
            this.logic = new UsuarioLogic();
        }

        public void Menu()
        {
            Console.WriteLine("1- Listado General");
            Console.WriteLine("2- Consulta");
            Console.WriteLine("3- Agregar");
            Console.WriteLine("4- Modificar");
            Console.WriteLine("5- Eliminar");
            Console.WriteLine("6- Salir");
            switch (Console.ReadLine())
            {
                case "1":
                    ListadoGeneral();
                    break;
                case "2":
                    Consulta();
                    break;
                case "3":
                    Agregar();
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;

            }
        }

        public void ListadoGeneral()
        {
            Console.Clear();
            foreach (Usuario usr in logic.GetAll())
            {
                MostrarDatos(usr);
            }
        }

        public void Consulta()
        {
            Console.Clear();
            Console.Write("Ingrese el ID del usuario a consultar: ");
            int id = int.Parse(Console.ReadLine());
            this.MostrarDatos(logic.GetOne(id));
        }

        public void MostrarDatos(Usuario usr)
        {
            Console.WriteLine("Usuario: {0}", usr.id);
            Console.WriteLine("\t\tNombre: {0}", usr.Nombre);
            Console.WriteLine("\t\tApellido: {0}", usr.Apellido);
            Console.WriteLine("\t\tNombre de usuario: {0}", usr.NombreUsuario);
            Console.WriteLine("\t\tClave: {0}", usr.Clave);
            Console.WriteLine("\t\tEmail: {0}", usr.Email);
            Console.WriteLine("\t\tHabilitado: {0}", usr.Habilitado);
            Console.WriteLine();

        }

        public void Agregar()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el nombre: ");



        }
    }
}
