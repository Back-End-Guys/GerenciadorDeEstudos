CREATE TABLE [dbo].[TbAlternativa] (
    [id]         INT           IDENTITY (1, 1) NOT NULL,
    [Resposta]   VARCHAR (MAX) NOT NULL,
    [Verdadeiro] BIT           NOT NULL,
    [Questao_Id] INT           NOT NULL,
    CONSTRAINT [PK_TbAlternativa] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_TbAlternativa_Questao] FOREIGN KEY ([Questao_Id]) REFERENCES [dbo].[Questao] ([id])
);







