BEGIN TRANSACTION;
GO

CREATE TABLE [Categories] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(100) NOT NULL,
    [Description] nvarchar(500) NULL,
    [Image] nvarchar(500) NOT NULL,
    [Price] money NOT NULL,
    CONSTRAINT [PK_Categories] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Salons] (
    [Id] uniqueidentifier NOT NULL,
    [NameOfSalon] nvarchar(100) NOT NULL,
    [City] nvarchar(100) NOT NULL,
    [Address] nvarchar(500) NOT NULL,
    [Description] nvarchar(500) NOT NULL,
    [CategoryId] uniqueidentifier NULL,
    CONSTRAINT [PK_Salons] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Salons_Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Categories] ([Id])
);
GO

CREATE INDEX [IX_Salons_CategoryId] ON [Salons] ([CategoryId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220316094643_CategoriesAndSalons', N'6.0.2');
GO

COMMIT;
GO

