using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleJogos.Models
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataEmprestimo { get; set; }

        public int AmigoId { get; set; }
        public int JogoId { get; set; }

        public Jogo Jogo { get; set; }
        public Amigo Amogo { get; set; }
    }
}
