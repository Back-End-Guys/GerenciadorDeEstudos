﻿using ListaExerciciosMariana.Dominio.ModuloMateria;

namespace ListaExerciciosMariana.Dominio.ModuloQuestao
{
    public class Questao : EntidadeBase<Questao>
    {
        public Materia Materia { get; set; }
        public string Enunciado { get; set; }
        public string RespostaCerta { get; set; }
        public List<Alternativa> ListAlternativas { get; set; }

        public Questao(Materia materia, string enunciado, string respostaCerta, List<Alternativa> listAlternativas)
        {
            Materia = materia;
            Enunciado = enunciado;
            RespostaCerta = respostaCerta;
            ListAlternativas = listAlternativas;
        }

        public override void AtualizarInformacoes(Questao registroAtualizado)
        {
            Materia = registroAtualizado.Materia;
            Enunciado = registroAtualizado.Enunciado;
            RespostaCerta = registroAtualizado.RespostaCerta;
            ListAlternativas = registroAtualizado.ListAlternativas;
        }

        public override string[] Validar()
        {
            throw new NotImplementedException();
        }
    }
    public class Alternativa
    {
        public string AlternativaResposta { get; set; }
        public bool Verdadeiro { get; set; }

        public override string ToString()
        {
            return AlternativaResposta;
        }
    }
}