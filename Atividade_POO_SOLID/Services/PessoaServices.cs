using Atividade_POO_SOLID.Interfaces;
using Atividade_POO_SOLID.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_POO_SOLID.Services
{
    public abstract class PessoaServices
    {
        public abstract string Adicionar(Aluno aluno);
        //public static string AdicionarAluno(IPessoaRepository pessoaRepository, Aluno aluno)
        //{
        //    pessoaRepository.Adicionar(aluno);

        //    return "Aluno cadastrado com sucesso";
        //}
    }
}
