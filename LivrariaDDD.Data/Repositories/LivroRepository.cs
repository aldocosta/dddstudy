using LivrariaDDD.Data.Context;
using LivrariaDDD.Domain.Entities;
using LivrariaDDD.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaDDD.Data.Repositories
{
    public class LivroRepository : RepositoryBase<Livro>, ILivroRepository
    {
        public LivroRepository(LivrariaContext livrariaContext) : base(livrariaContext)
        {
        }

        public async Task<IEnumerable<Livro>> ConsultaCompleta()
        {
            var ret =  await this._livrariaContext.Livros
                          .Include(p => p.LivroGeneros).ThenInclude(p => p.Genero).ToListAsync();
            return ret;
        }

        //public async IEnumerable<Livro> ConsultaCompleta()
        //{
        //    var ret = await this._livrariaContext.Livros
        //                  .Include(p => p.LivroGeneros).ThenInclude(p => p.Genero);

        //    return ret;
        //}

        public IEnumerable<Livro> ObterPorAutor(string autorNome)
        {
            return this.GetAll().Where(p => p.Autor == autorNome);
        }

        public Livro ObterPorNomeLivro(string nomeLivro)
        {
            return this.GetAll().Where(p => p.Nome == nomeLivro).FirstOrDefault();
        }

        
    }
}
