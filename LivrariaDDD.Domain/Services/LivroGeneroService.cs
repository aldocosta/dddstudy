using LivrariaDDD.Domain.Entities;
using LivrariaDDD.Domain.Interfaces.Repositories;
using LivrariaDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaDDD.Domain.Services
{
    public class LivroGeneroService : ServiceBase<LivroGenero>, ILivroGeneroService
    {
        IRepositoryBase<LivroGenero> repository_;
        public LivroGeneroService(IRepositoryBase<LivroGenero> repository) : base(repository)
        {
            repository_ = repository;
        }
    }
}
