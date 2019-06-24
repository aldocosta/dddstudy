using LivrariaDDD.Application.Interface;
using LivrariaDDD.Domain.Entities;
using LivrariaDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaDDD.Application
{
    public class GeneroAppService : AppServiceBase<Genero>, IGeneroAppService
    {
        private readonly IGeneroService _service;
        public GeneroAppService(IGeneroService service) : base(service)
        {

        }
    }
}
