using System;
using FuscaFilmes.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace FuscaFilmes.API.DbContexts;


public class Context(DbContextOptions<Context> options) : DbContext(options)
{
    public DbSet<Filme> Filmes { get; set; }
    public DbSet<Diretor> Diretores { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Diretor>()
        .HasMany(e => e.Filmes)
        .WithOne(e => e.Diretor)
        .HasForeignKey(e => e.DiretorId)
        .IsRequired();

        modelBuilder.Entity<Diretor>().HasData(
        new Diretor { Id = 1, Name = "Christopher Nolan" },
        new Diretor { Id = 2, Name = "Steven Spielberg" },
        new Diretor { Id = 3, Name = "Quentin Tarantino" },
        new Diretor { Id = 4, Name = "Greta Gerwig" },
        new Diretor { Id = 5, Name = "Denis Villeneuve" },
        new Diretor { Id = 6, Name = "Martin Scorsese" }
        );

        modelBuilder.Entity<Filme>().HasData(
        new Filme { Id = 1, Titulo = "Inception", Ano = 2010, DiretorId = 1 },
        new Filme { Id = 2, Titulo = "Jurassic Park", Ano = 1993, DiretorId = 2 },
        new Filme { Id = 3, Titulo = "Pulp Fiction", Ano = 1994, DiretorId = 3 },
        new Filme { Id = 4, Titulo = "Little Women", Ano = 2019, DiretorId = 4 },
        new Filme { Id = 5, Titulo = "Dune", Ano = 2021, DiretorId = 5 },
        new Filme { Id = 6, Titulo = "Schindler's List", Ano = 1993, DiretorId = 2 },
        new Filme { Id = 7, Titulo = "Kill Bill", Ano = 2003, DiretorId = 3 },
        new Filme { Id = 8, Titulo = "Barbie", Ano = 2023, DiretorId = 4 },
        new Filme { Id = 9, Titulo = "Arrival", Ano = 2016, DiretorId = 5 },
        new Filme { Id = 10, Titulo = "Interstellar", Ano = 2014, DiretorId = 1 },
        new Filme { Id = 11, Titulo = "The Fabelmans", Ano = 2022, DiretorId = 2 },
        new Filme { Id = 12, Titulo = "Django Unchained", Ano = 2012, DiretorId = 3 },
        new Filme { Id = 13, Titulo = "Lady Bird", Ano = 2017, DiretorId = 4 },
        new Filme { Id = 14, Titulo = "Blade Runner 2049", Ano = 2017, DiretorId = 5 },
        new Filme { Id = 15, Titulo = "Oppenheimer", Ano = 2023, DiretorId = 1 },
        new Filme { Id = 16, Titulo = "Ready Player One", Ano = 2018, DiretorId = 2 },
        new Filme { Id = 17, Titulo = "The Hateful Eight", Ano = 2015, DiretorId = 3 },
        new Filme { Id = 18, Titulo = "Tenet", Ano = 2020, DiretorId = 1 },
        new Filme { Id = 19, Titulo = "The Irishman", Ano = 2019, DiretorId = 6 },
        new Filme { Id = 20, Titulo = "Shutter Island", Ano = 2010, DiretorId = 6 },
        new Filme { Id = 21, Titulo = "The Wolf of Wall Street", Ano = 2013, DiretorId = 6 }
        );

    }

}