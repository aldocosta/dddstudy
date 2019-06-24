using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaDDD.Domain.Entities
{
    public class Livro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public DateTime DataPublicacao { get; set; }
        public ICollection<LivroGenero> LivroGeneros { get; set; }
    }
}
