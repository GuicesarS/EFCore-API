CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" TEXT NOT NULL CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY,
    "ProductVersion" TEXT NOT NULL
);

BEGIN TRANSACTION;

CREATE TABLE "Diretores" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Diretores" PRIMARY KEY AUTOINCREMENT,
    "Name" TEXT NOT NULL
);

CREATE TABLE "Filmes" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Filmes" PRIMARY KEY AUTOINCREMENT,
    "Titulo" TEXT NOT NULL,
    "Ano" INTEGER NOT NULL,
    "DiretorId" INTEGER NULL,
    CONSTRAINT "FK_Filmes_Diretores_DiretorId" FOREIGN KEY ("DiretorId") REFERENCES "Diretores" ("Id")
);

CREATE INDEX "IX_Filmes_DiretorId" ON "Filmes" ("DiretorId");

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20240925003333_inicial', '8.0.8');

COMMIT;

-- MIGRATION ATUALIZADA (M2M) SCRIPT

CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" TEXT NOT NULL CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY,
    "ProductVersion" TEXT NOT NULL
);

BEGIN TRANSACTION;

CREATE TABLE "Diretores" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Diretores" PRIMARY KEY AUTOINCREMENT,
    "Name" TEXT NOT NULL
);

CREATE TABLE "Filmes" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Filmes" PRIMARY KEY AUTOINCREMENT,
    "Titulo" TEXT NOT NULL,
    "Ano" INTEGER NOT NULL,
    "DiretorId" INTEGER NOT NULL,
    CONSTRAINT "FK_Filmes_Diretores_DiretorId" FOREIGN KEY ("DiretorId") REFERENCES "Diretores" ("Id") ON DELETE CASCADE
);

INSERT INTO "Diretores" ("Id", "Name")
VALUES (1, 'Christopher Nolan');
SELECT changes();

INSERT INTO "Diretores" ("Id", "Name")
VALUES (2, 'Steven Spielberg');
SELECT changes();

INSERT INTO "Diretores" ("Id", "Name")
VALUES (3, 'Quentin Tarantino');
SELECT changes();

INSERT INTO "Diretores" ("Id", "Name")
VALUES (4, 'Martin Scorsese');
SELECT changes();

INSERT INTO "Diretores" ("Id", "Name")
VALUES (5, 'James Cameron');
SELECT changes();

INSERT INTO "Diretores" ("Id", "Name")
VALUES (6, 'Greta Gerwig');
SELECT changes();


INSERT INTO "Filmes" ("Id", "Ano", "DiretorId", "Titulo")
VALUES (1, 2010, 1, 'Inception');
SELECT changes();

INSERT INTO "Filmes" ("Id", "Ano", "DiretorId", "Titulo")
VALUES (2, 2014, 1, 'Interstellar');
SELECT changes();

INSERT INTO "Filmes" ("Id", "Ano", "DiretorId", "Titulo")
VALUES (3, 2008, 1, 'The Dark Knight');
SELECT changes();

INSERT INTO "Filmes" ("Id", "Ano", "DiretorId", "Titulo")
VALUES (4, 1993, 2, 'Jurassic Park');
SELECT changes();

INSERT INTO "Filmes" ("Id", "Ano", "DiretorId", "Titulo")
VALUES (5, 1982, 2, 'E.T. the Extra-Terrestrial');
SELECT changes();

INSERT INTO "Filmes" ("Id", "Ano", "DiretorId", "Titulo")
VALUES (6, 1993, 2, 'Schindler''s List');
SELECT changes();

INSERT INTO "Filmes" ("Id", "Ano", "DiretorId", "Titulo")
VALUES (7, 1994, 3, 'Pulp Fiction');
SELECT changes();

INSERT INTO "Filmes" ("Id", "Ano", "DiretorId", "Titulo")
VALUES (8, 2003, 3, 'Kill Bill: Vol. 1');
SELECT changes();

INSERT INTO "Filmes" ("Id", "Ano", "DiretorId", "Titulo")
VALUES (9, 2012, 3, 'Django Unchained');
SELECT changes();

INSERT INTO "Filmes" ("Id", "Ano", "DiretorId", "Titulo")
VALUES (10, 1990, 4, 'Goodfellas');
SELECT changes();

INSERT INTO "Filmes" ("Id", "Ano", "DiretorId", "Titulo")
VALUES (11, 2019, 4, 'The Irishman');
SELECT changes();

INSERT INTO "Filmes" ("Id", "Ano", "DiretorId", "Titulo")
VALUES (12, 1976, 4, 'Taxi Driver');
SELECT changes();

INSERT INTO "Filmes" ("Id", "Ano", "DiretorId", "Titulo")
VALUES (13, 2009, 5, 'Avatar');
SELECT changes();

INSERT INTO "Filmes" ("Id", "Ano", "DiretorId", "Titulo")
VALUES (14, 1997, 5, 'Titanic');
SELECT changes();

INSERT INTO "Filmes" ("Id", "Ano", "DiretorId", "Titulo")
VALUES (15, 1984, 5, 'The Terminator');
SELECT changes();

INSERT INTO "Filmes" ("Id", "Ano", "DiretorId", "Titulo")
VALUES (16, 2017, 6, 'Lady Bird');
SELECT changes();

INSERT INTO "Filmes" ("Id", "Ano", "DiretorId", "Titulo")
VALUES (17, 2019, 6, 'Little Women');
SELECT changes();

INSERT INTO "Filmes" ("Id", "Ano", "DiretorId", "Titulo")
VALUES (18, 2023, 6, 'Barbie');
SELECT changes();


CREATE INDEX "IX_Filmes_DiretorId" ON "Filmes" ("DiretorId");

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20241013045129_InitialCreation', '8.0.10');

COMMIT;

BEGIN TRANSACTION;

CREATE TABLE "DiretorFilme" (
    "DiretoresId" INTEGER NOT NULL,
    "FilmesId" INTEGER NOT NULL,
    CONSTRAINT "PK_DiretorFilme" PRIMARY KEY ("DiretoresId", "FilmesId"),
    CONSTRAINT "FK_DiretorFilme_Diretores_DiretoresId" FOREIGN KEY ("DiretoresId") REFERENCES "Diretores" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_DiretorFilme_Filmes_FilmesId" FOREIGN KEY ("FilmesId") REFERENCES "Filmes" ("Id") ON DELETE CASCADE
);

CREATE INDEX "IX_DiretorFilme_FilmesId" ON "DiretorFilme" ("FilmesId");

CREATE INDEX "IX_DiretorFilme_DiretoresId" ON "DiretorFilme" ("DiretoresId");


            INSERT INTO DiretorFilme(FilmesId, DiretoresId)
            SELECT Id, DiretorId FROM Filmes WHERE DiretorId is not NULL

DROP INDEX "IX_Filmes_DiretorId";

CREATE TABLE "ef_temp_Filmes" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Filmes" PRIMARY KEY AUTOINCREMENT,
    "Ano" INTEGER NOT NULL,
    "Titulo" TEXT NOT NULL
);

INSERT INTO "ef_temp_Filmes" ("Id", "Ano", "Titulo")
SELECT "Id", "Ano", "Titulo"
FROM "Filmes";

COMMIT;

PRAGMA foreign_keys = 0;

BEGIN TRANSACTION;

DROP TABLE "Filmes";

ALTER TABLE "ef_temp_Filmes" RENAME TO "Filmes";

COMMIT;

PRAGMA foreign_keys = 1;

BEGIN TRANSACTION;

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20250602222630_M2MCreatingCollection', '8.0.10');

COMMIT;
