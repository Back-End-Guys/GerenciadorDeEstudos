﻿using ListaExerciciosMariana.Dominio.ModuloQuestao;
using ListaExerciciosMariana.Dominio.ModuloTeste;

namespace ListaExercicioMariana.Infra.Memoria.ModuloQuestao
{
    public class RepositorioQuestaoEmMemoria : RepositorioMemoriaBase<Questao>, IRepositorioQuestao
    {
        public RepositorioQuestaoEmMemoria(List<Questao> listaCadastros) : base(listaCadastros)
        {
        }

        public void CarregarAlternativas(Questao questao)
        {
            throw new NotImplementedException();
        }

        public void Editar(int id, Questao questao, List<Alternativa> alternativas)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Questao questao, List<Teste> testes)
        {
            throw new NotImplementedException();
        }

        public void Inserir(Questao questao, List<Alternativa> alternativasAdicionadas)
        {
            throw new NotImplementedException();
        }
    }
}
