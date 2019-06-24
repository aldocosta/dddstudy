using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaDDD.Domain.Entities
{
    public class Genero
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<LivroGenero> LivroGeneros { get; set; }
    }
}
