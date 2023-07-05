CREATE TABLE [dbo].[Disciplina] (
    [Id]   INT          IDENTITY (1, 1) NOT NULL,
    [Nome] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Disciplina] PRIMARY KEY CLUSTERED ([Id] ASC)
);

