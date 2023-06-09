﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Locadora.Clientes;


namespace Locadora.WindowsForms
{
    public partial class CadastroClientes : Form
    {
        public CadastroClientes()
        {
            InitializeComponent();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Telefone = mtxtTelefone.Text;
            cliente.RG = txtRG.Text;
            cliente.CPF = mtxtCPF.Text;
            cliente.Endereco = txtEndereco.Text;

            bool cpfValido = Cliente.ValidarCPF(mtxtCPF.Text);

            if (cpfValido)
            {
                MessageBox.Show("CLIENTE CADASTRADO! \nNome: " + cliente.Nome + "\nTelefone: " + cliente.Telefone + "\nRG: " + cliente.RG + "\nCPF: " + cliente.CPF + "\nEndereço: " + cliente.Endereco);//get
            }
            else
            {
                MessageBox.Show("CPF INVÁLIDO!");
            }
        }
    }
}
