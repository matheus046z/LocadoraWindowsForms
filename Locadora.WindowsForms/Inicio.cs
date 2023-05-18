using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Locadora.WindowsForms
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CadastroClientes().Show();
        }

        private void cadastroDeCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CadastroCategoria().Show();
        }

        private void cadastroDeGeneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CadastroGenero().Show();
        }
    }
}
