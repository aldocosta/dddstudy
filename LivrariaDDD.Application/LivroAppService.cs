using LivrariaDDD.Application.Interface;
using LivrariaDDD.Domain.Entities;
using LivrariaDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaDDD.Application
{
    public class LivroAppService : AppServiceBase<Livro>, ILivroAppService
    {
        private readonly ILivroService _livroService;
        public LivroAppService(ILivroService livroService) : base(livroService)
        {
            _livroService = livroService;
        }

        public async Task<IEnumerable<Livro>> ConsultaCompleta()
        {
            return await _livroService.ConsultaCompleta();
        }

        public IEnumerable<Livro> ObterPorAutor(string autorNome)
        {
            return _livroService.ObterPorAutor(autorNome);
        }

        public Livro ObterPorNomeLivro(string nomeLivro)
        {
            return _livroService.ObterPorNomeLivro(nomeLivro);
        }
    }
}
