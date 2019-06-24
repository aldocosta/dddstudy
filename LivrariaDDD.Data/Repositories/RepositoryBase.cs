using LivrariaDDD.Data.Context;
using LivrariaDDD.Domain.Interfaces.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;

namespace LivrariaDDD.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {

        protected readonly LivrariaContext _livrariaContext;
        public RepositoryBase(LivrariaDDD.Data.Context.LivrariaContext livrariaContext)
        {
            _livrariaContext = livrariaContext;
        }

        public void Add(TEntity obj)
        {
            _livrariaContext.Set<TEntity>().Add(obj);
            _livrariaContext.SaveChanges();
        }

        public void Dispose()
        {
            _livrariaContext.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _livrariaContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _livrariaContext.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            _livrariaContext.Set<TEntity>().Remove(obj);
            _livrariaContext.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            this._livrariaContext.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this._livrariaContext.SaveChanges();
        }
    }
}
