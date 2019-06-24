using LivrariaDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaDDD.Domain.Interfaces.Repositories
{
    public interface ILivroRepository : IRepositoryBase<Livro>
    {
        IEnumerable<Livro> ObterPorAutor(string autorNome);
        Livro ObterPorNomeLivro(string nomeLivro);
        Task<IEnumerable<Livro>> ConsultaCompleta();
    }
}
