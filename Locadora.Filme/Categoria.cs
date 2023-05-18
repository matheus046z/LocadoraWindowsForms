using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Filmes
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string ValorDiaria { get; set; }

        public Categoria()
        {
        }
        public Categoria(int id)
        {
            Id = id;
        }
        public Categoria(int id, string nome, string valorDiaria) : this(id)
        {
            Nome = nome;
            ValorDiaria = valorDiaria;
        }
    }
}
