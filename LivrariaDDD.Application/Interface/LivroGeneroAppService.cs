using LivrariaDDD.Domain.Entities;
using LivrariaDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaDDD.Application.Interface
{
    public class LivroGeneroAppService : AppServiceBase<LivroGenero>, ILivroGeneroAppService
    {
        private readonly ILivroGeneroService _service;
        public LivroGeneroAppService(ILivroGeneroService _service) : base(_service)
        {
        }
    }
}
