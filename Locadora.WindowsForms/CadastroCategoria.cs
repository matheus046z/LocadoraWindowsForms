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
    public partial class CadastroCategoria : Form
    {
        public CadastroCategoria()
        {
            InitializeComponent();
        }

        private void btnCadastroCategoria_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.Nome = txtNomeCategoria.Text;
            categoria.ValorDiaria = txtValorDiaria.Text;
            MessageBox.Show("Categoria cadastrada!\nNome: " + categoria.Nome + "\nValor da diaria: " + categoria.ValorDiaria);

        }
    }
}
