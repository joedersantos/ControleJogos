using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleJogos.Models
{
    public class Jogo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }

        public ICollection<Emprestimo> Emprestimos { get; set; }

    }
}
