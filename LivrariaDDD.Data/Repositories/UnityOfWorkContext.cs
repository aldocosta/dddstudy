using LivrariaDDD.Data.Context;
using LivrariaDDD.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaDDD.Data.Repositories
{
    public class UnityOfWorkContext : IUnityOfWork
    {
        public ILivroRepository _LivroRepository { get; set; }
        public ILivroGeneroRepository _LivroGeneroRepository { get; set; }
        public IGeneroRepository _GeneroRepository { get; set; }
        private readonly LivrariaContext livrariaContext;
        public UnityOfWorkContext(ILivroRepository livroRepository, LivrariaContext context)
        {
            _LivroRepository = livroRepository;
            livrariaContext = context;
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }
    }
}
