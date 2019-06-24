using LivrariaDDD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LivrariaDDD.Data.Context
{
    internal class LivroConfiguration : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(_ => _.Nome)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(_ => _.Autor)
                .HasColumnType("varchar(150)")
                .IsRequired();

        }
    }
}