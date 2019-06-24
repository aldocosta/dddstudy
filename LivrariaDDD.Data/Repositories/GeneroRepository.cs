using LivrariaDDD.Data.Context;
using LivrariaDDD.Domain.Entities;
using LivrariaDDD.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaDDD.Data.Repositories
{
    public class GeneroRepository : RepositoryBase<Genero>, IGeneroRepository
    {
        public GeneroRepository(LivrariaContext livrariaContext) : base(livrariaContext)
        {
        }
    }
}
