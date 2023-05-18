using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Clientes
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }

        public Cliente()
        {
        }

        public Cliente(int id)
        {
            Id = id;
        }
        public Cliente(string nome, string endereco, string telefone, string rg, string cpf)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            RG = rg;
            CPF = cpf;
        }
    }
}
