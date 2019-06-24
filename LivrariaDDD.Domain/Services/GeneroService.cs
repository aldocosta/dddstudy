using LivrariaDDD.Domain.Entities;
using LivrariaDDD.Domain.Interfaces.Repositories;
using LivrariaDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaDDD.Domain.Services
{
    public class GeneroService : ServiceBase<Genero>, IGeneroService
    {
        IRepositoryBase<Genero> repository_;
        public GeneroService(IRepositoryBase<Genero> repository) : base(repository)
        {
            repository_ = repository;
        }
    }
}
