CREATE TABLE [dbo].[TbQuestao_TbTeste] (
    [Questao_Id] INT NOT NULL,
    [Teste_Id]   INT NOT NULL,
    CONSTRAINT [FK_TbQuestao_TbTeste_Questao] FOREIGN KEY ([Questao_Id]) REFERENCES [dbo].[Questao] ([id]),
    CONSTRAINT [FK_TbQuestao_TbTeste_TbTeste] FOREIGN KEY ([Teste_Id]) REFERENCES [dbo].[TbTeste] ([Id])
);

