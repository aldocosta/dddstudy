using LivrariaDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaDDD.Application.Interface
{
    public interface ILivroAppService : IAppServiceBase<Livro>
    {
        IEnumerable<Livro> ObterPorAutor(string autorNome);
        Livro ObterPorNomeLivro(string nomeLivro);
        Task<IEnumerable<Livro>> ConsultaCompleta();
    }
}
