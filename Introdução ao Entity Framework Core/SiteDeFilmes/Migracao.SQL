IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Atores] (
    [Id] int NOT NULL IDENTITY,
    [PrimeiroNome] VARCHAR(20) NOT NULL,
    [UltimoNome] VARCHAR(20) NOT NULL,
    [Genero] VARCHAR(1) NOT NULL,
    CONSTRAINT [PK_Atores] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Filmes] (
    [Id] int NOT NULL IDENTITY,
    [Nome] VARCHAR(50) NOT NULL,
    [Ano] int NOT NULL,
    [Duracao] int NOT NULL,
    CONSTRAINT [PK_Filmes] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Generos] (
    [Id] int NOT NULL IDENTITY,
    [Genero] VARCHAR(20) NOT NULL,
    CONSTRAINT [PK_Generos] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [ElencoFilmes] (
    [Id] int NOT NULL IDENTITY,
    [IdAtor] int NOT NULL,
    [IdFilmes] int NOT NULL,
    [Papel] VARCHAR(30) NOT NULL,
    CONSTRAINT [PK_ElencoFilmes] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_ElencoFilmes_Atores_IdAtor] FOREIGN KEY ([IdAtor]) REFERENCES [Atores] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_ElencoFilmes_Filmes_IdFilmes] FOREIGN KEY ([IdFilmes]) REFERENCES [Filmes] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [FilmesGeneros] (
    [Id] int NOT NULL IDENTITY,
    [IdGenero] int NOT NULL,
    [IdFilmes] int NOT NULL,
    CONSTRAINT [PK_FilmesGeneros] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_FilmesGeneros_Filmes_IdFilmes] FOREIGN KEY ([IdFilmes]) REFERENCES [Filmes] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_FilmesGeneros_Generos_IdGenero] FOREIGN KEY ([IdGenero]) REFERENCES [Generos] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_ElencoFilmes_IdAtor] ON [ElencoFilmes] ([IdAtor]);
GO

CREATE INDEX [IX_ElencoFilmes_IdFilmes] ON [ElencoFilmes] ([IdFilmes]);
GO

CREATE INDEX [IX_FilmesGeneros_IdFilmes] ON [FilmesGeneros] ([IdFilmes]);
GO

CREATE INDEX [IX_FilmesGeneros_IdGenero] ON [FilmesGeneros] ([IdGenero]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240917102521_Migracao', N'8.0.8');
GO

COMMIT;
GO

