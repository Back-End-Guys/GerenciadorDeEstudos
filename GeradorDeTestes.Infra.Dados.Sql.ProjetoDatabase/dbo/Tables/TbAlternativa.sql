CREATE TABLE [dbo].[TbAlternativa] (
    [id]                  INT          IDENTITY (1, 1) NOT NULL,
    [AlternativaResposta] VARCHAR (50) NOT NULL,
    [Verdadeiro]          BIT          NOT NULL,
    [Questão_Id]          INT          NOT NULL,
    CONSTRAINT [PK_TbAlternativa] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_TbAlternativa_Questao] FOREIGN KEY ([Questão_Id]) REFERENCES [dbo].[Questao] ([id])
);

