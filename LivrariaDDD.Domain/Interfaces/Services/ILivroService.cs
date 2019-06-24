using LivrariaDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaDDD.Domain.Interfaces.Services
{
    public interface ILivroService : IServiceBase<Livro>
    {
        IEnumerable<Livro> ObterPorAutor(string autorNome);
        Livro ObterPorNomeLivro(string nomeLivro);
        Task<IEnumerable<Livro>> ConsultaCompleta();
    }
}
