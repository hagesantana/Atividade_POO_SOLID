using Atividade_POO_SOLID.Interfaces;
using Atividade_POO_SOLID.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_POO_SOLID.Services
{
    public class AlunoServices //: PessoaServices
    {
        private readonly IPessoaRepository _pessoaRepository;
        public AlunoServices(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }
        public string Adicionar(Aluno aluno)
        {
            _pessoaRepository.Adicionar(aluno);

            return "Aluno cadastrado com sucesso";
        }
    }
}
