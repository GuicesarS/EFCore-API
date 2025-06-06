﻿// <auto-generated />
using FuscaFilmes.API.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FuscaFilmes.Repo.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20241016025303_M2MCreatingClass")]
    partial class M2MCreatingClass
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("FuscaFilmes.Domain.Entities.Diretor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Diretores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Christopher Nolan"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Steven Spielberg"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Quentin Tarantino"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Martin Scorsese"
                        },
                        new
                        {
                            Id = 5,
                            Name = "James Cameron"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Greta Gerwig"
                        });
                });

            modelBuilder.Entity("FuscaFilmes.Domain.Entities.DiretorFilme", b =>
                {
                    b.Property<int>("DiretorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FilmeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DiretorId", "FilmeId");

                    b.HasIndex("FilmeId");

                    b.ToTable("DiretoresFilmes", (string)null);

                    b.HasData(
                        new
                        {
                            DiretorId = 1,
                            FilmeId = 1
                        },
                        new
                        {
                            DiretorId = 1,
                            FilmeId = 2
                        },
                        new
                        {
                            DiretorId = 1,
                            FilmeId = 3
                        },
                        new
                        {
                            DiretorId = 2,
                            FilmeId = 4
                        },
                        new
                        {
                            DiretorId = 2,
                            FilmeId = 5
                        },
                        new
                        {
                            DiretorId = 2,
                            FilmeId = 6
                        },
                        new
                        {
                            DiretorId = 3,
                            FilmeId = 7
                        },
                        new
                        {
                            DiretorId = 3,
                            FilmeId = 8
                        },
                        new
                        {
                            DiretorId = 3,
                            FilmeId = 9
                        },
                        new
                        {
                            DiretorId = 4,
                            FilmeId = 10
                        },
                        new
                        {
                            DiretorId = 4,
                            FilmeId = 11
                        },
                        new
                        {
                            DiretorId = 4,
                            FilmeId = 12
                        },
                        new
                        {
                            DiretorId = 5,
                            FilmeId = 13
                        },
                        new
                        {
                            DiretorId = 5,
                            FilmeId = 14
                        },
                        new
                        {
                            DiretorId = 5,
                            FilmeId = 15
                        },
                        new
                        {
                            DiretorId = 6,
                            FilmeId = 16
                        },
                        new
                        {
                            DiretorId = 6,
                            FilmeId = 17
                        },
                        new
                        {
                            DiretorId = 6,
                            FilmeId = 18
                        });
                });

            modelBuilder.Entity("FuscaFilmes.Domain.Entities.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ano")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Filmes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ano = 2010,
                            Titulo = "Inception"
                        },
                        new
                        {
                            Id = 2,
                            Ano = 2014,
                            Titulo = "Interstellar"
                        },
                        new
                        {
                            Id = 3,
                            Ano = 2008,
                            Titulo = "The Dark Knight"
                        },
                        new
                        {
                            Id = 4,
                            Ano = 1993,
                            Titulo = "Jurassic Park"
                        },
                        new
                        {
                            Id = 5,
                            Ano = 1982,
                            Titulo = "E.T. the Extra-Terrestrial"
                        },
                        new
                        {
                            Id = 6,
                            Ano = 1993,
                            Titulo = "Schindler's List"
                        },
                        new
                        {
                            Id = 7,
                            Ano = 1994,
                            Titulo = "Pulp Fiction"
                        },
                        new
                        {
                            Id = 8,
                            Ano = 2003,
                            Titulo = "Kill Bill: Vol. 1"
                        },
                        new
                        {
                            Id = 9,
                            Ano = 2012,
                            Titulo = "Django Unchained"
                        },
                        new
                        {
                            Id = 10,
                            Ano = 1990,
                            Titulo = "Goodfellas"
                        },
                        new
                        {
                            Id = 11,
                            Ano = 2019,
                            Titulo = "The Irishman"
                        },
                        new
                        {
                            Id = 12,
                            Ano = 1976,
                            Titulo = "Taxi Driver"
                        },
                        new
                        {
                            Id = 13,
                            Ano = 2009,
                            Titulo = "Avatar"
                        },
                        new
                        {
                            Id = 14,
                            Ano = 1997,
                            Titulo = "Titanic"
                        },
                        new
                        {
                            Id = 15,
                            Ano = 1984,
                            Titulo = "The Terminator"
                        },
                        new
                        {
                            Id = 16,
                            Ano = 2017,
                            Titulo = "Lady Bird"
                        },
                        new
                        {
                            Id = 17,
                            Ano = 2019,
                            Titulo = "Little Women"
                        },
                        new
                        {
                            Id = 18,
                            Ano = 2023,
                            Titulo = "Barbie"
                        });
                });

            modelBuilder.Entity("FuscaFilmes.Domain.Entities.DiretorFilme", b =>
                {
                    b.HasOne("FuscaFilmes.Domain.Entities.Diretor", "Diretor")
                        .WithMany("DiretoresFilmes")
                        .HasForeignKey("DiretorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FuscaFilmes.Domain.Entities.Filme", "Filme")
                        .WithMany("DiretoresFilmes")
                        .HasForeignKey("FilmeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Diretor");

                    b.Navigation("Filme");
                });

            modelBuilder.Entity("FuscaFilmes.Domain.Entities.Diretor", b =>
                {
                    b.Navigation("DiretoresFilmes");
                });

            modelBuilder.Entity("FuscaFilmes.Domain.Entities.Filme", b =>
                {
                    b.Navigation("DiretoresFilmes");
                });
#pragma warning restore 612, 618
        }
    }
}