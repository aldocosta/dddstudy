using LivrariaDDD.Domain.Entities;
using LivrariaDDD.Domain.Interfaces.Repositories;
using LivrariaDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaDDD.Domain.Services
{
    public class LivroService : ServiceBase<Livro>, ILivroService
    {
        ILivroRepository repository_;
        public LivroService(ILivroRepository repository) : base(repository)
        {
            repository_ = repository;
        }

        public async Task<IEnumerable<Livro>> ConsultaCompleta()
        {
            return await repository_.ConsultaCompleta();
        }

        public IEnumerable<Livro> ObterPorAutor(string autorNome)
        {
            throw new NotImplementedException();
        }

        public Livro ObterPorNomeLivro(string nomeLivro)
        {
            throw new NotImplementedException();
        }
    }
}
