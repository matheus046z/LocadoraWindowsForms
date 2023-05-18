using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Locadora.Filmes;

namespace Locadora.WindowsForms
{
    public partial class CadastroGenero : Form
    {
        public CadastroGenero()
        {
            InitializeComponent();
        }

        private void btnCadastrarGenero_Click(object sender, EventArgs e)
        {
            Genero genero = new Genero();
            Genero.Nome = txtNomeGenero.Text;
            

        }
    }
}
