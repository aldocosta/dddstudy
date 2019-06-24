﻿// <auto-generated />
using System;
using LivrariaDDD.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LivrariaDDD.Data.Migrations
{
    [DbContext(typeof(LivrariaContext))]
    partial class LivrariaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LivrariaDDD.Domain.Entities.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Genero");
                });

            modelBuilder.Entity("LivrariaDDD.Domain.Entities.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<DateTime>("DataPublicacao");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Livro");
                });

            modelBuilder.Entity("LivrariaDDD.Domain.Entities.LivroGenero", b =>
                {
                    b.Property<int>("LivroId");

                    b.Property<int>("GeneroId");

                    b.Property<int>("Id");

                    b.HasKey("LivroId", "GeneroId");

                    b.HasIndex("GeneroId");

                    b.ToTable("LivroGenero");
                });

            modelBuilder.Entity("LivrariaDDD.Domain.Entities.LivroGenero", b =>
                {
                    b.HasOne("LivrariaDDD.Domain.Entities.Genero", "Genero")
                        .WithMany("LivroGeneros")
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LivrariaDDD.Domain.Entities.Livro", "Livro")
                        .WithMany("LivroGeneros")
                        .HasForeignKey("LivroId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
