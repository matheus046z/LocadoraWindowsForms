using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Filmes
{
    public class Genero
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Genero()
        {
        }
        public Genero(int id)
        {
            Id = id;
        }
        public Genero(string nome)
        {
            Nome = nome;
        }
    }
}
