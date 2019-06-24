using LivrariaDDD.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LivrariaDDD.Data.Context
{
    public class LivrariaContext : DbContext
    {
        public LivrariaContext(DbContextOptions<LivrariaContext> options) : base(options)
        {            
        }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<LivroGenero> LivroGeneros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Livro>().ToTable("Livro");
            modelBuilder.ApplyConfiguration<Livro>(new LivroConfiguration());
            modelBuilder.Entity<Genero>().ToTable("Genero");
            modelBuilder.Entity<LivroGenero>().ToTable("LivroGenero");
          
            modelBuilder.Entity<LivroGenero>().HasKey(lg => new { lg.LivroId, lg.GeneroId });
            modelBuilder.Entity<LivroGenero>().HasOne(lg => lg.Livro).WithMany(l => l.LivroGeneros).HasForeignKey(lg => lg.LivroId);
            modelBuilder.Entity<LivroGenero>().HasOne(lg => lg.Genero).WithMany(l => l.LivroGeneros).HasForeignKey(lg => lg.GeneroId);
        }
    }
}
