using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace UI.Consola
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tlUsuarios_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Listar() 
        { 
            UsuarioLogic ul = new UsuarioLogic();
            this.dgvUsuarios.DataSource = ul.GetAll();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
