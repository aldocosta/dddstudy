﻿using LivrariaDDD.Application.Interface;
using LivrariaDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaDDD.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity>
            where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public void Add(TEntity obj)
        {
            _serviceBase.Add(obj);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }

        public System.Collections.Generic.IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _serviceBase.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            _serviceBase.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _serviceBase.Update(obj);
        }
    }
}
