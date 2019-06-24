using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaDDD.Domain.Entities
{
    public class LivroGenero
    {
        public int Id { get; set; }
        public int LivroId { get; set; }
        public Livro Livro { get; set; }
        public int GeneroId { get; set; }
        public Genero Genero { get; set; }
    }
}
