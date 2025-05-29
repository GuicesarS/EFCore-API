using System.Security.Cryptography.Xml;
using System.Text.Json.Serialization;
using FuscaFilmes.API.DbContexts;
using FuscaFilmes.API.Entities;
using FuscaFilmes.API.Models;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Context>(
    options => options.UseSqlite(builder.Configuration["ConnectionStrings:FuscaFilmesStr"])
                      .LogTo(Console.WriteLine, LogLevel.Information)
);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.AllowTrailingCommas = true;
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/diretores", (Context context) =>
{
    return context.Diretores.Include(diretor => diretor.Filmes).ToList();
})
.WithOpenApi();

app.MapGet("/diretores/agregacao/{name}", (string name,
    Context context) =>
{
    // return context.Diretores
    // .Include(diretor => diretor.Filmes)
    // //.Select(diretor => diretor.Name)
    // .FirstOrDefault(diretor => diretor.Name.Contains(name))
    // ?? new Diretor{Id = 555, Name = "Guilherme Silva"};

    return context.Diretores
    .Include(diretor => diretor.Filmes)
    .Select(diretor => diretor.Name)
    .FirstOrDefault()
    ?? "Guilherme Silva";
})
 .WithOpenApi();

app.MapGet("/diretores/where/{id}", (int id,
    Context context) =>
{
    return context.Diretores
    .Where(diretor => diretor.Id == id)
    .Include(diretor => diretor.Filmes)
    .ToList();
})
.WithOpenApi();

app.MapGet("/filmes", (Context context) =>
{
    return context.Filmes
    .Include(filme => filme.Diretor)
    .OrderByDescending(filme => filme.Ano)
    .ThenBy(filme => filme.Titulo)
    .ToList();
})
.WithOpenApi();

app.MapGet("/filmes/{id}", (int id,
    Context context) =>
{
    return context.Filmes
    .Where(filme => filme.Id == id)
    .Include(filme => filme.Diretor).ToList();
})
.WithOpenApi();

app.MapGet("/filmes/byNameEFFunctions/{titulo}", (string titulo,
    Context context) =>
{
    return context.Filmes
    .Where(filme => EF.Functions.Like(filme.Titulo, $"%{titulo}%"))
    .Include(filme => filme.Diretor).ToList();
})
.WithOpenApi();

app.MapGet("/filmes/byNameLinQ/{titulo}", (string titulo,
    Context context) =>
{
    return context.Filmes
    .Where(filme => filme.Titulo.Contains(titulo))
    .Include(filme => filme.Diretor).ToList();
})
.WithOpenApi();


app.MapPost("/diretores", (Context context, Diretor diretor) =>
{
    context.Diretores.Add(diretor);
    context.SaveChanges();
})
.WithOpenApi();

app.MapPut("/diretores/{diretorId}", (Context context, int diretorId, Diretor diretorNovo) =>
{
    var diretor = context.Diretores.Find(diretorId);

    if (diretor != null)
    {
        diretor.Name = diretorNovo.Name;
        if (diretorNovo.Filmes.Count > 0)
        {
            diretor.Filmes.Clear();
            foreach (var filme in diretorNovo.Filmes)
            {
                diretor.Filmes.Add(filme);
            }
        }
    }

    context.SaveChanges();
})
.WithOpenApi();

app.MapPatch("/filmes/Update", (Context context, FilmeUpdate filmeUpdate) =>
{

    var filme = context.Filmes.Find(filmeUpdate.Id);
    if (filme == null)
    {
        return Results.NoContent();
    }

    filme.Titulo = filmeUpdate.Titulo;
    filme.Ano = filmeUpdate.Ano;

    context.Filmes.Update(filme);
    context.SaveChanges();
    return Results.Ok($"Filme com ID {filmeUpdate.Id} atualizado com sucesso!");

})
.WithOpenApi();

app.MapPatch("/filmes/ExecuteUpdate", (Context context, FilmeUpdate filmeUpdate) =>
{

    var linhasAfetadas = context.Filmes
        .Where(filme => filme.Id == filmeUpdate.Id)
        .ExecuteUpdate(setter => setter
        .SetProperty(f => f.Titulo, filmeUpdate.Titulo)
        .SetProperty(f => f.Ano, filmeUpdate.Ano)
            );

    if (linhasAfetadas > 0)
    {
        return Results.Ok($"Você teve um total de {linhasAfetadas} linhas afetadas");
    }
    else
    {
        return Results.NoContent();
    }
})
.WithOpenApi();

app.MapDelete("/diretores/{diretorId}", (Context context, int diretorId) =>
{
    var diretor = context.Diretores.Find(diretorId);
    if (diretor != null)
        context.Diretores.Remove(diretor);

    context.SaveChanges();
})
.WithOpenApi();

app.Run();



