using ControleJogos.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControleJogos.Repositories
{
    public interface IRepositoryAmigo
    {
        Task Add(Amigo amigo);
        List<Amigo> GetAll();
        Task Update(Amigo amigo);
        Task Delete(int Id);
    }
}
