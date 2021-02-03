using Atividade_POO_SOLID.Interfaces;
using Atividade_POO_SOLID.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_POO_SOLID.Services
{
    public class PessoaServices : IPessoaServices
    {
        readonly IPessoaRepository _pessoaRepository;
        public PessoaServices(IPessoaRepository pessoaRepository)//5. DIP - Princípio da inversão da dependência
        {
            _pessoaRepository = pessoaRepository;
        }

        public void Adicionar(Pessoa entity)
        {
            _pessoaRepository.Adicionar(entity);
        }

        public void Alterar(Pessoa entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pessoa> Listar()
        {
            var lista = _pessoaRepository.Listar();
            return lista;
        }

        public void Remover(int id)
        {
            _pessoaRepository.Remover(id);
        }
    }
}
