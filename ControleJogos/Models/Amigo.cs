using System.Collections.Generic;

namespace ControleJogos.Models
{
    public class Amigo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public ICollection<Emprestimo> Emprestimos { get; set; }
    }
}
