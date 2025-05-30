﻿// <auto-generated />
using FuscaFilmes.API.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FuscaFilmes.API.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.3");

            modelBuilder.Entity("FuscaFilmes.API.Entities.Diretor", b =>
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
                            Name = "Greta Gerwig"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Denis Villeneuve"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Martin Scorsese"
                        });
                });

            modelBuilder.Entity("FuscaFilmes.API.Entities.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ano")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DiretorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DiretorId");

                    b.ToTable("Filmes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ano = 2010,
                            DiretorId = 1,
                            Titulo = "Inception"
                        },
                        new
                        {
                            Id = 2,
                            Ano = 1993,
                            DiretorId = 2,
                            Titulo = "Jurassic Park"
                        },
                        new
                        {
                            Id = 3,
                            Ano = 1994,
                            DiretorId = 3,
                            Titulo = "Pulp Fiction"
                        },
                        new
                        {
                            Id = 4,
                            Ano = 2019,
                            DiretorId = 4,
                            Titulo = "Little Women"
                        },
                        new
                        {
                            Id = 5,
                            Ano = 2021,
                            DiretorId = 5,
                            Titulo = "Dune"
                        },
                        new
                        {
                            Id = 6,
                            Ano = 1993,
                            DiretorId = 2,
                            Titulo = "Schindler's List"
                        },
                        new
                        {
                            Id = 7,
                            Ano = 2003,
                            DiretorId = 3,
                            Titulo = "Kill Bill"
                        },
                        new
                        {
                            Id = 8,
                            Ano = 2023,
                            DiretorId = 4,
                            Titulo = "Barbie"
                        },
                        new
                        {
                            Id = 9,
                            Ano = 2016,
                            DiretorId = 5,
                            Titulo = "Arrival"
                        },
                        new
                        {
                            Id = 10,
                            Ano = 2014,
                            DiretorId = 1,
                            Titulo = "Interstellar"
                        },
                        new
                        {
                            Id = 11,
                            Ano = 2022,
                            DiretorId = 2,
                            Titulo = "The Fabelmans"
                        },
                        new
                        {
                            Id = 12,
                            Ano = 2012,
                            DiretorId = 3,
                            Titulo = "Django Unchained"
                        },
                        new
                        {
                            Id = 13,
                            Ano = 2017,
                            DiretorId = 4,
                            Titulo = "Lady Bird"
                        },
                        new
                        {
                            Id = 14,
                            Ano = 2017,
                            DiretorId = 5,
                            Titulo = "Blade Runner 2049"
                        },
                        new
                        {
                            Id = 15,
                            Ano = 2023,
                            DiretorId = 1,
                            Titulo = "Oppenheimer"
                        },
                        new
                        {
                            Id = 16,
                            Ano = 2018,
                            DiretorId = 2,
                            Titulo = "Ready Player One"
                        },
                        new
                        {
                            Id = 17,
                            Ano = 2015,
                            DiretorId = 3,
                            Titulo = "The Hateful Eight"
                        },
                        new
                        {
                            Id = 18,
                            Ano = 2020,
                            DiretorId = 1,
                            Titulo = "Tenet"
                        },
                        new
                        {
                            Id = 19,
                            Ano = 2019,
                            DiretorId = 6,
                            Titulo = "The Irishman"
                        },
                        new
                        {
                            Id = 20,
                            Ano = 2010,
                            DiretorId = 6,
                            Titulo = "Shutter Island"
                        },
                        new
                        {
                            Id = 21,
                            Ano = 2013,
                            DiretorId = 6,
                            Titulo = "The Wolf of Wall Street"
                        });
                });

            modelBuilder.Entity("FuscaFilmes.API.Entities.Filme", b =>
                {
                    b.HasOne("FuscaFilmes.API.Entities.Diretor", "Diretor")
                        .WithMany("Filmes")
                        .HasForeignKey("DiretorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Diretor");
                });

            modelBuilder.Entity("FuscaFilmes.API.Entities.Diretor", b =>
                {
                    b.Navigation("Filmes");
                });
#pragma warning restore 612, 618
        }
    }
}
