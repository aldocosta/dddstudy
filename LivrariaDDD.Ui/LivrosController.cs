using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LivrariaDDD.Application;
using LivrariaDDD.Application.Interface;
using LivrariaDDD.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaDDD.Ui
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        ILivroAppService _service;
        public LivrosController(ILivroAppService service)
        {
            _service = service;
        }
        // GET: api/Livros
        [HttpGet]
        public IEnumerable<Livro> Get()
        {
            var ret =  _service.GetAll();            
            return ret;
        }

        // GET: api/Livros/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Livros
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Livros/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
