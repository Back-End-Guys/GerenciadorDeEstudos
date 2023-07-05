CREATE TABLE [dbo].[Questao] (
    [id]         INT          NOT NULL,
    [Enunciado]  VARCHAR (50) NOT NULL,
    [Materia_Id] INT          NOT NULL,
    CONSTRAINT [PK_Questao] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Questao_TbMateria] FOREIGN KEY ([Materia_Id]) REFERENCES [dbo].[TbMateria] ([Id])
);

