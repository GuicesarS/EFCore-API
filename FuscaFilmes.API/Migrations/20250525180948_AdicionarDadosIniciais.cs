using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FuscaFilmes.API.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarDadosIniciais : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Diretores",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Christopher Nolan" },
                    { 2, "Steven Spielberg" },
                    { 3, "Quentin Tarantino" },
                    { 4, "Greta Gerwig" },
                    { 5, "Denis Villeneuve" },
                    { 6, "Martin Scorsese" }
                });

            migrationBuilder.InsertData(
                table: "Filmes",
                columns: new[] { "Id", "Ano", "DiretorId", "Titulo" },
                values: new object[,]
                {
                    { 1, 2010, 1, "Inception" },
                    { 2, 1993, 2, "Jurassic Park" },
                    { 3, 1994, 3, "Pulp Fiction" },
                    { 4, 2019, 4, "Little Women" },
                    { 5, 2021, 5, "Dune" },
                    { 6, 1993, 2, "Schindler's List" },
                    { 7, 2003, 3, "Kill Bill" },
                    { 8, 2023, 4, "Barbie" },
                    { 9, 2016, 5, "Arrival" },
                    { 10, 2014, 1, "Interstellar" },
                    { 11, 2022, 2, "The Fabelmans" },
                    { 12, 2012, 3, "Django Unchained" },
                    { 13, 2017, 4, "Lady Bird" },
                    { 14, 2017, 5, "Blade Runner 2049" },
                    { 15, 2023, 1, "Oppenheimer" },
                    { 16, 2018, 2, "Ready Player One" },
                    { 17, 2015, 3, "The Hateful Eight" },
                    { 18, 2020, 1, "Tenet" },
                    { 19, 2019, 6, "The Irishman" },
                    { 20, 2010, 6, "Shutter Island" },
                    { 21, 2013, 6, "The Wolf of Wall Street" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Filmes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Filmes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Filmes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Filmes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Filmes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Filmes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Filmes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Filmes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Filmes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Filmes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Filmes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Filmes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Filmes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Filmes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Filmes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Filmes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Filmes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Filmes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Filmes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Filmes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Filmes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Diretores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Diretores",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Diretores",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Diretores",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Diretores",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Diretores",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
