using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleJogos.Data;
using ControleJogos.Models;

namespace ControleJogos.Repositories
{
    public class RepositoryAmigo : IRepositoryAmigo
    {
        private readonly ApplicationDbContext _applicationDb;

        public RepositoryAmigo(ApplicationDbContext applicationDb)
        {
            _applicationDb = applicationDb;
        }
        public async Task Add(Amigo amigo)
        {
            await _applicationDb.Set<Amigo>().AddAsync(amigo);
            await _applicationDb.SaveChangesAsync();
        }

        public Task Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Amigo> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(Amigo amigo)
        {
            throw new NotImplementedException();
        }
    }
}
